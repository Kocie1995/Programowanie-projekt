using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region var
        PictureBox[] WorldObjects = new PictureBox[10];
        PictureBox[] NPC = new PictureBox[2];
        Random rand = new Random();
        Boolean Player_Jump = false;
        Boolean Player_Left = false;
        Boolean Player_Right = false;
        Boolean LastDirRight = true;
        Boolean GameOn = false;
        Boolean GodMode = false;
        Boolean Debug = false;
        string DebugLog = "START: " + DateTime.Now + "\n";
        int Gravity = 20;
        int PowerMov = 0;
        int Speed_Movement = 3;
        int Speed_Jump = 3;
        int Speed_Fall = 3;
        int Score = 0;
        #endregion

        #region Sterowanie
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    Score += 120;
                    break;
                case Keys.X:
                    pb_Player.Top += 3;
                    break;
                case Keys.P:
                    if (GameOn)
                    {
                        GameOn = false;
                        label_Dead.Text = "Pauza, nacisnij P żeby kontynuuować";
                        label_Dead.Visible = true;
                    }
                    else
                    {
                        GameOn = true;
                        label_Dead.Text = "Game Over";
                        label_Dead.Visible = false;
                    }
                    break;
                case Keys.Left:
                    if (GameOn)
                    {
                        LastDirRight = false;
                        Player_Left = true;
                    }
                    break;
                case Keys.Right:
                    if (GameOn)
                    {
                        LastDirRight = true;
                        Player_Right = true;
                    }
                    break;
                case Keys.Space:
                    if (label_Dead.Visible && !label_Dead.Text.Contains("Pauza"))
                    {
                        Reset();
                    }
                    else
                    {
                        if (!Player_Jump && !InAirNoCollision(pb_Player))
                        {

                            pb_Player.Top -= Speed_Jump;
                            PowerMov = Gravity;
                            Player_Jump = true;
                        }
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOn)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        LastDirRight = false;
                        Player_Left = false;
                        break;
                    case Keys.Right:
                        LastDirRight = true;
                        Player_Right = false;
                        break;
                }
            }
        }
        #endregion

        #region Funkc Bool
        public Boolean InAirNoCollision(PictureBox tar)
        {   
            if (!OutsideWorldFrame(tar))
            {
                foreach (PictureBox Obj in WorldObjects)
                {   
                    if (!tar.Bounds.IntersectsWith(Obj.Bounds))
                    {
                        if (tar.Location.Y < World.Width)
                        {   
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public Boolean OutsideWorldFrame(PictureBox tar)
        {
            if (tar.Location.X < 0)
                return true;
            if (tar.Location.X > World.Width)
                return true;
            if (tar.Location.Y + tar.Height > World.Height - 3)
                return true;
            foreach (PictureBox Obj in WorldObjects)
            {
                if (Obj != null)
                {
                    if (tar.Bounds.IntersectsWith(Obj.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();    //tworzenie pixela nad graczem żeby sprawdzić czy występuje kolizja
                    temp1.Bounds = ob.Bounds;

                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;

                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;

                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = ob.Bounds;

                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        }
        #endregion

        #region Void
        public void Dead()
        {
            if (!GodMode)
            {
                pb_Player.Visible = false;
                label_Dead.Visible = true;
                GameOn = false;
            }

        }


        public void Reset()
        {
            label_Dead.Visible = false;
            int x = 0;

            pb_Player.Visible = true;
            pb_Player.Location = new System.Drawing.Point(167, World.Size.Height - 10 - pb_Player.Height);
            pb_NPC.Location = new System.Drawing.Point(1, World.Size.Height - 1 - pb_NPC.Height);
            pb_NPC2.Location = new System.Drawing.Point(World.Width - 10, World.Size.Height - 1 - pb_NPC2.Height);
            Score = 0;

            GameOn = true;
        }



        #endregion

        #region Timer
        private void timer_Jump_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (Player_Right && pb_Player.Right <= World.Width - 3 && !Collision_Left(pb_Player))
                {
                    pb_Player.Left += Speed_Movement;
                }
                if (Player_Left && pb_Player.Location.X >= 3 && !Collision_Right(pb_Player))
                {
                    pb_Player.Left -= Speed_Movement;
                }
            }
            else
            {
                Player_Right = false;
                Player_Left = false;
            }

            if (PowerMov > 0)
            {
                if (Collision_Bottom(pb_Player))
                {
                    PowerMov = 0;
                }
                else
                {
                    PowerMov--;
                    pb_Player.Top -= Speed_Jump;
                }
            }
            else
            {
                Player_Jump = false;
            }
        }

        private void timer_Gravity_Tick(object sender, EventArgs e)
        {
            if (!Player_Jump && pb_Player.Location.Y +
        pb_Player.Height < World.Height - 2 && !Collision_Top(pb_Player))

            {

                pb_Player.Top += Speed_Fall;

            }



            if (!Player_Jump && pb_Player.Location.Y + pb_Player.Height > World.Height - 1)
            {
                pb_Player.Top--;
            }
        }

        private void timer_Sec_Tick(object sender, EventArgs e)
        {
            Score_l.Text = "Score: " + Score;
            if (!label_Dead.Visible)
            {
                Score++;
            }
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    


