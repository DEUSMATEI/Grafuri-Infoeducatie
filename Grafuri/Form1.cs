using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Grafuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] matrice_adiacenta = new int[50, 50]; bool pauza = false;
        private void golire_matrice_adiacenta ()
        {
            for(int i=0; i<=50; i++)
            {
                for(int j=0; j<=50; j++)
                {
                  //  matrice_adiacenta[i, j] = 0;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Incarcarea paginii
            golire_vector();
            golire_matrice_adiacenta();
            am_selectat_un_nod = false;
            radio_orientat.Enabled = false;
        }

        private void incarca_alg(string filename)
        {

            rtb_algoritm.Text = "";
            
            try
            {
                string f = Directory.GetCurrentDirectory() + @"\algoritmi\" + filename;
                StreamReader sr = new StreamReader(f);
                string linie = null;
                while ((linie = sr.ReadLine()) != null)
                {
                    rtb_algoritm.Text += linie + "\r\n";

                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void afisare_matrice_adiacenta ()
        {
            rtb_rezultat.Text = rtb_rezultat.Text + "Matrice adiacenta" + "\n";
            for(int i=1; i<=nod_curent; i++)
            {
                for(int j=1; j<=nod_curent; j++)
                {

                    rtb_rezultat.Text = rtb_rezultat.Text + matrice_adiacenta[i, j].ToString() + "  ";
                    
                }
                rtb_rezultat.Text = rtb_rezultat.Text + "\n";
            }
        }
        //structura pentru nod
        public struct nod
        {
           public int x, y;
        }
        //structura pentru graf
        public struct grafuri
        {
           public int noduri; 
           public bool orientat, costuri;
        }
        //structura pentru laturi
        public struct latura
        {
            public int cost;
            //nr nod de origine si de destinatie
            public int origine, destinatie;
        }
            private void b_exit_Click(object sender, EventArgs e)
        {
            //inchidem fereastra curenta
            groupBox_startup.Visible = true;
        }
            nod[] noduri = new nod[300];
            private void button_stergegraf_Click(object sender, EventArgs e)
            {
                Point p = new Point(301, 459); button_stergegraf.Text = "Sterge graf";
                button_final.Enabled = false;
                button_stergegraf.Location = p;
                //stergere graf
                groupBox1.Visible = groupBox2.Visible = true; button_final.Visible = true;
                button_rulare_algoritm.Visible = button_resetare_culori_graf.Visible = false;
                label_nodstart.Visible = textBox_nod_start.Visible = rtb_algoritm.Visible = rtb_rezultat.Visible = label3.Visible = comboBox1.Visible = label4.Visible = false;
                radio_aranjare.Visible = true;
                label1.Text = "Deseneaza graful aici:";
                pictureBox1.Visible = true;
                radio_aranjare.Visible = true;
                primul_nod_a_fost_ales = false;
                graful_se_poate_edita = true;
                nod_curent = 0;
                golire_vector();
                golire_matrice_adiacenta();
                //golesc panoul grafic si datele memorate
                Graphics gr = panel_desenaregraf.CreateGraphics();
                Pen pn = new Pen(Color.White, 10);
                Font f = new System.Drawing.Font("Arial", 10);
                SolidBrush br = new SolidBrush(Color.White);
                gr.DrawRectangle(pn, 0, 0, 410, 299);
                gr.FillRectangle(br, 0, 0, 410, 299);
                
            }

            private void button_final_Click(object sender, EventArgs e)
            {
                Point p = new Point(634, 540);
                button_stergegraf.Location = p; button_stergegraf.Text = "Graf nou";
                button_rulare_algoritm.Visible = textBox_nod_start.Visible = true;
                pictureBox1.Visible = false;
                button_resetare_culori_graf.Visible = true;
                //graful este gata de desenat
                rtb_algoritm.Visible = rtb_rezultat.Visible = label3.Visible = label4.Visible = comboBox1.Visible = true;
                groupBox2.Visible = groupBox1.Visible = button_final.Visible = label2.Visible = false;
                label1.Text = "Graful tău:";
                graful_se_poate_edita = false;
                //afisez urmatoarea etapa
            }

            private void grafuriNeorientateToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //afisam teoria grafurilor neorientate
                Teorie_graf_neorientat teorie = new Teorie_graf_neorientat();
                teorie.Show();
            }
            int x, y;
            private void panel_desenaregraf_MouseMove(object sender, MouseEventArgs e)
            {
                //cand se muta mouseul ii memoram noile coordonate
                x = e.X;
                y = e.Y;
                //din coordonatele cursorului scadem coordonatele ferestrei si coordonatele interne ale panel grafului
                
            }
        //
        //
        //structura graf in care memoram datele despre graful nostru
        // 
        // 
        // 
            grafuri graf=new grafuri();
        //
        //
            int nod_curent = 0;
            public void golire_vector()
            {
                for (int i=0; i<300; i++)
                {
                    noduri[i].x = noduri[i].y = -10;
                }
            }
            public bool exista_nod = false, primul_nod_a_fost_ales=false, graful_se_poate_edita=true, am_selectat_un_nod=false;
            int primul_nod, al_doilea_nod;
            private void panel_desenaregraf_MouseClick(object sender, MouseEventArgs e)
            {
                if(nod_curent>1)
                {
                button_final.Enabled = true;
                }
                

                if (graful_se_poate_edita == true)
                {
                    //desenare nod
                    //avertizari si precizari
                    //
                    if (groupBox2.Visible == false)
                    {
                        label_avertizare.Text = "Trebuie sa alegi tipul grafului!";
                        label_avertizare.Visible = true;
                        timer_alerta_suprapunere_elemente.Start();
                    }
                    if (groupBox2.Visible == true && radio_nod.Checked == false && radio_Muchie.Checked == false && radio_aranjare.Checked == false)
                    {
                        label_avertizare.Text = "Alege ce vrei sa desenezi!";
                        label_avertizare.Visible = true;
                        timer_alerta_suprapunere_elemente.Start();
                    }
                    if (radio_nod.Checked == true)
                    {
                        //desenare noduri
                        nod_curent++;
                        Graphics gr = panel_desenaregraf.CreateGraphics();
                        Pen pn = new Pen(Color.Red, 10);
                        Font f = new System.Drawing.Font("Arial", 10);
                        SolidBrush br = new SolidBrush(Color.Black);

                        if (nod_curent >= 1)
                        {
                            bool ok = true;
                            for (int i = 1; i < nod_curent; i++)
                            {
                                //experimental trebuie sa determin marimea campului din jurul nodului pe care trebuie sa o protejez
                                if (noduri[i].x - 20 <= x && x <= noduri[i].x + 20 && noduri[i].y - 20 <= y && noduri[i].y + 20 >= y)
                                    ok = false;
                            }
                            if (ok == true)
                            {
                                gr.DrawEllipse(pn, x, y, 20, 20);
                                //memoram pozitia nodului
                                noduri[nod_curent].x = x;
                                noduri[nod_curent].y = y;
                                //umplem cercul
                                br.Color = Color.Red;
                                gr.FillEllipse(br, x, y, 20, 20);
                                br.Color = Color.White;
                                gr.DrawString(nod_curent.ToString(), f, br, x + 3, y + 3);

                            }
                            else
                            {
                                nod_curent--;
                                label_avertizare.Text = "NU POTI SUPRAPUNE DOUA NODURI ALE GRAFULUI!";
                                label_avertizare.Visible = true;
                                timer_alerta_suprapunere_elemente.Start();
                            }
                        }

                    }
                    /*
                     * Desenam muchiile...
                     * pentru aceasta trebuie sa vedem daca exista nu nod unde am dat click 
                     * apoi sa vedem daca exista nod unde dam click a doua oara.... si daca exista desenam muchia intre cele doua noduri si apoi memoram in matricea de adiacenta
                     * */
                }
                bool linia_a_Fost_desenata = false;
                if (radio_Muchie.Checked == true && primul_nod_a_fost_ales == true)
                {


                    
                    graful_se_poate_edita = false;
                    radio_aranjare.Hide(); 
                    //in variabila "nod_curent" memorez numarul ultimului nod

                    for (int i = 0; i <= nod_curent; i++)
                    {
                        if (e.X > noduri[i].x - 15 && e.X < noduri[i].x + 15 && e.Y > noduri[i].y - 15 && e.Y < noduri[i].y + 15 && i!=primul_nod)
                        {
                            al_doilea_nod = i;
                            
                            // in loc de: primul_nod_a_fost_ales = false;     
                            linia_a_Fost_desenata = true;
                            Graphics gr = panel_desenaregraf.CreateGraphics();
                            Pen pn = new Pen(Color.Black, 2);
                            SolidBrush br = new SolidBrush(Color.Black);
                            gr.DrawLine(pn, noduri[al_doilea_nod].x + 5, noduri[al_doilea_nod].y + 5, noduri[primul_nod].x + 5, noduri[primul_nod].y + 5);
                            matrice_adiacenta[primul_nod, al_doilea_nod] = 1;
                            matrice_adiacenta[al_doilea_nod, primul_nod] = 1;
                            //trebuie sa redesenam nodurile care se afla la capetele ,uchiei desenate
                            //primul_nod si al_doilea_nod
                            /*
                             *   Graphics gr = panel_desenaregraf.CreateGraphics();
                                 Pen pn = new Pen(Color.Red, 10);
                                 Font f = new System.Drawing.Font("Arial", 10);
                                 SolidBrush br = new SolidBrush(Color.Black);
                             * */
                            pn.Color = Color.Red;
                            br.Color = Color.Red;
                            Font f = new System.Drawing.Font("Arial", 10);
                            gr.DrawEllipse(pn, noduri[primul_nod].x, noduri[primul_nod].y, 20, 20);
                            gr.FillEllipse(br, noduri[primul_nod].x, noduri[primul_nod].y, 20, 20);
                            br.Color = Color.White;
                            gr.DrawString(primul_nod.ToString(), f, br, noduri[primul_nod].x +3 , noduri[primul_nod].y+3);
                            pn.Color = Color.Red;
                            br.Color = Color.Red;
                            
                            gr.DrawEllipse(pn, noduri[al_doilea_nod].x, noduri[al_doilea_nod].y, 20, 20);
                            gr.FillEllipse(br, noduri[al_doilea_nod].x, noduri[al_doilea_nod].y, 20, 20);
                            br.Color = Color.White;
                            gr.DrawString(al_doilea_nod.ToString(), f, br, noduri[al_doilea_nod].x + 3, noduri[al_doilea_nod].y + 3);
                        }
                    }
                    
                }
                if (radio_Muchie.Checked == true && primul_nod_a_fost_ales == false)
                    {


                        //in variabila "nod_curent" memorez numarul ultimului nod
                        //in variabila "primul_nod" memorez i-ul primului nod de la care desenam muchia
                        for (int i = 0; i <= nod_curent; i++)
                        {
                            if (e.X > noduri[i].x - 5 && e.X <= noduri[i].x + 20 && e.Y > noduri[i].y - 5 && e.Y <= noduri[i].y + 20)
                            {
                               /* exista_nod = true;*/ primul_nod = i; primul_nod_a_fost_ales = true;
                            }
                        }
                    }
                if(linia_a_Fost_desenata==true)
                {
                    primul_nod_a_fost_ales = false;
                }
                    //
                   


                    /*sfarsit eveniment mouse click 
                     * 
                     * 
                     * ******************************************************************
                     * ******************************************************************
                     * ******************************************************************
                     * ******************************************************************
                     * ******************************************************************
                     * 
                     * 
                     * */
                
            }

            private void radio_orientat_MouseClick(object sender, MouseEventArgs e)
            {
                
                if(radio_neorientat.Checked==true)
                {
                    graf.orientat = false;
                    button_final.Enabled = false;
                    groupBox2.Visible = button_final.Visible = button_stergegraf.Visible = true;
                    radio_nod.Checked = true;
                }else
                {
                   /* button_final.Enabled = false;
                    graf.orientat = true;
                    groupBox2.Visible = button_final.Visible = button_stergegraf.Visible = true;
                    radio_nod.Checked = true;*/
                }
            }

            private void timer_alerta_suprapunere_elemente_Tick(object sender, EventArgs e)
            {
                label_avertizare.Visible = false;
                timer_alerta_suprapunere_elemente.Stop();
            }

            private void radio_Muchie_MouseClick(object sender, MouseEventArgs e)
            {
                MessageBox.Show("După ce desenezi muchiile nu mai poți rearanja graful!");
            }

            private void panel_desenaregraf_MouseDown(object sender, MouseEventArgs e)
            {
                //verificam daca exista un nod in pozitia actuala
                //daca exista
                //stergem nodul curent de pe pozitia veche
                if(radio_aranjare.Checked==true && graful_se_poate_edita==true && am_selectat_un_nod ==false)
                {
                    bool ok = false;int poz=0;
                    
                    for(int i=0; i<=nod_curent; i++)
                    {
                        if(e.X>noduri[i].x-15 && e.X<noduri[i].x +15 && e.Y>noduri[i].y-15 && e.Y<noduri[i].y +15)
                        {
                            ok = true; poz = i; nodul_pe_care_il_mutam = poz;
                        }
                    }
                    //stergem nodul 
                    if(ok==true)
                    {
                        am_selectat_un_nod = true;
                        Graphics gr = panel_desenaregraf.CreateGraphics();
                        Pen pn = new Pen(Color.White, 10);
                        SolidBrush br = new SolidBrush(Color.White);
                        gr.DrawEllipse(pn, noduri[poz].x, noduri[poz].y, 20, 20);
                        gr.FillEllipse(br, noduri[poz].x, noduri[poz].y, 20, 20);
                    }
                }
            }
            int nodul_pe_care_il_mutam;
            private void panel_desenaregraf_MouseUp(object sender, MouseEventArgs e)
            {
                //verificam daca pozitia noua este libera
                //daca da
                //redesenam nodul si salvam noua sa locatie
                if (radio_aranjare.Checked == true && am_selectat_un_nod==true && graful_se_poate_edita==true)
                {
                  
                    bool ok = true; int poz = 0;
                    for (int i = 0; i <= nod_curent; i++)
                    {
                        if (e.X > noduri[i].x - 15 && e.X < noduri[i].x + 15 && e.Y > noduri[i].y - 15 && e.Y < noduri[i].y + 15)
                        {
                            ok = false; poz = i;
                        }
                    }
                    //desenam nodul
                    if (ok == true )
                    {
                        am_selectat_un_nod = false;
                        Graphics gr = panel_desenaregraf.CreateGraphics();
                        Pen pn = new Pen(Color.Red, 10);
                        Font f = new System.Drawing.Font("Arial", 10);
                        SolidBrush br = new SolidBrush(Color.Black);
                        //salvam noile coordonate
                        noduri[nodul_pe_care_il_mutam].x = e.X;
                        noduri[nodul_pe_care_il_mutam].y = e.Y;
                        //
                        gr.DrawEllipse(pn, noduri[nodul_pe_care_il_mutam].x, noduri[nodul_pe_care_il_mutam].y, 20, 20);
                         br.Color = Color.Red;
                         gr.FillEllipse(br, noduri[nodul_pe_care_il_mutam].x, noduri[nodul_pe_care_il_mutam].y, 20, 20);
                            br.Color = Color.White;
                            gr.DrawString(nodul_pe_care_il_mutam.ToString(), f, br, noduri[nodul_pe_care_il_mutam].x + 3, noduri[nodul_pe_care_il_mutam].y + 3);       
                    }else
                    {
                        //
                        label_avertizare.Text = "Nu poti suprapune două elemente ale grafului!";
                        label_avertizare.Visible = true;
                        timer_alerta_suprapunere_elemente.Start();
                        am_selectat_un_nod = false;
                        //
                        Graphics gr = panel_desenaregraf.CreateGraphics();
                        Pen pn = new Pen(Color.Red, 10);
                        Font f = new System.Drawing.Font("Arial", 10);
                        SolidBrush br = new SolidBrush(Color.Black);
                        gr.DrawEllipse(pn, noduri[nodul_pe_care_il_mutam].x, noduri[nodul_pe_care_il_mutam].y, 20, 20);
                        br.Color = Color.Red;
                        gr.FillEllipse(br, noduri[nodul_pe_care_il_mutam].x, noduri[nodul_pe_care_il_mutam].y, 20, 20);
                        br.Color = Color.White;
                        gr.DrawString(nodul_pe_care_il_mutam.ToString(), f, br, noduri[nodul_pe_care_il_mutam].x + 3, noduri[nodul_pe_care_il_mutam].y + 3);       
                        
                    }
                }
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
               //if(comboBox1.te)
                if (comboBox1.Text == "Graf Eulerian")
                {
                    incarca_alg("conexe.txt");
                }
                //matad.txt 
                if(comboBox1.Text=="Lant intre doua noduri")
                {
                    incarca_alg("lant.txt");
                }
                if (comboBox1.Text == "Matrice adiacenta")
                {
                    incarca_alg("matad.txt");
                    
                }
                if (comboBox1.Text == "Parcurgerea in latime")
                {
                    incarca_alg("bf.txt");
                   
                    
                   
                }
                if (comboBox1.Text == "Parcurgerea in adancime")
                {
                    incarca_alg("dfs.txt");
                }
            }

            private void Form1_KeyPress(object sender, KeyPressEventArgs e)
            {
                //eveniment de apasarea a unei taste pentru a trece mai departe in timp ce lucreaza algoritmul
                
                
            }
            public int i_c, sf_c;
            public int[] grad_noduri = new int[100];
            public int[] c = new int[100];
           public int[] s = new int[100];
        public void p_latime (int nod)
        {
            int nr_noduri_verificate = 0, nr_nod = nod, i_nod = 1;
            Graphics gr = panel_desenaregraf.CreateGraphics();
            Pen pn = new Pen(Color.DarkBlue, 2);
            Font f = new System.Drawing.Font("Arial", 10);
            SolidBrush br = new SolidBrush(Color.Black);
            pn.Color = br.Color = Color.Green;
            gr.DrawEllipse(pn, noduri[nod].x - 5, noduri[nod].y - 5, 30, 30);
            gr.FillEllipse(br, noduri[nod].x - 5, noduri[nod].y - 5, 30, 30);
            br.Color = Color.Black;
            gr.DrawString(nod.ToString(), f, br, noduri[nod].x +2, noduri[nod].y +2);
            c[i_c] = nod;
            s[nod] = 1;
            while(i_c <=sf_c)
            {
                int i = 1, ultimul_nod = nod;
                while(i<=nod_curent)
                {
                    if(matrice_adiacenta[c[i_c], i]==1 && s[i]==0)
                    {
                        sf_c++;
                        c[sf_c] = i;
                        s[i] = 1;
                        nr_noduri_verificate++;
                       /* label_avertizare.Text = nr_noduri_verificate.ToString();
                        label_avertizare.Visible = true;
                        if(nr_noduri_verificate==grad_noduri[c[i_nod]])
                        {
                            i_nod++;
                            ultimul_nod = c[i_nod];
                            label_avertizare.Text = i_nod.ToString();
                            label_avertizare.Visible = true;
                            nr_noduri_verificate =1;
                        }*/
                        ultimul_nod = c[i_c];
                        
                        //gr.DrawLine(pn, noduri[al_doilea_nod].x + 5, noduri[al_doilea_nod].y + 5, noduri[primul_nod].x + 5, noduri[primul_nod].y + 5);
                        pn.Color = br.Color = Color.DarkBlue;
                        gr.DrawLine(pn, noduri[i].x + 5, noduri[i].y + 5, noduri[ultimul_nod].x + 5, noduri[ultimul_nod].y + 5);
                        pn.Color = br.Color = Color.Gold;
                        gr.DrawEllipse(pn, noduri[i].x -5, noduri[i].y-5, 30, 30);
                        gr.FillEllipse(br, noduri[i].x -5, noduri[i].y-5, 30, 30);
                        br.Color = Color.Black;
                        gr.DrawString(i.ToString(), f, br, noduri[i].x + 2, noduri[i].y + 2);
                        //redesenam primul nod;
                        pn.Color = br.Color = Color.Gold;
                        gr.DrawEllipse(pn, noduri[ultimul_nod].x - 5, noduri[ultimul_nod].y - 5, 30, 30);
                        gr.FillEllipse(br, noduri[ultimul_nod].x - 5, noduri[ultimul_nod].y - 5, 30, 30);
                        br.Color = Color.Black;
                        gr.DrawString(ultimul_nod.ToString(), f, br, noduri[ultimul_nod].x + 2, noduri[ultimul_nod].y + 2);
                        //gr.DrawString()
                      

                        MessageBox.Show("Pentru a inainta apasa tasta *Enter* sau *Space*");
                        
                        
                    }
                    i++;
                }
                
                i_c++;
            }
        }
        private void calc_grad_noduri()
        {
            for (int i = 1; i <= nod_curent; i++)
            {
                for (int j = 1; j <= nod_curent; j++)
                {
                    
                        grad_noduri[i]=0;
                }
            }
            for(int i=1; i<=nod_curent; i++)
            {
                for(int j=1; j<=nod_curent; j++)
                {
                    if(matrice_adiacenta[i, j]==1)
                        grad_noduri[i]++;
                }
            }
        }
        private void initializare_vectori()
        {
            for(int i=0; i<100;i++)
            {
                c[i] = s[i] = 0;
            }
        }
        int[] ord_vizitare = new int[30]; int contor = 1;
        public void desenare(int nod, int i_nod)
        {
            Graphics gr = panel_desenaregraf.CreateGraphics();
            Pen pn = new Pen(Color.DarkBlue, 2);
            Font f = new System.Drawing.Font("Arial", 10);
            SolidBrush br = new SolidBrush(Color.Gold);
            if (contor == 1)
            {
                gr.DrawEllipse(pn, noduri[Convert.ToInt32(textBox_nod_start.Text)].x - 5, noduri[Convert.ToInt32(textBox_nod_start.Text)].y - 5, 30, 30);
            }else
            {
                gr.DrawLine(pn, noduri[nod].x + 5, noduri[nod].y + 5, noduri[i_nod].x + 5, noduri[i_nod].y + 5);
                gr.DrawEllipse(pn, noduri[nod].x - 5, noduri[nod].y - 5, 30, 30);
                gr.FillEllipse(br, noduri[nod].x - 5, noduri[nod].y - 5, 30, 30);
                br.Color = Color.Black;
                gr.DrawString(nod.ToString(), f, br, noduri[nod].x + 3, noduri[nod].y + 3);

                //desenam al-doilea nod
                br.Color = Color.Gold;
                gr.DrawEllipse(pn, noduri[i_nod].x - 5, noduri[i_nod].y - 5, 30, 30);
                gr.FillEllipse(br, noduri[i_nod].x - 5, noduri[i_nod].y - 5, 30, 30);
                br.Color = Color.Black;
                gr.DrawString(i_nod.ToString(), f, br, noduri[i_nod].x + 3, noduri[i_nod].y + 3);
            }
                
           /* Graphics gr = panel_desenaregraf.CreateGraphics();
            Pen pn = new Pen(Color.Black, 2);
            Font f = new System.Drawing.Font("Arial", 10);
            SolidBrush br = new SolidBrush(Color.Red);
            for (int i = 1; i <= nr_noduri; i++)
            {
                for (int j = 1; j <= nr_noduri; j++)
                {
                    if (matrice_adiacenta[i, j] == 1)
                    {
                        //desenam linia....
                        gr.DrawLine(pn, noduri[i].x + 5, noduri[i].y + 5, noduri[j].x + 5, noduri[j].y + 5);

                        //apoi nodurile
                    }
                }
            }
            for (int i = 1; i <= nr_noduri; i++)
            {
                br.Color = Color.Red;
                gr.DrawEllipse(pn, noduri[i].x - 5, noduri[i].y - 5, 30, 30);
                gr.FillEllipse(br, noduri[i].x - 5, noduri[i].y - 5, 30, 30);
                br.Color = Color.Black;
                gr.DrawString(i.ToString(), f, br, noduri[i].x + 3, noduri[i].y + 3);
           }*/
            
        }
        public void df(int nod)
        {
            if (contor == 1)
            {
                desenare(10,10);
            }

            rtb_rezultat.Text = rtb_rezultat.Text + nod.ToString()+" ";
            
            MessageBox.Show("");
           
            contor++;
            s[nod] = 1;
            for(int i=1; i<=nod_curent; i++)
            {
                if(matrice_adiacenta[nod, i]==1 && s[i]==0)
                {
                    desenare(nod, i);
                    df(i);
                }
            }
        }

        private void button_rulare_algoritm_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Parcurgerea in adancime")
            {
                try
                {
                    rtb_rezultat.Text = rtb_rezultat.Text + "\n" + "Parcurgere in adancime" +"\n";
                    initializare_vectori();
                    df(Convert.ToInt32(textBox_nod_start.Text));
                }catch
                {
                    label_avertizare.Text = "Verifica numarul introdus in casuta nod start";
                    label_avertizare.Visible = true;
                    timer_alerta_suprapunere_elemente.Start();
                }
            }
            if (comboBox1.Text == "Matrice adiacenta")
            {
                afisare_matrice_adiacenta();
            }
            if (comboBox1.Text == "Parcurgerea in latime")
            {
                initializare_vectori();
                i_c = sf_c = 1;
                try
                {
                    calc_grad_noduri();
                    if (Convert.ToInt32(textBox_nod_start.Text) <= nod_curent && Convert.ToInt32(textBox_nod_start.Text)>=1)
                    {
                        p_latime(Convert.ToInt32(textBox_nod_start.Text));
                        rtb_rezultat.Text = rtb_rezultat.Text + "Parcurgerea in latime:" + "\n";
                        for (int i = 1; i <= sf_c; i++)
                        {
                            rtb_rezultat.Text = rtb_rezultat.Text + c[i].ToString() + " ";
                        }
                        rtb_rezultat.Text = rtb_rezultat.Text + "\n";
                    }else
                    {
                        label_avertizare.Text = "Mai verifica numarul introdus in casuta nod start";
                        label_avertizare.Visible = true;
                        timer_alerta_suprapunere_elemente.Start();
                    }
                   
                }
                catch
                {
                    label_avertizare.Text = "Mai verifica numarul introdus in casuta nod start";
                    label_avertizare.Visible = true;
                    timer_alerta_suprapunere_elemente.Start();
                }
            }
        }

        private void button_resetare_culori_graf_Click(object sender, EventArgs e)
        {
            //redesenam graful
            deseneaza_graf(nod_curent);
        }   
        //deseneaza grAFUL CONFORM MATRICEI DE ADIACENTA
        public void deseneaza_graf(int nr_noduri)
        {
            Graphics gr = panel_desenaregraf.CreateGraphics();
            Pen pn = new Pen(Color.Black, 2);
            Font f = new System.Drawing.Font("Arial", 10);
            SolidBrush br = new SolidBrush(Color.Red);
            for(int i=1; i<=nr_noduri; i++)
            {
                for(int j=1; j<=nr_noduri; j++)
                {
                    if(matrice_adiacenta[i, j]==1)
                    {
                        //desenam linia....
                        gr.DrawLine(pn, noduri[i].x + 5, noduri[i].y + 5, noduri[j].x + 5, noduri[j].y + 5);
  
                        //apoi nodurile
                    }
                }
            }
            for(int i=1; i<=nr_noduri; i++)
            {
                br.Color = Color.Red;
                gr.DrawEllipse(pn, noduri[i].x -5, noduri[i].y-5, 30, 30);
                gr.FillEllipse(br, noduri[i].x - 5, noduri[i].y - 5, 30, 30);
                br.Color = Color.Black;
                gr.DrawString(i.ToString(), f, br, noduri[i].x + 3, noduri[i].y + 3);
            }
        
        }
        private void timer_pauza_animatie_Tick(object sender, EventArgs e)
        {
            pauza = true;
        }

        private void button_edu_Click(object sender, EventArgs e)
        {
            groupBox_startup.Visible = false;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teste t = new Teste();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
    }
}
