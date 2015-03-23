using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace N.A.V.I.S_M.K._1
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        Choices _choices;
        List<string> _commands;

        public Form1()
        {
            InitializeComponent();
            using (var w = new WebClient())
            {
                _commands = new List<string>();
                JObject stream = JObject.Parse(File.ReadAllText("C:/Users/Jim/Documents/Visual Studio 2013/Projects/N.A.V.I.S M.K.1/N.A.V.I.S M.K.1/Resources/dictionary.json"));
                
                foreach (var a in stream)
                {
                    //Console.WriteLine(a.Key);
                    _commands.Add(a.Key);
                }
            }
        }

        private void BtnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            BtnDisable.Enabled = true;
            BtnEnable.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _commands.AddRange(new string[] {});
            _choices = new Choices();
            _choices.Add(_commands.ToArray<string>());
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(_choices);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {   
                switch (e.Result.Text)
                {
                    case "say hello":
                        MessageBox.Show("hello Jim"); 
                        break;
                    case "print my name":
                        richTextBox1.AppendText("\n Jim"); 
                        break;
                    case "open chrome":
                        Process.Start("Chrome"); 
                        break;
                    case "open games":
                        Process.Start(@"D:\Games"); 
                        break;
                    case "clock":
                        var myForm = new clock(); myForm.Show(); 
                        break;
                    case "edit commands":
                        Process.Start("sublime_text.exe", "C:/Users/Jim/Documents/Visual Studio 2013/Projects/N.A.V.I.S M.K.1/N.A.V.I.S M.K.1/Resources/dictionary.json");
                        break;
                    case "open minecraft":
                        var path = Environment.ExpandEnvironmentVariables(@"D:\Games\Minecraft.exe"); Process.Start(path);
                        break;
                    case "go to youtube":
                        System.Diagnostics.Process.Start("http://youtube.com"); 
                        break;
                    case "open explorer":
                        string myDocspath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string windir = Environment.GetEnvironmentVariable("WINDIR");
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = windir + @"\explorer.exe";
                            prc.StartInfo.Arguments = myDocspath;
                            prc.Start();
                        break;

                    case "commands":
                        richTextBox1.Text += "\n";
                        foreach (string s in _commands )
                        {
                            richTextBox1.Text += s + "\n";
                        }
                        break;
                    case "help": MessageBox.Show("This program (called navis) is a schoolproject that i'm currently making. This program is made for speec Recognition and speech synthesize say commands to get the commands list"); break;
                    default: richTextBox1.Text += ("\n Unknown command: " + e.Result.Text); break;
                }
        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            BtnDisable.Enabled = false;
            BtnEnable.Enabled = true;
        }

        private void ExBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TexBtn_Click(object sender, EventArgs e)
        {
            var myForm = new TextSpeech(); myForm.Show();
        }
    }
}
