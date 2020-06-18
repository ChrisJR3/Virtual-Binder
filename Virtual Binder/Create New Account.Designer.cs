namespace Virtual_Binder
{
    partial class Create_New_Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.whichClassLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.anotherClassButton = new System.Windows.Forms.Button();
            this.moveOnButton = new System.Windows.Forms.Button();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 64);
            this.label1.TabIndex = 21;
            this.label1.Text = "Virtual Binder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Please enter Class\' Name:";
            // 
            // whichClassLabel
            // 
            this.whichClassLabel.AutoSize = true;
            this.whichClassLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichClassLabel.Location = new System.Drawing.Point(240, 87);
            this.whichClassLabel.Name = "whichClassLabel";
            this.whichClassLabel.Size = new System.Drawing.Size(89, 26);
            this.whichClassLabel.TabIndex = 23;
            this.whichClassLabel.Text = "CLASS 1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(259, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 27);
            this.textBox1.TabIndex = 24;
            // 
            // anotherClassButton
            // 
            this.anotherClassButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherClassButton.Location = new System.Drawing.Point(143, 196);
            this.anotherClassButton.Name = "anotherClassButton";
            this.anotherClassButton.Size = new System.Drawing.Size(133, 46);
            this.anotherClassButton.TabIndex = 25;
            this.anotherClassButton.Text = "Enter Another Class?";
            this.anotherClassButton.UseVisualStyleBackColor = true;
            this.anotherClassButton.Click += new System.EventHandler(this.anotherClassButton_Click);
            // 
            // moveOnButton
            // 
            this.moveOnButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveOnButton.Location = new System.Drawing.Point(328, 196);
            this.moveOnButton.Name = "moveOnButton";
            this.moveOnButton.Size = new System.Drawing.Size(133, 46);
            this.moveOnButton.TabIndex = 26;
            this.moveOnButton.Text = "Move on to Virtual Binder?";
            this.moveOnButton.UseVisualStyleBackColor = true;
            this.moveOnButton.Click += new System.EventHandler(this.moveOnButton_Click);
            // 
            // exitButton2
            // 
            this.exitButton2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton2.Location = new System.Drawing.Point(538, 221);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(85, 34);
            this.exitButton2.TabIndex = 27;
            this.exitButton2.Text = "Exit?";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // Create_New_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.moveOnButton);
            this.Controls.Add(this.anotherClassButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.whichClassLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_New_Account";
            this.Size = new System.Drawing.Size(626, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label whichClassLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button anotherClassButton;
        private System.Windows.Forms.Button moveOnButton;
        private System.Windows.Forms.Button exitButton2;
    }
}
