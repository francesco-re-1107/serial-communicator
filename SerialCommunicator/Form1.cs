using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace SerialCommunicator
{
    public partial class Form1 : Form
    {
        public string Port { get; set; } = "COM1";

        public int BaudRate { get; set; } = 4800;

        public Parity Parity { get; set; } = Parity.Even;

        public StopBits StopBits { get; set; } = StopBits.Two;

        public int DataBits { get; set; } = 7;

        public string FilePath { get; set; } = "";

        public bool IsConnected { get; set; } = false;

        public Handshake FlowControl { get; set; } = Handshake.XOnXOff;

        private SerialPort SerialPort = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var p in SerialPort.GetPortNames()){
                portDropdown.Items.Add(p);
            }
                
        }

        private void portDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port = portDropdown.SelectedItem.ToString();
            Console.WriteLine(Port);
            Log("Port selected: " + Port);
        }

        private void baudRateDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int r = 4800;
            string baudRateString = baudRateDropdown.SelectedItem.ToString();
            if (int.TryParse(baudRateString, out r))
            {
                BaudRate = r;
            }
            else
            {
                Log("Error selecting baud rate: " + baudRateString);
            }

            Log("Baud rate selected: " + BaudRate);
        }

        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    filePathTextBox.Text = file;
                    FilePath = file;
                    Log("Selected file " + file);
                    sendButton.Enabled = true;
                    return;
                }
                catch (IOException ex)
                {
                    Log(ex.Message);
                }
            }

            FilePath = "";
            sendButton.Enabled = false;
        }

        private void Log(string message)
        {
            logTextBox.Invoke((MethodInvoker)delegate
            {
                logTextBox.AppendText(message + "\n");
            });
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            IsConnected = true;
            SerialPort = new SerialPort(Port, BaudRate, Parity, DataBits, StopBits);
            SerialPort.Open();
            SerialPort.Handshake = FlowControl;
            SerialPort.RtsEnable = true;
            SerialPort.DtrEnable = true;
            SerialPort.Encoding = new ASCIIEncoding();
            connectButton.Enabled = false;

            Log("Connected to " + Port);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(FilePath);
            foreach (var line in lines)
            {
                Regex.Replace(line, @"\r\n|\r|\n", "\r\n");
            }

            progressBar.Maximum = lines.Length;
            Task.Run(() => SendFile(lines));
        }

        private async Task SendFile(string[] lines)
        {
            for(int i = 0; i < lines.Length; i++)
            {
                SerialPort.Write(lines[i]);
                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.Value = i + 1;
                });
                Thread.Sleep(20);
            }
            Log("File sent");
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = 0;
            });
        }
    }
}
