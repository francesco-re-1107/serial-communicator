namespace SerialCommunicator
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // portDropdown
            // 
            this.portDropdown.FormattingEnabled = true;
            this.portDropdown.Location = new System.Drawing.Point(12, 12);
            this.portDropdown.Name = "portDropdown";
            this.portDropdown.Size = new System.Drawing.Size(121, 21);
            this.portDropdown.TabIndex = 0;
            this.portDropdown.Text = "Porta";
            this.portDropdown.SelectedIndexChanged += new System.EventHandler(this.portDropdown_SelectedIndexChanged);
            // 
            // baudRateDropdown
            // 
            this.baudRateDropdown.FormattingEnabled = true;
            this.baudRateDropdown.Location = new System.Drawing.Point(12, 40);
            this.baudRateDropdown.Name = "baudRateDropdown";
            this.baudRateDropdown.Size = new System.Drawing.Size(121, 21);
            this.baudRateDropdown.TabIndex = 1;
            this.baudRateDropdown.Text = "Baud rate";
            this.baudRateDropdown.SelectedIndexChanged += new System.EventHandler(this.baudRateDropdown_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 88);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(362, 40);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connetti";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(13, 184);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(362, 40);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Invia";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(13, 152);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(280, 20);
            this.filePathTextBox.TabIndex = 4;
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(299, 150);
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
            this.openFileDialog1.Filter = "Files|*.nc;";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(13, 240);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(361, 116);
            this.logTextBox.TabIndex = 6;
            this.logTextBox.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 371);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(361, 13);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 396);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.browseFilesButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.baudRateDropdown);
            this.Controls.Add(this.portDropdown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

