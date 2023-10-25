using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motus
{
    public partial class Form1 : Form
    {
        Button[,] buttons;
        static int attempt;
        string secretWord;
        string[] lines;
        bool[] found;
        public Form1()
        {
            InitializeComponent();

            buttons = new Button[6, 6] { {btn1, btn2, btn3,btn4, btn5, btn6 }, {btn7, btn8, btn9, btn10, btn11, btn12},
            {btn13, btn14, btn15, btn16, btn17, btn18},{btn19, btn20, btn21, btn22, btn23, btn24},{btn25, btn26, btn27, btn28, btn29,btn30},
            {btn31, btn32,btn33, btn34,btn35,btn36}};
            attempt = 6;

            Task.Run(()=> ReadWord());
            found = new bool[6] { true, false, false, false,false,false };
        }

        public void InitializeTable()
        {
            buttons[0,0].Text = secretWord[0].ToString();
            for(int k=1; k < 6; k++)
            {
                buttons[0, k].Text = ".";
            }
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            if (attempt > 0)
            {
                if (txtProp.Text.Length > 6 || txtProp.Text.Length < 6)
                    MessageBox.Show("Falsche Laenge des Wortes");
                else
                {
                    CheckSecretWord(txtProp.Text);

                    LoadCells();
                }
            }
                
           
        }

        public void ReadWord()
        {
            if(lines != null)
            {
                if(lines.Length > 0)
                {
                    var r = new Random();
                    var randomLineNumber = r.Next(0, lines.Length - 1);
                    string line = lines[randomLineNumber];
                    secretWord = line.Trim().ToUpper();
                    lines.ToList().RemoveAt(randomLineNumber);
                }
                
            }
            else
            {
                lines = File.ReadAllLines("mots.txt");
                var r = new Random();
                var randomLineNumber = r.Next(0, lines.Length - 1);
                string line = lines[randomLineNumber];
                secretWord = line.Trim().ToUpper();
                lines.ToList().RemoveAt(randomLineNumber);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTable();
            
        }

        public void CheckSecretWord(string word)
        {
            
            if (string.Equals(secretWord, word, StringComparison.CurrentCultureIgnoreCase))
            {
                MessageBox.Show("Sie haben gewonnen !!!");
                Task.Run(() => Win());
                attempt = 6;
                ReadWord();
            }
               
            else
            {
                
                for (int i = 0; i < 6; i++)
                {
                    if(string.Equals(secretWord[i].ToString() ,txtProp.Text[i].ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        buttons[6 - attempt, i].BackColor = Color.Green;
                        found[i]= true;
                    }
                    else if(secretWord.Contains(txtProp.Text[i].ToString().ToUpper()))
                    {
                        buttons[6 - attempt, i].BackColor = Color.Orange;
                    }
                    else
                    {
                        buttons[6 - attempt, i].BackColor = Color.Red;
                    }
                    buttons[6 - attempt, i].Text = txtProp.Text[i].ToString().ToUpper();

                }
                Task.Run(() => NotWin());
               // new CustomMessageBox().ShowDialog();

            }

            attempt -= 1;
        }

        public void NotWin()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("mixkit-arcade-game-opener.wav");
            player.PlaySync();
        }

        public void Win()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("mixkit-game-level-completed.wav");
            player.PlaySync();
        }

        public void Lose()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("mixkit-player-losing-or-failing.wav");
            player.PlaySync();
        }

        private void btnJoker_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                if (found[i] == false)
                {
                    buttons[6 - attempt, i].Text = secretWord[i].ToString().ToUpper();
                    found[i] = true;
                    break;
                }
                                      
            }
            btnJoker.Enabled = false;
            btnJoker.BackColor = Color.LightSkyBlue;
        }

        public void LoadCells()
        {
            if (attempt > 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (found[i] == true)
                        buttons[6 - attempt, i].Text = secretWord[i].ToString().ToUpper();
                    else
                        buttons[6 - attempt, i].Text = ".";
                }
            }
            else
            {
                
                Task.Run(() => LoadSecretWord());
                Task.Run(() => Lose());
                MessageBox.Show("Sie haben verloren !!!");
            }
            
        }

        public void LoadSecretWord()
        {
            for (int i = 0; i < 6; i++)
            {
                buttons[5, i].Invoke((MethodInvoker)(() => {
                    buttons[5, i].Text = secretWord[i].ToString(); buttons[5, i].BackColor = Color.Green; } )); 

            }
           
        }

        private void txtProp_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnProp.PerformClick();
            }
            if(e.KeyCode == Keys.S)
            {
                Task.Run(() => NotWin());
            }
            if (e.KeyCode == Keys.L)
            {
                Task.Run(() => Lose());
            }*/
        }

        private void Reset()
        {
            for(int i=0; i<6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].BackColor = Color.Transparent;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Task.Run(() => ReadWord());
            found = new bool[6] { true, false, false, false, false, false };
            attempt = 6;
            Reset();
            InitializeTable();
        }
    }
}
