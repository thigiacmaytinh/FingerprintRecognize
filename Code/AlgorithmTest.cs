using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for AlgorithmTest.
	/// </summary>
	public class AlgorithmTest : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox picInput;
		private System.Windows.Forms.PictureBox picOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;


		private ImageData image;
		private int[,] originImage;
		private int width,height;
		private System.Windows.Forms.Button button5;
		//private int widthSquare = 8;
		private System.Windows.Forms.Button button6;
		private double[,] directs;

		private bool isNormal = false;
		private bool isEnhence = false;
		private bool isBinary = false;
		private bool isBone = false; 

		private int[,] normalImage;
		private int[,] enhenceImage;
		private int[,] binaryImage;
		private int[,] boneImage;

		public AlgorithmTest()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.picInput = new System.Windows.Forms.PictureBox();
			this.picOutput = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// picInput
			// 
			this.picInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.picInput.Location = new System.Drawing.Point(16, 40);
			this.picInput.Name = "picInput";
			this.picInput.Size = new System.Drawing.Size(248, 264);
			this.picInput.TabIndex = 0;
			this.picInput.TabStop = false;
			this.picInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picInput_MouseUp);
			// 
			// picOutput
			// 
			this.picOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.picOutput.Location = new System.Drawing.Point(288, 40);
			this.picOutput.Name = "picOutput";
			this.picOutput.Size = new System.Drawing.Size(248, 264);
			this.picOutput.TabIndex = 1;
			this.picOutput.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ảnh gốc";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(288, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ảnh xử lý";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 312);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "Mở ảnh";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(272, 312);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Nhị phân hóa";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(96, 312);
			this.button3.Name = "button3";
			this.button3.TabIndex = 6;
			this.button3.Text = "Chuẩn hóa";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(184, 312);
			this.button4.Name = "button4";
			this.button4.TabIndex = 7;
			this.button4.Text = "Tăng cường";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(456, 312);
			this.button5.Name = "button5";
			this.button5.TabIndex = 8;
			this.button5.Text = "Xem chi tiết";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(368, 312);
			this.button6.Name = "button6";
			this.button6.TabIndex = 9;
			this.button6.Text = "Tìm xương";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// AlgorithmTest
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 341);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picOutput);
			this.Controls.Add(this.picInput);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(552, 368);
			this.Name = "AlgorithmTest";
			this.Text = "Kiểm nghiệm thuật toán xử lý ảnh";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				image = new ImageData(dlg.FileName,FingerCompare.widthSquare);
				picInput.Image = image.ToBitmap();				
        directs = image.Direct;
					
				width = image.Width;
				height = image.Height;
				originImage = new int[width,height];
				for(int j=0;j<height;j++)
					for(int i=0;i<width;i++)					
						originImage[i,j] = image.Image[i,j];

				isNormal = false;
				isEnhence = false;
				isBinary = false;
				isBone = false;
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			ArrayList minus = image.GetMinutiae(50,20,50,20);			

			Pen pen = new Pen(Color.Red,1);
			Pen pen1 = new Pen(Color.Blue,2);
			Graphics g = Graphics.FromImage(picOutput.Image);
			for(int index=0;index<minus.Count;index++)
			{
				Minutiae minu = (Minutiae) minus[index];
				g.DrawRectangle(pen,minu.X-2,minu.Y-2,5,5);
				g.DrawLine(pen1,minu.X,minu.Y,minu.X+Convert.ToInt32(15*Math.Cos(minu.Direct)),minu.Y-Convert.ToInt32(15*Math.Sin(minu.Direct)));
			}
			picOutput.Refresh();
			g.Dispose();

			MessageBox.Show("Số lượng chi tiết: " + minus.Count.ToString());
		}

		private void picInput_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//MessageBox.Show(Convert.ToString(180*directs[e.X,e.Y]/Math.PI));
			Graphics g;
			//Pen pen = new Pen(Color.Blue,1);
			Pen pen1 = new Pen(Color.Red,2);
			g = Graphics.FromImage(picInput.Image);			
			//g.DrawRectangle(pen,e.X-2,e.Y-2,5,5);
			g.DrawLine(pen1,e.X,e.Y,e.X+Convert.ToInt32(15*Math.Cos(directs[e.X,e.Y])),e.Y-Convert.ToInt32(15*Math.Sin(directs[e.X,e.Y])));
			picInput.Refresh();
			g.Dispose();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if(!isEnhence)
			{
				image.ToFiltring(FingerCompare.widthSquare,FingerCompare.f,FingerCompare.fi);
				picOutput.Image = image.ToBitmap();
				enhenceImage = new int[width,height];
				for(int i=0;i<width;i++)
					for(int j=0;j<height;j++)
						enhenceImage[i,j] = image.Image[i,j];
				isEnhence = true;
			}
			else
			{
				ImageData view = new ImageData(enhenceImage,width,height,FingerCompare.widthSquare);
				picOutput.Image = view.ToBitmap();
			}
			this.Cursor = Cursors.Default;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if(!isNormal)
			{
				image.ToNornal(FingerCompare.m,FingerCompare.v);
				picOutput.Image = image.ToBitmap();
				normalImage = new int[width,height];
				for(int i=0;i<width;i++)
					for(int j=0;j<height;j++)
						normalImage[i,j] = image.Image[i,j];
				isNormal = true;
			}
			else
			{
				ImageData view = new ImageData(normalImage,width,height,FingerCompare.widthSquare);
				picOutput.Image = view.ToBitmap();

			}
			this.Cursor = Cursors.Default;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if(!isBinary)
			{
				image.ToBinary(FingerCompare.threshold);
				picOutput.Image = image.ToBitmap();
				binaryImage = new int[width,height];
				for(int i=0;i<width;i++)
					for(int j=0;j<height;j++)
						binaryImage[i,j] = image.Image[i,j];
				isBinary = true;
			}
			else
			{
				ImageData view = new ImageData(binaryImage,width,height,FingerCompare.widthSquare);
				picOutput.Image = view.ToBitmap();
			}
			this.Cursor = Cursors.Default;
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if(!isBone)
			{
				image.ToBoneImage();
				picOutput.Image = image.ToBitmap();	
				boneImage = new int[width,height];
				for(int i=0;i<width;i++)
					for(int j=0;j<height;j++)
						boneImage[i,j] = image.Image[i,j];
				isBone = true;
			}
			else
			{
				ImageData view = new ImageData(boneImage,width,height,FingerCompare.widthSquare);
				picOutput.Image = view.ToBitmap();
			}
			this.Cursor = Cursors.Default;
		}
	}
}
