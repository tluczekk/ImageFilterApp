using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
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

        private Bitmap originalImage;

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);
                //pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.Image = originalImage;
            }
        }

        private void ButtonGray_Click(object sender, EventArgs e)
        {
            Bitmap gray = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = MakeGrayScale(gray);
        }

        private Bitmap MakeGrayScale(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color originalColor = original.GetPixel(i, j);
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G *
                    .59) + (originalColor.B * .11));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }

        private Bitmap InverseFilter(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            for (int i=0; i < original.Width; i++)
            {
                for(int j=0; j < original.Height; j++)
                {
                    Color originalColor = original.GetPixel(i, j);
                    Color newColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }
    
        private void ButtonRevert_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originalImage;
        }

        private void ButtonInverse_Click(object sender, EventArgs e)
        {
            Bitmap inv = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = InverseFilter(inv);
        }

        private void ButtonBright_Click(object sender, EventArgs e)
        {
            Bitmap brght = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = BrghtCorr(brght);
        }

        private Bitmap BrghtCorr(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color originalColor = original.GetPixel(i, j);
                    int red, green, blue;
                    red = originalColor.R + 50 < 256 ? originalColor.R + 50 : 255;
                    green = originalColor.G + 50 < 256 ? originalColor.G + 50 : 255;
                    blue = originalColor.B + 50 < 256 ? originalColor.B + 50 : 255;
                    Color newColor = Color.FromArgb(red, green, blue);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }
        private Bitmap BrghtCorrD(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color originalColor = original.GetPixel(i, j);
                    int red, green, blue;
                    red = originalColor.R - 50 >= 0 ? originalColor.R - 50 : 0;
                    green = originalColor.G - 50 >= 0 ? originalColor.G - 50 : 0;
                    blue = originalColor.B - 50 >= 0 ? originalColor.B - 50 : 0;
                    Color newColor = Color.FromArgb(red, green, blue);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }

        private void ButtonBrght2_Click(object sender, EventArgs e)
        {
            Bitmap brght = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = BrghtCorrD(brght);
        }

        private void ButtonGamma_Click(object sender, EventArgs e)
        {
            Bitmap gamm = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = GammaUp(gamm);
        }

        private static int Clamp(int Value, int Max, int Min)

        {
            Value = Value > Max? Max : Value;
            Value = Value<Min? Min : Value;
            return Value;
        }

        private Bitmap GammaUp(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color originalColor = original.GetPixel(i, j);
                    int red, green, blue;
                    red = Clamp((int)((255.0 * System.Math.Pow(originalColor.R / 255.0, 1.0 / 3.0)) + 0.5), 255, 0);
                    green = Clamp((int)((255.0 * System.Math.Pow(originalColor.G / 255.0, 1.0 / 3.0)) + 0.5), 255, 0);
                    blue = Clamp((int)((255.0 * System.Math.Pow(originalColor.B / 255.0, 1.0 / 3.0)) + 0.5), 255, 0);
                    Color newColor = Color.FromArgb(red, green, blue);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }

        private Bitmap GammaDown(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color originalColor = original.GetPixel(i, j);
                    int red, green, blue;
                    red = Clamp((int)((255.0 * System.Math.Pow(originalColor.R / 255.0, 3.0)) + 0.5), 255, 0);
                    green = Clamp((int)((255.0 * System.Math.Pow(originalColor.G / 255.0, 3.0)) + 0.5), 255, 0);
                    blue = Clamp((int)((255.0 * System.Math.Pow(originalColor.B / 255.0, 3.0)) + 0.5), 255, 0);
                    Color newColor = Color.FromArgb(red, green, blue);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }

        private void ButtonGammaDn_Click(object sender, EventArgs e)
        {
            Bitmap gamm = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = GammaDown(gamm);
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
    }
}
