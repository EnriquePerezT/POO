using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Elipse: Figura
    {

        public Elipse (int x, int y):base(x,y) //Constructor
        {
            largo = 100;
            ancho = 50;
            grosor = 4;
            color_pluma = Color.Black;
        }

        public override void Dibuja(Graphics g) //Sobrecarga del Método Dibuja
        {
            Random aleatorio = new Random();
            Color colores = Color.FromArgb(aleatorio.Next(255), aleatorio.Next(255), aleatorio.Next(255));
            g.DrawEllipse(new Pen(color_pluma, grosor), x, y, largo, ancho);        
        }

        public override void ColoreaAzul(Graphics g) //Sobrecarga del Método ColoreaAzul
        {
           g.FillEllipse(new SolidBrush(Color.Blue),x, y, largo, ancho);
        }

        public override void ColoreaVerde(Graphics g) //Sobrecarga del Método ColoreaVerde
        {
            g.FillEllipse(new SolidBrush(Color.Green), x, y, largo, ancho);
        }

        public override void ColoreaRojo(Graphics g) //Sobrecarga del Método ColoreaRojo
        {
            g.FillEllipse(new SolidBrush(Color.Red), x, y, largo, ancho);
        }

        public override void ColoreaAmarillo(Graphics g) //Sobrecarga del Método ColoreaAmarillo
        {
            g.FillEllipse(new SolidBrush(Color.Yellow), x, y, largo, ancho);
        }







    }
}
