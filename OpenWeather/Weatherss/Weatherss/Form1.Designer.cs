﻿
namespace Weatherss
{
    partial class Form1
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
            this.lbl_textCity = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_DoCe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Con = new System.Windows.Forms.Label();
            this.lbl_Des = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_Des2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_textCity
            // 
            this.lbl_textCity.AutoSize = true;
            this.lbl_textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_textCity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_textCity.Location = new System.Drawing.Point(12, 9);
            this.lbl_textCity.Name = "lbl_textCity";
            this.lbl_textCity.Size = new System.Drawing.Size(334, 67);
            this.lbl_textCity.TabIndex = 0;
            this.lbl_textCity.Text = "Thành Phố ";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Country.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Country.Location = new System.Drawing.Point(12, 95);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(279, 67);
            this.lbl_Country.TabIndex = 1;
            this.lbl_Country.Text = "Quốc Gia";
            // 
            // lbl_DoCe
            // 
            this.lbl_DoCe.AutoSize = true;
            this.lbl_DoCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_DoCe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_DoCe.Location = new System.Drawing.Point(12, 186);
            this.lbl_DoCe.Name = "lbl_DoCe";
            this.lbl_DoCe.Size = new System.Drawing.Size(93, 87);
            this.lbl_DoCe.TabIndex = 2;
            this.lbl_DoCe.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(557, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forcast";
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Day.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Day.Location = new System.Drawing.Point(473, 111);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(111, 46);
            this.lbl_Day.TabIndex = 4;
            this.lbl_Day.Text = "Days";
            // 
            // lbl_Con
            // 
            this.lbl_Con.AutoSize = true;
            this.lbl_Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Con.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Con.Location = new System.Drawing.Point(473, 157);
            this.lbl_Con.Name = "lbl_Con";
            this.lbl_Con.Size = new System.Drawing.Size(210, 46);
            this.lbl_Con.TabIndex = 5;
            this.lbl_Con.Text = "Conditions";
            // 
            // lbl_Des
            // 
            this.lbl_Des.AutoSize = true;
            this.lbl_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Des.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Des.Location = new System.Drawing.Point(473, 203);
            this.lbl_Des.Name = "lbl_Des";
            this.lbl_Des.Size = new System.Drawing.Size(221, 46);
            this.lbl_Des.TabIndex = 6;
            this.lbl_Des.Text = "Description";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_speed.Location = new System.Drawing.Point(729, 111);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(167, 46);
            this.lbl_speed.TabIndex = 7;
            this.lbl_speed.Text = "12 Km/h";
            // 
            // lbl_Des2
            // 
            this.lbl_Des2.AutoSize = true;
            this.lbl_Des2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Des2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_Des2.Location = new System.Drawing.Point(729, 203);
            this.lbl_Des2.Name = "lbl_Des2";
            this.lbl_Des2.Size = new System.Drawing.Size(64, 46);
            this.lbl_Des2.TabIndex = 8;
            this.lbl_Des2.Text = "26";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.lbl_Des2);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.lbl_Des);
            this.Controls.Add(this.lbl_Con);
            this.Controls.Add(this.lbl_Day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DoCe);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_textCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_textCity;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_DoCe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Con;
        private System.Windows.Forms.Label lbl_Des;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label lbl_Des2;
    }
}

