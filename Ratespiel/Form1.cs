using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ratespiel
{
    public partial class Form1 : Form
    {


        Random randomNumber = new Random();


        int nummer = 0;
        int schätzen = 0;

        public Form1()
        {
            InitializeComponent();
            frageLaden();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            schätzen += 1;


            label2.Text = "Sie haben " + schätzen + " geraten";

            if(i == nummer)
            {
                MessageBox.Show("Richtig geratet!");
                frageLaden();
                textBox1.Text = "";
                schätzen = 0;
                    
            }
            else if (i < nummer)
            {
                MessageBox.Show("HÖHER GEHEN");
            }
            else
            {
                MessageBox.Show("KLEINER GEHEN");
            }
        }

        private void frageLaden()
        {
            nummer = randomNumber.Next(0, 10);

            label1.Text = "Ich denke an eine Zahl zwischen: 0 und 10 ";

        }
    }
}
