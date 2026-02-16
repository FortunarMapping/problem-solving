namespace WeightedGraph
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.srcComboBox = new System.Windows.Forms.ComboBox();
            this.calButton = new System.Windows.Forms.Button();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เมืองต้นทาง";
            // 
            // srcComboBox
            // 
            this.srcComboBox.FormattingEnabled = true;
            this.srcComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.srcComboBox.Location = new System.Drawing.Point(114, 34);
            this.srcComboBox.Name = "srcComboBox";
            this.srcComboBox.Size = new System.Drawing.Size(131, 21);
            this.srcComboBox.TabIndex = 1;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(271, 34);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(82, 62);
            this.calButton.TabIndex = 2;
            this.calButton.Text = "ระยะห่าง";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(145, 127);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "เมืองปลายทาง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ระยะทางระหว่างเมือง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "กิโลเมตร";
            // 
            // descComboBox
            // 
            this.descComboBox.FormattingEnabled = true;
            this.descComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.descComboBox.Location = new System.Drawing.Point(114, 75);
            this.descComboBox.Name = "descComboBox";
            this.descComboBox.Size = new System.Drawing.Size(131, 21);
            this.descComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 193);
            this.Controls.Add(this.descComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.srcComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "โปรแกรมคำนวณระยะห่างระหว่างเมือง";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox srcComboBox;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox descComboBox;
    }
}

