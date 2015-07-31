namespace Grafuri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_orientat = new System.Windows.Forms.RadioButton();
            this.radio_neorientat = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafuriNeorientateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafuriOrientateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arboriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_desenaregraf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_aranjare = new System.Windows.Forms.RadioButton();
            this.radio_Muchie = new System.Windows.Forms.RadioButton();
            this.radio_nod = new System.Windows.Forms.RadioButton();
            this.button_final = new System.Windows.Forms.Button();
            this.button_stergegraf = new System.Windows.Forms.Button();
            this.rtb_rezultat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_algoritm = new System.Windows.Forms.RichTextBox();
            this.label_avertizare = new System.Windows.Forms.Label();
            this.timer_alerta_suprapunere_elemente = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_nodstart = new System.Windows.Forms.Label();
            this.button_rulare_algoritm = new System.Windows.Forms.Button();
            this.textBox_nod_start = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_resetare_culori_graf = new System.Windows.Forms.Button();
            this.timer_pauza_animatie = new System.Windows.Forms.Timer(this.components);
            this.groupBox_startup = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_edu = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_startup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.Transparent;
            this.b_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_exit.BackgroundImage")));
            this.b_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_exit.Location = new System.Drawing.Point(962, 27);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(40, 40);
            this.b_exit.TabIndex = 0;
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Crimson;
            this.groupBox1.Controls.Add(this.radio_orientat);
            this.groupBox1.Controls.Add(this.radio_neorientat);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(42, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipul:";
            // 
            // radio_orientat
            // 
            this.radio_orientat.AutoSize = true;
            this.radio_orientat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_orientat.Location = new System.Drawing.Point(6, 27);
            this.radio_orientat.Name = "radio_orientat";
            this.radio_orientat.Size = new System.Drawing.Size(80, 20);
            this.radio_orientat.TabIndex = 6;
            this.radio_orientat.TabStop = true;
            this.radio_orientat.Text = "Orientat";
            this.radio_orientat.UseVisualStyleBackColor = true;
            this.radio_orientat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radio_orientat_MouseClick);
            // 
            // radio_neorientat
            // 
            this.radio_neorientat.AutoSize = true;
            this.radio_neorientat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_neorientat.Location = new System.Drawing.Point(6, 62);
            this.radio_neorientat.Name = "radio_neorientat";
            this.radio_neorientat.Size = new System.Drawing.Size(98, 20);
            this.radio_neorientat.TabIndex = 5;
            this.radio_neorientat.TabStop = true;
            this.radio_neorientat.Text = "Neorientat";
            this.radio_neorientat.UseVisualStyleBackColor = true;
            this.radio_neorientat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radio_orientat_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ajutorToolStripMenuItem,
            this.teorieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // teorieToolStripMenuItem
            // 
            this.teorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafuriNeorientateToolStripMenuItem,
            this.grafuriOrientateToolStripMenuItem,
            this.arboriToolStripMenuItem});
            this.teorieToolStripMenuItem.Name = "teorieToolStripMenuItem";
            this.teorieToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.teorieToolStripMenuItem.Text = "Teorie";
            // 
            // grafuriNeorientateToolStripMenuItem
            // 
            this.grafuriNeorientateToolStripMenuItem.Name = "grafuriNeorientateToolStripMenuItem";
            this.grafuriNeorientateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.grafuriNeorientateToolStripMenuItem.Text = "Grafuri Neorientate";
            this.grafuriNeorientateToolStripMenuItem.Click += new System.EventHandler(this.grafuriNeorientateToolStripMenuItem_Click);
            // 
            // grafuriOrientateToolStripMenuItem
            // 
            this.grafuriOrientateToolStripMenuItem.Name = "grafuriOrientateToolStripMenuItem";
            this.grafuriOrientateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.grafuriOrientateToolStripMenuItem.Text = "Grafuri Orientate";
            // 
            // arboriToolStripMenuItem
            // 
            this.arboriToolStripMenuItem.Name = "arboriToolStripMenuItem";
            this.arboriToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arboriToolStripMenuItem.Text = "Arbori";
            // 
            // panel_desenaregraf
            // 
            this.panel_desenaregraf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_desenaregraf.Location = new System.Drawing.Point(42, 120);
            this.panel_desenaregraf.Name = "panel_desenaregraf";
            this.panel_desenaregraf.Size = new System.Drawing.Size(410, 299);
            this.panel_desenaregraf.TabIndex = 5;
            this.panel_desenaregraf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_desenaregraf_MouseClick);
            this.panel_desenaregraf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_desenaregraf_MouseDown);
            this.panel_desenaregraf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_desenaregraf_MouseMove);
            this.panel_desenaregraf.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_desenaregraf_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desenează graful aici:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Controale graf:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Crimson;
            this.groupBox2.Controls.Add(this.radio_aranjare);
            this.groupBox2.Controls.Add(this.radio_Muchie);
            this.groupBox2.Controls.Add(this.radio_nod);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(171, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 104);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desenez:";
            this.groupBox2.Visible = false;
            // 
            // radio_aranjare
            // 
            this.radio_aranjare.AutoSize = true;
            this.radio_aranjare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_aranjare.Location = new System.Drawing.Point(14, 45);
            this.radio_aranjare.Name = "radio_aranjare";
            this.radio_aranjare.Size = new System.Drawing.Size(89, 19);
            this.radio_aranjare.TabIndex = 9;
            this.radio_aranjare.TabStop = true;
            this.radio_aranjare.Text = "Aranjează";
            this.radio_aranjare.UseVisualStyleBackColor = true;
            // 
            // radio_Muchie
            // 
            this.radio_Muchie.AutoSize = true;
            this.radio_Muchie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_Muchie.Location = new System.Drawing.Point(14, 69);
            this.radio_Muchie.Name = "radio_Muchie";
            this.radio_Muchie.Size = new System.Drawing.Size(72, 19);
            this.radio_Muchie.TabIndex = 8;
            this.radio_Muchie.TabStop = true;
            this.radio_Muchie.Text = "Muchie";
            this.radio_Muchie.UseVisualStyleBackColor = true;
            this.radio_Muchie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radio_Muchie_MouseClick);
            // 
            // radio_nod
            // 
            this.radio_nod.AutoSize = true;
            this.radio_nod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_nod.Location = new System.Drawing.Point(14, 22);
            this.radio_nod.Name = "radio_nod";
            this.radio_nod.Size = new System.Drawing.Size(51, 19);
            this.radio_nod.TabIndex = 7;
            this.radio_nod.TabStop = true;
            this.radio_nod.Text = "Nod";
            this.radio_nod.UseVisualStyleBackColor = true;
            // 
            // button_final
            // 
            this.button_final.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_final.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_final.Location = new System.Drawing.Point(301, 508);
            this.button_final.Name = "button_final";
            this.button_final.Size = new System.Drawing.Size(134, 48);
            this.button_final.TabIndex = 9;
            this.button_final.Text = "Am terminat!";
            this.button_final.UseVisualStyleBackColor = false;
            this.button_final.Visible = false;
            this.button_final.Click += new System.EventHandler(this.button_final_Click);
            // 
            // button_stergegraf
            // 
            this.button_stergegraf.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_stergegraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stergegraf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_stergegraf.Location = new System.Drawing.Point(301, 459);
            this.button_stergegraf.Name = "button_stergegraf";
            this.button_stergegraf.Size = new System.Drawing.Size(134, 48);
            this.button_stergegraf.TabIndex = 10;
            this.button_stergegraf.Text = "Șterge Graf";
            this.button_stergegraf.UseVisualStyleBackColor = false;
            this.button_stergegraf.Visible = false;
            this.button_stergegraf.Click += new System.EventHandler(this.button_stergegraf_Click);
            // 
            // rtb_rezultat
            // 
            this.rtb_rezultat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtb_rezultat.Location = new System.Drawing.Point(471, 255);
            this.rtb_rezultat.Name = "rtb_rezultat";
            this.rtb_rezultat.ReadOnly = true;
            this.rtb_rezultat.Size = new System.Drawing.Size(156, 162);
            this.rtb_rezultat.TabIndex = 11;
            this.rtb_rezultat.Text = "";
            this.rtb_rezultat.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(458, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rezultat algoritm:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(467, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Alege algoritmul:";
            this.label4.Visible = false;
            // 
            // rtb_algoritm
            // 
            this.rtb_algoritm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_algoritm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_algoritm.Location = new System.Drawing.Point(634, 120);
            this.rtb_algoritm.Name = "rtb_algoritm";
            this.rtb_algoritm.ReadOnly = true;
            this.rtb_algoritm.Size = new System.Drawing.Size(359, 414);
            this.rtb_algoritm.TabIndex = 15;
            this.rtb_algoritm.Text = "";
            this.rtb_algoritm.Visible = false;
            this.rtb_algoritm.WordWrap = false;
            // 
            // label_avertizare
            // 
            this.label_avertizare.BackColor = System.Drawing.Color.Red;
            this.label_avertizare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_avertizare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_avertizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_avertizare.ForeColor = System.Drawing.Color.White;
            this.label_avertizare.Location = new System.Drawing.Point(322, 33);
            this.label_avertizare.Name = "label_avertizare";
            this.label_avertizare.Size = new System.Drawing.Size(362, 48);
            this.label_avertizare.TabIndex = 16;
            this.label_avertizare.Text = "NU POTI SUPRAPUNE DOUA NODURI ALE GRAFULUI";
            this.label_avertizare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_avertizare.Visible = false;
            // 
            // timer_alerta_suprapunere_elemente
            // 
            this.timer_alerta_suprapunere_elemente.Interval = 2000;
            this.timer_alerta_suprapunere_elemente.Tick += new System.EventHandler(this.timer_alerta_suprapunere_elemente_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_nodstart
            // 
            this.label_nodstart.AutoSize = true;
            this.label_nodstart.BackColor = System.Drawing.Color.Transparent;
            this.label_nodstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nodstart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_nodstart.Location = new System.Drawing.Point(468, 172);
            this.label_nodstart.Name = "label_nodstart";
            this.label_nodstart.Size = new System.Drawing.Size(106, 18);
            this.label_nodstart.TabIndex = 20;
            this.label_nodstart.Text = "Nod de start:";
            this.label_nodstart.Visible = false;
            // 
            // button_rulare_algoritm
            // 
            this.button_rulare_algoritm.BackColor = System.Drawing.Color.Olive;
            this.button_rulare_algoritm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rulare_algoritm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_rulare_algoritm.Location = new System.Drawing.Point(771, 540);
            this.button_rulare_algoritm.Name = "button_rulare_algoritm";
            this.button_rulare_algoritm.Size = new System.Drawing.Size(134, 48);
            this.button_rulare_algoritm.TabIndex = 21;
            this.button_rulare_algoritm.Text = "Rulează algoritmul";
            this.button_rulare_algoritm.UseVisualStyleBackColor = false;
            this.button_rulare_algoritm.Visible = false;
            this.button_rulare_algoritm.Click += new System.EventHandler(this.button_rulare_algoritm_Click);
            // 
            // textBox_nod_start
            // 
            this.textBox_nod_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nod_start.Location = new System.Drawing.Point(471, 193);
            this.textBox_nod_start.Name = "textBox_nod_start";
            this.textBox_nod_start.Size = new System.Drawing.Size(53, 24);
            this.textBox_nod_start.TabIndex = 22;
            this.textBox_nod_start.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Matrice adiacenta",
            "Parcurgerea in latime",
            "Parcurgerea in adancime",
            "Componente conexe",
            "Lant intre doua noduri",
            "Graf Eulerian"});
            this.comboBox1.Location = new System.Drawing.Point(471, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "Alege un algoritm";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_resetare_culori_graf
            // 
            this.button_resetare_culori_graf.BackColor = System.Drawing.Color.Crimson;
            this.button_resetare_culori_graf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetare_culori_graf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_resetare_culori_graf.Location = new System.Drawing.Point(910, 540);
            this.button_resetare_culori_graf.Name = "button_resetare_culori_graf";
            this.button_resetare_culori_graf.Size = new System.Drawing.Size(85, 48);
            this.button_resetare_culori_graf.TabIndex = 24;
            this.button_resetare_culori_graf.Text = "Reseteaza culorile Grafului";
            this.button_resetare_culori_graf.UseVisualStyleBackColor = false;
            this.button_resetare_culori_graf.Visible = false;
            this.button_resetare_culori_graf.Click += new System.EventHandler(this.button_resetare_culori_graf_Click);
            // 
            // timer_pauza_animatie
            // 
            this.timer_pauza_animatie.Interval = 50000;
            this.timer_pauza_animatie.Tick += new System.EventHandler(this.timer_pauza_animatie_Tick);
            // 
            // groupBox_startup
            // 
            this.groupBox_startup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox_startup.BackgroundImage")));
            this.groupBox_startup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox_startup.Controls.Add(this.pictureBox3);
            this.groupBox_startup.Controls.Add(this.pictureBox2);
            this.groupBox_startup.Controls.Add(this.button1);
            this.groupBox_startup.Controls.Add(this.button_edu);
            this.groupBox_startup.Controls.Add(this.button_test);
            this.groupBox_startup.Location = new System.Drawing.Point(0, 27);
            this.groupBox_startup.Name = "groupBox_startup";
            this.groupBox_startup.Size = new System.Drawing.Size(1022, 585);
            this.groupBox_startup.TabIndex = 25;
            this.groupBox_startup.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(691, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 117);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(198, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 103);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(962, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_edu
            // 
            this.button_edu.BackColor = System.Drawing.Color.Khaki;
            this.button_edu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edu.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button_edu.Location = new System.Drawing.Point(131, 237);
            this.button_edu.Name = "button_edu";
            this.button_edu.Size = new System.Drawing.Size(260, 59);
            this.button_edu.TabIndex = 1;
            this.button_edu.Text = "Vreau sa invat";
            this.button_edu.UseVisualStyleBackColor = false;
            this.button_edu.Click += new System.EventHandler(this.button_edu_Click);
            // 
            // button_test
            // 
            this.button_test.BackColor = System.Drawing.Color.Khaki;
            this.button_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_test.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button_test.Location = new System.Drawing.Point(622, 237);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(272, 59);
            this.button_test.TabIndex = 0;
            this.button_test.Text = "Vreau sa-mi testez cunostintele";
            this.button_test.UseVisualStyleBackColor = false;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 609);
            this.Controls.Add(this.groupBox_startup);
            this.Controls.Add(this.button_resetare_culori_graf);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_nod_start);
            this.Controls.Add(this.button_rulare_algoritm);
            this.Controls.Add(this.label_nodstart);
            this.Controls.Add(this.label_avertizare);
            this.Controls.Add(this.rtb_algoritm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_rezultat);
            this.Controls.Add(this.button_stergegraf);
            this.Controls.Add(this.button_final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_desenaregraf);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_startup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.RadioButton radio_orientat;
        private System.Windows.Forms.RadioButton radio_neorientat;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.Panel panel_desenaregraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_nod;
        private System.Windows.Forms.RadioButton radio_Muchie;
        private System.Windows.Forms.Button button_final;
        private System.Windows.Forms.Button button_stergegraf;
        private System.Windows.Forms.ToolStripMenuItem teorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafuriNeorientateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafuriOrientateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arboriToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_avertizare;
        private System.Windows.Forms.Timer timer_alerta_suprapunere_elemente;
        private System.Windows.Forms.RadioButton radio_aranjare;
        public System.Windows.Forms.RichTextBox rtb_rezultat;
        public System.Windows.Forms.RichTextBox rtb_algoritm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_nodstart;
        private System.Windows.Forms.Button button_rulare_algoritm;
        private System.Windows.Forms.TextBox textBox_nod_start;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_resetare_culori_graf;
        private System.Windows.Forms.Timer timer_pauza_animatie;
        private System.Windows.Forms.GroupBox groupBox_startup;
        private System.Windows.Forms.Button button_edu;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

