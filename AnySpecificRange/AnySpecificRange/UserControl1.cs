using System;
using System.Windows.Forms;

namespace AnySpecificRange
{
    public partial class UserControl1 : UserControl
    {
        private enum RuleType
        {
            Any,
            Specific,
            Range,
        }

        private RuleType rule = RuleType.Any;
        private int minValue = 0, maxValue = 0;
        private int a = 0, b = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get
            {
                return mainLabel.Text;
            }
            set
            {
                mainLabel.Text = value;
            }
        }
        public int MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                minValue = value;
            }
        }

        public int MaxValue
        {
            get
            {
                return maxValue;
            }
            set
            {
                maxValue = value;
            }
        }

        private void SetSpecificVisibility(bool value)
        {
            valueLabel.Visible = value;
            valueBox.Visible = value;
        }

        private void SetRangeVisibility(bool value)
        {
            fromLabel.Visible = value;
            fromBox.Visible = value;

            toLabel.Visible = value;
            toBox.Visible = value;
        }

        private bool validateFields()
        {
            switch (rule)
            {
                case RuleType.Any:
                    Height = 77;
                    return true;

                case RuleType.Specific:
                    if (System.Int32.TryParse(valueBox.Text, out a))
                    {
                        if (a < minValue)
                        {
                            errorLabel.Text = "\"value\" can not be lower than " + minValue;
                            errorLabel.Visible = true;
                            Height = 121;
                            return false;
                        }

                        if (a > maxValue)
                        {
                            errorLabel.Text = "\"value\" can not be larger than " + maxValue;
                            errorLabel.Visible = true;
                            Height = 121;
                            return false;
                        }

                        errorLabel.Visible = false;
                        Height = 105;
                        return true;
                    }

                    errorLabel.Text = "\"value\" is not an integer";
                    errorLabel.Visible = true;
                    Height = 121;
                    return false;

                case RuleType.Range:
                    if (System.Int32.TryParse(fromBox.Text, out a))
                    {
                        if (System.Int32.TryParse(toBox.Text, out b))
                        {
                            if (a < minValue)
                            {
                                errorLabel.Text = "\"from\" can not be lower than " + minValue;
                                errorLabel.Visible = true;
                                Height = 121;
                                return false;
                            }

                            if (b > maxValue)
                            {
                                errorLabel.Text = "\"to\" can not be larger than " + maxValue;
                                errorLabel.Visible = true;
                                Height = 121;
                                return false;
                            }

                            if (a > b)
                            {
                                errorLabel.Text = "\"from\" can not be larger than \"to\"";
                                errorLabel.Visible = true;
                                Height = 121;
                                return false;
                            }

                            errorLabel.Visible = false;
                            Height = 105;
                            return true;
                        }

                        errorLabel.Text = "\"to\" is not an integer";
                        errorLabel.Visible = true;
                        Height = 121;
                        return false;
                    }

                    errorLabel.Text = "\"from\" is not an integer";
                    errorLabel.Visible = true;
                    Height = 121;
                    return false;

                default:
                    throw new Exception("Unknown RuleType in AnySpecificRange control");
            }
        }

        private void anyButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSpecificVisibility(false);
            SetRangeVisibility(false);

            rule = RuleType.Any;

            validateFields();
        }

        private void fromBox_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void valueBox_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void toBox_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void specificButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSpecificVisibility(true);
            SetRangeVisibility(false);

            rule = RuleType.Specific;

            validateFields();
        }

        private void rangeButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSpecificVisibility(false);
            SetRangeVisibility(true);

            rule = RuleType.Range;

            validateFields();
        }
    }
}