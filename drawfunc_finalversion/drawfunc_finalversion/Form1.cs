﻿using System;
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
        private Dictionary<string, Func<double, double>> _funcList;

        public frmMain()
        {
            InitializeComponent();
            _funcList = new Dictionary<string, Func<double, double>>()
            {
                { "kx + b", (x) => _k * x + _b },               
                { "k|x| + b", (x) => _k* Math.Abs(x) + _b },
                { "|kx + b|", (x) => Math.Abs(_k* x + _b) },
                { "|k|x| + b|", (x) => Math.Abs(_k* Math.Abs(x) + _b) },            

                { "a*x^2+b*x+c", (x) => x * (_a * x + _b) + _c },               
                { "a*x^2 + b*|x| + c", (x) => _a* Math.Pow(x,2) + _b* Math.Abs(x) + _c },
                { "|a*x^2 + b*x + c|", (x) => Math.Abs(_a* Math.Pow(x, 2) + _b* x + _c) },
                { "|a*x^2 + b*|x| + c|", (x) => Math.Abs(_a* Math.Pow(x, 2) + _b* Math.Abs(Math.Abs(x)) + _c) },

                { "a * sin (kx) ", (x) => _a * Math.Sin(_k * x) },
                { "a * sin (k*| x |)", (x) => _a * Math.Sin(_k * (Math.Abs(x))) },
                { "a * |sin x|", (x) => _a * Math.Abs(Math.Sin(_k * x)) },
                { "a * |sin| x ||", (x) => _a * Math.Abs(Math.Sin(_k * (Math.Abs(x)))) },

                { "y = a*√(k*X + b)", (x) => _a * Math.Sqrt(_k * x + _b) },
                { "y = a*√(k*|X| + b)", (x) => _a * Math.Sqrt(_k * Math.Abs(x) + _b) },
                { "y = |a*√(k*X + b)|", (x) => Math.Abs(_a * Math.Sqrt(_k * x + _b)) },
                { "y = |a*√(k*|X| + b)|", (x) => Math.Abs(_a * Math.Sqrt(_k * Math.Abs(x) + _b)) },

  
            };

            xFuncSelector.Items.AddRange(_funcList.Keys.ToArray());
            xFuncSelector.SelectedIndex = 0;

            var yFuncChange = new[]
            {
                "y",
                "|y|",
            };
            yFuncSelector.Items.AddRange(yFuncChange);
            yFuncSelector.SelectedIndex = 0;
        }

        private void GraphWind_Click(object sender, EventArgs e)
        {
            Graphics g = graphWind.CreateGraphics();    //horizontal axis X//

            // graphWind.Width
            // graphWind.Height
            //axis X//
            Pen myPen = new Pen(Color.Black);
            float xmin = 0;
            float ymin = graphWind.Height / 2;
            float xmax = graphWind.Width;
            float ymax = graphWind.Height / 2;
            g.DrawLine(myPen, xmin, ymin, xmax, ymax);
            
            //axis Y//
            _ = new Pen(Color.Black);
            float xmin1 = graphWind.Width / 2;
            float ymin1 = 0;
            float xmax1 = graphWind.Width / 2;
            float ymax1 = graphWind.Height;
            g.DrawLine(myPen, xmin1, ymin1, xmax1, ymax1);

            textBox3.Text = "^Y";
            textBox4.Text = ">X";

            //grid//
            //horizontal//
            _ = new Pen(Color.Gray);
            float xmin2 = 0;
            float y0 = graphWind.Height / 10;
            float xmax2 = graphWind.Width;
            g.DrawLine(myPen, xmin2, y0, xmax2, y0);          
            
            float y02 = (2 * graphWind.Height) / 10;        
            g.DrawLine(myPen, xmin2, y02, xmax2, y02);         
            
            float y03 = (3 * graphWind.Height) / 10;
            g.DrawLine(myPen, xmin2, y03, xmax2, y03);

            float y04 = (4 * graphWind.Height) / 10;
            g.DrawLine(myPen, xmin2, y04, xmax2, y04);

            float y06 = (6 * graphWind.Height) / 10;
            g.DrawLine(myPen, xmin2, y06, xmax2, y06);

            float y07 = (7 * graphWind.Height) / 10;
            g.DrawLine(myPen, xmin2, y07, xmax2, y07);

            float y08 = (8 * graphWind.Height) / 10;
            g.DrawLine(myPen, xmin2, y08, xmax2, y08);

            float y09 = (9 * graphWind.Height) / 10;
            g.DrawLine(myPen, xmin2, y09, xmax2, y09);

            //vertical//
            float ymin3 = 0;
            float x1 = graphWind.Height / 10;
            float ymax3 = graphWind.Width;
            g.DrawLine(myPen, x1, ymin3, x1, ymax3);

            float x12 = (2 * graphWind.Height) / 10;
            g.DrawLine(myPen, x12, ymin3, x12, ymax3);

            float x13 = (3 * graphWind.Height) / 10;
            g.DrawLine(myPen, x13, ymin3, x13, ymax3);

            float x14 = (4 * graphWind.Height) / 10;
            g.DrawLine(myPen, x14, ymin3, x14, ymax3);

            float x16 = (6 * graphWind.Height) / 10;
            g.DrawLine(myPen, x16, ymin3, x16, ymax3);

            float x17 = (7 * graphWind.Height) / 10;
            g.DrawLine(myPen, x17, ymin3, x17, ymax3);
            
            float x18 = (8 * graphWind.Height) / 10;
            g.DrawLine(myPen, x18, ymin3, x18, ymax3);
            
            float x19 = (9 * graphWind.Height) / 10;
            g.DrawLine(myPen, x19, ymin3, x19, ymax3);
        }

        private double _xMin = -10;
        private double _xMax = 10;
        private double _yMin = -10;
        private double _yMax = 10;


        private void Button1_Click(object sender, EventArgs e)
        {
            var g = graphWind.CreateGraphics();
            g.Clear(Color.White);
        }
        private void Button2_Click(object sender, EventArgs e) //the line 
        {
            textBox1.Text = "y = kx + b";

            _b = (double)nudB.Value;
            _k = (double)nudK.Value;

            drawFunction_base(lineFunc);
        }
        private void Button3_Click(object sender, EventArgs e) //square function 
        {
            textBox1.Text = "y = a*x ^ 2 + b*x + c";

            _a = (double)nudA.Value;
            _b = (double)nudB.Value;
            _c = (double)nudC.Value;

            drawFunction_base(squareFunc);
        }
        private void Button4_Click(object sender, EventArgs e) //sinusoids function
        {
            textBox1.Text = "y = a * sin(k * X)";

            _a = (double)nudA.Value;
            _k = (double)nudK.Value;
            drawFunction_base(lineFunc_SINX);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "y = a / (k * X + b)";

            _a = (double)nudA.Value;
            _b = (double)nudB.Value;
            _k = (double)nudK.Value;
            drawFunction_base(sqrtFunc);
        }
        private void drawFunction_base(Func<double, double> func, ClipY clip = ClipY.None)
        {
            var g = graphWind.CreateGraphics();

            int w = 0;
            var prevH = calcHeight(func, w, clip);

            for (w = 1; w < graphWind.Width; w++)
            {
                var h = calcHeight(func, w, clip);
                if (prevH.HasValue && h.HasValue)
                    g.DrawLine(_bluePen, w, prevH.Value, w, h.Value);
                prevH = h;

            }
        }
        private void drawFunction(Func<double, double> func, ClipY clip = ClipY.None)
        {
            var g = graphWind.CreateGraphics();

            _redPen.Width = 3;
            int w = 0;
            var prevH = calcHeight(func, w, clip);

            for (w = 1; w < graphWind.Width; w++)
            {
                var h = calcHeight(func, w + 1, clip);
                if(prevH.HasValue && h.HasValue)
                    g.DrawLine(_redPen, w, prevH.Value, w, h.Value);
                prevH = h;
                
            }
        }

        private float? calcHeight(Func<double, double> func, int w, ClipY clip)
        {  
            var x = _xMin + (_xMax - _xMin) * w / graphWind.Width;

            var y = func(x);

            if(clip == ClipY.Up && y > 0)
                return null;

            if (clip == ClipY.Down && y < 0)
                return null;

            return (float)(graphWind.Height * (1 - (y - _yMin) / (_yMax - _yMin)));
        }

        public enum ClipY
        {
            None,
            Up,
            Down
        }

        private void GraphWind_Resize(object sender, EventArgs e)
        {


        }

        private Pen _blackPen = new Pen(Color.Black);
        private Pen _bluePen = new Pen(Color.Blue);
        private Pen _redPen = new Pen(Color.Red);

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

        public string LineFunc_change { get; private set; }

        private double lineFunc(double x)               //functions
        {
            return _k * x + _b;
        }
        private double lineFunc_SINX(double x)
        {
            return Math.Sin(_k * x) * _a;
        }
        private double squareFunc(double x)
        {
            return x * (_a * x + _b) + _c;
        }
        private double sqrtFunc(double x)
        {
            return _a * Math.Sqrt(_k * x + _b);
        }
        private double hyperbolaFunc(double x)
        {
            return _a / (_k * x + _b);
        }
                                                        //functions

        private Func<double, double> xFuncByName(string name)
        {
            return _funcList[name];
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            var xFuncName = (string)xFuncSelector.SelectedItem;
            var yFuncName = (string)yFuncSelector.SelectedItem;
           
            textBox2.Text = (string)yFuncSelector.SelectedItem + " = " + (string)xFuncSelector.SelectedItem;

            if (xFuncName == null || yFuncName == null)
                return;

            var xFunc = xFuncByName(xFuncName);

            _a = (double)nudA.Value;
            _b = (double)nudB.Value;
            _c = (double)nudC.Value;
            _k = (double)nudK.Value;

            if(yFuncName == "|y|")
            {
                drawFunction(xFunc, ClipY.Down);
                drawFunction((x) => -xFunc(x), ClipY.Up);
            }
            else
            {
                drawFunction(xFunc, ClipY.None);
            }
            textBox3.Text = "^Y";
            textBox4.Text = ">X";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }               

        private void Draw_axes_Click(object sender, EventArgs e)
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

    }

}