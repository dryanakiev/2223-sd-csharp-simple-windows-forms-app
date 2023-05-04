namespace Csharp_windows_library.PL
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            buttonLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(150, 41);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(200, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(150, 74);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PasswordChar = '*';
            TextBoxPassword.PlaceholderText = "Password";
            TextBoxPassword.Size = new Size(200, 27);
            TextBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(200, 132);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(150, 18);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 5;
            label1.Text = "Incorrect Username/Password";
            label1.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 203);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(TextBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox TextBoxPassword;
        private Button buttonLogin;
        private Label label1;
    }
}