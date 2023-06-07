using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testVyjimkyStach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prumer = 0;
            int pocitadlo = 0;
            string[] text = textBox1.Lines;
            foreach(string radek in text)
            {
                try
                {
                    int cislo = Convert.ToInt32(radek);
                    if (cislo < 0)
                    {
                        prumer = prumer + cislo;
                        pocitadlo++;
                    }
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(OverflowException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }
            try
            {
                prumer = prumer / pocitadlo;
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DivideByZeroException)
            {
                
            }
            label1.Text = "Prumer je: " + prumer; 
        }
    }
}
