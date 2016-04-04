using System;
using System.Collections.Generic;
using System.Drawing;

namespace GrayScaleImage
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());
			string newName = "New(1).jpg";
			Bitmap bmp = (Bitmap)Image.FromFile("aaaa.bmp");
			GrayScaleImage(bmp, newName);
			ResampleImage(bmp, new Size(width, height), "RSIaaa.jpg");
		}

		static void GrayScaleImage(Bitmap a, string savePath)
		{
			for (int i = 0; i < a.Width; i++)
			{
				for (var j = 0; j < a.Height; j++)
				{
					var pixel = a.GetPixel(i, j);
					//Color newPixel = Color.FromArgb(Gray, Gray, Gray);
					 Color newPixel = Color.FromArgb(pixel.G,pixel.B,pixel.R); 
					a.SetPixel(i, j, newPixel);
				}

			}
			a.Save(savePath);
		}
		static void ResampleImage(Bitmap b, Size newSize ,string savePath)
		{

			Bitmap q = new Bitmap(b.Size.Width * newSize.Width, b.Size.Height * newSize.Height);
			for (int x = 0; x < q.Width; x++)
			{
				for (int y = 0; y < q.Height; y++)
				{
					int getX = (int)Math.Round(x / (float)newSize.Width);
					int getY = (int)Math.Round(y / (float)newSize.Height);
					if (getX >= newSize.Width)
					{
						getX--;
					}
					if (getY >= newSize.Height)
					{
						getY--;
					}
					Color pixel = b.GetPixel(getX, getY);
					//	Color newPixel = Color.FromArgb(,,);
					q.SetPixel(x, y, pixel);
					//Console.Write("...			.			...			.			...");
				}
			}
			q.Save(savePath);
		

		}

		public static void BlurImage(Bitmap bitmap, string savePath)

		{
			Bitmap blurred = (Bitmap)bitmap.Clone();
			List<Color> colors;

			for (int i = 0; i < blurred.Size.Width; i++)
			{
				for (int b = 0; b < blurred.Size.Height; b++)
				{
					colors = GetPixels(blurred, i, b);
					Color avrg = GetAverage(colors);
					SetColors(blurred, i, b, avrg);
					//blurred.SetPixel(i, b, avrg);
				}
			}

			blurred.Save(savePath);
		}
		static Color GetAverage(List<Color> colors)
		{
			int red = 0;
			int green = 0;
			int bl = 0;

			colors.ForEach(col =>
			{
				red += col.R;
				green += col.G;
				bl += col.B;
			});

			red /= colors.Count;
			green /= colors.Count;
			bl /= colors.Count;

			return Color.FromArgb(red, green, bl);
		}

		static List<Color> GetPixels(Bitmap bitmap, int i, int b)
		{

			List<Color> colors = new List<Color>();
			for (int x = -1; x < 2; x++)
			{
				for (int y = -1; y < 2; y++)
				{
					if (x+i >= 0 && x+i < bitmap.Size.Width && y+b >= 0 && y+b < bitmap.Size.Height)
					{
						colors.Add(bitmap.GetPixel(i + x, b + y));
					}
				}
			}

			return colors;
		}

		static void SetColors(Bitmap bitmap, int i, int b, Color color)
		{
			for (var x = 0; x < 3; x++)
			{
				for (int y = 0; y < 3; y++)
				{
					x += i;
					y += b;
					if(x >= 0 && x < bitmap.Size.Width && y >= 0 && y < bitmap.Size.Height)
					{
						bitmap.SetPixel(i + x, b + y, color);
					}
				}
			}
		}

	}
}

