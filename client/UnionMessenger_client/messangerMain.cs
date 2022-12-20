using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnionMessenger_client
{
    public partial class messenger : Form
    {
        static HttpClient client = new HttpClient();
        public static string user_name;
        string[] namesUsers;
        public messenger()
        {
            InitializeComponent();
        }

        async Task listNameUsers()
        {
            HttpResponseMessage content = await client.GetAsync("http://localhost:8080/union/numberOfUsers");
            var numberOfUsers = await content.Content.ReadAsStringAsync();

            HttpResponseMessage response = await client.GetAsync("http://localhost:8080/union/allUsers");
            var contentUser = await response.Content.ReadAsStringAsync();

            List<string> users = new List<string>();

            using JsonDocument usersJson = JsonDocument.Parse(contentUser);
            JsonElement root = usersJson.RootElement;
            for (int i = 0; i < int.Parse(numberOfUsers); i++)
            {
                var initialsJson = root[i];
                users.Add(initialsJson.GetProperty("initials").ToString());
            }
            namesUsers = users.ToArray();

            listUsers.Items.AddRange(namesUsers);
        }

        async Task Connect()
        {
            //if (nameUser.Text != null)
            {
                try
                {
                    var content = new StringContent(JsonSerializer.Serialize(new { status = "online" }), Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("http://localhost:8080/union/checkConnect", content);
                    checkConnectForm.Text = "В сети";
                }
                catch
                {
                    checkConnectForm.Text = "Не в сети";
                }
            }
        }
        async Task Disconnect()
        {
            var content = new StringContent(JsonSerializer.Serialize(new { status = "offline" }), Encoding.UTF8, "application/json");
            var result = await client.PostAsync("http://localhost:8080/union/checkConnect", content);
        }
        private void MainMessenger_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }

        private void messengerMain_Activated(object sender, EventArgs e)
        {
            Connect();
            nameUser.Text = user_name;
        }

        private void messenger_Load(object sender, EventArgs e)
        {
            listNameUsers();
        }


        private void searchFriend_TextChanged(object sender, EventArgs e)
        {
            listUsers.Items.Clear();
            if (string.IsNullOrWhiteSpace(searchFriend.Text))
            {
                listUsers.Items.AddRange(namesUsers);
            }
            else
            {
                listUsers.Items.AddRange(namesUsers.Where(s => s.StartsWith(searchFriend.Text)).ToArray());
            }
        }
    }
}
