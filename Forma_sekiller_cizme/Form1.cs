using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forma_sekiller_cizme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g; 
        Font fontum = new Font("tahoma", 15); 
        SolidBrush  fircam = new SolidBrush(Color.Blue); 
        Pen  kalemim = new Pen(Color.Blue, 2); 

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox1.Text)
            {//Comboda seçili olan
                case "Çember"://Çember ise
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);  
                        g.DrawEllipse(kalemim, 120, 100, 80, 80); 
                        g.Dispose(); 
                        break;
                    }
                case "Elips":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawEllipse(kalemim, 120, 100, 100, 65);
                        g.Dispose();
                        break;
                    }
                case "Kare":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawRectangle(kalemim, 120, 100, 80, 80);
                        g.Dispose();
                        break;
                    }
                case "Dikdörtgen":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawRectangle(kalemim, 120, 100, 100, 65);
                        g.Dispose();
                        break;
                    }
                case "Yazı yaz":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawString("Murat Bilginer Kişisel Web Sayfası", fontum, fircam, 70, 100);
                        g.Dispose();
                        break;
                    }
                case "Yay":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawArc(kalemim, 120, 80, 50, 50, 90, 250);
                        g.Dispose();
                        break;
                    }
                case "Serbest Yay":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawBezier(kalemim, 100, 75, 135, 100, 170, 100, 200, 75);
                        g.Dispose();
                        break;
                    }
                case "Serbest Çizim":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        Point[] p1 = { new Point(100, 70), new Point(125, 100), new Point(150, 150), new Point(200, 60) };
                        g.DrawCurve(kalemim, p1, 1);
                        g.Dispose();
                        break;
                    }
                case "Çizgi":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawLine(kalemim, 100, 100, 300, 100);
                        g.Dispose();
                        break;
                    }
                case "Çeyrek Çember":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        g.DrawPie(kalemim, 100, 100, 150, 100, 200, 100);
                        g.Dispose();
                        break;
                    }
                case "Çokgen":
                    {
                        g = this.CreateGraphics();
                        g.Clear(this.BackColor);
                        Point[] p2 = { new Point(150, 100), new Point(200, 150), new Point(200, 200), new Point(150, 250), new Point(100, 150), new Point(100, 110) };
                        g.DrawPolygon(kalemim, p2);
                        g.Dispose();
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
