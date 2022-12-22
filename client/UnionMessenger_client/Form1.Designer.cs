namespace UnionMessenger_client
{
    partial class FormCode
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
            this.button_code = new System.Windows.Forms.Button();
            this.code_RegBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_code
            // 
            this.button_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_code.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_code.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_code.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.button_code.ForeColor = System.Drawing.SystemColors.Control;
            this.button_code.Location = new System.Drawing.Point(108, 124);
            this.button_code.Name = "button_code";
            this.button_code.Size = new System.Drawing.Size(65, 31);
            this.button_code.TabIndex = 9;
            this.button_code.Text = "ок";
            this.button_code.UseVisualStyleBackColor = false;
            this.button_code.Click += new System.EventHandler(this.button_code_Click);
            // 
            // code_RegBox
            // 
            this.code_RegBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.code_RegBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code_RegBox.ForeColor = System.Drawing.SystemColors.Window;
            this.code_RegBox.Location = new System.Drawing.Point(65, 78);
            this.code_RegBox.MaxLength = 6;
            this.code_RegBox.Name = "code_RegBox";
            this.code_RegBox.Size = new System.Drawing.Size(152, 39);
            this.code_RegBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ввведите код с почты";
            // 
            // FormCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(280, 189);
            this.ControlBox = false;
            this.Controls.Add(this.button_code);
            this.Controls.Add(this.code_RegBox);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FormCode";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkCode";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_code;
        private TextBox code_RegBox;
        private Label label2;
    }
}