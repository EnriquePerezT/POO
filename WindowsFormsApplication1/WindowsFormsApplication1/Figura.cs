using System;
using System.Collections.Generic;
using System.Drawing;



namespace WindowsFormsApplication1
{

    abstract class Figura //Clase abstracta Figura Principal
    {
       protected int x, y, largo, ancho, grosor;
       protected Color color_pluma, color_brocha;

         public Figura (int x, int y) //Constructor
        {
            this.x = x;
            this.y = y;
            largo = 100;
            ancho = 50;
            grosor = 3;
            color_pluma = Color.Black;            
        }

         public abstract void Dibuja(Graphics g); //Metodo Abstracto Dibuja

         public virtual void ColoreaAzul(Graphics g)
         {
             g.FillRectangle(new SolidBrush(color_brocha), x, y, largo, ancho);
         }

         public virtual void ColoreaVerde(Graphics g)
         {
             g.FillRectangle(new SolidBrush(color_brocha), x, y, largo, ancho);
         }

         public virtual void ColoreaRojo(Graphics g)
         {
             g.FillRectangle(new SolidBrush(color_brocha), x, y, largo, ancho);
         }

         public virtual void ColoreaAmarillo(Graphics g)
         {
             g.FillRectangle(new SolidBrush(color_brocha), x, y, largo, ancho);
         }

    }
}
