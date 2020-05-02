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
        // port name (e.g. COM1)
        public string Port { get; set; } = "";

        // baud rate of the port (the list of baud rates is defined in the dropdown items)
        public int BaudRate { get; set; } = -1;

        // parity of the port, it can be None, Odd or Even
        public Parity Parity { get; set; }

        // stop bits of the port, it can be None, One, Two, OnePointFive
        public StopBits StopBits { get; set; }

        // data bits of the port, it can be 5, 6, 7, 8 or 9
        public int DataBits { get; set; } = -1;

        // flow control of the port, it can be xOnxOff
        public Handshake FlowControl { get; set; }

        // flag indicating whether or not the program should replace every new line char with CR LF
        public bool ReplaceNewLine { get; set; } = false;

        // this variable is used to store the path of the selected file to send
        public string FilePath { get; set; } = "";

        // this flag is used to check if the port is open or not
        public bool IsConnected { get; set; } = false;

        // this is the serial port object
        private SerialPort SerialPort = null;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // do not show maximize button of the window
            MaximizeBox = false;

            //update ports dropdown with all available ports
            foreach (var p in SerialPort.GetPortNames()){
                portDropdown.Items.Add(p);
            }
            
            readSettingsFromMemory();
        }
        
        /**
         * This function read every setting from memory and restore it in the UI
         */
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

        /**
         * This function is called whenever port is changed
         */ 
        private void portDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port = portDropdown.SelectedItem.ToString();
            Log("Port selected: " + Port);
            
            // port is changed then check if connect and disconnect buttons should be enabled or disabled
            checkConnectionButtons();
        }

        /**
         * This function is called whenever baud rate is changed
         */
        private void baudRateDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int r;
            string baudRateString = baudRateDropdown.SelectedItem.ToString();
            if (int.TryParse(baudRateString, out r))
            {
                BaudRate = r;
                //saving baud rate in memory
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
            //show open file dialog 
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

        /**
         * This function check if send button should be enabled or not
         */
        private void checkSendButton()
        {
            sendButton.Enabled = IsConnected && !string.IsNullOrEmpty(FilePath);
        }

        /**
         * This function logs every message to the logTextBox
         */
        private void Log(string message)
        {
            logTextBox.Invoke((MethodInvoker)delegate
            {
                logTextBox.AppendText(message + "\n");
            });
        }

        /**
         * This function is called when the connect button is pressed
         * and is responsible of the connection to the port
         */
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

        /**
         * This function is a listener for data arriving from the port
         */
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            receiveTextBox.AppendText(SerialPort.ReadExisting());
        }

        /**
         * This function is called whenever port is changed
         */
        private void sendButton_Click(object sender, EventArgs e)
        {
            var text = File.ReadAllText(FilePath);

            if (ReplaceNewLine)
                Regex.Replace(text, @"\r\n|\r|\n", "\r\n");

            // start the progressBar
            progressBar.Style = ProgressBarStyle.Marquee;
            // run on a new thread so the UI does not freeze
            Task.Run(() => sendFile(text));
        }

        /**
         * This function writes the file to the port
         */
        private async Task sendFile(string text)
        {
            SerialPort.Write(text);
            
            Log("File sent");
            
            // stop the progressBar
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Style = ProgressBarStyle.Continuous;
            });
        }

        /**
         * This function scrolls the logTextBox to caret
         */
        private void logTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            logTextBox.SelectionStart = logTextBox.Text.Length;
            // scroll it automatically
            logTextBox.ScrollToCaret();
        }

        /**
         * This function is called whenever parity is changed
         */
        private void parityDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parity = (Parity) parityDropdown.SelectedIndex;

            Log("Parity selected: " + parityDropdown.SelectedItem.ToString());
            
            // saving parity to memory
            Properties.Settings.Default.Parity = parityDropdown.SelectedIndex;
            Properties.Settings.Default.Save();

            checkConnectionButtons();
        }

        /**
         * This function is called whenever data bits is changed
         */
        private void databitsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d;
            string databitsString = databitsDropdown.SelectedItem.ToString();

            if (int.TryParse(databitsString, out d))
            {
                DataBits = d;
                //saving data bits to memory
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

        /**
         * This function is called whenever stop bits is changed
         */
        private void stopbitsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopBits = (StopBits) stopbitsDropdown.SelectedIndex;

            // saving stop bits to memory
            Properties.Settings.Default.StopBits = stopbitsDropdown.SelectedIndex;
            Properties.Settings.Default.Save();

            Log("Stop bits selected: " + stopbitsDropdown.SelectedItem.ToString());
            checkConnectionButtons();
        }

        /**
         * This function is called whenever flow comtrol is changed
         */
        private void flowcontrolDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlowControl = (Handshake) flowcontrolDropdown.SelectedIndex;

            // saving flow control to memory
            Properties.Settings.Default.FlowControl = flowcontrolDropdown.SelectedIndex;
            Properties.Settings.Default.Save();

            Log("Flow control selected: " + flowcontrolDropdown.SelectedItem.ToString());
            checkConnectionButtons();
        }

        /**
         * This function is used to check if connect an disconnect buttons should be enabled or disabled
         */
        private void checkConnectionButtons()
        {
            if (IsConnected)
            {
                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
            }
            else
            {
                // check if all settings are good
                bool shouldConnect = 
                    !string.IsNullOrEmpty(Port) && 
                    BaudRate != -1 &&
                    StopBits != StopBits.None;

                connectButton.Enabled = shouldConnect;
                disconnectButton.Enabled = false;
            }
            checkSendButton();
        }

        /**
         * This function is called when disconnect button is called
         * and is responsible of closing and disposing the serial port
         */
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

        /**
         * This function is called whenever the replace new line checkbox is changed
         */
        private void replaceNewlineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ReplaceNewLine = replaceNewlineCheckbox.Checked;

            // saving to memory
            Properties.Settings.Default.ReplaceNewLine = ReplaceNewLine;
            Properties.Settings.Default.Save();

            Log("Replace new line with CR LF: " + ReplaceNewLine);
        }

        /**
         * This function scrolls the logTextBox to caret
         */
        private void receiveTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            receiveTextBox.SelectionStart = logTextBox.Text.Length;
            // scroll it automatically
            receiveTextBox.ScrollToCaret();
        }

        /**
         * This function saves the text received from port to file
         */
        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            var text = receiveTextBox.Text;

            saveFileDialog.Title = "Save received text";
            saveFileDialog.ShowDialog();
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.CheckFileExists = true;

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

        /**
         * This function resets the receiveTextBot 
         */
        private void resetButton_Click(object sender, EventArgs e)
        {
            receiveTextBox.Text = "";
            Log("Reset receive box");
        }
    }
}
