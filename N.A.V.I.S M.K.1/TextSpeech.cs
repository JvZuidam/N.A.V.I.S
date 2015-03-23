using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace N.A.V.I.S_M.K._1
{
    public partial class TextSpeech : Form
    {
        public TextSpeech()
        {
            InitializeComponent();
        }

        private void TextSpeech_Load(object sender, EventArgs e)
        {

        }

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                sSynth.Dispose();
                sSynth = new SpeechSynthesizer();
                sSynth.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Please fill in some text first!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sSynth != null)
            {
                if (sSynth.State == SynthesizerState.Speaking)
                {
                    sSynth.Pause();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sSynth != null)
            {
                if (sSynth.State == SynthesizerState.Paused)
                {
                    sSynth.Resume();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(sSynth != null)
            {
                sSynth.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
