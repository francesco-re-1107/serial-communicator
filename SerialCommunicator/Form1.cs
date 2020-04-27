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
    public partial class MainScreen : Form
    {
        public string Port { get; set; } = "";

        public int BaudRate { get; set; } = -1;

        public Parity Parity { get; set; }

        public StopBits StopBits { get; set; }

        public int DataBits { get; set; } = -1;

        public Handshake FlowControl { get; set; }

        public bool ReplaceNewLine { get; set; } = false;

        public string FilePath { get; set; } = "";

        public bool IsConnected { get; set; } = false;

        private SerialPort SerialPort = null;

        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            foreach (var p in SerialPort.GetPortNames()){
                portDropdown.Items.Add(p);
            }
            readSettingsFromMemory();
        }
        
        private void readSettingsFromMemory()
        {
            if (Properties.Settings.Default.BaudRate != -1)
            {
                BaudRate = Properties.Settings.Default.BaudRate;
                baudRateDropdown.SelectedItem = BaudRate.ToString();
            }

            if (Properties.Settings.Default.Parity != -1)
            {
                var parityInt = Properties.Settings.Default.Parity;
                Parity = (Parity) parityInt;
                parityDropdown.SelectedIndex = parityInt;
            }

            if (Properties.Settings.Default.DataBits != -1)
            {
                DataBits = Properties.Settings.Default.DataBits;
                databitsDropdown.SelectedItem = DataBits.ToString();
            }

            if (Properties.Settings.Default.StopBits != -1)
            {
                var stopBitsInt = Properties.Settings.Default.StopBits;
                StopBits = (StopBits) stopBitsInt;
                stopbitsDropdown.SelectedIndex = stopBitsInt;
            }

            if (Properties.Settings.Default.FlowControl != -1)
            {
                var flowControlInt = Properties.Settings.Default.FlowControl;
                FlowControl = (Handshake)flowControlInt;
                flowcontrolDropdown.SelectedIndex = flowControlInt;
            }

            ReplaceNewLine = Properties.Settings.Default.ReplaceNewLine;
        }

        private void portDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port = portDropdown.SelectedItem.ToString();
            Log("Port selected: " + Port);
            checkConnectionButtons();
        }

        private void baudRateDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int r;
            string baudRateString = baudRateDropdown.SelectedItem.ToString();
            if (int.TryParse(baudRateString, out r))
            {
                BaudRate = r;
                Properties.Settings.Default.BaudRate = BaudRate;
                Properties.Settings.Default.Save();
            }
            else
            {
                Log("Error selecting baud rate: " + baudRateString);
            }

            Log("Baud rate selected: " + BaudRate);
            checkConnectionButtons();
        }

        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    filePathTextBox.Text = file;
                    FilePath = file;
                    Log("Selected file " + file);
                }
                catch (IOException ex)
                {
                    Log(ex.Message);
                }
            }

            checkSendButton();
        }

        private void checkSendButton()
        {
            sendButton.Enabled = IsConnected && !string.IsNullOrEmpty(FilePath);
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
            try
            {
                SerialPort = new SerialPort(Port, BaudRate, Parity);
                if (DataBits != -1)
                    SerialPort.DataBits = DataBits;
                if(StopBits != StopBits.None)
                    SerialPort.StopBits = StopBits;

                SerialPort.Handshake = FlowControl;
                SerialPort.RtsEnable = true;
                SerialPort.DtrEnable = true;
                SerialPort.Encoding = new ASCIIEncoding();
                SerialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                SerialPort.Open();

                connectButton.Enabled = false;
                IsConnected = true;

                Log("Connected to " + Port);
            }catch(Exception ex)
            {
                Log("Error: " + ex.Message);
            }

            checkConnectionButtons();

        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            receiveTextBox.AppendText(SerialPort.ReadExisting());
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var text = File.ReadAllText(FilePath);

            if (ReplaceNewLine)
                Regex.Replace(text, @"\r\n|\r|\n", "\r\n");

            progressBar.Style = ProgressBarStyle.Marquee;
            Task.Run(() => sendFile(text));
        }

        private async Task sendFile(string text)
        {
            SerialPort.Write(text);
            
            Log("File sent");
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Style = ProgressBarStyle.Continuous;
            });
        }

        private void logTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            logTextBox.SelectionStart = logTextBox.Text.Length;
            // scroll it automatically
            logTextBox.ScrollToCaret();
        }

        private void parityDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parity = (Parity) parityDropdown.SelectedIndex;

            Log("Parity selected: " + parityDropdown.SelectedItem.ToString());

            Properties.Settings.Default.Parity = parityDropdown.SelectedIndex;
            Properties.Settings.Default.Save();
            checkConnectionButtons();
        }

        private void databitsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d;
            string databitsString = databitsDropdown.SelectedItem.ToString();

            if (int.TryParse(databitsString, out d))
            {
                DataBits = d;
                Properties.Settings.Default.DataBits = DataBits;
                Properties.Settings.Default.Save();
            }
            else
            {
                Log("Error selecting data bits: " + databitsString);
            }

            Log("Data bits selected: " + DataBits);
            checkConnectionButtons();
        }

        private void stopbitsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopBits = (StopBits) stopbitsDropdown.SelectedIndex;

            Properties.Settings.Default.StopBits = stopbitsDropdown.SelectedIndex;
            Properties.Settings.Default.Save();

            Log("Stop bits selected: " + stopbitsDropdown.SelectedItem.ToString());
            checkConnectionButtons();
        }

        private void flowcontrolDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlowControl = (Handshake) flowcontrolDropdown.SelectedIndex;

            Properties.Settings.Default.FlowControl = flowcontrolDropdown.SelectedIndex;
            Properties.Settings.Default.Save();

            Log("Flow control selected: " + flowcontrolDropdown.SelectedItem.ToString());
            checkConnectionButtons();
        }

        private void checkConnectionButtons()
        {
            if (IsConnected)
            {
                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
            }
            else
            {
                bool shouldConnect = 
                    !string.IsNullOrEmpty(Port) && 
                    BaudRate != -1 &&
                    StopBits != StopBits.None;

                connectButton.Enabled = shouldConnect;
                disconnectButton.Enabled = false;
            }
            checkSendButton();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort.IsOpen)
                {
                    SerialPort.Close();
                    SerialPort.Dispose();
                }
                IsConnected = false;
                Log("Port closed successfully");
            }
            catch(Exception ex)
            {
                Log("Error closing serial port: " + ex.Message);
            }

            checkConnectionButtons();
        }

        private void replaceNewlineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ReplaceNewLine = replaceNewlineCheckbox.Checked;

            Properties.Settings.Default.ReplaceNewLine = ReplaceNewLine;
            Properties.Settings.Default.Save();

            Log("Replace new line with CR LF: " + ReplaceNewLine);
        }

        private void receiveTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            logTextBox.SelectionStart = logTextBox.Text.Length;
            // scroll it automatically
            logTextBox.ScrollToCaret();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            var text = receiveTextBox.Text;

            saveFileDialog.Title = "Save received text";
            saveFileDialog.ShowDialog();

            var filePath = saveFileDialog.FileName;
            if (filePath != "")
            {
                try
                {
                    File.WriteAllText(filePath, text);
                    Log("Saved received text to file");
                }catch(Exception ex)
                {
                    Log("Error saving received text: " + ex.Message);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            receiveTextBox.Text = "";
            Log("Reset receive box");
        }
    }
}
