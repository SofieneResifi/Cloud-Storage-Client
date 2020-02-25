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
using Microsoft.VisualBasic;
using System.Workflow.ComponentModel;
using System.Windows.Input;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using System.IO;

namespace Cloud_Storage_service
{
    public partial class Main : Form
    {

        public string[] folders { get; set; }
        public string[] files { get; set; }
        public string actualDir { get; set; }
        public string copyCut { get; set; }
        public string ipServer = "127.0.0.1";


        public Main()
        {
            InitializeComponent();
            SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < folders.Length; i++) { if (folders[i].Split('$')[0] != "") listView1.Items.Add(new ListViewItem(folders[i].Split('$')[0], 1)); }
            for (int i = 0; i < files.Length; i++) { if (files[i].Split('$')[0] != "") listView1.Items.Add(new ListViewItem(files[i].Split('$')[0], 0)); }

            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.creationDate.Text = " ";
            this.size.Text = " ";
            this.dir.Text = "/";
        }
        private void Update_listView(String respond)
        {
            this.folders = respond.Split('/')[1].Split(';');
            this.files = respond.Split('/')[2].Split(';');
            listView1.Clear();

            for (int i = 0; i < folders.Length; i++) { if (folders[i].Split('$')[0] != "") listView1.Items.Add(new ListViewItem(folders[i].Split('$')[0], 1)); }
            for (int i = 0; i < files.Length; i++) { if (files[i].Split('$')[0] != "") listView1.Items.Add(new ListViewItem(files[i].Split('$')[0], 0)); }
            this.creationDate.Text = " ";
            this.size.Text = " ";
            this.totalSize.Text = respond.Split('/')[3] + "MO /1GO";
            this.percentage.Value = (int)Math.Round((double)(100 * int.Parse(respond.Split('/')[3])) / 1024);

        }
        public String correctedInput(String input)
        {
            Boolean b = false;

            for (int i = 0; i < folders.Length; i++)
            {
                if (folders[i].Split('$')[0] == input)
                {
                    b=true;
                    break;

                }
            }
            for (int i = 0; i < files.Length; i++)
            {

                if (this.files[i].Split('$')[0] == input)
                {
                    b = true;
                    break;
                }

            }
            String in_case_name_exists = "";
            if (b) in_case_name_exists = " (1)";
            if (input.Split('.').Length!=1)
            {
                return input.Split('.')[0] + in_case_name_exists + "."+input.Split('.')[1];
            }
            
            else return input+ in_case_name_exists;
        }

        private void listView1_Click(object sender, EventArgs e)
        {

            try
            {
                String item = listView1.SelectedItems[0].ToString().Split('{')[1].Split('}')[0];
                for (int i = 0; i < folders.Length; i++)
                {
                    if (folders[i].Split('$')[0] == item)
                    {
                        this.creationDate.Text = folders[i].Split('$')[2];
                        this.size.Text = folders[i].Split('$')[1];
                        break;

                    }
                }
                for (int i = 0; i < files.Length; i++)
                {

                    if (this.files[i].Split('$')[0] == item)
                    {
                        this.creationDate.Text = files[i].Split('$')[2];
                        this.size.Text = files[i].Split('$')[1];
                        break;
                    }

                }


            }



            catch (Exception)
            {
                MessageBox.Show("Operation failed ");

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                String folder = listView1.SelectedItems[0].ToString().Split('{')[1].Split('}')[0];
                List<String> foldersNames = new List<string>();
                for (int i = 0; i < this.folders.Length; i++) foldersNames.Add(this.folders[i].Split('$')[0]);
                if (foldersNames.Contains(folder))
                {
                    String respond = Message("open/" + folder);
                    actualDir = actualDir + folder + "$";
                    this.dir.Text = actualDir.Replace("$", "/");
                    Update_listView(respond);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }



       
        private void Copy_Click(object sender, EventArgs e)
        {
            try
            {
                this.copyCut = "copy/" + this.actualDir + listView1.SelectedItems[0].ToString().Split('{')[1].Split('}')[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            try
            {
                this.copyCut = "cut/" + this.actualDir + listView1.SelectedItems[0].ToString().Split('{')[1].Split('}')[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }

        private void Past_Click(object sender, EventArgs e)
        {
            if (this.copyCut.Length != 0)
            {
                try
                {

                    String correctedName = correctedInput(this.copyCut.Split('$')[this.copyCut.Split('$').Length-1]);
                    String[] l = this.copyCut.Split('$');
                    l[l.Length-1] = correctedName;
                    String respond = Message(String.Join("$",l));
                    MessageBox.Show(respond.Split('/')[0]);
                    Update_listView(respond);
                }
                catch (Exception)
                {
                    MessageBox.Show("Operation failed ");
                }
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Please enter the new name :", "", "Default", -1, -1);
                String respond = Message("rename/" + listView1.SelectedItems[0].ToString().Split('{')[1].Split('}')[0] + "/" + correctedInput(input));
                //MessageBox.Show(respond.Split('/')[0]);
                Update_listView(respond);
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }











        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                String respond = Message("delete/" + listView1.SelectedItems[0].ToString().Split('{')[1].Split('}')[0]);
                Update_listView(respond);
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {

            try
            {
                if (actualDir != "$")
                {
                    String respond = Message("back");
                    String[] d = actualDir.Split('$');
                    actualDir = "$";
                    for (int i = 1; i < d.Length - 2; i++) actualDir += d[i] + "$";
                    this.dir.Text = actualDir.Replace("$", "/");
                    Update_listView(respond);
                }
                else MessageBox.Show("a a aaa !! you can't go out of your space !");

            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }




        private void SignOut_Click(object sender, EventArgs e)
        {
            try
            {
                String respond = Message("logout");
                this.Hide();
                login su = new login();
                su.Closed += (s, args) => this.Close();
                su.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }

        }

        private void NewFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Please enter the name of your new folder :", "", "Default", -1, -1);
                String respond = Message("create/" + correctedInput(input));
                Update_listView(respond);
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "upload a file";
                theDialog.Filter = "All files|*.*";
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
 
                    String respond = Message("upload/" + correctedInput( theDialog.FileName.ToString().Split('\\')[theDialog.FileName.ToString().Split('\\').Length-1]));
                    
                    MessageBox.Show("Please click ok to start uploading");
                    SendFile(theDialog.FileName.ToString());
                    respond = Message("get/");
                    MessageBox.Show("file uploaded successfully :D");
                    Update_listView(respond);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed, please try again ");
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                String file = listView1.SelectedItems[0].ToString().Split('{')[1].Split('}')[0];
                List<String> filesNames = new List<string>();
                for (int i = 0; i < this.files.Length; i++) filesNames.Add(this.files[i].Split('$')[0]);
                if (filesNames.Contains(file))
                {
                    String respond = Message("download/" + file);
                    FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                    if (folderDlg.ShowDialog() == DialogResult.OK)
                    {

                        receiveFile(folderDlg.SelectedPath.ToString() +"\\"+ file);
                        respond = Message("get/");
                        Update_listView(respond);
                        MessageBox.Show("file downloaded successfully :D");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Operation failed ");
            }
        }















































        // file transfer functions :
        public void receiveFile(string fileName)
        {
            var listener = new TcpListener(IPAddress.Loopback, 8000);
            listener.Start();
            
                using (var client = listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                using (var output = File.Create(fileName))
                {
                    // read the file in chunks of 1KB
                    var buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                }




        }



        public void SendFile(string fileName)
        {
            try
            {
                string IpAddressString = this.ipServer;
                IPEndPoint ipEnd_client = new IPEndPoint(IPAddress.Parse(IpAddressString), 8888);
                Socket clientSock_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string filePath = "";

                fileName = fileName.Replace("\\", "/");

                while (fileName.IndexOf("/") > -1)
                {
                    filePath += fileName.Substring(0, fileName.IndexOf("/") + 1);
                    fileName = fileName.Substring(fileName.IndexOf("/") + 1);
                }

                byte[] fileNameByte = Encoding.UTF8.GetBytes(fileName);
                if (fileNameByte.Length > 5000 * 1024)
                {
                    MessageBox.Show("File size is more than 5Mb, please try with small file.");
                    return;
                }

                string fullPath = filePath + fileName;

                byte[] fileData = File.ReadAllBytes(fullPath);
                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);


                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                clientSock_client.Connect(ipEnd_client);

                clientSock_client.Send(clientData, 0, clientData.Length, 0);

                clientSock_client.Close();
    
            }
            catch (Exception ex)
            {
                if (ex.Message == "No connection could be made because the target machine actively refused it")
                    MessageBox.Show("File Sending fail. Because server not running.");
                else
                    MessageBox.Show("File Sending fail. " + ex.Message);
                return;
            }
            return;
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
            return recv;
        }

    }
}

