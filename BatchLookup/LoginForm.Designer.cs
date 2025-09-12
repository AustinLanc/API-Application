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
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)companyLoginLogo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameInput
            // 
            usernameInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameInput.BackColor = SystemColors.ControlLightLight;
            usernameInput.BorderStyle = BorderStyle.FixedSingle;
            usernameInput.Cursor = Cursors.IBeam;
            usernameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameInput.ForeColor = SystemColors.InactiveCaptionText;
            usernameInput.Location = new Point(3, 230);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "Username";
            usernameInput.Size = new Size(254, 29);
            usernameInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            passwordInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordInput.BackColor = SystemColors.ControlLightLight;
            passwordInput.BorderStyle = BorderStyle.FixedSingle;
            passwordInput.Cursor = Cursors.IBeam;
            passwordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.ForeColor = SystemColors.InactiveCaptionText;
            passwordInput.Location = new Point(3, 265);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.PlaceholderText = "Password";
            passwordInput.Size = new Size(254, 29);
            passwordInput.TabIndex = 1;
            // 
            // loginSubmit
            // 
            loginSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginSubmit.BackColor = Color.MidnightBlue;
            loginSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginSubmit.ForeColor = SystemColors.ControlLightLight;
            loginSubmit.Location = new Point(3, 315);
            loginSubmit.Name = "loginSubmit";
            loginSubmit.Size = new Size(254, 44);
            loginSubmit.TabIndex = 2;
            loginSubmit.Text = "Sign In";
            loginSubmit.UseVisualStyleBackColor = false;
            loginSubmit.Click += loginSubmit_Click;
            // 
            // companyLoginLogo
            // 
            companyLoginLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyLoginLogo.BackColor = SystemColors.ControlLightLight;
            companyLoginLogo.Image = (Image)resources.GetObject("companyLoginLogo.Image");
            companyLoginLogo.Location = new Point(3, 3);
            companyLoginLogo.Name = "companyLoginLogo";
            companyLoginLogo.Size = new Size(254, 199);
            companyLoginLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLoginLogo.TabIndex = 3;
            companyLoginLogo.TabStop = false;
            // 
            // errorMsg
            // 
            errorMsg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorMsg.BackColor = SystemColors.ControlLightLight;
            errorMsg.BorderStyle = BorderStyle.None;
            errorMsg.ForeColor = Color.FromArgb(192, 0, 0);
            errorMsg.Location = new Point(3, 365);
            errorMsg.Name = "errorMsg";
            errorMsg.ReadOnly = true;
            errorMsg.Size = new Size(254, 16);
            errorMsg.TabIndex = 4;
            errorMsg.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(passwordInput, 0, 2);
            tableLayoutPanel1.Controls.Add(companyLoginLogo, 0, 0);
            tableLayoutPanel1.Controls.Add(errorMsg, 0, 4);
            tableLayoutPanel1.Controls.Add(usernameInput, 0, 1);
            tableLayoutPanel1.Controls.Add(loginSubmit, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.139534F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9534883F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9534883F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9534883F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(260, 387);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(284, 411);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += LoginForm_Shown;
            ((System.ComponentModel.ISupportInitialize)companyLoginLogo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button loginSubmit;
        private PictureBox companyLoginLogo;
        private TextBox errorMsg;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
