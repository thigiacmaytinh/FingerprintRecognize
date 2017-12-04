using System;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for MaskGabor.
	/// </summary>
	public class MaskGabor
	{
		private double[,] mask;
		private int width;
		public double[,] Mask
		{
			get
			{
				return mask;
			}
		}
		public int Width
		{
			get
			{
				return width;
			}
		}
		public MaskGabor(int widthSquare,double filterDirect,double f,int fi)
		{
			double[,] rtMask = new double[2*widthSquare+1,2*widthSquare+1];
			for(int x=0;x<2*widthSquare+1;x++)
				for(int y=0;y<2*widthSquare+1;y++)
				{
					double x1 = Math.Sin(filterDirect)*(x-widthSquare) + Math.Cos(filterDirect)*(y-widthSquare);
					double y1 = Math.Sin(filterDirect)*(y-widthSquare) - Math.Cos(filterDirect)*(x-widthSquare);
					rtMask[x,y] = Math.Exp(-0.5*(Math.Pow(x1,2)/Math.Pow(fi,2) + Math.Pow(y1,2)/Math.Pow(fi,2)))*Math.Cos(2*Math.PI*f*x1);				
				}
			mask = rtMask;
			width = widthSquare*2 + 1;
		}
	}
}
