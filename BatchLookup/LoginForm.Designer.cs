namespace APIApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            loginSubmit = new Button();
            companyLoginLogo = new PictureBox();
            errorMsg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)companyLoginLogo).BeginInit();
            SuspendLayout();
            // 
            // usernameInput
            // 
            usernameInput.BackColor = SystemColors.ControlLightLight;
            usernameInput.BorderStyle = BorderStyle.FixedSingle;
            usernameInput.Cursor = Cursors.IBeam;
            usernameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameInput.ForeColor = SystemColors.InactiveCaptionText;
            usernameInput.Location = new Point(45, 251);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "Username";
            usernameInput.Size = new Size(200, 29);
            usernameInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            passwordInput.BackColor = SystemColors.ControlLightLight;
            passwordInput.BorderStyle = BorderStyle.FixedSingle;
            passwordInput.Cursor = Cursors.IBeam;
            passwordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.ForeColor = SystemColors.InactiveCaptionText;
            passwordInput.Location = new Point(45, 291);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.PlaceholderText = "Password";
            passwordInput.Size = new Size(200, 29);
            passwordInput.TabIndex = 1;
            // 
            // loginSubmit
            // 
            loginSubmit.BackColor = Color.MidnightBlue;
            loginSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginSubmit.ForeColor = SystemColors.ControlLightLight;
            loginSubmit.Location = new Point(79, 331);
            loginSubmit.Name = "loginSubmit";
            loginSubmit.Size = new Size(120, 34);
            loginSubmit.TabIndex = 2;
            loginSubmit.Text = "Sign In";
            loginSubmit.UseVisualStyleBackColor = false;
            loginSubmit.Click += loginSubmit_Click;
            // 
            // pictureBox1
            // 
            companyLoginLogo.BackColor = SystemColors.ControlLightLight;
            companyLoginLogo.Image = (Image)resources.GetObject("pictureBox1.Image");
            companyLoginLogo.Location = new Point(45, 50);
            companyLoginLogo.Name = "pictureBox1";
            companyLoginLogo.Size = new Size(200, 156);
            companyLoginLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLoginLogo.TabIndex = 3;
            companyLoginLogo.TabStop = false;
            // 
            // errorMsg
            // 
            errorMsg.BackColor = SystemColors.ControlLightLight;
            errorMsg.BorderStyle = BorderStyle.None;
            errorMsg.Location = new Point(45, 371);
            errorMsg.Name = "errorMsg";
            errorMsg.ReadOnly = true;
            errorMsg.Size = new Size(200, 16);
            errorMsg.TabIndex = 4;
            errorMsg.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(284, 411);
            Controls.Add(errorMsg);
            Controls.Add(companyLoginLogo);
            Controls.Add(usernameInput);
            Controls.Add(passwordInput);
            Controls.Add(loginSubmit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Shown += LoginForm_Shown;
            ((System.ComponentModel.ISupportInitialize)companyLoginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button loginSubmit;
        private PictureBox companyLoginLogo;
        private TextBox errorMsg;
    }
}
