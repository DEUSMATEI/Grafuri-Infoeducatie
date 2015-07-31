using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafuri
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
            timer_gengraf.Start();
        }
         graf gr = new graf();
        
        //eveniment button exit
        private void button_exit_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show("Doresti sa parasesti aceasts sectiune?");
            var raspuns= MessageBox.Show("Doresti sa parasesti aceasta sectiune?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(raspuns == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
                
            }
            
        }
      
       

        public void afis_img(bool raspuns)
        {
            if(raspuns == true)
            {
                button_corectare.Text = "";
                button_corectare.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.man_with_check_sign_05));
                timer_button_corectare.Start();
            }else
            {
                button_corectare.Text = "";
                button_corectare.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CheckMarkX));
                timer_button_corectare.Start();
            }
        }

        class graf 
        {
            
            public int nr_noduri;
            public int[,] m_adiacenta = new int[40, 40];
            public Point [] noduri = new Point [40];
            public Random rn = new Random();

            public graf()
            {
                //pozitiile pt noduri
                  noduri[1].X= 25;
                    noduri[1].Y= 23;
                  noduri[2].X=324;
                noduri[2].Y= 28;
                  noduri[3].X=315;
                noduri[3].Y=250;
                  noduri[4].X=18;
                noduri[4].Y=259;
                  noduri[5].X=98;
                noduri[5].Y=81;
                  noduri[6].X=241;
                noduri[6].Y=74;
                  noduri[7].X=225;
                noduri[7].Y=211;
                noduri[8].X=93;
                noduri[8].Y=219;
                  noduri[9].X=346;
                noduri[9].Y=80;
                  noduri[10].X=4;
                noduri[10].Y=205;
                  noduri[11].X=13;
                noduri[11].Y=85;
                  noduri[12].X=127;
                noduri[12].Y=10;

                grafnou();
                    
                 
            }

            //generare graf nou
            public void grafnou()
            {
                
                nr_noduri = rn.Next(3, 11);
                
                //initialoizam matricea
                for (int i = 1; i <= nr_noduri; i++)
                {
                    for (int j = 1; j <= nr_noduri; j++)
                    {
                        m_adiacenta[i, j] = 0;
                    }
                }
                //introducem valori in matrice
                for (int i = 1; i <= nr_noduri; i++)
                {
                    for (int j = 1; j <= nr_noduri; j++)
                    {
                        if (rn.Next(0, 900) % 2 == 0 && m_adiacenta[i, j] == 0 && i != j)
                        {
                            m_adiacenta[i, j] = 1;
                            m_adiacenta[j, i] = 1;
                        }
                        else
                        {
                            if (m_adiacenta[i, j] != 1)
                            {
                                m_adiacenta[i, j] = 0;
                            }

                        }

                    }
                }
                int nr_permutari = rn.Next(20);
                for (int l = 0; l <= nr_permutari; l++)
                {

                    for (int i = 1; i < 12; i++)
                    {
                        Point aux = noduri[i];
                        noduri[i] = noduri[i + 1];
                        noduri[i + 1] = aux;
                    }

                }


            }

            //desenare muchie
            public void desenare_muchie(Point a, Point b,ref Panel panel_graf)
            {
                Graphics gr = panel_graf.CreateGraphics();
                Pen pn = new Pen(Color.Black, 2);
                Font f = new System.Drawing.Font("Arial", 10);
                SolidBrush br = new SolidBrush(Color.Red);
                gr.DrawLine(pn, a, b);
            }
            //desenare nod
            public void desenare_nod(Point a, int nr_nod,ref Panel panel_graf)
            {
                Graphics gr = panel_graf.CreateGraphics();
                Pen pn = new Pen(Color.Black, 2);
                Font f = new System.Drawing.Font("Arial", 10);
                SolidBrush br = new SolidBrush(Color.Red);
                gr.DrawEllipse(pn, a.X-10, a.Y-10, 30, 30);
                gr.FillEllipse(br, a.X-10, a.Y-10, 30, 30);
                br.Color = Color.Black;
                gr.DrawString(nr_nod.ToString(), f, br, a.X-3, a.Y-3);
            }
            //method:desenare graf
            public void desenare_graf (ref Panel p)
            {

                for (int i = 1; i <= nr_noduri; i++)
                {
                    for (int j = 1; j <= nr_noduri; j++)
                    {
                           if(m_adiacenta[i, j]==1)
                           {
                               desenare_muchie(noduri[i], noduri[j], ref p);
                               
                           }
                    }
                }
                  for (int i = 1; i <= nr_noduri; i++)
                  {
                      desenare_nod(noduri[i], i, ref p);
                  }
            }
            public bool corectare_matad(RichTextBox richTextBox_matad)
            {
                try
                {
                    string raspuns = richTextBox_matad.Text, matad="";
                    raspuns.Replace(" ", "");
                    for(int i=1; i<=nr_noduri; i++)
                    {
                        for(int j=1; j<=nr_noduri; j++)
                        {
                            matad = matad + Convert.ToString(m_adiacenta[i,j]);
                        }
                        if(i!=nr_noduri)
                        matad = matad + "\n";
                    }
                   

                    if(raspuns==matad)
                    {
                        return true;
                    }else
                    {
                        matad = matad + "\n";
                        if (raspuns == matad)
                        {
                            return true;
                        }else                           
                        return false;
                    }
                }catch
                {
                    MessageBox.Show("Mai verifica raspunsul introdus!");
                    return false;
                }
                
                
                
            }
            public bool corectare_df(ref RichTextBox r, int nod_start)
            {
                
                try                
                {
                    
                    
                     string rasp = r.Text, rezultat="";
                    
                    int[] s = new int[30];
                    //initializare vector s
                    for (int i = 0; i < 30; i++ )
                    {
                        s[i] = 0;
                    }
                    df(nod_start, ref s, ref rezultat);
                    
                    if(rasp==rezultat)
                    {
                        return true;
                    }else
                    {
                        rasp = rasp + " ";
                        if (rasp == rezultat)
                        {
                            return true;
                        }else
                        return false;
                       
                    }
                        
                }catch
                {
                    return false;
                   
                }
            }

            private void df(int nod, ref int [] s, ref string rezultat)
            {                  
                   s[nod] = 1;
                   rezultat = rezultat + Convert.ToString(nod) + " ";
                    for (int i = 1; i <=this.nr_noduri; i++ )
                    {
                        if(m_adiacenta[nod,i]==1 && s[i]==0)
                        {
                            
                               
                                df(i, ref s, ref rezultat);
                           
                           
                        }
                    }
            }

            //sf class graf
        }
        int nod_start;
        private void button1_Click(object sender, EventArgs e)
        {
            //trecere mai depaerte
            
                //trecem la cerinta urmatoare
                
                group_matad.Visible = false;
                Random ran = new Random();
                nod_start = ran.Next(1, gr.nr_noduri);
                label_df.Text = "Ce se afiseaza la apelul functiei *df(" + nod_start.ToString() + ") (parcurgere in adancime)";
                groupBox_df.Visible = true;
           
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            
            Graphics gra = panel_graf.CreateGraphics();
            Pen pn = new Pen(Color.Black, 2);
            Font f = new System.Drawing.Font("Arial", 10);
            SolidBrush br = new SolidBrush(Color.White);
            gra.DrawRectangle(pn, 0, 0, 371, 282);
            gra.FillRectangle(br, 0, 0, 371, 282);
            gr.grafnou();
            gr.desenare_graf(ref panel_graf);
        }

        private void timer_gengraf_Tick(object sender, EventArgs e)
        {
            gr.desenare_graf(ref panel_graf);
            timer_gengraf.Stop();
        }

        private void button_cerinta_urm_Click(object sender, EventArgs e)
        {
            groupBox_df.Visible = false;
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //corectare cerinta *df*
            if (gr.corectare_df(ref richTextBox_raspuns_df, nod_start) == true && groupBox_df.Visible==true)
            {
                afis_img(true);
            }
            else
            {
                if (gr.corectare_matad(richTextBox_matad) == true && group_matad.Visible==true)
                {
                    afis_img(true);
                }else
                {
                    afis_img(false);
                }
                
            }
        }

        private void timer_button_corectare_Tick(object sender, EventArgs e)
        {
            button_corectare.BackgroundImage = null;
            button_corectare.Text = "Corectare";
            timer_button_corectare.Stop();
        }   
        
    }
    
}
