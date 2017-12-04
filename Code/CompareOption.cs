using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FingerprintRegnition
{
	/// <summary>
	/// Summary description for CompareOption.
	/// </summary>
	public class CompareOption : System.Windows.Forms.Form
	{
		#region window controls		
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtAngLimit;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtDisLimit;
		private System.Windows.Forms.TextBox txtMinuNumLimit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		#endregion

		#region attributes and propties
		private int angleLimit;
		private int distanceLimit;
		private int minuNumberLimit;

		public int AngleLimit
		{
			get
			{
				return angleLimit;
			}
		}
		public int DistanceLimit
		{
			get
			{
				return distanceLimit;
			}
		}
		public int MinuNumberLimit
		{
			get
			{
				return minuNumberLimit;
			}
		}
		#endregion

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CompareOption(int angle,int distance,int minuNumber)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			angleLimit = angle;
			distanceLimit = distance;
			minuNumberLimit = minuNumber;
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
			this.button7 = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtAngLimit = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtDisLimit = new System.Windows.Forms.TextBox();
			this.txtMinuNumLimit = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(72, 192);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(56, 23);
			this.button7.TabIndex = 22;
			this.button7.Text = "Default";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(16, 32);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(176, 16);
			this.label17.TabIndex = 21;
			this.label17.Text = "Lượng chi tiết trùng khớp  tối thiểu";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 56);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(144, 23);
			this.label18.TabIndex = 20;
			this.label18.Text = "Độ lệch góc";
			// 
			// txtAngLimit
			// 
			this.txtAngLimit.Location = new System.Drawing.Point(192, 56);
			this.txtAngLimit.Name = "txtAngLimit";
			this.txtAngLimit.Size = new System.Drawing.Size(40, 20);
			this.txtAngLimit.TabIndex = 19;
			this.txtAngLimit.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 24);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(144, 23);
			this.label19.TabIndex = 18;
			this.label19.Text = "Độ lớn khoảng cách";
			// 
			// txtDisLimit
			// 
			this.txtDisLimit.Location = new System.Drawing.Point(192, 24);
			this.txtDisLimit.Name = "txtDisLimit";
			this.txtDisLimit.Size = new System.Drawing.Size(40, 20);
			this.txtDisLimit.TabIndex = 17;
			this.txtDisLimit.Text = "";
			// 
			// txtMinuNumLimit
			// 
			this.txtMinuNumLimit.Location = new System.Drawing.Point(200, 32);
			this.txtMinuNumLimit.Name = "txtMinuNumLimit";
			this.txtMinuNumLimit.Size = new System.Drawing.Size(40, 20);
			this.txtMinuNumLimit.TabIndex = 23;
			this.txtMinuNumLimit.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.txtDisLimit);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.txtAngLimit);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 88);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Điều kiện chi tiết trùng khớp";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(232, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 22;
			this.label2.Text = "px";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(232, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 24);
			this.label1.TabIndex = 21;
			this.label1.Text = "o";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(216, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 25;
			this.button1.Text = "Cancel";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(144, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 23);
			this.button2.TabIndex = 26;
			this.button2.Text = "OK";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.txtMinuNumLimit);
			this.groupBox2.Location = new System.Drawing.Point(16, 112);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 64);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Điều kiện hai vân tay trùng khớp";
			// 
			// CompareOption
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 229);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button7);
			this.Name = "CompareOption";
			this.Text = "Thông số đối sánh ảnh";
			this.Load += new System.EventHandler(this.CompareOption_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Events
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			angleLimit = Convert.ToInt32(txtAngLimit.Text);
			distanceLimit = Convert.ToInt32(txtDisLimit.Text);
			minuNumberLimit = Convert.ToInt32(txtMinuNumLimit.Text);			
			this.Close();
		}
	
		private void button7_Click(object sender, System.EventArgs e)
		{
			txtMinuNumLimit.Text = "14";
			txtAngLimit.Text = "5";
			txtDisLimit.Text = "5";
		}
	#endregion

		private void CompareOption_Load(object sender, System.EventArgs e)
		{
			txtAngLimit.Text = angleLimit.ToString();
			txtDisLimit.Text = distanceLimit.ToString();
			txtMinuNumLimit.Text = minuNumberLimit.ToString();
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				angleLimit = Convert.ToInt32(txtAngLimit.Text);
				distanceLimit = Convert.ToInt32(txtDisLimit.Text);
				minuNumberLimit = Convert.ToInt32(txtMinuNumLimit.Text);
				this.Close();
			}
			catch
			{
				MessageBox.Show("Dữ liệu nhập không tốt");
			}
		}

	}
}
