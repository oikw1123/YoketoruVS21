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
using System.IO;

namespace YoketoruVS21
{
   


    public partial class Form1 : Form
    {
        const bool isDebug = true;


        const int SppedMax = 20;

        const int PlayerMax = 1;
        const int EnemyMax = 3;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;

        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        const int PlayerIndex = 0;
        const int  EnemyIndex =PlayerIndex;
        const int ItemIndex = EnemyIndex + EnemyMax;
        const int Starttime = 100;

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
        int Itemcount = 0;
        int time= 0;
        int hiscore = 100;

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
                chrs[i].Font = templabel.Font;

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
                        vx[i] = rand.Next(-SppedMax, SppedMax + 1);
                        vy[i] = rand.Next(-SppedMax, SppedMax + 1);
                        chrs[i].Visible = true;
                    }
                    Itemcount = ItemMax;
                    time = Starttime+1;


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
                    hilabel.Visible = true;
                    if(time>hiscore)
                    {
                        hiscore = time;
                        hilabel.Text = $"highscore; { hiscore}";

                        File.WriteAllText("hisc.txt", $"{hiscore}\n");

                    }

                    break;

                    
            }
        }
        void UpdateGame()
        {

            time--;
            TIMElabel.Text = $"Time{time}";
            if(time<=0)
            {
                nextState = State.Gameover;
            }

            Point mp = PointToClient (MousePosition);
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width/2;
            chrs[PlayerIndex].Left = mp.Y - chrs[PlayerIndex].Width/2;

            for(int i=EnemyIndex;i<ChrMax;i++)
            {
               
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if(chrs[i].Left<0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                if ((mp.X >= chrs[i].Left)
                    && (mp.X < chrs[i].Right)
                    && (mp.Y >= chrs[i].Top)
                    && (mp.Y < chrs[i].Bottom)
                    )
                {
                   // MessageBox.Show("あたった!");

                    if(i<ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        chrs[i].Visible = false;
                        Itemcount--;
                        leftlabel.Text="★:" + Itemcount;
                        if (Itemcount <= 0)
                        {
                            nextState = State.clear;
                        }

                        vx[i] = 0;
                        vy[i] = 0;
                        chrs[i].Left = 10000;
                    }
                }
            }
            

           

            //MessageBox.Show("重なった!");

            //TODO; mpがプレイヤーラベルの中心になるように設定
        }


        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void Titlelabel_Click(object sender, EventArgs e)
        {
            
        }

        private void Titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
