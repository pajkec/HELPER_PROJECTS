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
using System.Threading;
using System.Diagnostics;

namespace SimpleTCPServer
{
    public partial class Form1 : Form
    {

        private DateTime textBox1_last_send;
        private DateTime textBox2_last_send;
        private DateTime textBox3_last_send;
        private DateTime textBox4_last_send;
        private DateTime textBox5_last_send;

        private TcpClient client;
        private CancellationTokenSource _cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteToTextBox(textBox_OutputDebug, "Start clicked\r\n");


            _cancellationTokenSource = new CancellationTokenSource();


            Task.Run(() => StartServer(textBox_IP.Text, int.Parse(textBox_PORT.Text), _cancellationTokenSource.Token));
            Task.Run(() => LoopMsgSend(_cancellationTokenSource.Token));

        }

        public void StartServer(string ipAddress, int port, CancellationToken cancellationToken)
        {
            try
            {
                TcpListener server = new TcpListener(IPAddress.Parse(ipAddress), port);
                server.Start();
                WriteToTextBox(textBox_OutputDebug, $"Scale simulator started on {ipAddress}:{port}\r\n");

                while (!cancellationToken.IsCancellationRequested)
                {
                    // Accept client connections asynchronously
                    client = server.AcceptTcpClient();
                    WriteToTextBox(textBox_OutputDebug, "Client connected.\r\n");

                    // Start each client in its own task
                    Task.Run(() => HandleClient(client, cancellationToken));
                }


                WriteToTextBox(textBox_OutputDebug, $"Scale simulator stopped on {ipAddress}:{port}\r\n");

                server.Stop();

            }
            catch (Exception ex)
            {
                WriteToTextBox(textBox_OutputDebug, $"Server error: {ex.Message}\r\n");
            }
        }


        public void LoopMsgSend(CancellationToken cancellationToken)
        {
            try
            {

                while (!cancellationToken.IsCancellationRequested)
                {
                    SendLoopedMessages();
                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {
                WriteToTextBox(textBox_OutputDebug, $"Server error: {ex.Message}\r\n");
            }
        }


        private void HandleClient(TcpClient client, CancellationToken cancellationToken)
        {
            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = new byte[1024];

                try
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            WriteToTextBox(textBox_OutputDebug, "Client disconnected.\r\n");
                            break;
                        }

                        string command = Encoding.ASCII.GetString(buffer, 0, bytesRead).Trim();
                        WriteToTextBox(textBox_OutputDebug, $"Received command: {command}\r\n");

                        WriteToTextBox(textBox_outputData, $"<-IN--      {command}\r\n");

                        if (command.Equals(textBox_IfGet1.Text, StringComparison.OrdinalIgnoreCase))
                            Task.Run(() =>
                            {
                                Thread.Sleep(int.Parse(textBox_ifDelay1.Text));
                                SendMessage(textBox_IfSet1.Text);
                            });

                        if (command.Equals(textBox_IfGet2.Text, StringComparison.OrdinalIgnoreCase))
                            Task.Run(() =>
                            {
                                Thread.Sleep(int.Parse(textBox_ifDelay2.Text));
                                SendMessage(textBox_IfSet2.Text);
                            });

                        if (command.Equals(textBox_IfGet3.Text, StringComparison.OrdinalIgnoreCase))
                            Task.Run(() =>
                            {
                                Thread.Sleep(int.Parse(textBox_ifDelay3.Text));
                                SendMessage(textBox_IfSet3.Text);
                            });

                    }
                }
                catch (Exception ex)
                {
                    WriteToTextBox(textBox_OutputDebug, $"Error: {ex.Message}\r\n");
                }
                finally
                {
                    client.Close();
                }
            }
        }




        private void WriteToTextBox(System.Windows.Forms.TextBox tb, string text)
        {
            Debug.WriteLine(text);

            if (tb.InvokeRequired)
            {
                tb.Invoke(new Action(() => tb.Text = text + tb.Text));
            }
            else
            {
                tb.Text = text + tb.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendMessage(textBox_send1.Text);
        }


        private void SendMessage(string text)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    NetworkStream stream = client.GetStream();
                    byte[] messageBytes = Encoding.ASCII.GetBytes(text.Replace("\\r", "\r").Replace("\\n", "\n"));
                    stream.Write(messageBytes, 0, messageBytes.Length);
                    WriteToTextBox(textBox_OutputDebug, $"Sent message to client: {text}\r\n");
                    WriteToTextBox(textBox_outputData, $"-OUT->      {text}\r\n");
                }
                else
                {
                    WriteToTextBox(textBox_OutputDebug, "Client is not connected.\r\n");
                }
            }
            catch (Exception ex)
            {
                WriteToTextBox(textBox_OutputDebug, $"Error sending message: {ex.Message}\r\n");
            }
        }

        private void SendLoopedMessages()
        {
            if (checkBox_loop1.Checked)
            {
                if (textBox1_last_send < DateTime.Now.AddMilliseconds(-int.Parse(textBox_loopTime1.Text)))
                {
                    SendMessage(textBox_send1.Text);
                    textBox1_last_send = DateTime.Now;
                }
            }

            if (checkBox_loop2.Checked)
            {
                if (textBox2_last_send < DateTime.Now.AddMilliseconds(-int.Parse(textBox_loopTime2.Text)))
                {
                    SendMessage(textBox_send2.Text);
                    textBox2_last_send = DateTime.Now;
                }
            }

            if (checkBox_loop3.Checked)
            {
                if (textBox3_last_send < DateTime.Now.AddMilliseconds(-int.Parse(textBox_loopTime3.Text)))
                {
                    SendMessage(textBox_send3.Text);
                    textBox3_last_send = DateTime.Now;
                }
            }

            if (checkBox_loop4.Checked)
            {
                if (textBox4_last_send < DateTime.Now.AddMilliseconds(-int.Parse(textBox_loopTime4.Text)))
                {
                    SendMessage(textBox_send4.Text);
                    textBox4_last_send = DateTime.Now;
                }
            }

            if (checkBox_loop5.Checked)
            {
                if (textBox5_last_send < DateTime.Now.AddMilliseconds(-int.Parse(textBox_loopTime5.Text)))
                {
                    SendMessage(textBox_send5.Text);
                    textBox5_last_send = DateTime.Now;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                WriteToTextBox(textBox_OutputDebug, "Cancellation requested.\r\n");
            }
        }

        private void button_send2_Click(object sender, EventArgs e)
        {
            SendMessage(textBox_send2.Text);
        }

        private void button_send3_Click(object sender, EventArgs e)
        {
            SendMessage(textBox_send3.Text);
        }

        private void button_send4_Click(object sender, EventArgs e)
        {
            SendMessage(textBox_send4.Text);
        }

        private void button_send5_Click(object sender, EventArgs e)
        {
            SendMessage(textBox_send5.Text);
        }
    }
}
