namespace text_to_speech_reader
{
    partial class FormSpeedReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbProgress = new TrackBar();
            tbFontSize = new TrackBar();
            label2 = new Label();
            btnStop = new Button();
            btnReadClipboard = new Button();
            rtxtContent = new RichTextBox();
            tbSpeed = new TrackBar();
            btnReadBox = new Button();
            label1 = new Label();
            lblCurrentWord = new Label();
            tmrSpeed = new System.Windows.Forms.Timer(components);
            lblWPM = new Label();
            ((System.ComponentModel.ISupportInitialize)tbProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            SuspendLayout();
            // 
            // tbProgress
            // 
            tbProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbProgress.AutoSize = false;
            tbProgress.Location = new Point(12, 291);
            tbProgress.Maximum = 100;
            tbProgress.Name = "tbProgress";
            tbProgress.Size = new Size(631, 25);
            tbProgress.TabIndex = 21;
            tbProgress.TickStyle = TickStyle.None;
            tbProgress.Value = 100;
            tbProgress.Scroll += tbProgress_Scroll;
            // 
            // tbFontSize
            // 
            tbFontSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFontSize.AutoSize = false;
            tbFontSize.Location = new Point(69, 170);
            tbFontSize.Maximum = 75;
            tbFontSize.Minimum = 10;
            tbFontSize.Name = "tbFontSize";
            tbFontSize.Size = new Size(574, 25);
            tbFontSize.TabIndex = 20;
            tbFontSize.Value = 48;
            tbFontSize.ValueChanged += tbFontSize_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Text Size";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(196, 12);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 17;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReadClipboard
            // 
            btnReadClipboard.Location = new Point(93, 12);
            btnReadClipboard.Name = "btnReadClipboard";
            btnReadClipboard.Size = new Size(97, 24);
            btnReadClipboard.TabIndex = 16;
            btnReadClipboard.Text = "Read clipboard";
            btnReadClipboard.UseVisualStyleBackColor = true;
            btnReadClipboard.Click += btnReadClipboard_Click;
            // 
            // rtxtContent
            // 
            rtxtContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtxtContent.BackColor = Color.FromArgb(88, 88, 88);
            rtxtContent.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtContent.ForeColor = Color.FromArgb(239, 226, 203);
            rtxtContent.Location = new Point(12, 42);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(631, 125);
            rtxtContent.TabIndex = 15;
            rtxtContent.Text = "";
            // 
            // tbSpeed
            // 
            tbSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSpeed.AutoSize = false;
            tbSpeed.Location = new Point(356, 17);
            tbSpeed.Maximum = 520;
            tbSpeed.Minimum = 100;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(217, 25);
            tbSpeed.SmallChange = 10;
            tbSpeed.TabIndex = 14;
            tbSpeed.Value = 100;
            tbSpeed.ValueChanged += tbSpeed_ValueChanged;
            // 
            // btnReadBox
            // 
            btnReadBox.Location = new Point(12, 12);
            btnReadBox.Name = "btnReadBox";
            btnReadBox.Size = new Size(75, 23);
            btnReadBox.TabIndex = 13;
            btnReadBox.Text = "Read box";
            btnReadBox.UseVisualStyleBackColor = true;
            btnReadBox.Click += btnReadBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 17);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Speed";
            // 
            // lblCurrentWord
            // 
            lblCurrentWord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentWord.BackColor = SystemColors.ControlDarkDark;
            lblCurrentWord.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentWord.Location = new Point(12, 198);
            lblCurrentWord.Name = "lblCurrentWord";
            lblCurrentWord.Size = new Size(631, 90);
            lblCurrentWord.TabIndex = 22;
            lblCurrentWord.Text = "Sample";
            lblCurrentWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrSpeed
            // 
            tmrSpeed.Interval = 600;
            tmrSpeed.Tick += tmrSpeed_Tick;
            // 
            // lblWPM
            // 
            lblWPM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWPM.AutoSize = true;
            lblWPM.Location = new Point(579, 17);
            lblWPM.Name = "lblWPM";
            lblWPM.Size = new Size(36, 15);
            lblWPM.TabIndex = 23;
            lblWPM.Text = "WPM";
            // 
            // FormSpeedReader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(655, 328);
            Controls.Add(lblWPM);
            Controls.Add(lblCurrentWord);
            Controls.Add(tbProgress);
            Controls.Add(tbFontSize);
            Controls.Add(label2);
            Controls.Add(btnStop);
            Controls.Add(btnReadClipboard);
            Controls.Add(rtxtContent);
            Controls.Add(tbSpeed);
            Controls.Add(btnReadBox);
            Controls.Add(label1);
            Name = "FormSpeedReader";
            Text = "Speed Reader";
            Load += FormSpeedReader_Load;
            ((System.ComponentModel.ISupportInitialize)tbProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbProgress;
        private TrackBar tbFontSize;
        private Label label2;
        private Button btnStop;
        private Button btnReadClipboard;
        private RichTextBox rtxtContent;
        private TrackBar tbSpeed;
        private Button btnReadBox;
        private Label label1;
        private Label lblCurrentWord;
        private System.Windows.Forms.Timer tmrSpeed;
        private Label lblWPM;
    }
}