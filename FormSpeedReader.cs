using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_to_speech_reader
{
    public partial class FormSpeedReader : Form
    {
        // position index; length
        int[] last_highlighted_word = { -1, 0 };

        public FormSpeedReader()
        {
            InitializeComponent();
        }

        public void setText(string text)
        {
            rtxtContent.Text = text;
        }

        private void highlight_word(int index, int lenght)
        {
            if (last_highlighted_word[0] == -1)
            {
                // remove all highlights
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
            rtxtContent.Select(index + lenght, 0);

            last_highlighted_word[0] = index;
            last_highlighted_word[1] = lenght;
        }

        private void btnReadBox_Click(object sender, EventArgs e)
        {
            // if speecher is paused
            if (btnReadBox.Text == "Pause")
            {
                tmrSpeed.Enabled = false;
                btnReadBox.Text = "Resume";
            }
            // to start or resume speecher
            else
            {
                if (rtxtContent.Text == "")
                {
                    rtxtContent.Text = Clipboard.GetText();
                    tbProgress.Value = 0;
                }
                if (rtxtContent.Text != "")
                {
                    // change last_highlighted_word to clear all highlights before start
                    if (btnReadBox.Text == "Read box")
                    {
                        last_highlighted_word[0] = -1;
                    }

                    btnReadBox.Text = "Pause";
                    if (rtxtContent.SelectionStart == rtxtContent.Text.Length)
                    {
                        rtxtContent.SelectionStart = 0;
                    }
                    tmrSpeed.Enabled = true;
                }
            }
        }

        private void btnReadClipboard_Click(object sender, EventArgs e)
        {
            tmrSpeed.Enabled = false;
            rtxtContent.Text = "";
            btnReadBox_Click(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tbProgress.Value = 0;
            btnReadBox.Text = "Read box";
            tmrSpeed.Enabled = false;
            rtxtContent.SelectionStart = 0;
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            tmrSpeed.Interval = 60 * 1000 / tbSpeed.Value;
            lblWPM.Text = tbSpeed.Value + " WPM";
        }

        private void tbFontSize_ValueChanged(object sender, EventArgs e)
        {
            lblCurrentWord.Font = new Font(new FontFamily("Arial"), tbFontSize.Value);
        }

        private void FormSpeedReader_Load(object sender, EventArgs e)
        {
            lblCurrentWord.Text = "";
            lblWPM.Text = tbSpeed.Value + " WPM";
        }

        private void tmrSpeed_Tick(object sender, EventArgs e)
        {
            int current_position = rtxtContent.SelectionStart;
            int next_space_index = rtxtContent.Text.IndexOf(" ", current_position + 1);
            int word_length;
            int text_length = rtxtContent.Text.Length;

            if (text_length != 0)
            {
                int value = (current_position * 100 / text_length);
                tbProgress.Value = value;
            }

            // if next_space_index is < 0 means current word is the last word
            if (next_space_index < 0)
            {
                word_length = text_length - current_position;
            }
            else
            {
                word_length = next_space_index - current_position;
            }

            lblCurrentWord.Text = rtxtContent.Text.Substring(current_position, word_length);

            highlight_word(current_position, word_length);

            if (current_position + word_length + 1 >= text_length)
            {
                tmrSpeed.Enabled = false;
                tbProgress.Value = 100;
                btnReadBox.Text = "Read box";
                rtxtContent.SelectionStart = 0;
            }
            else
            {
                // + 1 is to prevent space highlight before next word
                rtxtContent.SelectionStart = current_position + word_length + 1;
            }
        }

        private void tbProgress_Scroll(object sender, EventArgs e)
        {
            if (tmrSpeed.Enabled == false)
            {
                int start_position = rtxtContent.Text.Length * tbProgress.Value / 100;
                int end_position = rtxtContent.Text.IndexOf(" ", start_position);
                int selection_length = end_position - start_position;

                // check if is last word or start = end
                if (selection_length <= 0)
                {
                    selection_length = 1;
                }

                lblCurrentWord.Text = rtxtContent.Text.Substring(start_position, selection_length);
                highlight_word(start_position, selection_length);
            }
        }
    }
}
