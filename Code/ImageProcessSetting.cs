using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for ImageProcessSetting.
	/// </summary>
	public class ImageProcessSetting : System.Windows.Forms.Form
	{
		#region Window controls
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox txtV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtM;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtF;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox txtThreshold;
		private System.Windows.Forms.RadioButton raManual;
		private System.Windows.Forms.RadioButton raAuto;
		private System.Windows.Forms.TextBox txtfi;
		private System.Windows.Forms.Label lbThreshManu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chbMask;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMaskNumber;
		#endregion

		#region Attributes
		private int threshold;
		private int m;
		private int v;
		private int f;
		private int fi;
		private int maskNumber;
		#endregion

		#region Propties
		public int Threshold
		{
			get
			{
				return threshold;
			}
		}
		public int M
		{
			get
			{
				return m;
			}
		}
		public int V
		{
			get
			{
				return v;
			}
		}
		public int F
		{
			get
			{
				return f;
			}
		}
		public int Fi
		{
			get
			{
				return fi;
			}
		}
		public int MaskNumber
		{
			get
			{
				return maskNumber;
			}
		}
		#endregion 

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImageProcessSetting(int thresh,int mValue,int vValue,int fValue,int fiValue,int maskValue)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			threshold = thresh;
			m = mValue;
			v = vValue;
			f = fValue;
			fi = fiValue;
			maskNumber = maskValue;
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtM = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.raManual = new System.Windows.Forms.RadioButton();
			this.raAuto = new System.Windows.Forms.RadioButton();
			this.lbThreshManu = new System.Windows.Forms.Label();
			this.txtThreshold = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.txtMaskNumber = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.chbMask = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtfi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtF = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(8, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(296, 176);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txtV);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtM);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(288, 150);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Chuẩn Hóa";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(216, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Default";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Thiết đặt thông số chuẩn hóa ảnh";
			// 
			// txtV
			// 
			this.txtV.Location = new System.Drawing.Point(216, 96);
			this.txtV.Name = "txtV";
			this.txtV.Size = new System.Drawing.Size(48, 20);
			this.txtV.TabIndex = 6;
			this.txtV.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Giá trị kỳ vọng mong muốn";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Giá trị phương sai mong muốn";
			// 
			// txtM
			// 
			this.txtM.Location = new System.Drawing.Point(216, 56);
			this.txtM.Name = "txtM";
			this.txtM.Size = new System.Drawing.Size(48, 20);
			this.txtM.TabIndex = 4;
			this.txtM.Text = "";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.raManual);
			this.tabPage2.Controls.Add(this.raAuto);
			this.tabPage2.Controls.Add(this.lbThreshManu);
			this.tabPage2.Controls.Add(this.txtThreshold);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(288, 150);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Nhị Phân";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Thiết đặt thông số nhị phân hóa ảnh";
			// 
			// raManual
			// 
			this.raManual.Location = new System.Drawing.Point(36, 68);
			this.raManual.Name = "raManual";
			this.raManual.Size = new System.Drawing.Size(152, 24);
			this.raManual.TabIndex = 7;
			this.raManual.Text = "Tự thiết đặt giá trị ngưỡng";
			this.raManual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.raManual_MouseUp);
			// 
			// raAuto
			// 
			this.raAuto.Location = new System.Drawing.Point(36, 44);
			this.raAuto.Name = "raAuto";
			this.raAuto.Size = new System.Drawing.Size(160, 24);
			this.raAuto.TabIndex = 6;
			this.raAuto.Text = "Tính ngưỡng tự động";
			this.raAuto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.raAuto_MouseUp);
			this.raAuto.CheckedChanged += new System.EventHandler(this.raAuto_CheckedChanged);
			// 
			// lbThreshManu
			// 
			this.lbThreshManu.Location = new System.Drawing.Point(60, 100);
			this.lbThreshManu.Name = "lbThreshManu";
			this.lbThreshManu.Size = new System.Drawing.Size(120, 23);
			this.lbThreshManu.TabIndex = 5;
			this.lbThreshManu.Text = "Đặt giá trị ngưỡng";
			// 
			// txtThreshold
			// 
			this.txtThreshold.Location = new System.Drawing.Point(180, 100);
			this.txtThreshold.Name = "txtThreshold";
			this.txtThreshold.Size = new System.Drawing.Size(48, 20);
			this.txtThreshold.TabIndex = 4;
			this.txtThreshold.Text = "";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.txtMaskNumber);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.chbMask);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.button4);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.txtfi);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.txtF);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(288, 150);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Tăng cường";
			// 
			// txtMaskNumber
			// 
			this.txtMaskNumber.Location = new System.Drawing.Point(224, 120);
			this.txtMaskNumber.Name = "txtMaskNumber";
			this.txtMaskNumber.Size = new System.Drawing.Size(48, 20);
			this.txtMaskNumber.TabIndex = 17;
			this.txtMaskNumber.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(96, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 18;
			this.label9.Text = "Số lượng mặt nạ";
			// 
			// chbMask
			// 
			this.chbMask.Location = new System.Drawing.Point(40, 96);
			this.chbMask.Name = "chbMask";
			this.chbMask.Size = new System.Drawing.Size(160, 24);
			this.chbMask.TabIndex = 16;
			this.chbMask.Text = "Sử dụng bộ mặt nạ chuẩn";
			this.chbMask.CheckedChanged += new System.EventHandler(this.chbMask_CheckedChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(208, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "1/";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(224, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(56, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "Default";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Thiết đặt thông số tăng cường ảnh";
			// 
			// txtfi
			// 
			this.txtfi.Location = new System.Drawing.Point(224, 72);
			this.txtfi.Name = "txtfi";
			this.txtfi.Size = new System.Drawing.Size(48, 20);
			this.txtfi.TabIndex = 11;
			this.txtfi.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(40, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 16);
			this.label7.TabIndex = 10;
			this.label7.Text = "Giá trị tần suất vân tay cụ bộ";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(40, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "Đại diện giải thông";
			// 
			// txtF
			// 
			this.txtF.Location = new System.Drawing.Point(224, 48);
			this.txtF.Name = "txtF";
			this.txtF.Size = new System.Drawing.Size(48, 20);
			this.txtF.TabIndex = 9;
			this.txtF.Text = "";
			// 
			// button3
			// 
			this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button3.Location = new System.Drawing.Point(168, 200);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "OK";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Cancel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ImageProcessSetting
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 229);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Name = "ImageProcessSetting";
			this.Text = "Thông số xử lý ảnh";
			this.Load += new System.EventHandler(this.ImageProcessSetting_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ImageProcessSetting_Load(object sender, System.EventArgs e)
		{
			txtM.Text = m.ToString();
			txtV.Text = v.ToString();
			txtfi.Text = fi.ToString();
			txtF.Text = f.ToString();
			if(threshold>0)
			{
				raManual.Checked = true;
				txtThreshold.Text = threshold.ToString();
				txtThreshold.Enabled = true;
				lbThreshManu.Enabled = true;
			}
			else
			{
				raAuto.Checked = true;
				txtThreshold.Text = "";
				txtThreshold.Enabled = false;
				lbThreshManu.Enabled = false;
			}
			if(maskNumber>0)
			{
				chbMask.Checked = true;
				txtMaskNumber.Text = maskNumber.ToString();
				label9.Enabled = true;
				txtMaskNumber.Enabled = true;
			}
			else
			{
				maskNumber = 0;
				label9.Enabled = false;
				txtMaskNumber.Enabled = false;
			}
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			txtM.Text = "50";
			txtV.Text = "300";
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			txtF.Text = "7";
			txtfi.Text = "3";
			chbMask.Checked = true;
			txtMaskNumber.Text = "32";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				m = Convert.ToInt32(txtM.Text);
				v = Convert.ToInt32(txtV.Text);
				f = Convert.ToInt32(txtF.Text);
				fi = Convert.ToInt32(txtfi.Text);
				if(raAuto.Checked == true)
					threshold = 0;
				else
				{
					if(!txtThreshold.Text.Equals(""))					
						threshold = Convert.ToInt32(txtThreshold.Text);
				}
				if(chbMask.Checked == true)
				{
					if(!txtMaskNumber.Text.Equals(""))			
						maskNumber = Convert.ToInt32(txtMaskNumber.Text);
				}
				else
					maskNumber = 0;
			}
			catch
			{
				MessageBox.Show("Dữ liệu nhập không tốt");
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void raAuto_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			lbThreshManu.Enabled = false;
			txtThreshold.Enabled = false;
		}

		private void raManual_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			lbThreshManu.Enabled = true;
			txtThreshold.Enabled = true;
		}

		private void chbMask_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chbMask.Checked == true)
			{
				label9.Enabled = true;
				txtMaskNumber.Enabled = true;				
			}
			else
			{
				label9.Enabled = false;
				txtMaskNumber.Enabled = false;
				txtMaskNumber.Text = "";
			}
		}

		private void raAuto_CheckedChanged(object sender, System.EventArgs e)
		{
			if(raAuto.Checked == true)
			{
				lbThreshManu.Enabled = false;
				txtThreshold.Enabled = false;
				txtThreshold.Text = "";
			}
			else
			{
				lbThreshManu.Enabled = true;
				txtThreshold.Enabled = true;
			}
		}
	}
}
