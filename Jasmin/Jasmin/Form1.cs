using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Jasmin
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kUkBSJNHvAhXv31pis29SDB11uD71edxr8x1TEwK",
            BasePath = "https://jasmin-chat-demo.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();

        }

        private async void btnSend_ClickAsync(object sender, EventArgs e)
        {
            var messageData = new MessageData
            {
                Message = txtMesaj.Text,
                Name = "current name",
                Shoutout = false
            };

            SetResponse response = await client.SetAsync("Groups/GrupulMafiaHate/26", messageData);
            MessageData result = response.ResultAs<MessageData>();

            MessageBox.Show("trimite mesaju" + result);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            //if (client != null)
            //{
            //    MessageBox.Show("Merge");
            //}
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Groups/GrupulMafiaHate/");
            MessageData responseMessage = response.ResultAs<MessageData>();
            lstMesaje.Items.Add(responseMessage.Message);

        }
    }
}
