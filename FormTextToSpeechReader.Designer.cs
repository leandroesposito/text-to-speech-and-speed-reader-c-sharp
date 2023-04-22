namespace text_to_speech_reader
{
    partial class FormTextToSpeechReader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnReadBox = new Button();
            cbVoices = new ComboBox();
            tbSpeed = new TrackBar();
            rtxtContent = new RichTextBox();
            btnReadClipboard = new Button();
            btnStop = new Button();
            btnExportWav = new Button();
            label2 = new Label();
            tbFontSize = new TrackBar();
            label3 = new Label();
            tbProgress = new TrackBar();
            btnSpeedReader = new Button();
            lblTime = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbProgress).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 17);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Speed";
            // 
            // btnReadBox
            // 
            btnReadBox.Location = new Point(12, 12);
            btnReadBox.Name = "btnReadBox";
            btnReadBox.Size = new Size(75, 23);
            btnReadBox.TabIndex = 1;
            btnReadBox.Text = "Read box";
            btnReadBox.UseVisualStyleBackColor = true;
            btnReadBox.Click += btnReadBox_Click;
            // 
            // cbVoices
            // 
            cbVoices.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVoices.FormattingEnabled = true;
            cbVoices.Location = new Point(12, 83);
            cbVoices.Name = "cbVoices";
            cbVoices.Size = new Size(242, 23);
            cbVoices.TabIndex = 2;
            // 
            // tbSpeed
            // 
            tbSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSpeed.AutoSize = false;
            tbSpeed.Location = new Point(381, 35);
            tbSpeed.Minimum = -10;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(426, 25);
            tbSpeed.TabIndex = 3;
            tbSpeed.Value = 2;
            tbSpeed.ValueChanged += tbSpeed_ValueChanged;
            // 
            // rtxtContent
            // 
            rtxtContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtContent.BackColor = Color.FromArgb(88, 88, 88);
            rtxtContent.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtContent.ForeColor = Color.FromArgb(239, 226, 203);
            rtxtContent.Location = new Point(12, 112);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(795, 240);
            rtxtContent.TabIndex = 4;
            rtxtContent.Text = "";
            // 
            // btnReadClipboard
            // 
            btnReadClipboard.Location = new Point(93, 12);
            btnReadClipboard.Name = "btnReadClipboard";
            btnReadClipboard.Size = new Size(97, 24);
            btnReadClipboard.TabIndex = 5;
            btnReadClipboard.Text = "Read clipboard";
            btnReadClipboard.UseVisualStyleBackColor = true;
            btnReadClipboard.Click += btnReadClipboard_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(196, 12);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnExportWav
            // 
            btnExportWav.Location = new Point(277, 12);
            btnExportWav.Name = "btnExportWav";
            btnExportWav.Size = new Size(75, 23);
            btnExportWav.TabIndex = 7;
            btnExportWav.Text = "Expot Wav";
            btnExportWav.UseVisualStyleBackColor = true;
            btnExportWav.Click += btnExportWav_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Text Size";
            // 
            // tbFontSize
            // 
            tbFontSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFontSize.AutoSize = false;
            tbFontSize.Location = new Point(381, 81);
            tbFontSize.Maximum = 40;
            tbFontSize.Minimum = 8;
            tbFontSize.Name = "tbFontSize";
            tbFontSize.Size = new Size(426, 25);
            tbFontSize.TabIndex = 9;
            tbFontSize.Value = 12;
            tbFontSize.ValueChanged += tbFontSize_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 10;
            label3.Text = "Voice";
            // 
            // tbProgress
            // 
            tbProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbProgress.AutoSize = false;
            tbProgress.Location = new Point(12, 358);
            tbProgress.Maximum = 100;
            tbProgress.Name = "tbProgress";
            tbProgress.Size = new Size(795, 25);
            tbProgress.TabIndex = 11;
            tbProgress.TickStyle = TickStyle.None;
            tbProgress.Value = 100;
            tbProgress.Scroll += tbProgress_Scroll;
            // 
            // btnSpeedReader
            // 
            btnSpeedReader.Location = new Point(260, 82);
            btnSpeedReader.Name = "btnSpeedReader";
            btnSpeedReader.Size = new Size(92, 23);
            btnSpeedReader.TabIndex = 12;
            btnSpeedReader.Text = "Speed Reader";
            btnSpeedReader.UseVisualStyleBackColor = true;
            btnSpeedReader.Click += btnSpeedReader_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(179, 63);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(10, 15);
            lblTime.TabIndex = 13;
            lblTime.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 63);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Time: ";
            // 
            // FormTextToSpeechReader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(819, 395);
            Controls.Add(label4);
            Controls.Add(lblTime);
            Controls.Add(btnSpeedReader);
            Controls.Add(tbProgress);
            Controls.Add(label3);
            Controls.Add(tbFontSize);
            Controls.Add(label2);
            Controls.Add(btnExportWav);
            Controls.Add(btnStop);
            Controls.Add(btnReadClipboard);
            Controls.Add(rtxtContent);
            Controls.Add(tbSpeed);
            Controls.Add(cbVoices);
            Controls.Add(btnReadBox);
            Controls.Add(label1);
            Name = "FormTextToSpeechReader";
            Text = "Text To Speech Reader";
            Load += TextToSpeechReaderForm_Load;
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbProgress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReadBox;
        private ComboBox cbVoices;
        private TrackBar tbSpeed;
        private RichTextBox rtxtContent;
        private Button btnReadClipboard;
        private Button btnStop;
        private Button btnExportWav;
        private Label label2;
        private TrackBar tbFontSize;
        private Label label3;
        private TrackBar tbProgress;
        private Button btnSpeedReader;
        private Label lblTime;
        private Label label4;
    }
}