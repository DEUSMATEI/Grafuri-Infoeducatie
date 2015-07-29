namespace Grafuri
{
    partial class Teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teste));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_graf = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.group_matad = new System.Windows.Forms.GroupBox();
            this.button_next = new System.Windows.Forms.Button();
            this.richTextBox_matad = new System.Windows.Forms.RichTextBox();
            this.button_new = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_gengraf = new System.Windows.Forms.Timer(this.components);
            this.groupBox_df = new System.Windows.Forms.GroupBox();
            this.label_df = new System.Windows.Forms.Label();
            this.button_cerinta_urm = new System.Windows.Forms.Button();
            this.richTextBox_raspuns_df = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.group_matad.SuspendLayout();
            this.groupBox_df.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiind dat acest graf rezolva urmatoarele cerinte";
            // 
            // panel_graf
            // 
            this.panel_graf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_graf.Location = new System.Drawing.Point(33, 38);
            this.panel_graf.Name = "panel_graf";
            this.panel_graf.Size = new System.Drawing.Size(371, 282);
            this.panel_graf.TabIndex = 1;
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Location = new System.Drawing.Point(32, 323);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(73, 62);
            this.button_exit.TabIndex = 2;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // group_matad
            // 
            this.group_matad.Controls.Add(this.button_next);
            this.group_matad.Controls.Add(this.richTextBox_matad);
            this.group_matad.Location = new System.Drawing.Point(461, 38);
            this.group_matad.Name = "group_matad";
            this.group_matad.Size = new System.Drawing.Size(398, 282);
            this.group_matad.TabIndex = 3;
            this.group_matad.TabStop = false;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(283, 167);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(95, 52);
            this.button_next.TabIndex = 1;
            this.button_next.Text = "Cerinta urmatoare";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox_matad
            // 
            this.richTextBox_matad.Location = new System.Drawing.Point(14, 65);
            this.richTextBox_matad.Name = "richTextBox_matad";
            this.richTextBox_matad.Size = new System.Drawing.Size(252, 171);
            this.richTextBox_matad.TabIndex = 0;
            this.richTextBox_matad.Text = "";
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(111, 326);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(114, 59);
            this.button_new.TabIndex = 2;
            this.button_new.Text = "graf nou";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(472, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introdu matricea de adiacenta corespunzatoare grafului:";
            // 
            // timer_gengraf
            // 
            this.timer_gengraf.Interval = 7;
            this.timer_gengraf.Tick += new System.EventHandler(this.timer_gengraf_Tick);
            // 
            // groupBox_df
            // 
            this.groupBox_df.Controls.Add(this.label4);
            this.groupBox_df.Controls.Add(this.label_df);
            this.groupBox_df.Controls.Add(this.button_cerinta_urm);
            this.groupBox_df.Controls.Add(this.richTextBox_raspuns_df);
            this.groupBox_df.Location = new System.Drawing.Point(455, 49);
            this.groupBox_df.Name = "groupBox_df";
            this.groupBox_df.Size = new System.Drawing.Size(398, 225);
            this.groupBox_df.TabIndex = 4;
            this.groupBox_df.TabStop = false;
            this.groupBox_df.Visible = false;
            // 
            // label_df
            // 
            this.label_df.AutoSize = true;
            this.label_df.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_df.ForeColor = System.Drawing.Color.Brown;
            this.label_df.Location = new System.Drawing.Point(11, 19);
            this.label_df.Name = "label_df";
            this.label_df.Size = new System.Drawing.Size(374, 13);
            this.label_df.TabIndex = 3;
            this.label_df.Text = "Ce se afiseaza la apelul functiei \"df(x)\" (parcurgere in adancime)";
            // 
            // button_cerinta_urm
            // 
            this.button_cerinta_urm.Location = new System.Drawing.Point(297, 156);
            this.button_cerinta_urm.Name = "button_cerinta_urm";
            this.button_cerinta_urm.Size = new System.Drawing.Size(95, 52);
            this.button_cerinta_urm.TabIndex = 1;
            this.button_cerinta_urm.Text = "Cerinta urmatoare";
            this.button_cerinta_urm.UseVisualStyleBackColor = true;
            this.button_cerinta_urm.Click += new System.EventHandler(this.button_cerinta_urm_Click);
            // 
            // richTextBox_raspuns_df
            // 
            this.richTextBox_raspuns_df.Location = new System.Drawing.Point(12, 54);
            this.richTextBox_raspuns_df.Name = "richTextBox_raspuns_df";
            this.richTextBox_raspuns_df.Size = new System.Drawing.Size(262, 38);
            this.richTextBox_raspuns_df.TabIndex = 0;
            this.richTextBox_raspuns_df.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 397);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.groupBox_df);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.group_matad);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.panel_graf);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teste";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.group_matad.ResumeLayout(false);
            this.groupBox_df.ResumeLayout(false);
            this.groupBox_df.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_graf;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.GroupBox group_matad;
        private System.Windows.Forms.RichTextBox richTextBox_matad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Timer timer_gengraf;
        private System.Windows.Forms.GroupBox groupBox_df;
        private System.Windows.Forms.Label label_df;
        private System.Windows.Forms.Button button_cerinta_urm;
        private System.Windows.Forms.RichTextBox richTextBox_raspuns_df;
        private System.Windows.Forms.Label label4;
    }
}