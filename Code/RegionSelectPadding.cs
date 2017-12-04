using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for RegionSelectPadding.
	/// </summary>
	public class RegionSelectPadding : System.Windows.Forms.Form
	{
		private int left1WidthPadding;
		private int top1WidthPadding;
		private int right1WidthPadding;
		private int bottom1WidthPadding;
		private int left2WidthPadding;
		private int top2WidthPadding;
		private int right2WidthPadding;
		private int bottom2WidthPadding;

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Finger1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt1LeftPadding;
		private System.Windows.Forms.TextBox txt1TopPadding;
		private System.Windows.Forms.TextBox txt1RightPadding;
		private System.Windows.Forms.TextBox txt1BottomPadding;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt2LeftPadding;
		private System.Windows.Forms.TextBox txt2TopPadding;
		private System.Windows.Forms.TextBox txt2RightPadding;
		private System.Windows.Forms.TextBox txt2BottomPadding;
		private System.Windows.Forms.Button bt2SetDefault;
		private System.Windows.Forms.Button bt1SetDefault;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RegionSelectPadding()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			left1WidthPadding = 10;
			left2WidthPadding = 10;
			top1WidthPadding = 10;
			top2WidthPadding = 10;
			right1WidthPadding = 10;
			right2WidthPadding = 10;
			bottom1WidthPadding = 10;
			bottom2WidthPadding = 10;

			txt1LeftPadding.Text = Convert.ToString(left1WidthPadding);
			txt1TopPadding.Text = Convert.ToString(top1WidthPadding);
			txt1RightPadding.Text = Convert.ToString(right1WidthPadding);
			txt1BottomPadding.Text = Convert.ToString(bottom1WidthPadding);
			
			txt2LeftPadding.Text = Convert.ToString(left2WidthPadding);
			txt2TopPadding.Text = Convert.ToString(top2WidthPadding);
			txt2RightPadding.Text = Convert.ToString(right2WidthPadding);
			txt2BottomPadding.Text = Convert.ToString(bottom2WidthPadding);
		}


		public RegionSelectPadding(int left1Width,int top1Width,int right1Width,int bottom1Width,int left2Width,int top2Width,int right2Width,int bottom2Width)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			left1WidthPadding = left1Width;			
			left2WidthPadding = left2Width;
			top1WidthPadding = top1Width;
			top2WidthPadding = top2Width;
			right1WidthPadding = right1Width;
			right2WidthPadding = right2Width;
			bottom1WidthPadding = bottom1Width;
			bottom2WidthPadding = bottom2Width;

			txt1LeftPadding.Text = Convert.ToString(left1WidthPadding);
			txt1TopPadding.Text = Convert.ToString(top1WidthPadding);
			txt1RightPadding.Text = Convert.ToString(right1WidthPadding);
			txt1BottomPadding.Text = Convert.ToString(bottom1WidthPadding);
			
			txt2LeftPadding.Text = Convert.ToString(left2WidthPadding);
			txt2TopPadding.Text = Convert.ToString(top2WidthPadding);
			txt2RightPadding.Text = Convert.ToString(right2WidthPadding);
			txt2BottomPadding.Text = Convert.ToString(bottom2WidthPadding);
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Finger1 = new System.Windows.Forms.TabPage();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt1BottomPadding = new System.Windows.Forms.TextBox();
			this.txt1RightPadding = new System.Windows.Forms.TextBox();
			this.txt1TopPadding = new System.Windows.Forms.TextBox();
			this.txt1LeftPadding = new System.Windows.Forms.TextBox();
			this.bt1SetDefault = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt2BottomPadding = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt2RightPadding = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt2TopPadding = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt2LeftPadding = new System.Windows.Forms.TextBox();
			this.bt2SetDefault = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btOK = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.Finger1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Finger1);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(8, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(280, 224);
			this.tabControl1.TabIndex = 0;
			// 
			// Finger1
			// 
			this.Finger1.Controls.Add(this.label16);
			this.Finger1.Controls.Add(this.label15);
			this.Finger1.Controls.Add(this.label14);
			this.Finger1.Controls.Add(this.label13);
			this.Finger1.Controls.Add(this.label12);
			this.Finger1.Controls.Add(this.label11);
			this.Finger1.Controls.Add(this.label10);
			this.Finger1.Controls.Add(this.label9);
			this.Finger1.Controls.Add(this.txt1BottomPadding);
			this.Finger1.Controls.Add(this.txt1RightPadding);
			this.Finger1.Controls.Add(this.txt1TopPadding);
			this.Finger1.Controls.Add(this.txt1LeftPadding);
			this.Finger1.Controls.Add(this.bt1SetDefault);
			this.Finger1.Location = new System.Drawing.Point(4, 22);
			this.Finger1.Name = "Finger1";
			this.Finger1.Size = new System.Drawing.Size(272, 198);
			this.Finger1.TabIndex = 0;
			this.Finger1.Text = "Vân tay 1";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(16, 144);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(168, 23);
			this.label16.TabIndex = 12;
			this.label16.Text = "Độ rộng phần loại bỏ bên dưới";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(16, 112);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(160, 23);
			this.label15.TabIndex = 11;
			this.label15.Text = "Độ rộng phần loại bỏ bên phải";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(16, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(160, 16);
			this.label14.TabIndex = 10;
			this.label14.Text = "Độ rộng phần loại bỏ bên trên";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(160, 23);
			this.label13.TabIndex = 9;
			this.label13.Text = "Độ rộng phần loại bỏ bên trái";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(248, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(16, 16);
			this.label12.TabIndex = 8;
			this.label12.Text = "px";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(248, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(16, 16);
			this.label11.TabIndex = 7;
			this.label11.Text = "px";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(248, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(16, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "px";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(248, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 16);
			this.label9.TabIndex = 5;
			this.label9.Text = "px";
			// 
			// txt1BottomPadding
			// 
			this.txt1BottomPadding.Location = new System.Drawing.Point(208, 144);
			this.txt1BottomPadding.Name = "txt1BottomPadding";
			this.txt1BottomPadding.Size = new System.Drawing.Size(40, 20);
			this.txt1BottomPadding.TabIndex = 4;
			this.txt1BottomPadding.Text = "";
			// 
			// txt1RightPadding
			// 
			this.txt1RightPadding.Location = new System.Drawing.Point(208, 112);
			this.txt1RightPadding.Name = "txt1RightPadding";
			this.txt1RightPadding.Size = new System.Drawing.Size(40, 20);
			this.txt1RightPadding.TabIndex = 3;
			this.txt1RightPadding.Text = "";
			// 
			// txt1TopPadding
			// 
			this.txt1TopPadding.Location = new System.Drawing.Point(208, 80);
			this.txt1TopPadding.Name = "txt1TopPadding";
			this.txt1TopPadding.Size = new System.Drawing.Size(40, 20);
			this.txt1TopPadding.TabIndex = 2;
			this.txt1TopPadding.Text = "";
			// 
			// txt1LeftPadding
			// 
			this.txt1LeftPadding.Location = new System.Drawing.Point(208, 48);
			this.txt1LeftPadding.Name = "txt1LeftPadding";
			this.txt1LeftPadding.Size = new System.Drawing.Size(40, 20);
			this.txt1LeftPadding.TabIndex = 1;
			this.txt1LeftPadding.Text = "";
			// 
			// bt1SetDefault
			// 
			this.bt1SetDefault.Location = new System.Drawing.Point(192, 8);
			this.bt1SetDefault.Name = "bt1SetDefault";
			this.bt1SetDefault.TabIndex = 0;
			this.bt1SetDefault.Text = "Set Default";
			this.bt1SetDefault.Click += new System.EventHandler(this.bt1SetDefault_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txt2BottomPadding);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txt2RightPadding);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txt2TopPadding);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.txt2LeftPadding);
			this.tabPage1.Controls.Add(this.bt2SetDefault);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(272, 198);
			this.tabPage1.TabIndex = 1;
			this.tabPage1.Text = "Vân tay 2";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(248, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 16);
			this.label8.TabIndex = 11;
			this.label8.Text = "px";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(248, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 16);
			this.label7.TabIndex = 10;
			this.label7.Text = "px";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(248, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "px";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Độ rộng phần loại bỏ bên dưới";
			// 
			// txt2BottomPadding
			// 
			this.txt2BottomPadding.Location = new System.Drawing.Point(208, 144);
			this.txt2BottomPadding.Name = "txt2BottomPadding";
			this.txt2BottomPadding.Size = new System.Drawing.Size(40, 20);
			this.txt2BottomPadding.TabIndex = 7;
			this.txt2BottomPadding.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Độ rộng phần loại bỏ bên phải";
			// 
			// txt2RightPadding
			// 
			this.txt2RightPadding.Location = new System.Drawing.Point(208, 112);
			this.txt2RightPadding.Name = "txt2RightPadding";
			this.txt2RightPadding.Size = new System.Drawing.Size(40, 20);
			this.txt2RightPadding.TabIndex = 5;
			this.txt2RightPadding.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Độ rộng phần loại bỏ bên trên";
			// 
			// txt2TopPadding
			// 
			this.txt2TopPadding.Location = new System.Drawing.Point(208, 80);
			this.txt2TopPadding.Name = "txt2TopPadding";
			this.txt2TopPadding.Size = new System.Drawing.Size(40, 20);
			this.txt2TopPadding.TabIndex = 3;
			this.txt2TopPadding.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Độ rộng phần loại bỏ bên trái";
			// 
			// txt2LeftPadding
			// 
			this.txt2LeftPadding.Location = new System.Drawing.Point(208, 48);
			this.txt2LeftPadding.Name = "txt2LeftPadding";
			this.txt2LeftPadding.Size = new System.Drawing.Size(40, 20);
			this.txt2LeftPadding.TabIndex = 1;
			this.txt2LeftPadding.Text = "";
			// 
			// bt2SetDefault
			// 
			this.bt2SetDefault.Location = new System.Drawing.Point(192, 8);
			this.bt2SetDefault.Name = "bt2SetDefault";
			this.bt2SetDefault.TabIndex = 0;
			this.bt2SetDefault.Text = "Set Default";
			this.bt2SetDefault.Click += new System.EventHandler(this.bt2SetDefault_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(248, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "px";
			// 
			// btOK
			// 
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Location = new System.Drawing.Point(168, 248);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(48, 23);
			this.btOK.TabIndex = 1;
			this.btOK.Text = "OK";
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(224, 248);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Cancel";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// RegionSelectPadding
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.ControlBox = false;
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button1);
			this.Name = "RegionSelectPadding";
			this.Text = "Vùng chọn đặc trưng";
			this.tabControl1.ResumeLayout(false);
			this.Finger1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion



		public int Left1WidthPadding
		{
			get
			{
				return left1WidthPadding;
			}
		}
		public int Left2WidthPadding
		{
			get
			{
				return left2WidthPadding;
			}
		}
		public int Top1WidthPadding
		{
			get 
			{
				return top1WidthPadding;
			}
		}
		public int Top2WidthPadding
		{
			get
			{
				return top2WidthPadding;
			}
		}
		public int Right1WidthPadding
		{
			get
			{
				return right1WidthPadding;
			}
		}
		public int Right2WidthPadding
		{
			get
			{
				return right2WidthPadding;
			}
		}		

		public int Bottom1WidthPadding
		{
			get
			{
				return bottom1WidthPadding;
			}
		}
		public int Bottom2WidthPadding
		{
			get
			{
				return bottom2WidthPadding;
			}
		}


		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void btOK_Click(object sender, System.EventArgs e)
		{
			try
			{
				left1WidthPadding = Convert.ToInt32(txt1LeftPadding.Text);
				left2WidthPadding = Convert.ToInt32(txt2LeftPadding.Text);
				top1WidthPadding = Convert.ToInt32(txt1TopPadding.Text);
				top2WidthPadding = Convert.ToInt32(txt2TopPadding.Text);
				right1WidthPadding = Convert.ToInt32(txt1RightPadding.Text);
				right2WidthPadding = Convert.ToInt32(txt2RightPadding.Text);
				bottom1WidthPadding = Convert.ToInt32(txt1BottomPadding.Text);
				bottom2WidthPadding = Convert.ToInt32(txt2BottomPadding.Text);
				this.Close();
			}
			catch
			{
				MessageBox.Show("Dữ liệu nhập không tốt");
			}
		}

		private void bt1SetDefault_Click(object sender, System.EventArgs e)
		{
			txt1LeftPadding.Text = "10";
			txt1TopPadding.Text = "10";
			txt1RightPadding.Text = "10";
			txt1BottomPadding.Text = "10";
		}

		private void bt2SetDefault_Click(object sender, System.EventArgs e)
		{
			txt2LeftPadding.Text = "10";
			txt2TopPadding.Text = "10";
			txt2RightPadding.Text = "10";
			txt2BottomPadding.Text = "10";
		}
	}
}
