using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrayScaleImage
{
	class Program
	{
		
		/*static void Main(string[] args)
		{
			int Width = int.Parse(Console.ReadLine());
			int Height = int.Parse(Console.ReadLine());
			string newName = "New(1).jpg";
			Bitmap bmp = (Bitmap)Image.FromFile("aaaa.bmp");
			GrayScaleImage(bmp, newName);
			ResampleImage(bmp, new Size(Width, Height), "RSIaaa.jpg");
		}
		static void GrayScaleImage(Bitmap a, string savePath)
		{
			for (int i = 0; i < a.Width; i++)
			{
				for (int j = 0; j < a.Height; j++)
				{
					Color Pixel = a.GetPixel(i, j);
					int Gray = (int)Math.Round(Pixel.B * 0.33 + Pixel.R * 0.33 + Pixel.G * 0.33);
					//Color newPixel = Color.FromArgb(Gray, Gray, Gray);
					Color newPixel = Color.FromArgb(Pixel.G, Pixel.B, Pixel.R);
					a.SetPixel(i, j, newPixel);
				}

			}
			a.Save(savePath);
		}
		static void ResampleImage(Bitmap b, Size NewSize, string savePath)
		{

			Bitmap q = new Bitmap(b.Size.Width * NewSize.Width, b.Size.Height * NewSize.Height);
			for (int x = 0; x < q.Width; x++)
			{
				for (int y = 0; y < q.Height; y++)
				{
					int Get_x = (int)Math.Round(x / (float)NewSize.Width);
					int Get_y = (int)Math.Round(y / (float)NewSize.Height);
					if (Get_x >= NewSize.Width)
					{
						Get_x--;
					}
					if (Get_y >= NewSize.Height)
					{
						Get_y--;
					}
					Color Pixel = b.GetPixel(Get_x, Get_y);
					//	Color newPixel = Color.FromArgb(,,);
					q.SetPixel(x, y, Pixel);
					Console.Write("...			.			...			.			...");
				}
			}
			q.Save(savePath);


		}
		static void BlurImage(Bitmap bmp, string savePath)
		{

		}*/
	}
}
