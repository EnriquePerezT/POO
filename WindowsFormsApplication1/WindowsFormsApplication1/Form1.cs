using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PROGRAMA REALIZADO POR PEREZ AMADOR ENRIQUE.
//Núm. Control: 16212062
//Instituto Tecnológico de Tijuana.
//Programación Orientada a Objetos
//Profesor: Jose Mario García.

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private List<Figura> figuras; //Creacion de lista que almacena las figuras creadas

        public Form1()
        {
            InitializeComponent();
            figuras = new List<Figura>();
            linkLabel1.Links.Add(0, 0, "www.twitter.com/EnriquePerezBC"); //Link que lleva a URL indicada           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) //Dibujar Rectangulo al dar click izquierdo
            {
                Graphics g = CreateGraphics();
                Rectangulo r = new Rectangulo(e.X, e.Y);
                r.Dibuja(g);
                figuras.Add(r);

                if (this.azulToolStripMenuItem.Checked == true) 
                {
                    r.ColoreaAzul(g);
                }
                else if (this.verdeToolStripMenuItem.Checked == true)
                {
                    r.ColoreaVerde(g);
                }
                else if (this.rojoToolStripMenuItem.Checked == true)
                {
                    r.ColoreaRojo(g);
                }
                else if (this.amarilloToolStripMenuItem.Checked == true)
                {
                    r.ColoreaAmarillo(g);
                }

            }
            else if (e.Button == MouseButtons.Right) //Dibujar Elipse al dar click Derecho
            {
                Graphics g = CreateGraphics();
                Elipse elip = new Elipse(e.X,e.Y);
                elip.Dibuja(g);
                figuras.Add(elip);

                if (this.azulToolStripMenuItem.Checked == true)
                {
                    elip.ColoreaAzul(g);
                }
                else if (this.verdeToolStripMenuItem.Checked == true)
                {
                    elip.ColoreaVerde(g);
                }
                else if (this.rojoToolStripMenuItem.Checked == true)
                {
                    elip.ColoreaRojo(g);
                }
                else if (this.amarilloToolStripMenuItem.Checked == true)
                {
                    elip.ColoreaAmarillo(g);
                }
                  
            }

            else //Mostrar menú al dar botón de enmedio 
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }

            //Contador de Figuras
            int contador = figuras.Count(); 
            lblFiguras.Text = "Numero de dibujos:" + contador;

        }

        private void Form1_Paint(object sender, PaintEventArgs e) //Instruccion para cargar las figuras (Evento Paint de la forma) 
        {
            foreach (Figura c in figuras)
            {
               c.Dibuja(CreateGraphics());
            }
        }


        private void azulToolStripMenuItem_Click(object sender, EventArgs e) //Evento al Seleccionar el color Azul del Menú
        {
            this.azulToolStripMenuItem.Checked = true; // Activa la opción del color Azul.
            this.verdeToolStripMenuItem.Checked = false;
            this.amarilloToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e) //Evento al Seleccionar el color Verde del Menú
        {
            this.verdeToolStripMenuItem.Checked = true; // Activa la opción del color Verde.
            this.azulToolStripMenuItem.Checked = false;
            this.amarilloToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e) //Evento al Seleccionar el color Rojo del Menú
        {
            this.rojoToolStripMenuItem.Checked = true; // Activa la opción del color Rojo
            this.azulToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
            this.amarilloToolStripMenuItem.Checked = false;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.amarilloToolStripMenuItem.Checked = true; // Activa la opción del color Amarillo
            this.azulToolStripMenuItem.Checked = false;
            this.verdeToolStripMenuItem.Checked = false;
            this.rojoToolStripMenuItem.Checked = false;
        }
    


        
        //BOTONES
        private void btnSalir_Click(object sender, EventArgs e) //Botón para cerrar la ventana(Forma)
        {
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e) //Boton para cambiar color a la forma
        {
            Random aleatorio = new Random();
            Color colores = Color.FromArgb(aleatorio.Next(255), aleatorio.Next(255), aleatorio.Next(255));
            this.BackColor = colores;
        }

        public void btnLimpiar_Click(object sender, EventArgs e) //Boton limpiar 
        {
            figuras.Clear();  //Se limpia la lista que guarda las figuras dibujadas
            lblFiguras.Text = " ";           
            this.BackColor = Color.WhiteSmoke;
            this.BackColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Evento al dar clic en Hipervinculo
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString()); //Proceso que lleva al hipervínculo
        }

   
    }
}
