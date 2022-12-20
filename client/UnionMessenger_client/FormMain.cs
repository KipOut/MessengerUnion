using System;
using System.IO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UnionMessenger_client
{
    public partial class loginForm : Form
    {
        static HttpClient client = new HttpClient();
        messenger formMain = new messenger();
        public loginForm()
        {
            InitializeComponent();
        }
        void saveData()
        {

        }
        async Task SignUpUser()
        {
            if (email_RegBox.Text.Length >= 5 && password_RegBox.Text.Length >= 5 && nameBox.Text.Length >= 2 && surnameBox.Text.Length >= 4)
            {
                var content = new StringContent(JsonSerializer.Serialize(new
                {
                    email = email_RegBox.Text,
                    password = password_RegBox.Text,
                    initials = nameBox.Text + " " + surnameBox.Text
                }), Encoding.UTF8, "application/json");

                var result = await client.PostAsync("http://localhost:8080/union/signUpUser", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                MessageBox.Show(resultContent);
            }
            else
            {
                errorMessage("Заполните все поля данными");
            }

        }

        async Task SignInUser()
        {
            if (email_EnterBox.Text.Length >= 5 && password_EnterBox.Text.Length >= 5)
            {
                var content = new StringContent(JsonSerializer.Serialize(new
                {
                    email = email_EnterBox.Text,
                    password = password_EnterBox.Text,
                }), Encoding.UTF8, "application/json");

                var result = await client.PostAsync("http://localhost:8080/union/signInUser", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                if (resultContent == "Вы вошли")
                {
                    HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/union/userName/{email_EnterBox.Text}");
                    string contentUser = await response.Content.ReadAsStringAsync();
                    messenger.user_name = contentUser;
                    formMain.Show();
                    panel_Login.Enabled = false;
                    tail.Enabled = false;
                }
                else
                {
                    errorMessage("Неверный логин или пароль");
                }
            }
            else
            {
                errorMessage("Заполните все поля данными");
            }

        }

        async Task Connect()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/union/connect");
                string contentUser = await response.Content.ReadAsStringAsync();
                checkConnect.Text = contentUser;
            }
            catch
            {
                errorMessage("Нет подключения к серверу");
                Application.Exit();
            }
        }
        void errorMessage(string why)
        {
            SystemSounds.Hand.Play();
            DialogResult nameBox = MessageBox.Show(why, "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
        private void ToolStripMenuItem_register_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_register.Visible = true;
        }

        private void ToolStripMenuItem_login_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = true;
            panel_register.Visible = false;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SignUpUser();
            email_RegBox.Text = null;
            password_RegBox.Text = null;
            nameBox.Text = null;
            surnameBox.Text = null;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            SignInUser();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void loginForm_Enter(object sender, EventArgs e)
        {

        }

        private void loginForm_Activated(object sender, EventArgs e)
        {
            Connect();
        }
    }
}