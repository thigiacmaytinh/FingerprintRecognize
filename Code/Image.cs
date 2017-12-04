using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for Image.
	/// </summary>
	public class ImageData
	{
		#region Image Info
		private int[,] image;
		private double[,] direct;
		private int width;
		private int height;
		private bool isNormal = false;
		private bool isBinary = false;
		private bool isBone = false;
		#endregion


		#region propties
		public int[,] Image
		{
			get
			{
				return image;
			}
		}
		public double[,] Direct
		{
			get
			{
				return direct;
			}
		}
		public int Width
		{
			get
			{
				return width;
			}
		}
		public int Height
		{
			get
			{
				return height;
			}
		}
		#endregion


		#region Image contructor
		public ImageData()
		{
		}
		public ImageData(string sourceFile,int widthSquare)
		{
			Bitmap bmp = new Bitmap(sourceFile);
			Color c;    
			image = new Int32[bmp.Width,bmp.Height];
			width = bmp.Width;
			height = bmp.Height;
			for ( int x=0; x<bmp.Width; x++ )
			{
				for ( int y=0; y<bmp.Height; y++ )
				{
					c = bmp.GetPixel( x, y );
					Int32 temp = System.Convert.ToInt32(c.R*0.299 + c.G*0.587 + c.B*0.114);					
					image[x,y] = temp;
				}
			}
			direct = GetDirectionMatrix(widthSquare);
		}
		public ImageData(int[,] inputImage,int inputWidth,int inputHeight,int widthSquare)
		{
			image = inputImage;
			width = inputWidth;
			height = inputHeight;
			direct = GetDirectionMatrix(widthSquare);
		}
		
		#endregion


		#region set image data
		public void SetImage(int[,] inputImage,int inputWidth,int inputHeight,int widthSquare)
		{
			image = inputImage;
			width = inputWidth;
			height = inputHeight;
			direct = GetDirectionMatrix(widthSquare);
		}
		#endregion


		#region point direct caculation

		public double[,] GetDirectionMatrix(int widthSqare)
		{
			int i,j,x,y;
			int Ax,Ay,Axy;
			int Gxx,Gyy,Gxy;
			int Bx,By;

			double[,] directMatrix = new double[width,height];
			for(j=0;j<height;j++)
				for(i=0;i<width;i++)					
					directMatrix[i,j] = 0;
			for(y=widthSqare+1;y<height-widthSqare-1; y++)
			{
				for (x=widthSqare+1; x<width-widthSqare-1; x++ )
				{
					Ax=0;Ay=0;Axy=0;
					Gxx=0;Gyy=0;Gxy=0;
					Bx=0;By=0;
					for (j=y-widthSqare;j<y+widthSqare-1;j++ )						
					{
						for(i=x-widthSqare;i<x+widthSqare-1;i++ )
						{
							Bx = ((image[i+2,j]+2*image[i+2,j+1]+image[i+2,j+2]-image[i,j]-2*image[i,j+1]-image[i,j+2]));
							By = ((image[i,j+2]+2*image[i+1,j+2]+image[i+2,j+2]-image[i,j]-2*image[i+1,j]-image[i+2,j]));
							Ax+=Bx*Bx;
							Ay+=By*By;
							Axy+=Bx*By;
						}
					}
					Gxx = Ax;
					Gyy = Ay;
					Gxy = Axy;
					
					directMatrix[x,y] = Math.PI/2-0.5*Math.Atan2(2*Gxy, Gxx-Gyy);
				}
			}
			return directMatrix;
		
		}
		#endregion


		#region Print Image
		public Bitmap ToBitmap()
		{
			Bitmap bmp = new Bitmap(width,height);
			for(int x=0;x<width;x++)
				for(int y=0;y<height;y++)
				{
					Color c = Color.FromArgb(image[x,y],image[x,y],image[x,y]);
					bmp.SetPixel(x,y,c);
				}
			return bmp;
		}

		#endregion


		#region Threshold caculate

		public int GetThreshold()
		{
			int threshold = 0;
			double tempF = 0;
			for(int g=0;g<=255;g++)
				if(GetF(g)>tempF)
				{
					tempF = GetF(g);
					threshold = g;
				}
			return threshold;
			
		}
		//helper functions
		private int GetT(int g)
		{
			int t = 0;
			int x,y;
			for(x=0;x<width;x++)
				for(y=0;y<height;y++)
					if(image[x,y]<=g) t++;

			return t;
		}
		private double GetM(int g)
		{
			int x,y;
			int temp = 0;
			for(x=0;x<width;x++)
				for(y=0;y<height;y++)
					if(image[x,y]<=g) temp += image[x,y];
			double m = Convert.ToDouble(temp)/Convert.ToDouble(GetT(g));
			return m;
		}
		private double GetF(int g)
		{			
			return Convert.ToDouble(GetT(g))*(GetM(g)-GetM(255))*(GetM(g)-GetM(255))/Convert.ToDouble((width*height)-GetT(g));
		}
		#endregion		


		#region Normalization helper method
		public void ToNornal(int M,int V)
		{			
			double m = GetM();
			double v = GetV();
			for(int j=0;j<height;j++)			
			{
				for(int i=0;i<width;i++)
				{
					double tempData = Convert.ToDouble(image[i,j]);
					if(tempData>m)
					{
						image[i,j] = Convert.ToInt32(M + Math.Sqrt((tempData-m)*(tempData-m)*V/v));
					}
					else
					{
						image[i,j] = Convert.ToInt32(M - Math.Sqrt((tempData-m)*(tempData-m)*V/v));
					}
				}
			}			
		}

		//Normalization helper functions
		private double GetM()
		{
			int temp = 0;
			for(int j=0;j<height;j++)
			for(int i=0;i<width;i++)				
			{
				temp = temp + image[i,j];
			}
			return Convert.ToDouble(temp)/Convert.ToDouble(width*height);
		}
		private double GetV()
		{
			double temp = 0;
			double m = GetM();
			for(int j=0;j<height;j++)
			for(int i=0;i<width;i++)				
			{
				temp += (image[i,j] - m)*(image[i,j] - m);
			}
			return temp/(width*height);
		}
		#endregion


		#region Binary convert
		public void ToBinary(int thresh)
		{
			int thresthold;
			if(thresh>0&&thresh<255)
				thresthold = thresh;
			else
				thresthold = this.GetThreshold();
			for(int j=0;j<height;j++)			
			{
				for(int i=0;i<width;i++)	
				{
					if(image[i,j]>=thresthold)
						image[i,j] = 255;
					else
						image[i,j] = 0;
				}
			}		
		}
		#endregion


		#region Image bone finding


		public void ToBoneImage()
		{
			this.MakeBone();
			this.ClearBone();
		}

		//bone helper functions
		private bool IsBoder(int x, int y)
		{
			if((image[x-1,y]==255||image[x+1,y]==255||image[x,y-1]==255||image[x,y+1]==255)&&image[x,y]==0)
				return true;
			return false;
		}

		private bool IsDeleable(int x,int y)
		{
			int p1 = image[x-1,y-1];
			int p2 = image[x,y-1];
			int p3 = image[x+1,y-1];
			int p4 = image[x-1,y];
			int p5 = image[x+1,y];
			int p6 = image[x-1,y+1];
			int p7 = image[x,y+1];
			int p8 = image[x+1,y+1];

			if((p1+p2+p3)==0&&(p6*p7*p8>0)) return true;
			if((p1+p2+p4)==0&&(p5*p7*p8>0)) return true;
			if((p1+p4+p6)==0&&(p3*p5*p8>0)) return true;
			if((p2+p3+p5==0)&&(p4*p6*p7>0)) return true;
			if((p6+p7+p8==0)&&(p1*p2*p3>0)) return true;
			if((p5+p7+p8==0)&&(p1*p2*p4>0)) return true;
			if((p3+p5+p8)==0&&(p1*p4*p6>0)) return true;
			if((p4+p6+p7)==0&&(p2*p3*p5>0)) return true;

			return false;
		}

		private void MakeBone()
		{
			bool isBone = false;
			while(!isBone)
			{
				isBone = true;
				for(int j=1;j<height-1;j++)				
				{
					for(int i=1;i<width-1;i++)	
					{
						if(IsBoder(i,j))
						{
							if(IsDeleable(i,j))
							{
								image[i,j]=255;
								isBone = false;
							}
						}
					}
				}
			}
		}

		private void ClearBone()
		{
			for(int y=1;y<height-1;y++)			
				for(int x=1;x<width-1;x++)	
				{
					if(image[x,y]==0)
					{
						if(image[x-1,y-1]==0) 
						{
							image[x,y-1]=255;
							image[x-1,y]=255;
						}
						if(image[x+1,y-1]==0)
						{
							image[x,y-1]=255;
							image[x+1,y] = 255;
						}
						if(image[x+1,y+1]==0)
						{
							image[x+1,y]=255;
							image[x,y+1]=255;
						}
						if(image[x-1,y+1]==0)
						{
							image[x-1,y]=255;
							image[x,y+1]=255;
						}

					}
				}
		}
		#endregion


		#region minutiae finding

		public ArrayList GetMinutiae(int leftPading,int topPadding,int rightPadding,int bottomPadding)
		{
			ArrayList minus1 = new ArrayList();
			for(int x=leftPading;x<width-rightPadding;x++)
				for(int y=topPadding;y<height-bottomPadding;y++)
				{
					if(this.IsFeature(x,y))
					minus1.Add(new Minutiae(x,y,direct[x,y]));
				}	

			#region Clear Minutiae
			for(int i=0;i<minus1.Count-1;i++)
			{
				Minutiae m1 = (Minutiae)minus1[i];
				for(int j=i+1;j<minus1.Count;j++)
				{
					Minutiae m2 = (Minutiae)minus1[j];
					if(Functions.GetMinuDistance(m1,m2)<6)
					{
						if(i>0)
						{
							minus1.RemoveAt(j);
							minus1.RemoveAt(i);
							j = j-2;							
							i--;
							break;
						}
						else
						{
							minus1.RemoveAt(j);
							minus1.RemoveAt(i);
							if(j>1)
								j--;
							break;
						}
						
					}
				}
			}
			#endregion
			return minus1;
		}

		public bool IsFeature(int x,int y)
		{
			if(x>0&&x<width&&y>0&&y<height&&image[x,y]==0)
			{
				int result = Math.Abs(image[x-1,y-1]-image[x-1,y])+Math.Abs(image[x-1,y+1]-image[x,y+1]) + Math.Abs(image[x+1,y+1]-image[x+1,y]) + Math.Abs(image[x+1,y-1]-image[x,y-1]);
				if(result==1*255) return true;
				if(result==3*255) return true;
				return false;
			}
			return false;
		}
		#endregion


		#region Filtering

		public void ToFiltring(int widthSquare,int f,int fi)
		{
			try
			{
				double pointValue = 0;
				for(int x=0;x<width-2*widthSquare-1;x++)
					for(int y=0;y<height-2*widthSquare-1;y++)
					{
						double[,] mask;
						if(FingerCompare.maskNumber>0)
						{
							mask = GetMaskFilter(direct[x,y]);
						}
						else
						{
							mask = GetMaskFilter(direct[x,y],widthSquare,1.0/f,fi);
						}
						for(int i=0;i<2*widthSquare+1;i++)
							for(int j=0;j<2*widthSquare+1;j++)
							{
								pointValue += mask[i,j]*image[i+x,j+y];
							}
						if(pointValue<0)
							pointValue = 0;
						if(pointValue>255)
							pointValue = 255;
						image[x,y] = Convert.ToInt32(pointValue);
					}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private double[,] GetMaskFilter(double filterDirect)
		{		
			MaskGabor mask;
			for(int i=0;i<FingerCompare.maskNumber;i++)
			{
				if(filterDirect>=i*Math.PI/FingerCompare.maskNumber&&filterDirect<(i+1)*Math.PI/FingerCompare.maskNumber)
				{
					mask = (MaskGabor) FingerCompare.MaskGaborCollection[i];
					return mask.Mask;
				}
			}
			mask = (MaskGabor)FingerCompare.MaskGaborCollection[FingerCompare.maskNumber-1];
			return mask.Mask;

		}
		private double[,] GetMaskFilter(double filterDirect,int widthSquare,double f,int fi)
		{			
			double[,] rtMask = new double[2*widthSquare+1,2*widthSquare+1];
			for(int x=0;x<2*widthSquare+1;x++)
				for(int y=0;y<2*widthSquare+1;y++)
				{
					double x1 = Math.Sin(filterDirect)*(x-widthSquare) + Math.Cos(filterDirect)*(y-widthSquare);
					double y1 = Math.Sin(filterDirect)*(y-widthSquare) - Math.Cos(filterDirect)*(x-widthSquare);
					rtMask[x,y] = Math.Exp(-0.5*(Math.Pow(x1,2)/Math.Pow(fi,2) + Math.Pow(y1,2)/Math.Pow(fi,2)))*Math.Cos(2*Math.PI*f*x1);
				}
			return rtMask;
		}
		#endregion
	}
}
