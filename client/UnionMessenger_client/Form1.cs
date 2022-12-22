using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;
using System.Media;

namespace UnionMessenger_client
{
    public partial class FormCode : Form
    {
        static HttpClient client = new HttpClient();
        public FormCode()
        {
            InitializeComponent();
        }

        private void button_code_Click(object sender, EventArgs e)
        {
            enterCode();
        }

        async Task enterCode()
        {
            if (code_RegBox.Text.Length == 6)
            {
                var content = new StringContent(JsonSerializer.Serialize(new
                {
                    email = loginForm.emailText,
                    password = loginForm.passwordText,
                    initials = loginForm.nameText + " " + loginForm.surnameText
                }), Encoding.UTF8, "application/json");

                var result = await client.PostAsync($"http://localhost:8080/union/signUpUser/{code_RegBox.Text}", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                if (resultContent == "Введите код")
                {
                    MessageBox.Show("Ошибка: код неверный");
                }
                else if (resultContent == "Вы зарегистрировались")
                {
                    loginForm.isReg = true;
                    MessageBox.Show(resultContent);
                    this.Close();
                }
            }
            else
            {
                errorMessage("Заполните все поля данными");
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

        private void FormCode_Load(object sender, EventArgs e)
        {

        }
    }
}
