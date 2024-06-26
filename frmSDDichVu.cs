using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace qlks
{

	public class frmSDDichVu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdSave;
		#region User Varibles
        //Download source code tại Sharecode.vn
		#endregion

		private System.Windows.Forms.ComboBox cboMaP;
		private System.Windows.Forms.Panel panTrangBi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dTPicker_NgaySD;

       
		private System.ComponentModel.Container components = null;

		public frmSDDichVu()
		{
			
			InitializeComponent();

			
		}

	
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
	
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTPicker_NgaySD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaP = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panTrangBi = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPicker_NgaySD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMaP);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panTrangBi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 397);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dTPicker_NgaySD
            // 
            this.dTPicker_NgaySD.CustomFormat = "\"dd mm yyyy\"";
            this.dTPicker_NgaySD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPicker_NgaySD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_NgaySD.Location = new System.Drawing.Point(115, 55);
            this.dTPicker_NgaySD.Name = "dTPicker_NgaySD";
            this.dTPicker_NgaySD.Size = new System.Drawing.Size(106, 23);
            this.dTPicker_NgaySD.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ngày sử dụng:";
            // 
            // cboMaP
            // 
            this.cboMaP.Location = new System.Drawing.Point(115, 18);
            this.cboMaP.Name = "cboMaP";
            this.cboMaP.Size = new System.Drawing.Size(106, 24);
            this.cboMaP.TabIndex = 12;
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(278, 52);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(77, 26);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Thoát";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(278, 18);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(77, 27);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã phòng:";
            // 
            // panTrangBi
            // 
            this.panTrangBi.AutoScroll = true;
            this.panTrangBi.Location = new System.Drawing.Point(10, 92);
            this.panTrangBi.Name = "panTrangBi";
            this.panTrangBi.Size = new System.Drawing.Size(345, 296);
            this.panTrangBi.TabIndex = 19;
            this.panTrangBi.Paint += new System.Windows.Forms.PaintEventHandler(this.panTrangBi_Paint);
            // 
            // frmSDDichVu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(392, 397);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSDDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		void Load_TrangThietBi()
		{
			DataTable dt=SqlHelper.ExecuteQuery("pr_list_ThietBi",
				CommandType.StoredProcedure,"@option","2");
			panTrangBi.Controls.Clear();
			int i=0;
			foreach (DataRow row in dt.Rows)
			{
				CheckBox chk=new CheckBox();
				chk.Checked=false;
				chk.Location=new Point(5,i*25+3);
				chk.CheckedChanged+=new EventHandler(chk_CheckedChanged);
				chk.Width=10;
				chk.FlatStyle=FlatStyle.System;
				chk.Name="chk;"+row["Mathietbi"].ToString();
				panTrangBi.Controls.Add(chk);
				
				Label lbl=new Label();
				lbl.Text=row["TENTHIETBI"].ToString();
				lbl.BorderStyle=BorderStyle.None;
				lbl.Location=new Point(5+10+5,i*25+5);
				lbl.Width=150;
				panTrangBi.Controls.Add(lbl);

				NumericUpDown num=new NumericUpDown();
				num.Value=0;
				num.Minimum=0;
				num.Maximum=10;
				num.Location=new Point(5+10+5+150+5,i*25+5);
				num.Visible=true;
				num.Enabled=false;
				num.Width=50;
				panTrangBi.Controls.Add(num);

				chk.Tag=num;
				i++;
			}
		}
		void Load_LoaiP()
		{
			try
			{
				DataTable dtLoaiP=SqlHelper.ExecuteQuery(
					"select distinct thuephong.maphong, chitietthuephong.sHDthuephong from thuephong,khachhang,chitietthuephong where thuephong.sHDthuephong not in (select sHDthuephong from HDThanhtoanphong)and thuephong.sHDthuephong = chitietthuephong.sHDthuephong and khachhang.makhach = chitietthuephong.makhach",
					CommandType.Text);
				foreach (DataRow row in dtLoaiP.Rows)
				//cboMaP.DataSource=dtLoaiP;
				cboMaP.Items.Add(row["maphong"].ToString().Trim());
				//cboMaP.DisplayMember="msphong";
				//cboMaP.ValueMember="msphong";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_LoaiP();
			Load_TrangThietBi();
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void chk_CheckedChanged(object sender, System.EventArgs e)
		{
			CheckBox chk=sender as CheckBox;
			NumericUpDown num=chk.Tag as NumericUpDown;
			num.Enabled=chk.Checked;
			cmdSave.Enabled=true;
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			cmdSave.Enabled=false;

			for(int i=0;i<panTrangBi.Controls.Count;i++)
			{
				if (panTrangBi.Controls[i].Name.IndexOf("chk;")>=0)
				{
					CheckBox chk=panTrangBi.Controls[i] as CheckBox;
					if (chk.Checked)
					{
						string mstb=chk.Name.Replace("chk;","");
						NumericUpDown num=chk.Tag as NumericUpDown;
						string soluong=num.Value.ToString();

						DataTable dtPhong_KH=SqlHelper.ExecuteQuery(
							"pr_Phong_KH",
							CommandType.StoredProcedure,
							"@maphong",cboMaP.Text);
						string sHDthue = dtPhong_KH.Rows[0]["sHDthuephong"].ToString();				
						
						SqlHelper.ExecuteNonQuery("pr_ins_SuDung_DV",
							CommandType.StoredProcedure,
							"@option",1,
							"@SHDTHUEPHONG",sHDthue,
							"@Mathietbi",mstb,
							"@NGAYSD",dTPicker_NgaySD.Value,
							"@SOLUONG",soluong);
					
					}
				}
			}
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void panTrangBi_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
