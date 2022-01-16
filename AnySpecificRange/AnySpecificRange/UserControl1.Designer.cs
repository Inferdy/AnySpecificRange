namespace AnySpecificRange
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLabel = new System.Windows.Forms.Label();
            this.anyButton = new System.Windows.Forms.RadioButton();
            this.specificButton = new System.Windows.Forms.RadioButton();
            this.rangeButton = new System.Windows.Forms.RadioButton();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.toBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(-3, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(24, 13);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "text";
            // 
            // anyButton
            // 
            this.anyButton.AutoSize = true;
            this.anyButton.Checked = true;
            this.anyButton.Location = new System.Drawing.Point(0, 16);
            this.anyButton.Name = "anyButton";
            this.anyButton.Size = new System.Drawing.Size(43, 17);
            this.anyButton.TabIndex = 1;
            this.anyButton.TabStop = true;
            this.anyButton.Text = "Any";
            this.anyButton.UseVisualStyleBackColor = true;
            this.anyButton.CheckedChanged += new System.EventHandler(this.anyButton_CheckedChanged);
            // 
            // specificButton
            // 
            this.specificButton.AutoSize = true;
            this.specificButton.Location = new System.Drawing.Point(0, 39);
            this.specificButton.Name = "specificButton";
            this.specificButton.Size = new System.Drawing.Size(63, 17);
            this.specificButton.TabIndex = 2;
            this.specificButton.Text = "Specific";
            this.specificButton.UseVisualStyleBackColor = true;
            this.specificButton.CheckedChanged += new System.EventHandler(this.specificButton_CheckedChanged);
            // 
            // rangeButton
            // 
            this.rangeButton.AutoSize = true;
            this.rangeButton.Location = new System.Drawing.Point(0, 62);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(57, 17);
            this.rangeButton.TabIndex = 3;
            this.rangeButton.TabStop = true;
            this.rangeButton.Text = "Range";
            this.rangeButton.UseVisualStyleBackColor = true;
            this.rangeButton.CheckedChanged += new System.EventHandler(this.rangeButton_CheckedChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(0, 88);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(27, 13);
            this.fromLabel.TabIndex = 4;
            this.fromLabel.Text = "from";
            this.fromLabel.Visible = false;
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(33, 85);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(60, 20);
            this.fromBox.TabIndex = 5;
            this.fromBox.Visible = false;
            this.fromBox.TextChanged += new System.EventHandler(this.fromBox_TextChanged);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(99, 88);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(16, 13);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "to";
            this.toLabel.Visible = false;
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(121, 85);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(60, 20);
            this.toBox.TabIndex = 7;
            this.toBox.Visible = false;
            this.toBox.TextChanged += new System.EventHandler(this.toBox_TextChanged);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(0, 88);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(33, 13);
            this.valueLabel.TabIndex = 8;
            this.valueLabel.Text = "value";
            this.valueLabel.Visible = false;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(39, 85);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(60, 20);
            this.valueBox.TabIndex = 9;
            this.valueBox.Visible = false;
            this.valueBox.TextChanged += new System.EventHandler(this.valueBox_TextChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(3, 108);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.rangeButton);
            this.Controls.Add(this.specificButton);
            this.Controls.Add(this.anyButton);
            this.Controls.Add(this.mainLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(200, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.RadioButton anyButton;
        private System.Windows.Forms.RadioButton specificButton;
        private System.Windows.Forms.RadioButton rangeButton;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label errorLabel;
    }
}
