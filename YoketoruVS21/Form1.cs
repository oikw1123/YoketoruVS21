using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YoketoruVS21
{
   


    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 3;
        const int ItemMax = 3;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;

        Label[] chrs = new Label[ChrMax];

        const int PlayerIndex = 0;
        const int  EnemyIndex =PlayerIndex;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(´・ω・｀)";
        const string EnemyText = "◇";
        const string ItemText = "★";

        static Random rand = new Random();

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            clear,
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if (i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = tenplabel.Font;

                Controls.Add(chrs[i]);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.clear;
                }
            }

            if (nextState != State.None)
            {
                initProc();
            }

            if (currentState == State.Game)
            {
                UpdateGame();
            }
        }
        void initProc()
        {
            currentState = nextState;
            nextState = State.None;
            switch (currentState)
            {
                case State.Title:
                    Titlelabel.Visible = true;
                    startbutton.Visible = true;
                    copyrightlabel.Visible = true;
                    hilabel.Visible = true;
                    gameoverlabel.Visible = false;
                    Titlebutton.Visible = false;
                    gameclearlabel.Visible = false;
                    break;
                case State.Game:
                    Titlelabel.Visible = false;
                    startbutton.Visible = false;
                    copyrightlabel.Visible =false;
                    hilabel.Visible = false;

                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }


                    break;

                case State.Gameover:
                    //MessageBox.Show("GameOver");
                    gameoverlabel.Visible = true;
                    Titlebutton.Visible = true;
                    break;

                case State.clear:
                    //MessageBox.Show("Clear");
                    gameclearlabel.Visible = true;
                    Titlebutton.Visible = true;
                    break;

                    
            }
        }
        void UpdateGame()
        {
            Point mp = PointToClient (MousePosition);

            //TODO; mpがプレイヤーラベルの中心になるように設定
        }


        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void Titlelabel_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
