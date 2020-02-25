using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Cloud_Storage_service
{

    public partial class login : Form

    {
        public string ipServer = "127.0.0.1";
        public login()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public String Message(string message)
        {
            //initiating
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAdd = System.Net.IPAddress.Parse(ipServer);
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



        private void Label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            signup su = new signup();
            su.Closed += (s, args) => this.Close();
            su.Show();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
  
            Autothentication();


        }
        public void Autothentication()
        {
            try
            {
                if ((username.TextName != "" && username.TextName != "Username" ) && (password.TextName != "" && password.TextName != "Password"))
                {
                    String respond = Message("login/" + username.TextName + "/" + password.TextName);
                    if (respond[0] == 'C')
                    {
                        
                      this.Hide();
                      Main su = new Main();
                      su.Closed += (s, args) => this.Close();
                      su.user.Text = respond.Split('/')[1]+" !";
                      su.actualDir = "$" ;
                      su.copyCut = "";
                      su.totalSize.Text = respond.Split('/')[4] + "MO /1GO";
                      su.percentage.Value = (int)Math.Round((double)(100 * int.Parse(respond.Split('/')[4])) / 1024);

                      su.folders = respond.Split('/')[2].Split(';');
                      su.files= respond.Split('/')[3].Split(';');
                      su.Show();
                    }
                    else MessageBox.Show("Wrong username or password ");
                }
                else MessageBox.Show("Please enter both username and password ");

            }
            catch (Exception)
            {
                MessageBox.Show("Login operation failed "); 
            }
        }
    }
}
