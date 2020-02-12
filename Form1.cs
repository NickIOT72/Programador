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
            //Poner no visibles las opciones del menu
            BorrarPantalla();
            //////

            this.Height = 800;
            this.Width = 1000;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Text = "Programador TECNAS";
            this.LeftButton.Visible = false;
            this.RigthButton.Visible = false;
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
                ScroolText.Controls.Clear();
                UpdateScreen();
            }
        }

        public void UpdateScreen()
        {
            // Variables y objetos del titulo
            int PuntoX1 = 1 * this.Width / 100;
            int Espacio = 10;
            this.PanelTitulo.Visible = true;
            this.PanelTitulo.Width = 97 * this.Width / 100;
            this.PanelTitulo.Location = new Point(PuntoX1, Espacio);
            // Variables y objetos del segundo titulo
            int PuntoX2 = this.PanelTitulo.Width - PuntoX1 - this.LabelProg.Width;
            int PuntoY1 = this.PanelTitulo.Height + Espacio * 30 / 20;
            this.LabelProg.Visible = true;
            this.LabelProg.Location = new Point(PuntoX2, Espacio);
            // Seteo de Panel de Configuraciones
            this.PanelConfg.Visible = true;
            this.PanelConfg.Height = 8 * this.Height / 100;
            this.PanelConfg.Location = new Point(PuntoX1, PuntoY1);
            // Seteo de Panel de Opciones
            ///////////////////int PuntoX3 = this.Height - (15 + this.PanelTitulo.Height + 2 * this.PanelConfg.Height);
            int PuntoY3 = 15 + this.PanelTitulo.Height + this.PanelConfg.Height;
            this.PanelOpciones.Height = this.Height - (15 + this.PanelTitulo.Height + 2*this.PanelConfg.Height); //;
            this.PanelOpciones.Location = new Point(PuntoX1, PuntoY3);
            this.PanelOpciones.Visible = true;

            this.PanelForText.Visible = true;
            this.PanelForText.Height = this.PanelOpciones.Height + this.PanelConfg.Height;
            this.PanelForText.Width = this.Width - this.PanelConfg.Width - 2 * this.Width/100 - 25;
            this.PanelForText.Location = new Point(2 * this.Width / 100 + this.PanelOpciones.Width, this.PanelTitulo.Height + 15);
            
            this.ScroolText.Visible = true;
            this.ScroolText.Width = 95 * this.PanelForText.Width / 100;
            this.ScroolText.Height = 95 * this.PanelForText.Height / 100;
            this.ScroolText.Location = new Point(this.PanelConfg.Width + 2 * this.Width / 100 + 5 * this.PanelForText.Width / 200, this.PanelTitulo.Height + 15 + 5 * this.PanelForText.Height / 200);
            
            this.BotonSalir.Visible = true;
            this.BotonSalir.Width = 80 * this.PanelOpciones.Width / 100;
            this.BotonSalir.Height = 40;
            this.BotonSalir.Location = new Point(1 * this.Width / 100 + 5 * this.PanelOpciones.Width / 100, 60 * this.Height / 100);

            this.PanelBlancoOpc.Visible = true;
            this.PanelBlancoOpc.Width = 80 * this.PanelOpciones.Width / 100;
            this.PanelBlancoOpc.Height = 80*this.PanelOpciones.Height/100;
            this.PanelBlancoOpc.Location = new Point(1 * this.Width / 100 + 5 * this.PanelOpciones.Width / 100, 3 * this.Height / 100);

            this.BotonUp.Visible = true;
            this.BotonUp.Width = 70 * this.PanelOpciones.Width / 100;
            this.BotonUp.Height = 40;
            this.BotonUp.Location = new Point(1 * this.Width / 100 + 7 * this.PanelOpciones.Width / 100, 0 * this.Height / 100);
            this.BotonUp.

            /* ScroolText.Controls.Clear();
            for (int i = MinNumImagenIntro; i <= MaxNumImagenIntro; i++)
            {
                string LocationOfIntroImage = "C:\\Users\\nico_\\Documents\\TECNAS\\Programador\\Interfaz_VS\\Imagenes\\articulo_cientifico-page-" + i.ToString("D") + ".jpg";
                ShowImages(LocationOfIntroImage);
            }*/
        }

        public void BorrarPantalla()
        {
            this.PanelTitulo.Visible = false;
            this.LabelProg.Visible = false;
            this.PanelConfg.Visible = false;
            this.PanelOpciones.Visible = false;
            this.PanelForText.Visible = false;
            this.ScroolText.Visible = false;
            this.BotonSalir.Visible = false;
            this.PanelBlancoOpc.Visible = false;
            this.BotonUp.Visible = false;
            this.BotonDown.Visible = false;
            this.BotonConsid.Visible = false;
            this.BotonConsid1.Visible = false;
            this.BotonConsid3.Visible = false;
            this.BotonConsid4.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
