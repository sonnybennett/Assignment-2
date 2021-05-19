using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read Length and Height and Width from textboxes
                double Length = double.Parse(textBox1.Text);
                double Height = double.Parse(textBox2.Text);
                double Width = double.Parse(textBox3.Text);
                //read Surface area and Volume from labels
                double Surfacearea = 2.0 * (Length * Height + Length * Width + Height * Width);
                double Volume = Length * Height * Width;
                //run the code between these brackets 
                label1.Text = "Surface area = " + Surfacearea;
                label2.Text = "Volume = " + Volume;

            }
            catch
            {
                MessageBox.Show("Error on input");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {   //read Radius from textboxes
                double Radius = double.Parse(textBox1.Text);
                //read Surface area and Volume from labels
                double Surfacearea = 4.0 * Math.PI * Radius * Radius;
                double Volume = 4.0 / 3.0 * Math.PI * Radius * Radius * Radius ;
                //run the code between these brackets 
                label1.Text = "Surface area = " + Surfacearea;
                label2.Text = "Volume = " + Volume;
                



            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //read Radius and Height  from textboxes
            double Radius = double.Parse(textBox1.Text);
            double Height = double.Parse(textBox2.Text);
            //read Surface area and Volume from labels
            double Surfacearea = 2.0 * (Length * Height + Length * Width + Height * Width);
            double Volume = Length * Height * Width;
            //run the code between these brackets 
            label1.Text = "Surface area = " + Surfacearea;
            label2.Text = "Volume = " + Volume;
        }
    }
}