namespace Projekt
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Score_l = new System.Windows.Forms.Label();
            this.Time_l = new System.Windows.Forms.Label();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_NPC = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer_Gravity = new System.Windows.Forms.Timer(this.components);
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.timer_Jump = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.World = new System.Windows.Forms.Panel();
            this.label_Dead = new System.Windows.Forms.Label();
            this.pb_NPC2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.World.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).BeginInit();
            this.SuspendLayout();
            // 
            // Score_l
            // 
            this.Score_l.AutoSize = true;
            this.Score_l.Location = new System.Drawing.Point(13, 17);
            this.Score_l.Name = "Score_l";
            this.Score_l.Size = new System.Drawing.Size(35, 13);
            this.Score_l.TabIndex = 0;
            this.Score_l.Text = "Score";
            // 
            // Time_l
            // 
            this.Time_l.AutoSize = true;
            this.Time_l.Location = new System.Drawing.Point(13, 48);
            this.Time_l.Name = "Time_l";
            this.Time_l.Size = new System.Drawing.Size(30, 13);
            this.Time_l.TabIndex = 1;
            this.Time_l.Text = "Time";
            // 
            // pb_Player
            // 
            this.pb_Player.Location = new System.Drawing.Point(16, 233);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(44, 50);
            this.pb_Player.TabIndex = 3;
            this.pb_Player.TabStop = false;
            // 
            // pb_NPC
            // 
            this.pb_NPC.Location = new System.Drawing.Point(88, 233);
            this.pb_NPC.Name = "pb_NPC";
            this.pb_NPC.Size = new System.Drawing.Size(35, 50);
            this.pb_NPC.TabIndex = 4;
            this.pb_NPC.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(265, 328);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(386, 328);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // World
            // 
            this.World.Controls.Add(this.label_Dead);
            this.World.Controls.Add(this.pb_NPC2);
            this.World.Controls.Add(this.panel2);
            this.World.Controls.Add(this.pictureBox3);
            this.World.Controls.Add(this.pictureBox4);
            this.World.Controls.Add(this.pb_Player);
            this.World.Controls.Add(this.pb_NPC);
            this.World.Controls.Add(this.Score_l);
            this.World.Controls.Add(this.Time_l);
            this.World.Location = new System.Drawing.Point(-1, -2);
            this.World.Name = "World";
            this.World.Size = new System.Drawing.Size(598, 529);
            this.World.TabIndex = 10;
            // 
            // label_Dead
            // 
            this.label_Dead.AutoSize = true;
            this.label_Dead.Location = new System.Drawing.Point(256, 176);
            this.label_Dead.Name = "label_Dead";
            this.label_Dead.Size = new System.Drawing.Size(61, 13);
            this.label_Dead.TabIndex = 12;
            this.label_Dead.Text = "Game Over";
            // 
            // pb_NPC2
            // 
            this.pb_NPC2.Location = new System.Drawing.Point(154, 233);
            this.pb_NPC2.Name = "pb_NPC2";
            this.pb_NPC2.Size = new System.Drawing.Size(30, 50);
            this.pb_NPC2.TabIndex = 11;
            this.pb_NPC2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 50);
            this.panel2.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 558);
            this.Controls.Add(this.World);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.World.ResumeLayout(false);
            this.World.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Score_l;
        private System.Windows.Forms.Label Time_l;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.PictureBox pb_NPC;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer_Gravity;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.Timer timer_Jump;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel World;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_NPC2;
        private System.Windows.Forms.Label label_Dead;
    }
}