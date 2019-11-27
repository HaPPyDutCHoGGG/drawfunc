using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawfunctionn
{
    public partial class frmMain : Form //the CENTRE :(graphWind.Width / 2; graphWind.Height / 2) for programm; (0;0) for user//
                                                        
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void GraphWind_Click(object sender, EventArgs e)
        {
            Graphics g = graphWind.CreateGraphics();    //horizontal axis X//

            // graphWind.Width
            // graphWind.Height

            Pen myPen = new Pen(Color.Black);                                                                                                    
                float xmin = 0;
                float ymin = graphWind.Height / 2;
                float xmax = graphWind.Width;
                float ymax = graphWind.Height / 2;
            g.DrawLine(myPen, xmin, ymin, xmax, ymax);

                                                        //horizontal axis Y//
            Pen myPen1 = new Pen(Color.Black);           
                float xmin1 = graphWind.Width / 2;
                float ymin1 = 0;
                float xmax1 = graphWind.Width / 2;
                float ymax1 = graphWind.Height;
            g.DrawLine(myPen1, xmin1, ymin1, xmax1, ymax1);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphics g = graphWind.CreateGraphics();    //i dont know wat its//
            Pen myPen = new Pen(Color.Blue);
            int nmbInterv = 100;//100//
                float xmin = 0;//0//
                float xmax = 2;//2//
                float ymin = 0;//0//
                float ymax = 4;//4//
            float xstep = (xmax - xmin) / nmbInterv;
            float kx = graphWind.Width / xmax;
            float ky = graphWind.Height / ymax;
            float x1 = xmin;
            float y1 = x1 * x1, x2, y2;
            for(int i = 0; i < nmbInterv; i++)
            {
                x2 = x1 + xstep;
                y2 = x2 * x2;
                g.DrawLine(myPen, kx * x1, graphWind.Height - ky * y1, kx * x2, graphWind.Height - ky * y2);
                x1 = x2;
                y1 = y2;
            }
        }

        private double _xMin = -3;
        private double _xMax = 3;
        private double _yMin = -3;
        private double _yMax = 3;

        private void Button2_Click(object sender, EventArgs e) //the line
        {
            _b = double.Parse(_lineB.Text);
            _k = double.Parse(_lineK.Text);

            drawFunction(lineFunc);
        }

        private void drawFunction(Func<double, double> func)
        {
            var g = graphWind.CreateGraphics();

            int w = 0;
            float prevH = calcHeight(func, w);

            for (w = 1; w < graphWind.Width; w++)
            {
                var h = calcHeight(func, w);

                g.DrawLine(_bluePen, w - 1, prevH, w, h);
                prevH = h;
            }
        }

        private float calcHeight(Func<double, double> func, int w)
        {
            var x = _xMin + (_xMax - _xMin) * w / graphWind.Width;

            var y = func(x);

            return (float)(graphWind.Height * (1 - (y - _yMin) / (_yMax - _yMin)));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _a = double.Parse(squareA.Text);
            _b = double.Parse(squareB.Text);
            _c = double.Parse(squareC.Text);

            drawFunction(squareFunc);
        }

        private void GraphWind_Resize(object sender, EventArgs e)
        {
           

        }

        private Pen _blackPen = new Pen(Color.Black);
        private Pen _bluePen = new Pen(Color.Blue);

        private void GraphWind_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void GraphWind_SizeChanged(object sender, EventArgs e)
        {
            var g = graphWind.CreateGraphics();    //horizontal axis X//

            // graphWind.Width
            // graphWind.Height

            g.Clear(Color.White);

            float xmin = 0;                             
            float ymin = graphWind.Height / 2;
            float xmax = graphWind.Width;
            float ymax = graphWind.Height / 2;
            g.DrawLine(_blackPen, xmin, ymin, xmax, ymax);

                                                         //axis Y//
            float xmin1 = graphWind.Width / 2;                          
            float ymin1 = 0;
            float xmax1 = graphWind.Width / 2;
            float ymax1 = graphWind.Height;
            g.DrawLine(_blackPen, xmin1, ymin1, xmax1, ymax1);
        }
        
        private double _a = 1;
        private double _b = 1;
        private double _c = 1;
        private double _k = 1;

        private double lineFunc(double x)
        {
            return _k * x + _b;
        }

        private double squareFunc(double x)
        {
            return x * (_a * x + _b) + _c;
        }

        private void  FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            double b = double.Parse(squareB.Text);//for parabola   
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            double b1 = double.Parse(_lineK.Text);//for line
        }
        
        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
