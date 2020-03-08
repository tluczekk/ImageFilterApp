using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CGTluczek1
{
    public class Filters
    {
        public static Bitmap Filter(Bitmap original, Func<byte[], int, int, int, byte[]> fil)
        {
            Bitmap org = new Bitmap(original);
            BitmapData bData = org.LockBits(new Rectangle(0, 0, original.Width, original.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int len = bData.Stride * bData.Height;
            byte[] data = new byte[len];
            byte[] res = new byte[len];
            IntPtr ptr = bData.Scan0;
            Marshal.Copy(ptr, data, 0, len);
            org.UnlockBits(bData);
            res = fil(data, org.Width, org.Height, bData.Stride);
            Bitmap resBitmap = new Bitmap(original.Width, original.Height);
            BitmapData resData = resBitmap.LockBits(new Rectangle(0, 0, original.Width, original.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(res, 0, resData.Scan0, len);
            resBitmap.UnlockBits(resData);
            return resBitmap;
        }

        public static Bitmap ConvFil(Bitmap original, double[,] ker, int blurDiv)
        {
            double[,] kernel = ker;
            Bitmap org = new Bitmap(original);
            BitmapData bData = org.LockBits(new Rectangle(0, 0, original.Width, original.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int len = bData.Stride * bData.Height;
            byte[] data = new byte[len];
            byte[] res = new byte[len];
            IntPtr ptr = bData.Scan0;
            Marshal.Copy(ptr, data, 0, len);
            org.UnlockBits(bData);
            for (int i = 0; i < len; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    res[i] = data[i];
                    continue;
                }
                double resPix = 0;
                int firstColumn = -kernel.GetLength(0) / 2;
                int lastColumn = kernel.GetLength(0) / 2;
                for (int j = firstColumn; j <= lastColumn; j++)
                {
                    if (i + 4 * j < 0 || i + 4 * j >= len)
                    {
                        resPix = 0;
                        break;
                    }
                    int firstRow = -kernel.GetLength(1) / 2;
                    int lastRow = kernel.GetLength(1) / 2;
                    for (int k = firstRow; k <= lastRow; k++)
                    {
                        if (i + 4 * j + k * bData.Stride < 0 || i + 4 * j + k * bData.Stride >= len)
                        {
                            break;
                        }
                        resPix += kernel[j - firstColumn, k - firstRow] * data[i + 4 * j + k * bData.Stride];
                    }
                }
                res[i] = (byte)Form1.Clamp((int)(resPix / blurDiv), 255, 0);
            }
            Bitmap resBitmap = new Bitmap(original.Width, original.Height);
            BitmapData resData = resBitmap.LockBits(new Rectangle(0, 0, original.Width, original.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(res, 0, resData.Scan0, len);
            resBitmap.UnlockBits(resData);
            return resBitmap;
        }
        public static Bitmap FuncFil(Bitmap original)
        {
            Bitmap org = new Bitmap(original);
            BitmapData bData = org.LockBits(new Rectangle(0, 0, original.Width, original.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int len = bData.Stride * bData.Height;
            byte[] data = new byte[len];
            byte[] res = new byte[len];
            IntPtr ptr = bData.Scan0;
            Marshal.Copy(ptr, data, 0, len);
            org.UnlockBits(bData);
            int current = 0;
            int cChannels = 3;
            for (int i = 0; i < org.Height; i++)
            {
                for (int j = 0; j < org.Width; j++)
                {
                    current = i * bData.Stride + j * 4;
                    for (int k = 0; k < cChannels; k++)
                    {
                        res[current + k] = (byte)Form1.pLL.points[(int)(data[current + k]), 1];
                    }
                    res[current + 3] = 255;
                }
            }
            Bitmap resBitmap = new Bitmap(original.Width, original.Height);
            BitmapData resData = resBitmap.LockBits(new Rectangle(0, 0, original.Width, original.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(res, 0, resData.Scan0, len);
            resBitmap.UnlockBits(resData);
            return resBitmap;
        }
    }
}
