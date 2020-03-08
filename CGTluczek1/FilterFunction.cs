using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTluczek1
{
    public class FilterFunction
    {
        public static byte[] MakeGrayScale(byte[] data, int w, int h, int s)
        {
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    // calculating shade of gray 
                    double grayScale = (double)data[current] * .3 + (double)data[current + 1] * .59 + (double)data[current + 2] * .11;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        res[current + k] = (byte)(grayScale);
                    }
                    res[current + 3] = 255;
                }
            }
            return res;
        }

        public static byte[] Inverse(byte[] data, int w, int h, int s)
        {
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        double inv = (double)data[current + k];
                        res[current + k] = (byte)((255 - inv));
                    }
                    res[current + 3] = 255;
                }
            }
            return res;

        }

        public static byte[] BrghtCorr(byte[] data, int w, int h, int s)
        {
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        res[current + k] = (byte)(data[current + k] + Tweakable.brightCoeff < 256 ? data[current + k] + Tweakable.brightCoeff : 255);
                    }
                    res[current + 3] = 255;
                }
            }
            return res;
        }

        public static byte[] BrghtCorrD(byte[] data, int w, int h, int s)
        {
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        res[current + k] = (byte)(data[current + k] - Tweakable.brightCoeff >= 0 ? data[current + k] - Tweakable.brightCoeff : 0);
                    }
                    res[current + 3] = 255;
                }
            }
            return res;
        }

        public static byte[] GammaUp(byte[] data, int w, int h, int s)
        {
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        res[current + k] = (byte)Form1.Clamp((int)((255.0 * System.Math.Pow(data[current + k] / 255.0, 1.0 / Tweakable.gammaCoeff)) + 0.5), 255, 0);
                    }
                    res[current + 3] = 255;
                }
            }
            return res;

        }

        public static byte[] GammaDown(byte[] data, int w, int h, int s)
        {
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        res[current + k] = (byte)Form1.Clamp((int)((255.0 * System.Math.Pow(data[current + k] / 255.0, Tweakable.gammaCoeff)) + 0.5), 255, 0);
                    }
                    res[current + 3] = 255;
                }
            }
            return res;
        }

        public static byte[] ContrUp(byte[] data, int w, int h, int s)
        {
            double contr = Math.Pow((100.0 + Tweakable.contrastCoeff) / 100.0, 2);
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        res[current + k] = (byte)Form1.Clamp((int)(((((data[current + k] / 255.0) - 0.5) * contr) + 0.5) * 255.0), 255, 0);
                    }
                    res[current + 3] = 255;
                }
            }
            return res;
        }

        public static byte[] ContrDn(byte[] data, int w, int h, int s)
        {
            double contr = 1 / (Math.Pow((100.0 + Tweakable.contrastCoeff) / 100.0, 2));
            byte[] res = new byte[s * h];
            int current = 0;
            int colorChannels = 3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    current = i * s + j * 4;
                    for (int k = 0; k < colorChannels; k++)
                    {
                        res[current + k] = (byte)Form1.Clamp((int)(((((data[current + k] / 255.0) - 0.5) * contr) + 0.5) * 255.0), 255, 0); ;
                    }
                    res[current + 3] = 255;
                }
            }
            return res;
        }
    }
}
