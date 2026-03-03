namespace Pr6_volontor
{
    partial class FormLogin
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
            pbLogo = new PictureBox();
            pnMain = new Panel();
            lbLogin = new Label();
            txtLogin = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnlogin = new Button();
            btnGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.логотип;
            pbLogo.Location = new Point(142, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.Honeydew;
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnlogin);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(lbPassword);
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(lbLogin);
            pnMain.Location = new Point(28, 118);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(329, 219);
            pnMain.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(138, 15);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 19);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(39, 40);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 26);
            txtLogin.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(135, 72);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(58, 19);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(76, 175, 80);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Location = new Point(89, 129);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(150, 30);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Войти";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(76, 175, 80);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(89, 165);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnMain;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtLogin;
        private Label lbLogin;
        private Button btnGuest;
        private Button btnlogin;
    }
}
