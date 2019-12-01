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

            var xFuncChange = new []
            {
                "kx + b",
                "|k|x| + b|",
                "k|x| + b",
                "|kx + b|",

                "a*x^2+b*x+c",
                "a*|x|^2 + b*x + c",
                "a*|x|^2 + b*|x| + c",
                "a*x^2 + b*|x| + c",
                "|a*x^2 + b*x + c|",
                "|a*|x|^2 + b*|x| + c|",
                "|a*|x|^2 + b*x + c|",
                "|a*x^2 + b*|x| + c|",

                "sin| x |",
                "|sin x|",
                "|sin| x ||",
            };
            xFuncSelector.Items.AddRange(xFuncChange);
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

        private double _xMin = -5;
        private double _xMax = 5;
        private double _yMin = -5;
        private double _yMax = 5;

        private void Button2_Click(object sender, EventArgs e) //the line 
        {
            _b = (double)nudB.Value;
            _k = (double)nudK.Value;

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

        private void drawFunction_module(Func<double, double> func)
        {
            var g = graphWind.CreateGraphics();

            int w = 0;
            float prevH = calcHeight(func, w);

            for (w = 1; w < graphWind.Width; w++)
            {
                var h = calcHeight(func, w);

                g.DrawLine(_redPen, w - 1, prevH, w, h);
                prevH = h;
            }
        }

        private float calcHeight(Func<double, double> func, int w)
        {
            var x = _xMin + (_xMax - _xMin) * w / graphWind.Width;

            var y = func(x);

            return (float)(graphWind.Height * (1 - (y - _yMin) / (_yMax - _yMin)));
        }

        private void Button3_Click(object sender, EventArgs e) //square function 
        {
            _a = (double)nudA.Value;
            _b = (double)nudB.Value;
            _c = (double)nudC.Value;

            drawFunction(squareFunc);
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

        private double squareFunc(double x)
        {
            return x * (_a * x + _b) + _c;
        }                                               //functions

        private Func<double, double> xFuncByName(string name)
        {
            switch(name)
            {
                case "kx + b":
                    return lineFunc;
                case "|k|x| + b|":
                    return (x) => Math.Abs(_k * Math.Abs(x) + _b);                  //only modules for kx+b/прямые
                case "k|x| + b":
                    return (x) => _k * Math.Abs(x) + _b;
                case "|kx + b|":
                    return (x) => Math.Abs(_k * x + _b);


                case "a*x^2+b*x+c":
                    return squareFunc;
                //case "a*|x|^2+b*x+c":                                              //only for parabolas/параболы  
                //    return (x) => _a * Math.Abs(Math.Pow(x, 2)) + _b * x + _c; ;
                //case "a*|x|^2 + b*|x| + c":
                //    return (x) => _a * Math.Abs(Math.Pow(x, 2)) + _b * Math.Abs(x) + _c; ;
                case "a*x^2 + b*|x| + c":
                    return (x) => _a * Math.Pow(x,2) + _b * Math.Abs(x) + _c;
                case "|a*x^2 + b*x + c|":
                    return (x) => Math.Abs(_a * Math.Pow(x, 2) + _b * x + _c);
                //case "|a*|x|^2 + b*|x| + c|":
                //    return (x) => Math.Abs(_a * Math.Abs(Math.Pow(x, 2)) + _b * Math.Abs(Math.Abs(x)) + _c);
                case "|a*|x|^2 + b*x + c|":
                    return (x) => Math.Abs(_a * Math.Abs(Math.Pow(x, 2)) + _b * Math.Abs(x) + _c);
                case "|a*x^2 + b*|x| + c|":
                    return (x) => Math.Abs(_a * Math.Pow(x, 2) + _b * Math.Abs(Math.Abs(x)) + _c);


                case "sin| x |":
                    return (x) => Math.Abs(Math.Sin(x)) * _a;                       //only for sinusoids/синусоиды
                case "|sin x|":
                    return (x) => Math.Abs(Math.Sin(x) * _a);
                case "|sin| x ||":
                    return (x) => Math.Abs(Math.Abs(Math.Sin(x) * _a));


                default:
                    throw new NotImplementedException();
                                                                
            }
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            var xFuncName = (string)xFuncSelector.SelectedItem;
            var yFuncName = (string)yFuncSelector.SelectedItem;

            if (xFuncName == null || yFuncName == null)
                return;

            var xFunc = xFuncByName(xFuncName);

            _a = (double)nudA.Value;
            _b = (double)nudB.Value;
            _c = (double)nudC.Value;
            _k = (double)nudK.Value;

            drawFunction(xFunc);

            //drawFunction((x) => -xFunc(x));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private double lineFunc_SINX(double x)
        {
            return Math.Sin(x) * _a;
        }
        private void Button4_Click(object sender, EventArgs e) //sinusoids function
        {
            _a = (double)nudA.Value;
            drawFunction(lineFunc_SINX);
        }
    }
        
 }

    

