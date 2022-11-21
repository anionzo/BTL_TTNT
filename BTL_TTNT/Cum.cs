using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // Sử dụng color

namespace BTL_TTNT
{
    class Cum
    {
        private int KhoangCachNhoNhat(int[] KhoangCach, int k)
        {
            int min = KhoangCach[0];
            int minKhoangCach = 0;
            for (int i = 0; i < k; i++)
            {
                if (KhoangCach[i] < min)
                {
                    min = KhoangCach[i];
                    minKhoangCach = i;
                }
            }
            return minKhoangCach;
        }
     
        public Bitmap PhanDoanHinhAnh(Bitmap bitm, int k)
        {
            Random ranDom = new Random();
            Point[] pointTrungTam = new Point[k];
            // tạo số điểm = k  bất kì trên ảnh
            for(int i = 0; i < k; i++)
            {
                pointTrungTam[i] = new Point(ranDom.Next(bitm.Width), ranDom.Next(bitm.Height));
            }
            int[] KhoangCach = new int[k];
            for (int y = 0; y < bitm.Height; y++)
            {
                for (int x = 0; x < bitm.Width; x++)
                {
                  
                    for (int i = 0; i < k; i++)
                    {
                        
                        int r = Math.Abs(bitm.GetPixel(x, y).R - bitm.GetPixel(pointTrungTam[i].X, pointTrungTam[i].Y).R);      
                        int g = Math.Abs(bitm.GetPixel(x, y).G - bitm.GetPixel(pointTrungTam[i].X, pointTrungTam[i].Y).G);
                        int b = Math.Abs(bitm.GetPixel(x, y).B - bitm.GetPixel(pointTrungTam[i].X, pointTrungTam[i].Y).B);

                        //Khoảng cách diểm
                        // Tìm số lượng và áp dụng công thức Euclid
                        KhoangCach[i] = (int)(Math.Sqrt(r * r + g * g) + Math.Sqrt(g * g + b * b) + Math.Sqrt(r * r + b * b));   

                    }
                    
                    int nearest = KhoangCachNhoNhat(KhoangCach, k);     
                    Color clr = bitm.GetPixel(pointTrungTam[nearest].X, pointTrungTam[nearest].Y);      // take centroid color
                    bitm.SetPixel(x, y, clr);       // set pixel centroid color
                }
            }


            return bitm;
        }
       

    }
}
