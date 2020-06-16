namespace Virtual_Binder
{
    partial class LoginScreen
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
            this.logInButton1 = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backgroundBox1 = new System.Windows.Forms.PictureBox();
            this.emailOrUsernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailOrUsernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInButton2 = new System.Windows.Forms.Button();
            this.createAccountButton2 = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.backgroundTextBox2 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTextBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Virtual Binder";
            // 
            // logInButton1
            // 
            this.logInButton1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton1.Location = new System.Drawing.Point(211, 134);
            this.logInButton1.Name = "logInButton1";
            this.logInButton1.Size = new System.Drawing.Size(96, 38);
            this.logInButton1.TabIndex = 1;
            this.logInButton1.Text = "Log In?";
            this.logInButton1.UseVisualStyleBackColor = true;
            this.logInButton1.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.Location = new System.Drawing.Point(163, 178);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(199, 38);
            this.createAccountButton.TabIndex = 2;
            this.createAccountButton.Text = "Create Account?";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(442, 294);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 38);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit?";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backgroundBox1
            // 
            this.backgroundBox1.BackgroundImage = global::Virtual_Binder.Properties.Resources.Blue_square;
            this.backgroundBox1.Location = new System.Drawing.Point(48, 106);
            this.backgroundBox1.Name = "backgroundBox1";
            this.backgroundBox1.Size = new System.Drawing.Size(436, 149);
            this.backgroundBox1.TabIndex = 4;
            this.backgroundBox1.TabStop = false;
            this.backgroundBox1.Visible = false;
            // 
            // emailOrUsernameLabel
            // 
            this.emailOrUsernameLabel.AutoSize = true;
            this.emailOrUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailOrUsernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailOrUsernameLabel.ForeColor = System.Drawing.Color.White;
            this.emailOrUsernameLabel.Location = new System.Drawing.Point(60, 121);
            this.emailOrUsernameLabel.Name = "emailOrUsernameLabel";
            this.emailOrUsernameLabel.Size = new System.Drawing.Size(175, 26);
            this.emailOrUsernameLabel.TabIndex = 5;
            this.emailOrUsernameLabel.Text = "Email/Username:";
            this.emailOrUsernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(60, 164);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 26);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Visible = false;
            // 
            // emailOrUsernameTextBox
            // 
            this.emailOrUsernameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailOrUsernameTextBox.Location = new System.Drawing.Point(262, 118);
            this.emailOrUsernameTextBox.Name = "emailOrUsernameTextBox";
            this.emailOrUsernameTextBox.Size = new System.Drawing.Size(213, 33);
            this.emailOrUsernameTextBox.TabIndex = 7;
            this.emailOrUsernameTextBox.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(262, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(213, 33);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Visible = false;
            // 
            // logInButton2
            // 
            this.logInButton2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton2.Location = new System.Drawing.Point(211, 207);
            this.logInButton2.Name = "logInButton2";
            this.logInButton2.Size = new System.Drawing.Size(96, 39);
            this.logInButton2.TabIndex = 9;
            this.logInButton2.Text = "Log In?";
            this.logInButton2.UseVisualStyleBackColor = true;
            this.logInButton2.Visible = false;
            this.logInButton2.Click += new System.EventHandler(this.logInButton2_Click);
            // 
            // createAccountButton2
            // 
            this.createAccountButton2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton2.Location = new System.Drawing.Point(163, 239);
            this.createAccountButton2.Name = "createAccountButton2";
            this.createAccountButton2.Size = new System.Drawing.Size(186, 39);
            this.createAccountButton2.TabIndex = 15;
            this.createAccountButton2.Text = "Create Account?";
            this.createAccountButton2.UseVisualStyleBackColor = true;
            this.createAccountButton2.Visible = false;
            this.createAccountButton2.Click += new System.EventHandler(this.createAccountButton2_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(262, 120);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(213, 33);
            this.usernameTextBox.TabIndex = 14;
            this.usernameTextBox.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(262, 81);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(213, 33);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(60, 123);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(113, 26);
            this.usernameLabel.TabIndex = 12;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(60, 84);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 26);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Visible = false;
            // 
            // backgroundTextBox2
            // 
            this.backgroundTextBox2.BackgroundImage = global::Virtual_Binder.Properties.Resources.Blue_square;
            this.backgroundTextBox2.Location = new System.Drawing.Point(48, 76);
            this.backgroundTextBox2.Name = "backgroundTextBox2";
            this.backgroundTextBox2.Size = new System.Drawing.Size(436, 212);
            this.backgroundTextBox2.TabIndex = 10;
            this.backgroundTextBox2.TabStop = false;
            this.backgroundTextBox2.Visible = false;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox2.Location = new System.Drawing.Point(262, 198);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.Size = new System.Drawing.Size(213, 33);
            this.passwordTextBox2.TabIndex = 19;
            this.passwordTextBox2.Visible = false;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox1.Location = new System.Drawing.Point(262, 159);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(213, 33);
            this.passwordTextBox1.TabIndex = 18;
            this.passwordTextBox1.Visible = false;
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel2.ForeColor = System.Drawing.Color.White;
            this.passwordLabel2.Location = new System.Drawing.Point(60, 201);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(191, 26);
            this.passwordLabel2.TabIndex = 17;
            this.passwordLabel2.Text = "Confirm Password:";
            this.passwordLabel2.Visible = false;
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel1.ForeColor = System.Drawing.Color.White;
            this.passwordLabel1.Location = new System.Drawing.Point(60, 162);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(107, 26);
            this.passwordLabel1.TabIndex = 16;
            this.passwordLabel1.Text = "Password:";
            this.passwordLabel1.Visible = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(537, 332);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.createAccountButton2);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.backgroundTextBox2);
            this.Controls.Add(this.logInButton2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailOrUsernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailOrUsernameLabel);
            this.Controls.Add(this.backgroundBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.logInButton1);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundTextBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logInButton1;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox backgroundBox1;
        private System.Windows.Forms.Label emailOrUsernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailOrUsernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logInButton2;
        private System.Windows.Forms.Button createAccountButton2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox backgroundTextBox2;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.Label passwordLabel1;
    }
}