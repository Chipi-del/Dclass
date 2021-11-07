using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) Рассчёт(); };
          

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void Рассчёт()
        {

        n: string расстояние_до_цели = Interaction.InputBox("Введите расстояние до цели", " ");
            if (расстояние_до_цели == "")
            { goto n; }
          n1: string скорость_полёта_снаряда = Interaction.InputBox("Введите скорость полёта снаряда", " ");
            if (скорость_полёта_снаряда == "")
            { goto n1; }
            
            ;
            double ugol = Math.Sin(double.Parse(расстояние_до_цели)*9.8 / Math.Pow(double.Parse(скорость_полёта_снаряда),2));
            MessageBox.Show(Convert.ToString(ugol));

        }
    }
}
