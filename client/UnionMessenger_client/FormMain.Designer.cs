namespace UnionMessenger_client
{
    partial class loginForm
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
            this.panel_Login = new System.Windows.Forms.Panel();
            this.email_EnterBox = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.password_EnterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_register = new System.Windows.Forms.Panel();
            this.email_RegBox = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.password_RegBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_login = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_register = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tail = new System.Windows.Forms.MenuStrip();
            this.panel_Login.SuspendLayout();
            this.panel_register.SuspendLayout();
            this.tail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.Controls.Add(this.email_EnterBox);
            this.panel_Login.Controls.Add(this.button_enter);
            this.panel_Login.Controls.Add(this.password_EnterBox);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Location = new System.Drawing.Point(30, 25);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(539, 371);
            this.panel_Login.TabIndex = 0;
            // 
            // email_EnterBox
            // 
            this.email_EnterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_EnterBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_EnterBox.ForeColor = System.Drawing.SystemColors.Window;
            this.email_EnterBox.Location = new System.Drawing.Point(69, 103);
            this.email_EnterBox.MaxLength = 30;
            this.email_EnterBox.Name = "email_EnterBox";
            this.email_EnterBox.PlaceholderText = "                   email";
            this.email_EnterBox.Size = new System.Drawing.Size(381, 47);
            this.email_EnterBox.TabIndex = 7;
            this.email_EnterBox.TabStop = false;
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_enter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.button_enter.ForeColor = System.Drawing.SystemColors.Control;
            this.button_enter.Location = new System.Drawing.Point(208, 229);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(105, 43);
            this.button_enter.TabIndex = 6;
            this.button_enter.Text = "ок";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // password_EnterBox
            // 
            this.password_EnterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_EnterBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_EnterBox.ForeColor = System.Drawing.SystemColors.Window;
            this.password_EnterBox.Location = new System.Drawing.Point(69, 163);
            this.password_EnterBox.MaxLength = 30;
            this.password_EnterBox.Name = "password_EnterBox";
            this.password_EnterBox.PlaceholderText = "                 пароль";
            this.password_EnterBox.Size = new System.Drawing.Size(381, 47);
            this.password_EnterBox.TabIndex = 5;
            this.password_EnterBox.TabStop = false;
            this.password_EnterBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Войти";
            // 
            // panel_register
            // 
            this.panel_register.Controls.Add(this.email_RegBox);
            this.panel_register.Controls.Add(this.button_register);
            this.panel_register.Controls.Add(this.surnameBox);
            this.panel_register.Controls.Add(this.nameBox);
            this.panel_register.Controls.Add(this.password_RegBox);
            this.panel_register.Controls.Add(this.label2);
            this.panel_register.Location = new System.Drawing.Point(5, 31);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(526, 356);
            this.panel_register.TabIndex = 1;
            this.panel_register.Visible = false;
            // 
            // email_RegBox
            // 
            this.email_RegBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_RegBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_RegBox.ForeColor = System.Drawing.SystemColors.Window;
            this.email_RegBox.Location = new System.Drawing.Point(94, 87);
            this.email_RegBox.MaxLength = 25;
            this.email_RegBox.Name = "email_RegBox";
            this.email_RegBox.PlaceholderText = "                   Email";
            this.email_RegBox.Size = new System.Drawing.Size(384, 47);
            this.email_RegBox.TabIndex = 8;
            this.email_RegBox.TextChanged += new System.EventHandler(this.email_RegBox_TextChanged);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.button_register.ForeColor = System.Drawing.SystemColors.Control;
            this.button_register.Location = new System.Drawing.Point(236, 278);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(105, 43);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "ок";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnameBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.surnameBox.Location = new System.Drawing.Point(297, 149);
            this.surnameBox.MaxLength = 25;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.PlaceholderText = "   фамилия";
            this.surnameBox.Size = new System.Drawing.Size(181, 47);
            this.surnameBox.TabIndex = 7;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.nameBox.Location = new System.Drawing.Point(94, 149);
            this.nameBox.MaxLength = 25;
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "        имя";
            this.nameBox.Size = new System.Drawing.Size(186, 47);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // password_RegBox
            // 
            this.password_RegBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_RegBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_RegBox.ForeColor = System.Drawing.SystemColors.Window;
            this.password_RegBox.Location = new System.Drawing.Point(94, 212);
            this.password_RegBox.MaxLength = 30;
            this.password_RegBox.Name = "password_RegBox";
            this.password_RegBox.PlaceholderText = "                  пароль";
            this.password_RegBox.Size = new System.Drawing.Size(384, 47);
            this.password_RegBox.TabIndex = 5;
            this.password_RegBox.UseSystemPasswordChar = true;
            this.password_RegBox.TextChanged += new System.EventHandler(this.password_RegBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(162, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зарегистрироваться";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_login,
            this.ToolStripMenuItem_register,
            this.toolStripSeparator1});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuItem1.Text = "Аккаунт";
            // 
            // ToolStripMenuItem_login
            // 
            this.ToolStripMenuItem_login.Name = "ToolStripMenuItem_login";
            this.ToolStripMenuItem_login.Size = new System.Drawing.Size(234, 26);
            this.ToolStripMenuItem_login.Text = "Войти";
            this.ToolStripMenuItem_login.Click += new System.EventHandler(this.ToolStripMenuItem_login_Click);
            // 
            // ToolStripMenuItem_register
            // 
            this.ToolStripMenuItem_register.Name = "ToolStripMenuItem_register";
            this.ToolStripMenuItem_register.Size = new System.Drawing.Size(234, 26);
            this.ToolStripMenuItem_register.Text = "Зарегистрироваться";
            this.ToolStripMenuItem_register.Click += new System.EventHandler(this.ToolStripMenuItem_register_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // checkConnect
            // 
            this.checkConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkConnect.Name = "checkConnect";
            this.checkConnect.Size = new System.Drawing.Size(66, 24);
            this.checkConnect.Text = "offline";
            // 
            // tail
            // 
            this.tail.BackColor = System.Drawing.SystemColors.ControlText;
            this.tail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.checkConnect});
            this.tail.Location = new System.Drawing.Point(0, 0);
            this.tail.Name = "tail";
            this.tail.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tail.Size = new System.Drawing.Size(581, 28);
            this.tail.Stretch = false;
            this.tail.TabIndex = 2;
            this.tail.Text = "menuStrip1";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(581, 396);
            this.Controls.Add(this.tail);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.panel_Login);
            this.MainMenuStrip = this.tail;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.loginForm_Activated);
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            this.tail.ResumeLayout(false);
            this.tail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_Login;
        private Label label1;
        private TextBox password_EnterBox;
        private Button button_enter;
        private Panel panel_register;
        private Button button_register;
        private TextBox password_RegBox;
        private Label label2;
        private TextBox surnameBox;
        private TextBox nameBox;
        private TextBox email_EnterBox;
        private TextBox email_RegBox;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItem_login;
        private ToolStripMenuItem ToolStripMenuItem_register;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem checkConnect;
        private MenuStrip tail;
    }
}