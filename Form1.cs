using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using libdebug;

namespace PS4Shenanigans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // add auto detect game by scaning through process list


        private PS4DBG ps4;
        private int pid;
        public static Socket _psocket;
        public static bool pDConnected;
        public static string Exception;

        private void cntbtn_Click(object sender, EventArgs e)
        {
            if (ipaddrinput.Text == "")
            {
                MessageBox.Show("You need to enter an IP to connect");
            } else
            {
                try
                {
                    ps4 = new PS4DBG(ipaddrinput.Text);
                    ps4.Connect();
                    ps4.Notify(222, "PS4Shenanigans Connected Successfully!");
                    cntstatus.Text = "Connected!";
                    cntstatus.ForeColor = Color.Green;
                    foreach (libdebug.Process process in ps4.GetProcessList().processes)
                    {
                        processlist.Items.Add(process); // needs testing
                    }
                }
                catch
                {
                    cntstatus.Text = "Failed to Connect!";
                    cntstatus.ForeColor = Color.Red;
                }
            }
        }

        private void disconnectbtn_Click(object sender, EventArgs e)
        {
            if (cntstatus.Text == "Not Connected!")
            {
                MessageBox.Show("You need to be connected to be able to disconnect.");
            } else if (cntstatus.Text == "Failed to Connect!")
            {
                MessageBox.Show("It failed to connect so theres nothing to disconnect from.");
            } else
            {
                ps4.Disconnect(); // needs testing
            }
            
        }

        private void notifybtn_Click(object sender, EventArgs e)
        {
            if (notifyicons.SelectedIndex == 0)
            {
                ps4.Notify(222, this.notifyinput.Text); // needs testing
            } else if (notifyinput.Text == "") {
                ps4.Notify(222, "Test notify sent by PS4Shenanigans :)");
            } else
            {
                ps4.Notify(notifyicons.SelectedIndex, this.notifyinput.Text);
            }
        }

        private void printsendbtn_Click(object sender, EventArgs e)
        {
            ps4.Print(this.printinput.Text);
        }

        public static bool PS4Connect(string ip, string port)
        {
            try
            {
                _psocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _psocket.ReceiveTimeout = 3000;
                _psocket.SendTimeout = 3000;
                _psocket.Connect(new IPEndPoint(IPAddress.Parse(ip), Int32.Parse(port)));
                pDConnected = true;
                return true;
            } catch
            {
                pDConnected = false;
                Exception = Exception.ToString();
                return false;
            }
        }

        public static void SendPayload(string filename)
        {
            _psocket.SendFile(filename);
        }

        private void sendpayload_Click(object sender, EventArgs e)
        {
            if (ipaddrinputpl.Text == "")
            {
                MessageBox.Show("You need to enter an IP to connect");
            } else if (payloadpath.Text == "") {
                MessageBox.Show("Please Select a payload to send");
            }
            else
            {
                bool result = PS4Connect(ipaddrinputpl.Text, portinput.Text);
                if (!result)
                {
                    MessageBox.Show("Failled to connect!" + Exception);
                }
                else
                {
                    try
                    {
                        SendPayload(path2payload);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Couldn't send payload!" + ex);
                    }
                }
            }
        }

        public static string path2payload;
        public static string path2elf;

        private void loadpayload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "bin files (*.bin)|*.bin";
            path2payload = openFileDialog1.FileName;
            payloadpath.Text = path2payload;
        }

        private void injectbtn_Click(object sender, EventArgs e)
        {
            if (elfpath.Text == "")
            {
                MessageBox.Show("Please Select An Elf Before Sending"); // needs testing
            } else
            {
                ps4.LoadElf(pid, path2elf);
            }
        }

        private void elfloadbtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            openFileDialog2.Filter = "Elf files (*.elf)|*.elf;";
            path2elf = openFileDialog2.FileName;
            elfpath.Text = path2elf;
        }

        private void prostop_Click(object sender, EventArgs e)
        {
            ps4.ProcessStop();
        }

        private void prokill_Click(object sender, EventArgs e)
        {
            ps4.ProcessKill();
        }

        private void proresume_Click(object sender, EventArgs e)
        {
            ps4.ProcessResume();
        }
    }
}
