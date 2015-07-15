using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
        
        private void button_exit_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show("Doresti sa parasesti aceasts sectiune?");
            var rezultat = MessageBox.Show("Doresti sa parasesti aceasta sectiune?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rezultat == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
                
            }
            
        }
    }
}
