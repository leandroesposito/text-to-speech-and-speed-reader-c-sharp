using System.Reflection.PortableExecutable;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace text_to_speech_reader
{
    public partial class FormTextToSpeechReader : Form
    {
        SpeechSynthesizer speecher = new SpeechSynthesizer();
        string text_to_read;
        bool speed_changed = false;
        int[] last_highlighted_word = { -1, 0 };

        public FormTextToSpeechReader()
        {
            InitializeComponent();
        }

        private void reader_SpeakCompleted(Object sender, SpeakCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                tbProgress.Value = 100;
                btnReadBox.Text = "Read box";
                rtxtContent.Select(rtxtContent.Text.Length, 0);
            }
            // to clear all highlights on next start
            last_highlighted_word[0] = -1;
        }

        private void reader_SpeakProgress(Object sender, SpeakProgressEventArgs e)
        {
            int text_length = rtxtContent.Text.Length,
                current_position = rtxtContent.Text.IndexOf(text_to_read) + e.CharacterPosition;

            highlight_word(current_position, e.CharacterCount);

            if (text_length != 0)
            {
                int progress_percent = (current_position * 100 / text_length);
                tbProgress.Value = progress_percent;
                lblTime.Text = Convert.ToString(e.AudioPosition);
            }
            // if speed changed then cancel speech and start again from current position with new speed
            if (speed_changed)
            {
                speecher.SpeakAsyncCancelAll();
                text_to_read = text_to_read.Substring(e.CharacterPosition);

                speecher.Rate = tbSpeed.Value;
                speecher.SpeakAsync(text_to_read);
                speed_changed = false;
            }
        }

        private void highlight_word(int index, int lenght)
        {
            if (last_highlighted_word[0] == -1)
            {
                // clar all highlighted words
                rtxtContent.SelectAll();
                rtxtContent.SelectionBackColor = rtxtContent.BackColor;
                rtxtContent.Select(0, 0);
            }
            else
            {
                // remove last highlight text
                // don't clear while text box becaus will generate scroll fast movements
                rtxtContent.Select(last_highlighted_word[0], last_highlighted_word[1]);
                rtxtContent.SelectionBackColor = rtxtContent.BackColor;
            }

            rtxtContent.Select(index, lenght);
            rtxtContent.SelectionBackColor = Color.Black;

            // focus to move scroll if new word is not visible
            if (!rtxtContent.Focused)
            {
                rtxtContent.Focus();
            }
            // move cursor to end of current word to remove blue selection highlight
            rtxtContent.Select(index, 0);

            last_highlighted_word[0] = index;
            last_highlighted_word[1] = lenght;
        }

        void trackBar_MouseWheel(object sender, MouseEventArgs e)
        {
            //disable default mouse wheel handler to prevent default nulber of value change and cahnge value by 1
            ((HandledMouseEventArgs)e).Handled = true;
            System.Windows.Forms.TrackBar senderTrackBar = (System.Windows.Forms.TrackBar)sender;

            if (e.Delta > 0)
            {
                if (senderTrackBar.Value < senderTrackBar.Maximum)
                {
                    senderTrackBar.Value++;
                }
            }
            else
            {
                if (senderTrackBar.Value > senderTrackBar.Minimum)
                {
                    senderTrackBar.Value--;
                }
            }
        }

        private void TextToSpeechReaderForm_Load(object sender, EventArgs e)
        {
            speecher.SpeakProgress += reader_SpeakProgress;
            speecher.SpeakCompleted += reader_SpeakCompleted;

            tbSpeed.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);
            tbFontSize.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);

            // load installed voices to comboBox
            foreach (var voice in speecher.GetInstalledVoices())
            {
                var info = voice.VoiceInfo;
                cbVoices.Items.Add(info.Name);
            }

            // select first voice
            cbVoices.SelectedIndex = 0;
        }

        private void btnReadBox_Click(object sender, EventArgs e)
        {
            if (speecher.State == SynthesizerState.Speaking)
            {
                speecher.SpeakAsyncCancelAll();
                btnReadBox.Text = "Resume";
            }
            else
            {
                if (rtxtContent.Text == "")
                {
                    rtxtContent.Text = Clipboard.GetText();
                    tbProgress.Value = 0;
                }
                if (rtxtContent.Text != "")
                {
                    btnReadBox.Text = "Pause";

                    int current_position = rtxtContent.SelectionStart;

                    if (current_position < rtxtContent.Text.Length)
                    {
                        rtxtContent.Select(current_position, 0);
                    }
                    else
                    {
                        rtxtContent.Select(0, 0);
                    }

                    // start speech reader from current cursor position

                    text_to_read = rtxtContent.Text.Substring(rtxtContent.SelectionStart);

                    try
                    {
                        speecher.SelectVoice(cbVoices.Text);
                    }
                    catch (Exception)
                    {
                        btnReadBox.Text = "Read box";
                        MessageBox.Show("Error selecting voice, try a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    speed_changed = false;
                    speecher.Rate = tbSpeed.Value;
                    speecher.SpeakAsync(text_to_read);
                }
            }
        }

        private void btnReadClipboard_Click(object sender, EventArgs e)
        {
            speecher.SpeakAsyncCancelAll();
            rtxtContent.Text = "";
            btnReadBox_Click(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            speecher.SpeakAsyncCancelAll();
            tbProgress.Value = 0;
            btnReadBox.Text = "Read box";
            rtxtContent.Select(0, 0);
        }

        private void btnExportWav_Click(object sender, EventArgs e)
        {
            if (rtxtContent.Text.Length > 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save text to wav file";
                saveFileDialog1.Filter = "WAV|*.wav";
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    SpeechSynthesizer wavReader = new SpeechSynthesizer();
                    wavReader.SpeakCompleted += reader_SpeakCompleted;
                    wavReader.SpeakProgress += reader_SpeakProgress;

                    if (speecher.State == SynthesizerState.Speaking)
                    {
                        speecher.SpeakAsyncCancelAll();
                        btnReadBox.Text = "Read box";
                    }

                    if (rtxtContent.Text != "")
                    {
                        text_to_read = rtxtContent.Text;

                        wavReader.SelectVoice(cbVoices.Text);
                        wavReader.SetOutputToWaveFile(saveFileDialog1.FileName);
                        wavReader.SpeakAsync(text_to_read);
                    }
                }
            }
        }

        private void tbProgress_Scroll(object sender, EventArgs e)
        {
            if (speecher.State == SynthesizerState.Ready && rtxtContent.Text != "")
            {
                int start_position = rtxtContent.Text.Length * tbProgress.Value / 100;
                int end_position = rtxtContent.Text.IndexOf(" ", start_position);
                int selection_length = end_position - start_position;

                // check if is last word or start = end
                if (selection_length <= 0)
                {
                    selection_length = 1;
                }

                highlight_word(start_position, selection_length);

                rtxtContent.ScrollToCaret();
            }
        }

        private void tbFontSize_ValueChanged(object sender, EventArgs e)
        {
            rtxtContent.Font = new Font(new FontFamily("Calibri"), tbFontSize.Value);
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            speed_changed = true;
        }

        private void btnSpeedReader_Click(object sender, EventArgs e)
        {
            FormSpeedReader frm = new FormSpeedReader();
            if (rtxtContent.Text != "")
            {
                frm.setText(rtxtContent.Text);
            }
            frm.Show();
        }
    }
}