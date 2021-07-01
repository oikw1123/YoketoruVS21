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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O)<0)
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

                    break;

                case State.Gameover:
                    //MessageBox.Show("GameOver");
                    gameoverlabel.Visible = true;
                    Titlebutton.Visible = true;
                    break;

                case State.clear:
                    //MessageBox.Show("Clear");
                    gameclearlabel.Visible = false;
                    Titlebutton.Visible = false;
                    break;

                    
            }
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
