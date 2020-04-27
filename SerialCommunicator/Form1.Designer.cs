namespace SerialCommunicator
{
    partial class MainScreen
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.portDropdown = new System.Windows.Forms.ComboBox();
            this.baudRateDropdown = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.replaceNewlineCheckbox = new System.Windows.Forms.CheckBox();
            this.flowcontrolDropdown = new System.Windows.Forms.ComboBox();
            this.databitsDropdown = new System.Windows.Forms.ComboBox();
            this.stopbitsDropdown = new System.Windows.Forms.ComboBox();
            this.parityDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // portDropdown
            // 
            this.portDropdown.FormattingEnabled = true;
            this.portDropdown.Location = new System.Drawing.Point(22, 37);
            this.portDropdown.Margin = new System.Windows.Forms.Padding(6);
            this.portDropdown.Name = "portDropdown";
            this.portDropdown.Size = new System.Drawing.Size(316, 33);
            this.portDropdown.TabIndex = 0;
            this.portDropdown.Text = "Port*";
            this.portDropdown.SelectedIndexChanged += new System.EventHandler(this.portDropdown_SelectedIndexChanged);
            // 
            // baudRateDropdown
            // 
            this.baudRateDropdown.FormattingEnabled = true;
            this.baudRateDropdown.Items.AddRange(new object[] {
            "75",
            "110",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudRateDropdown.Location = new System.Drawing.Point(22, 88);
            this.baudRateDropdown.Margin = new System.Windows.Forms.Padding(6);
            this.baudRateDropdown.Name = "baudRateDropdown";
            this.baudRateDropdown.Size = new System.Drawing.Size(316, 33);
            this.baudRateDropdown.TabIndex = 1;
            this.baudRateDropdown.Text = "Baud rate*";
            this.baudRateDropdown.SelectedIndexChanged += new System.EventHandler(this.baudRateDropdown_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(22, 277);
            this.connectButton.Margin = new System.Windows.Forms.Padding(6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(320, 44);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(130, 112);
            this.sendButton.Margin = new System.Windows.Forms.Padding(6);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(478, 50);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(22, 42);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(504, 31);
            this.filePathTextBox.TabIndex = 4;
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(550, 38);
            this.browseFilesButton.Margin = new System.Windows.Forms.Padding(6);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(150, 44);
            this.browseFilesButton.TabIndex = 5;
            this.browseFilesButton.Text = "Browse";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Text|*.txt|All|*.*";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(22, 37);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(674, 225);
            this.logTextBox.TabIndex = 6;
            this.logTextBox.Text = "";
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(24, 871);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.MarqueeAnimationSpeed = 500;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(724, 52);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(380, 277);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(6);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(320, 44);
            this.disconnectButton.TabIndex = 8;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.replaceNewlineCheckbox);
            this.groupBox1.Controls.Add(this.flowcontrolDropdown);
            this.groupBox1.Controls.Add(this.databitsDropdown);
            this.groupBox1.Controls.Add(this.stopbitsDropdown);
            this.groupBox1.Controls.Add(this.parityDropdown);
            this.groupBox1.Controls.Add(this.portDropdown);
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.baudRateDropdown);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(724, 344);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // replaceNewlineCheckbox
            // 
            this.replaceNewlineCheckbox.AutoSize = true;
            this.replaceNewlineCheckbox.Location = new System.Drawing.Point(22, 213);
            this.replaceNewlineCheckbox.Margin = new System.Windows.Forms.Padding(6);
            this.replaceNewlineCheckbox.Name = "replaceNewlineCheckbox";
            this.replaceNewlineCheckbox.Size = new System.Drawing.Size(426, 29);
            this.replaceNewlineCheckbox.TabIndex = 13;
            this.replaceNewlineCheckbox.Text = "Replace new line characters with CR LF";
            this.replaceNewlineCheckbox.UseVisualStyleBackColor = true;
            this.replaceNewlineCheckbox.CheckedChanged += new System.EventHandler(this.replaceNewlineCheckbox_CheckedChanged);
            // 
            // flowcontrolDropdown
            // 
            this.flowcontrolDropdown.FormattingEnabled = true;
            this.flowcontrolDropdown.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "Request to send",
            "Request to send XOnXOff"});
            this.flowcontrolDropdown.Location = new System.Drawing.Point(380, 140);
            this.flowcontrolDropdown.Margin = new System.Windows.Forms.Padding(6);
            this.flowcontrolDropdown.Name = "flowcontrolDropdown";
            this.flowcontrolDropdown.Size = new System.Drawing.Size(316, 33);
            this.flowcontrolDropdown.TabIndex = 12;
            this.flowcontrolDropdown.Text = "Flow control";
            this.flowcontrolDropdown.SelectedIndexChanged += new System.EventHandler(this.flowcontrolDropdown_SelectedIndexChanged);
            // 
            // databitsDropdown
            // 
            this.databitsDropdown.FormattingEnabled = true;
            this.databitsDropdown.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.databitsDropdown.Location = new System.Drawing.Point(380, 37);
            this.databitsDropdown.Margin = new System.Windows.Forms.Padding(6);
            this.databitsDropdown.Name = "databitsDropdown";
            this.databitsDropdown.Size = new System.Drawing.Size(316, 33);
            this.databitsDropdown.TabIndex = 11;
            this.databitsDropdown.Text = "Data Bits";
            this.databitsDropdown.SelectedIndexChanged += new System.EventHandler(this.databitsDropdown_SelectedIndexChanged);
            // 
            // stopbitsDropdown
            // 
            this.stopbitsDropdown.FormattingEnabled = true;
            this.stopbitsDropdown.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "1.5"});
            this.stopbitsDropdown.Location = new System.Drawing.Point(380, 88);
            this.stopbitsDropdown.Margin = new System.Windows.Forms.Padding(6);
            this.stopbitsDropdown.Name = "stopbitsDropdown";
            this.stopbitsDropdown.Size = new System.Drawing.Size(316, 33);
            this.stopbitsDropdown.TabIndex = 10;
            this.stopbitsDropdown.Text = "Stop Bits*";
            this.stopbitsDropdown.SelectedIndexChanged += new System.EventHandler(this.stopbitsDropdown_SelectedIndexChanged);
            // 
            // parityDropdown
            // 
            this.parityDropdown.FormattingEnabled = true;
            this.parityDropdown.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityDropdown.Location = new System.Drawing.Point(22, 140);
            this.parityDropdown.Margin = new System.Windows.Forms.Padding(6);
            this.parityDropdown.Name = "parityDropdown";
            this.parityDropdown.Size = new System.Drawing.Size(316, 33);
            this.parityDropdown.TabIndex = 9;
            this.parityDropdown.Text = "Parity*";
            this.parityDropdown.SelectedIndexChanged += new System.EventHandler(this.parityDropdown_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logTextBox);
            this.groupBox2.Location = new System.Drawing.Point(24, 583);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(724, 277);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filePathTextBox);
            this.groupBox3.Controls.Add(this.sendButton);
            this.groupBox3.Controls.Add(this.browseFilesButton);
            this.groupBox3.Location = new System.Drawing.Point(24, 379);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(724, 192);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resetButton);
            this.groupBox4.Controls.Add(this.saveToFileButton);
            this.groupBox4.Controls.Add(this.receiveTextBox);
            this.groupBox4.Location = new System.Drawing.Point(776, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(668, 900);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(351, 837);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(283, 43);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(28, 837);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(283, 43);
            this.saveToFileButton.TabIndex = 1;
            this.saveToFileButton.Text = "Save to file";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(28, 37);
            this.receiveTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.Size = new System.Drawing.Size(606, 785);
            this.receiveTextBox.TabIndex = 0;
            this.receiveTextBox.Text = "";
            this.receiveTextBox.TextChanged += new System.EventHandler(this.receiveTextBox_TextChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 944);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.Text = "Serial Communicator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portDropdown;
        private System.Windows.Forms.ComboBox baudRateDropdown;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox parityDropdown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox stopbitsDropdown;
        private System.Windows.Forms.CheckBox replaceNewlineCheckbox;
        private System.Windows.Forms.ComboBox flowcontrolDropdown;
        private System.Windows.Forms.ComboBox databitsDropdown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox receiveTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

