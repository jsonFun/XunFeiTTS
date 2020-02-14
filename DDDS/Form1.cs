using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DDDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a <= 10)
            {
                textBox1.Text = a.ToString();
              
                Bgcolor(a);
                a++;
            }
            else
            {
                a = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            int ss = 0;
            Random ran = new Random();
            ss = ran.Next(0, 10);
            textBox1.Text = ss.ToString();
            BgcolorPlay(ss);
           
        }

        public void Bgcolor(int ss)
        {
            switch (ss)
            {
                case 0:
                   this.BackColor = Color.Red;
                    break;
                case 1:
                    this.BackColor = Color.Blue;
                    break;
                case 2:
                    this.BackColor = Color.Black;
                    break;
                case 3:
                    this.BackColor = Color.Yellow;
                    break;
                case 4:
                    this.BackColor = Color.Green;
                    break;
                case 5:
                    this.BackColor = Color.Pink;
                    break;
                case 6:
                    this.BackColor = Color.Orange;
                    break;
                case 7:
                    this.BackColor = Color.Cyan;
                    break;
                case 8:
                    this.BackColor = Color.Violet;
                    break;
                case 9:
                    this.BackColor = Color.YellowGreen;
                    break;
                case 10:
                    this.BackColor = Color.OrangeRed;
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
            textBox1.ForeColor = this.BackColor;
        }

        public void BgcolorPlay(int ss)
        {
            switch (ss)
            {
                case 0:
                    this.BackColor = Color.Red;
                    textBox1.ForeColor = this.BackColor;
                    
                    PLayer.NewMethod("这个数字读: 0 。 颜色是红色");
                    break;
                case 1:
                    this.BackColor = Color.Blue;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 1 。 颜色是蓝色");
                    break;
                case 2:
                    this.BackColor = Color.Black;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 2 。 颜色是黑色");
                    break;
                case 3:
                    this.BackColor = Color.Yellow;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 3 。 颜色是黄色");
                    break;
                case 4:
                    this.BackColor = Color.Green;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 4 。 颜色是绿色");
                    break;
                case 5:
                    this.BackColor = Color.Pink;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 5 。 颜色是粉色");
                    break;
                case 6:
                    this.BackColor = Color.Orange;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 6 。 颜色是橙色");
                    break;
                case 7:
                    this.BackColor = Color.Cyan;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 7 。 颜色是青色");
                    break;
                case 8:
                    this.BackColor = Color.Violet;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 8 。 颜色是紫色");
                    break;
                case 9:
                    this.BackColor = Color.YellowGreen;
                    PLayer.NewMethod("这个数字读: 9 。 颜色是黄绿色");
                    break;
                case 10:
                    this.BackColor = Color.OrangeRed;
                    textBox1.ForeColor = this.BackColor;
                    PLayer.NewMethod("这个数字读: 10 。 颜色是橙红色");
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
            if(this.BackColor != Color.White)
            {
                button1.ForeColor = this.BackColor;
                button2.ForeColor = this.BackColor;
                button3.ForeColor = this.BackColor;
            }
        }

        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            this.Region = new Region(FormPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rect">窗体大小</param>
        /// <param name="radius">圆角大小</param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arcRect, 180, 90);//左上角

            arcRect.X = rect.Right - diameter;//右上角
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = rect.Bottom - diameter;// 右下角
            path.AddArc(arcRect, 0, 90);

            arcRect.X = rect.Left;// 左下角
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                SetWindowRegion();
            }
            else
            {
                this.Region = null;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
