using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlusPractice
{
    public partial class Form1 : Form
    {
        private Point rectangleToLeft = new Point(0, 0);
        private Size rectangleSize = new Size(100, 200);
        private Point ellipseToLeft = new Point(50, 200);
        private Size ellipseSize = new Size(200, 100);
        private Pen bluePen = new Pen(Color.Blue, 3);
        private Pen redPen = new Pen(Color.Red, 2);

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics dc = e.Graphics;

            if (e.ClipRectangle.Top < 350 && e.ClipRectangle.Left < 250)
            {
                Rectangle rectangleArea =
                    new Rectangle(rectangleToLeft, rectangleSize);
                Rectangle ellipseArea =
                    new Rectangle(ellipseToLeft, ellipseSize);

                dc.DrawRectangle(bluePen, rectangleArea);
                dc.DrawEllipse(redPen, ellipseArea);
            }
        }
    }
}
