using System;
using System.Collections.Generic;
using System.Drawing;



namespace WindowsFormsApplication1
{
    class Rectangulo : Figura
    {
      
       public Rectangulo (int x, int y):base(x,y)
        {

            largo = 100;
            ancho = 50;
            grosor = 4;
            color_pluma = Color.Black;

        }

        public override void Dibuja(Graphics g)
         {
             g.DrawRectangle(new Pen(color_pluma, grosor), x, y, largo, ancho);     
         }

         public override void ColoreaAzul(Graphics g) //Sobrecarga del Método ColoreaAzul
         {
             g.FillRectangle(new SolidBrush(Color.Blue), x, y, largo, ancho);
         }

         public override void ColoreaVerde(Graphics g) //Sobrecarga del Método ColoreaVerde
         {
             g.FillRectangle(new SolidBrush(Color.Green), x, y, largo, ancho);
         }

         public override void ColoreaRojo(Graphics g) //Sobrecarga del Método ColoreaRojo
         {
             g.FillRectangle(new SolidBrush(Color.Red), x, y, largo, ancho);
         }

         public override void ColoreaAmarillo(Graphics g) //Sobrecarga del Método ColoreaAmarillo
         {
             g.FillRectangle(new SolidBrush(Color.Yellow), x, y, largo, ancho);
         }







    }
}
