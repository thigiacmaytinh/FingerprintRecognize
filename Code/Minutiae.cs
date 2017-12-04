using System;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for Minutiae.
	/// </summary>
	public class Minutiae
	{
		private int x;
		private int y;
		private double direct;

		#region properties
		public int X
		{
			get
			{
				return x;
			}
		}
		public int Y
		{
			get
			{
				return y;
			}
		}
		public double Direct
		{
			get
			{
				return direct;
			}
		}
		#endregion

		#region Contructor
		public Minutiae()
		{
		}
		public Minutiae(int _x,int _y,double _direct)
		{
			x = _x;
			y = _y;
			direct = _direct;
		}
		#endregion

		public void SetMinutiae(int _x,int _y,double _direct)
		{
			x = _x;
			y = _y;
			direct = _direct;
		}
	
		public Minutiae GetMinutiaeAfterChange(int deltaX,int deltaY,double angleRotation, int xRoot,int yRoot)
		{
			int xCurrent = x - xRoot;
			int yCurrent = yRoot - y;
			int _x = Convert.ToInt32(xCurrent*Math.Cos(angleRotation) - yCurrent*Math.Sin(angleRotation)) + deltaX;
			int _y = Convert.ToInt32(xCurrent*Math.Sin(angleRotation) + yCurrent*Math.Cos(angleRotation)) + deltaY;
			double _direct = direct + angleRotation;
			if(_direct>Math.PI)
				_direct = _direct - Math.PI;
			return new Minutiae(xRoot + _x,yRoot - _y,_direct);
		}	
	}
}
