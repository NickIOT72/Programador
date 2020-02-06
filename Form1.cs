using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1_C
{
    public partial class Form1 : Form
    {
        int NumeroImagenIntro = 1;
        int MaxNumImagenIntro = 16;
        int MinNumImagenIntro = 1;
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(Form1_WindowStateTrigger);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Height = 800;
            //this.Width = 1000;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Text = "Programador TECNAS";
            UpdateScreen();
            
        }

        private void Form1_WindowStateTrigger(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //MessageBox.Show("FORM1 MINIMIZED!");
            }

            if (this.WindowState == FormWindowState.Normal)
            {
                ScroolText.Controls.Clear();
                UpdateScreen();

            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                UpdateScreen();
            }
        }

        public void UpdateScreen()
        {
            this.PanelTitulo.Width = 97 * this.Width / 100;
            this.PanelTitulo.Location = new Point(1 * this.Width / 100, 10);
            this.LabelProg.Location = new Point(this.PanelTitulo.Width - this.LabelProg.Width - 10, 10);
            this.PanelConfg.Location = new Point(1 * this.Width / 100, this.PanelTitulo.Height + 15);
            this.PanelOpciones.Height = this.Height - ( 15 + this.PanelTitulo.Height + 2*this.PanelConfg.Height);
            this.PanelOpciones.Location = new Point(1 * this.Width / 100, 15 + this.PanelTitulo.Height + this.PanelConfg.Height);
            this.PanelForText.Height = this.PanelOpciones.Height + this.PanelConfg.Height;
            this.PanelForText.Width = this.Width - this.PanelConfg.Width - 2 * this.Width/100 - 25;
            this.PanelForText.Location = new Point(2 * this.Width / 100 + this.PanelOpciones.Width, this.PanelTitulo.Height + 15);
            this.ScroolText.Width = 95 * this.PanelForText.Width / 100;
            this.ScroolText.Height = 95 * this.PanelForText.Height / 100;
            this.ScroolText.Location = new Point(this.PanelConfg.Width + 2 * this.Width / 100 + 5 * this.PanelForText.Width / 200, this.PanelTitulo.Height + 15 + 5 * this.PanelForText.Height / 200);
            ScroolText.Controls.Clear();
            for (int i = MinNumImagenIntro; i <= MaxNumImagenIntro; i++)
            {
                string LocationOfIntroImage = "C:\\Users\\nico_\\Documents\\TECNAS\\Programador\\Interfaz_VS\\Imagenes\\articulo_cientifico-page-" + i.ToString("D") + ".jpg";
                ShowImages(LocationOfIntroImage);
            }
        }

        public void ShowImages(string Location)
        {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Image = Image.FromFile(Location);
            pb.Image = new Bitmap(pb.Image, ScroolText.Width, pb.Image.Height);
            ScroolText.AutoScroll = true;
            ScroolText.Controls.Add(pb);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (NumeroImagenIntro < MaxNumImagenIntro)
            {
                NumeroImagenIntro++;
                string LocationOfIntroImage = "C:\\Users\\nico_\\Documents\\TECNAS\\Programador\\Interfaz_VS\\Imagenes\\Intro" + NumeroImagenIntro.ToString("D") + ".jpg";
                ShowImages(LocationOfIntroImage);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (NumeroImagenIntro > MinNumImagenIntro)
            {
                NumeroImagenIntro--;
                string LocationOfIntroImage = "C:\\Users\\nico_\\Documents\\TECNAS\\Programador\\Interfaz_VS\\Imagenes\\Intro" + NumeroImagenIntro.ToString("D") + ".jpg";
                ShowImages(LocationOfIntroImage);
            }
        }
    }
}
