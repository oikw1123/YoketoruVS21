
namespace YoketoruVS21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.TIMElabel = new System.Windows.Forms.Label();
            this.leftlabel = new System.Windows.Forms.Label();
            this.hilabel = new System.Windows.Forms.Label();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.gameclearlabel = new System.Windows.Forms.Label();
            this.Titlebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.templabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(212, 117);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(370, 86);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "よけとる2021";
            this.Titlelabel.Click += new System.EventHandler(this.Titlelabel_Click);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startbutton.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startbutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.startbutton.Location = new System.Drawing.Point(263, 256);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(305, 58);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "スタート";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightlabel.Location = new System.Drawing.Point(263, 367);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(255, 30);
            this.copyrightlabel.TabIndex = 2;
            this.copyrightlabel.Text = "copyright© C#　及川颯大";
            // 
            // TIMElabel
            // 
            this.TIMElabel.AutoSize = true;
            this.TIMElabel.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TIMElabel.Location = new System.Drawing.Point(1, -2);
            this.TIMElabel.Name = "TIMElabel";
            this.TIMElabel.Size = new System.Drawing.Size(163, 50);
            this.TIMElabel.TabIndex = 3;
            this.TIMElabel.Text = "TIME100";
            // 
            // leftlabel
            // 
            this.leftlabel.AutoSize = true;
            this.leftlabel.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftlabel.Location = new System.Drawing.Point(652, 9);
            this.leftlabel.Name = "leftlabel";
            this.leftlabel.Size = new System.Drawing.Size(136, 50);
            this.leftlabel.TabIndex = 4;
            this.leftlabel.Text = "★：10";
            // 
            // hilabel
            // 
            this.hilabel.AutoSize = true;
            this.hilabel.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hilabel.Location = new System.Drawing.Point(298, 203);
            this.hilabel.Name = "hilabel";
            this.hilabel.Size = new System.Drawing.Size(220, 50);
            this.hilabel.TabIndex = 5;
            this.hilabel.Text = "ハイスコア100";
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameoverlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameoverlabel.Location = new System.Drawing.Point(273, 75);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(320, 86);
            this.gameoverlabel.TabIndex = 6;
            this.gameoverlabel.Text = "gameover";
            // 
            // gameclearlabel
            // 
            this.gameclearlabel.AutoSize = true;
            this.gameclearlabel.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameclearlabel.ForeColor = System.Drawing.Color.Gold;
            this.gameclearlabel.Location = new System.Drawing.Point(263, 9);
            this.gameclearlabel.Name = "gameclearlabel";
            this.gameclearlabel.Size = new System.Drawing.Size(330, 86);
            this.gameclearlabel.TabIndex = 7;
            this.gameclearlabel.Text = "gameclear";
            // 
            // Titlebutton
            // 
            this.Titlebutton.BackColor = System.Drawing.Color.Blue;
            this.Titlebutton.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titlebutton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Titlebutton.Location = new System.Drawing.Point(241, 306);
            this.Titlebutton.Name = "Titlebutton";
            this.Titlebutton.Size = new System.Drawing.Size(305, 58);
            this.Titlebutton.TabIndex = 8;
            this.Titlebutton.Text = "タイトルへ";
            this.Titlebutton.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // templabel
            // 
            this.templabel.AutoSize = true;
            this.templabel.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.templabel.Location = new System.Drawing.Point(76, 203);
            this.templabel.Name = "templabel";
            this.templabel.Size = new System.Drawing.Size(44, 37);
            this.templabel.TabIndex = 9;
            this.templabel.Text = "★";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.templabel);
            this.Controls.Add(this.Titlebutton);
            this.Controls.Add(this.gameclearlabel);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.hilabel);
            this.Controls.Add(this.leftlabel);
            this.Controls.Add(this.TIMElabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.Titlelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Label TIMElabel;
        private System.Windows.Forms.Label leftlabel;
        private System.Windows.Forms.Label hilabel;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label gameclearlabel;
        private System.Windows.Forms.Button Titlebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label templabel;
    }
}

