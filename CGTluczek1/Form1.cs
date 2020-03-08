using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGTluczek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Original image backup and Polyline array representation
        private Bitmap originalImage;
        public static Polyline pLL;
        // utility methods
        private void resetFuncFil()
        {
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics g = Graphics.FromImage(pictureBox2.Image);
            g.Clear(Color.White);
            for (int i = 0; i < 256; i++)
            {
                ((Bitmap)pictureBox2.Image).SetPixel(i, 255 - i, Color.Red);
            }
            pLL = new Polyline();
        }

        public static int Clamp(int Value, int Max, int Min)
        {
            Value = Value > Max ? Max : Value;
            Value = Value < Min ? Min : Value;
            return Value;
        }
        // event handlers
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);
                pictureBox1.Image = originalImage;
            }
            resetFuncFil();
        }

        private void ButtonGray_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image, FilterFunction.MakeGrayScale);
        }

        private void ButtonRevert_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originalImage;
        }

        private void ButtonInverse_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image, FilterFunction.Inverse);
        }

        private void ButtonBright_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image,FilterFunction.BrghtCorr);
        }

        private void ButtonBrght2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image,FilterFunction.BrghtCorrD);
        }

        private void ButtonGamma_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image, FilterFunction.GammaUp);
        }

        private void ButtonGammaDn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image, FilterFunction.GammaDown);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg, *.png, *.tiff, *.bmp, *.gif) | *.jpg; *.png; *.tiff; *.bmp; *.gif";
            saveFile.Title = "Save an image";
            saveFile.AddExtension = true;
            saveFile.DefaultExt = "jpg";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fName = saveFile.FileName;
                pictureBox1.Image.Save(fName, ImageFormat.Bmp);
            }
        }

        private void ButtonCtUp_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image, FilterFunction.ContrUp);
        }
        
        private void ButtonCtDn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.Filter((Bitmap)pictureBox1.Image, FilterFunction.ContrDn);
        }

        private void ButtonBlur_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.ConvFil((Bitmap)pictureBox1.Image, Tweakable.blurKernel,9);
        }

        private void ButtonGBlur_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.ConvFil((Bitmap)pictureBox1.Image, Tweakable.gaussBlurKernel, 80);
        }

        private void ButtonSharp_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.ConvFil((Bitmap)pictureBox1.Image, Tweakable.sharpKernel, 1);
        }

        private void ButtonEdge_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.ConvFil((Bitmap)pictureBox1.Image, Tweakable.edgeKernel, 1);
        }

        private void ButtonEmboss_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Filters.ConvFil((Bitmap)pictureBox1.Image, Tweakable.embKernel, 1);
        }

        private void ButtonFunc_Click(object sender, EventArgs e)
        {
            Bitmap fun = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Filters.FuncFil(fun);
            Bitmap fun2 = new Bitmap(fun.Width, fun.Height);
            Graphics g = Graphics.FromImage(fun2);
            g.Clear(Color.White);
            for (int i = 0; i < 256; i++)
            {
                try
                {
                    fun2.SetPixel(i, 255 - (int)pLL.points[i, 1], Color.Red);
                }
                catch(Exception x)
                {
                    continue;
                }
            }
            pictureBox2.Image = fun2;
        }
        
        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ((Bitmap)pictureBox2.Image).SetPixel(e.X, (int)pLL.points[e.X, 1], Color.White);
            // saving changes to Polyline array
            // 255 - e.Y because of inverted Y axis
            pLL.points[e.X, 1] = 255 - e.Y;
            ((Bitmap)pictureBox2.Image).SetPixel(e.X, e.Y, Color.Red);
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!((e.X == 0 && e.Y == 255) || (e.X == 255 && e.Y == 0)))
                    {
                        ((Bitmap)pictureBox2.Image).SetPixel(e.X, (int)pLL.points[e.X, 1], Color.White);
                        pLL.points[e.X, 1] = 255 - e.Y;
                        ((Bitmap)pictureBox2.Image).SetPixel(e.X, e.Y, Color.Red);
                    }
                }
            }
            catch(Exception x)
            {
                return;
            }
        }

        private void ButtonResFunc_Click(object sender, EventArgs e)
        {
            resetFuncFil();
        }
    }
}