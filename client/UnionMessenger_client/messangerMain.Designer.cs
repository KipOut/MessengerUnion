namespace UnionMessenger_client
{
    partial class messenger
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
            this.settings_panel = new System.Windows.Forms.TabControl();
            this.users_panel = new System.Windows.Forms.TabPage();
            this.searchFriend = new System.Windows.Forms.TextBox();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chats_panel = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nameUser = new System.Windows.Forms.ToolStripMenuItem();
            this.checkConnectForm = new System.Windows.Forms.ToolStripMenuItem();
            this.listChat = new System.Windows.Forms.ListBox();
            this.settings_panel.SuspendLayout();
            this.users_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_panel
            // 
            this.settings_panel.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.settings_panel.Controls.Add(this.users_panel);
            this.settings_panel.Controls.Add(this.chats_panel);
            this.settings_panel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settings_panel.Location = new System.Drawing.Point(396, 0);
            this.settings_panel.Multiline = true;
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settings_panel.SelectedIndex = 0;
            this.settings_panel.Size = new System.Drawing.Size(262, 524);
            this.settings_panel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.settings_panel.TabIndex = 1;
            // 
            // users_panel
            // 
            this.users_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.users_panel.Controls.Add(this.searchFriend);
            this.users_panel.Controls.Add(this.listUsers);
            this.users_panel.Controls.Add(this.panel1);
            this.users_panel.Location = new System.Drawing.Point(4, 35);
            this.users_panel.Name = "users_panel";
            this.users_panel.Padding = new System.Windows.Forms.Padding(3);
            this.users_panel.Size = new System.Drawing.Size(254, 485);
            this.users_panel.TabIndex = 3;
            this.users_panel.Text = "Люди";
            // 
            // searchFriend
            // 
            this.searchFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchFriend.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchFriend.Location = new System.Drawing.Point(6, 4);
            this.searchFriend.Name = "searchFriend";
            this.searchFriend.Size = new System.Drawing.Size(239, 30);
            this.searchFriend.TabIndex = 0;
            this.searchFriend.TextChanged += new System.EventHandler(this.searchFriend_TextChanged);
            // 
            // listUsers
            // 
            this.listUsers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 28;
            this.listUsers.Location = new System.Drawing.Point(6, 41);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(239, 448);
            this.listUsers.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 489);
            this.panel1.TabIndex = 4;
            // 
            // chats_panel
            // 
            this.chats_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chats_panel.Location = new System.Drawing.Point(4, 35);
            this.chats_panel.Name = "chats_panel";
            this.chats_panel.Padding = new System.Windows.Forms.Padding(3);
            this.chats_panel.Size = new System.Drawing.Size(254, 485);
            this.chats_panel.TabIndex = 4;
            this.chats_panel.Text = "  Чаты";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameUser,
            this.checkConnectForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nameUser
            // 
            this.nameUser.BackColor = System.Drawing.SystemColors.Control;
            this.nameUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(79, 32);
            this.nameUser.Text = "Union";
            // 
            // checkConnectForm
            // 
            this.checkConnectForm.Name = "checkConnectForm";
            this.checkConnectForm.Size = new System.Drawing.Size(142, 32);
            this.checkConnectForm.Text = "Connecting....";
            // 
            // listChat
            // 
            this.listChat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listChat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listChat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listChat.FormattingEnabled = true;
            this.listChat.ItemHeight = 28;
            this.listChat.Location = new System.Drawing.Point(7, 40);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(382, 448);
            this.listChat.TabIndex = 3;
            // 
            // messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(653, 524);
            this.Controls.Add(this.listChat);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "messenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnionClient";
            this.Activated += new System.EventHandler(this.messengerMain_Activated);
            this.Load += new System.EventHandler(this.messenger_Load);
            this.settings_panel.ResumeLayout(false);
            this.users_panel.ResumeLayout(false);
            this.users_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl settings_panel;
        private TabPage users_panel;
        private TabPage chats_panel;
        private MenuStrip menuStrip1;
        private TextBox searchFriend;
        private ListBox listUsers;
        private ListBox listChat;
        private Panel panel1;
        private ToolStripMenuItem checkConnectForm;
        private ToolStripMenuItem nameUser;
    }
}