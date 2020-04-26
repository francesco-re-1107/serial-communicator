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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.readTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // portDropdown
            // 
            this.portDropdown.FormattingEnabled = true;
            this.portDropdown.Location = new System.Drawing.Point(11, 19);
            this.portDropdown.Name = "portDropdown";
            this.portDropdown.Size = new System.Drawing.Size(160, 21);
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
            this.baudRateDropdown.Location = new System.Drawing.Point(11, 46);
            this.baudRateDropdown.Name = "baudRateDropdown";
            this.baudRateDropdown.Size = new System.Drawing.Size(160, 21);
            this.baudRateDropdown.TabIndex = 1;
            this.baudRateDropdown.Text = "Baud rate*";
            this.baudRateDropdown.SelectedIndexChanged += new System.EventHandler(this.baudRateDropdown_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(11, 144);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(160, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(65, 58);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(239, 26);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(11, 22);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(254, 20);
            this.filePathTextBox.TabIndex = 4;
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(275, 20);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(75, 23);
            this.browseFilesButton.TabIndex = 5;
            this.browseFilesButton.Text = "Browse";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            this.browseFilesButton.Click += new System.EventHandler(this.browseFilesButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text|*.txt|All|*.*";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(11, 19);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(339, 119);
            this.logTextBox.TabIndex = 6;
            this.logTextBox.Text = "";
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 453);
            this.progressBar.MarqueeAnimationSpeed = 500;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(362, 27);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(190, 144);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(160, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // replaceNewlineCheckbox
            // 
            this.replaceNewlineCheckbox.AutoSize = true;
            this.replaceNewlineCheckbox.Location = new System.Drawing.Point(11, 111);
            this.replaceNewlineCheckbox.Name = "replaceNewlineCheckbox";
            this.replaceNewlineCheckbox.Size = new System.Drawing.Size(216, 17);
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
            this.flowcontrolDropdown.Location = new System.Drawing.Point(190, 73);
            this.flowcontrolDropdown.Name = "flowcontrolDropdown";
            this.flowcontrolDropdown.Size = new System.Drawing.Size(160, 21);
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
            this.databitsDropdown.Location = new System.Drawing.Point(190, 19);
            this.databitsDropdown.Name = "databitsDropdown";
            this.databitsDropdown.Size = new System.Drawing.Size(160, 21);
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
            this.stopbitsDropdown.Location = new System.Drawing.Point(190, 46);
            this.stopbitsDropdown.Name = "stopbitsDropdown";
            this.stopbitsDropdown.Size = new System.Drawing.Size(160, 21);
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
            this.parityDropdown.Location = new System.Drawing.Point(11, 73);
            this.parityDropdown.Name = "parityDropdown";
            this.parityDropdown.Size = new System.Drawing.Size(160, 21);
            this.parityDropdown.TabIndex = 9;
            this.parityDropdown.Text = "Parity*";
            this.parityDropdown.SelectedIndexChanged += new System.EventHandler(this.parityDropdown_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 144);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filePathTextBox);
            this.groupBox3.Controls.Add(this.sendButton);
            this.groupBox3.Controls.Add(this.browseFilesButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.readTextBox);
            this.groupBox4.Location = new System.Drawing.Point(388, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 468);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read";
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(14, 19);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(305, 437);
            this.readTextBox.TabIndex = 0;
            this.readTextBox.Text = "";
            this.readTextBox.TextChanged += new System.EventHandler(this.readTextBox_TextChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
        private System.Windows.Forms.RichTextBox readTextBox;
    }
}

