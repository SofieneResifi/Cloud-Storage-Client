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
using System.Net.Sockets;

namespace Cloud_Storage_service
{
    public partial class signup : Form
    {
        public string ipServer = "127.0.0.1";

        public signup()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button_signup_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login su = new login();
            su.Closed += (s, args) => this.Close();
            su.Show();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        public void SignUp()
        {
            try
            {
                if (!email.TextName.Contains('@')) MessageBox.Show("Please enter a correct e-mail");
                else
                {
                    if ((username.TextName != "" && username.TextName != "Username") && (password.TextName != "" && password.TextName != "Password") && (email.TextName != "" && email.TextName != "E-mail"))
                    {
                        String respond = Message("signup/" + username.TextName + "/" + email.TextName + "/" + password.TextName);
                        MessageBox.Show(respond.Split('/')[0]);
                    }
                    else MessageBox.Show("Please fill all the informations needed ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sign up operation failed ");
            }
        }
        public String Message(string message)
        {
            //initiating
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAdd = System.Net.IPAddress.Parse(this.ipServer);
            IPEndPoint remoteEP = new IPEndPoint(ipAdd, 8888);

            //connect socket
            socket.Connect(remoteEP);

            //send message
            byte[] byData = System.Text.Encoding.ASCII.GetBytes(message);
            socket.Send(byData);

            //receiving message 
            byte[] buffer = new byte[1024];
            int iRx = socket.Receive(buffer);
            char[] chars = new char[iRx];

            System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
            int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
            System.String recv = new System.String(chars);

            socket.Disconnect(false);
            socket.Close();
            //MessageBox.Show(recv);
            return recv;
        }

    }

}
