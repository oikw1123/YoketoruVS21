using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoketoruVS21
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
                    startbutton.Visible = true;
                    copyrightlabel.Visible =false;
                    hilabel.Visible = false;

                    break;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
