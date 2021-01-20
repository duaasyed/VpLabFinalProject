using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Collections;

namespace SpeechRecognizer
{
    public partial class SpeechRecognizer : Form
    {
        private SpeechRecognitionEngine sre;
        private SpeechSynthesizer ss;
        private Commands command;
        private GrammarBuilder gb;
        private Choices choices;
        private Dictionary<string, string> cmd;
        private string path;
        private bool cease = true;

        public SpeechRecognizer()
        {
            InitializeComponent();
            this.path = @"E:\Downloads\nd\Command.txt";
            this.sre = new SpeechRecognitionEngine();
            this.ss = new SpeechSynthesizer();
            this.command = new Commands();
            this.gb = new GrammarBuilder();
            this.choices = new Choices();
            this.cmd = new Dictionary<string, string>();
        }

        internal Commands include
        {
            get => default;
            set
            {
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {

            btnEnable.Focus();
            if (cease)
            {
                sre.RecognizeAsync(RecognizeMode.Single);
            }

            cease = false;
            //btnDisable.Enabled=true;
            //btnDisable.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Process.Start("www.youtube.com");
            //Process.Start("opera.exe");

            this.cmd = this.command.ReadFile(path);
            this.choices.Add(this.cmd.Keys.ToArray());
            this.gb.Append(this.choices);
            Grammar gr = new Grammar(gb);
            sre.LoadGrammarAsync(gr);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += sre_SpeechRecognized;
        }


        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
            txtBoxOutput.Text += "\n" + e.Result.Text;
            if (this.cmd.ContainsKey(e.Result.Text))
            {
                var temp = e.Result.Text.Split(' ');
                //txtBoxOutput.Text += "\n" + temp.Length;
                if (temp[0].Equals("open"))
                {
                    ss.SpeakAsync("Opening" + temp[1]);
                    Process.Start(this.cmd[e.Result.Text]);
                    sre.RecognizeAsyncStop();
                    cease = true;

                }
                if (temp[0].Equals("hello") || temp[0].Equals("hey"))
                {
                    ss.SpeakAsync(this.cmd[e.Result.Text]);
                    //tabControl1.SelectTab(this.tabPageCommand.Name);
                    sre.RecognizeAsyncStop();
                    cease = true;

                }
                if (temp[1].Equals("name"))
                {
                    ss.SpeakAsync(this.cmd[e.Result.Text]);
                    sre.RecognizeAsyncStop();
                    cease = true;
                }
                if (temp[0].Equals("Add"))
                {
                    ss.SpeakAsync("Adding Commands");
                    tabControl1.SelectTab(this.tabPageCommand.Name);
                    sre.RecognizeAsyncStop();
                    cease = true;
                }
            }
        }

        private void btnAddCmd_Click(object sender, EventArgs e)
        {
            if (this.textBoxCmd.Text.Equals("") || this.textBoxCmdName.Text.Equals(""))
            {
                MessageBox.Show("Please provide command", "Input command error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var tempArray = this.textBoxCmdName.Text.Split(' ');
                if (tempArray.Length != 2)
                {
                    MessageBox.Show("Hint Command must be two words", "Input command error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string temp = this.textBoxCmdName.Text + ";" + this.textBoxCmd.Text;
                    this.command.WriteFile(temp, path);
                    MessageBox.Show("Command Added");
                    //sre.Dispose();
                    this.cmd = this.command.ReadFile(this.path);
                    this.choices = new Choices(cmd.Keys.ToArray());
                    this.gb = new GrammarBuilder(this.choices);
                    Grammar gr = new Grammar(this.gb);
                    this.sre.LoadGrammarAsync(gr);
                }

            }
        }
    }
}