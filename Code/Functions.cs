using System;
using System.Collections;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for Functions.
	/// </summary>
	public class Functions
	{
		public Functions()
		{
		}
		public static int GetMinuDistance(Minutiae m1,Minutiae m2)
		{
			return Convert.ToInt32(Math.Sqrt(Math.Pow(m1.X-m2.X,2) + Math.Pow(m1.Y-m2.Y,2)));
		}

		public static bool IsMinutiaeMatching(Minutiae m1,Minutiae m2,int distanceLimit,double angleLimit,Minutiae minuChanging)
		{			
			Minutiae m = m2.GetMinutiaeAfterChange(minuChanging.X,minuChanging.Y,minuChanging.Direct,128,128);	
			int distance = Convert.ToInt32(Math.Sqrt(Math.Pow(m.X-m1.X,2) + Math.Pow(m.Y-m1.Y,2)));
			double angleRotate = Math.Min(Math.Abs(m.Direct-m1.Direct),Math.PI*2-Math.Abs(m.Direct-m1.Direct));
      if((distance<distanceLimit)&&(angleRotate<angleLimit))
				return true;
			return false;
		}

		public static Minutiae GetMinutiaeChanging_UseHoughTransform(ArrayList minuSet1,ArrayList minuSet2,int[] angleSet,int[] deltaXSet,int[] deltaYSet,double angleLimit,int xRoot,int yRoot)
		{
			int i,j,k;
			int length = deltaXSet.Length*deltaYSet.Length*angleSet.Length;
			int[,,] A = new int[deltaXSet.Length,deltaYSet.Length,angleSet.Length];
			Minutiae m1;
			Minutiae m2;
			double _deltaX;
			double _deltaY;			
			for(i=0;i<deltaXSet.Length;i++)
				for(j=0;j<deltaYSet.Length;j++)
					for(k=0;k<angleSet.Length;k++)
						A[i,j,k] = 0;
		
			for(i=0;i<minuSet1.Count;i++)
			{
				m1 = (Minutiae)minuSet1[i];
				for(j=0;j<minuSet2.Count;j++)
				{
					m2 = (Minutiae)minuSet2[j];
					for(int angleIndex=0;angleIndex<angleSet.Length;angleIndex++)					
					{
						double tempAngle = Math.Abs((m2.Direct+angleSet[angleIndex]*Math.PI/180)-m1.Direct);
						if((tempAngle < angleLimit)||((Math.PI*2 - tempAngle)<angleLimit))
						{
							int c1X = m1.X - xRoot;
							int c1Y = yRoot - m1.Y;
							int c2X = m2.X - xRoot;
							int c2Y = yRoot - m2.Y;
						
							_deltaX = c1X - (Math.Cos(angleSet[angleIndex]*Math.PI/180)*c2X - Math.Sin(angleSet[angleIndex]*Math.PI/180)*c2Y);
							_deltaY = c1Y - (Math.Sin(angleSet[angleIndex]*Math.PI/180)*c2X + Math.Cos(angleSet[angleIndex]*Math.PI/180)*c2Y);

							#region quantization deltax,deltay
							int deltaXSelect = deltaXSet[0];
							int deltaXIndexSelect = 0;
							int deltaYSelect = deltaYSet[0];
							int deltaYIndexSelect = 0;
							for(int deltaXIndex=0;deltaXIndex<deltaXSet.Length;deltaXIndex++)								
								if(Math.Abs(Convert.ToDouble(deltaXSet[deltaXIndex])-_deltaX)<Math.Abs(Convert.ToDouble(deltaXSelect)-_deltaX))
								{
									deltaXSelect = deltaXSet[deltaXIndex];
									deltaXIndexSelect = deltaXIndex;
								}
							for(int deltaYIndex=0;deltaYIndex<deltaYSet.Length;deltaYIndex++)								
								if(Math.Abs(Convert.ToDouble(deltaYSet[deltaYIndex])-_deltaY)<Math.Abs(Convert.ToDouble(deltaYSelect)-_deltaY))
								{
									deltaYSelect = deltaYSet[deltaYIndex];
									deltaYIndexSelect = deltaYIndex;
								}
							#endregion

							A[deltaXIndexSelect,deltaYIndexSelect,angleIndex]++;
						}
					}
				}
			}
			#region Select Return value
			int _deltaXIndex = 0;			
			int _deltaYIndex = 0;
			int _angleIndex = 0;
			for(i=0;i<deltaXSet.Length;i++)
				for(j=0;j<deltaYSet.Length;j++)
					for(k=0;k<angleSet.Length;k++)
					{
						if(A[i,j,k]>A[_deltaXIndex,_deltaYIndex,_angleIndex])
						{
							_deltaXIndex = i;
							_deltaYIndex = j;
							_angleIndex = k;
						}
					}
			
			return new Minutiae(deltaXSet[_deltaXIndex],deltaYSet[_deltaYIndex],angleSet[_angleIndex]*Math.PI/180);
			#endregion

		}

		public static int CountMinuMatching(ArrayList minuSet1,ArrayList minuSet2,Minutiae minuChanging,int distanceLimit, double angleLimit)
		{			 
			int i,j;
			bool[] mark = new bool[minuSet2.Count];
			for(i=0;i<minuSet2.Count;i++)
				mark[i] = false;

			for(i=0;i<minuSet1.Count;i++)
			{
				Minutiae m1 = (Minutiae)minuSet1[i];
				for(j=0;j<minuSet2.Count;j++)
				{					
					if(!mark[j])
					{
						Minutiae m2 = (Minutiae) minuSet2[j];
						if(Functions.IsMinutiaeMatching(m1,m2,distanceLimit,angleLimit,minuChanging))
						{
							mark[j] = true;
							break;
						}
					}				
				}
			}
			int count = 0;
			for(i=0;i<minuSet2.Count;i++)
				if(mark[i]) count++;
			return count;
		}

	}

}
