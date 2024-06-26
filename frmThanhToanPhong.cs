using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace qlks
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class frmTraPhong : System.Windows.Forms.Form
	{
		#region User Varibles
		DateTime ngaytra;
		double tong_tien=0;
		#endregion
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboMaP;
		private System.Windows.Forms.ColumnHeader TenDV;
		private System.Windows.Forms.ColumnHeader Ngay;
		private System.Windows.Forms.ColumnHeader SoLuong;
		private System.Windows.Forms.ColumnHeader Gia;
		private System.Windows.Forms.TextBox txtBaoCao;
		private System.Windows.Forms.Button cmdShow;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Button cmdThanhToan;


		private System.ComponentModel.Container components = null;

		public frmTraPhong()
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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cboMaP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBaoCao = new System.Windows.Forms.TextBox();
            this.lView = new System.Windows.Forms.ListView();
            this.TenDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdThanhToan = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdExit);
            this.groupBox2.Controls.Add(this.cmdShow);
            this.groupBox2.Controls.Add(this.cboMaP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.cmdThanhToan);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 545);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hợp đồng thanh toán";
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(374, 489);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(202, 46);
            this.cmdExit.TabIndex = 31;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdShow
            // 
            this.cmdShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShow.Location = new System.Drawing.Point(288, 46);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(86, 28);
            this.cmdShow.TabIndex = 29;
            this.cmdShow.Text = "Xem";
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cboMaP
            // 
            this.cboMaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaP.Location = new System.Drawing.Point(134, 46);
            this.cboMaP.Name = "cboMaP";
            this.cboMaP.Size = new System.Drawing.Size(125, 25);
            this.cboMaP.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Chọn mã phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBaoCao);
            this.groupBox1.Controls.Add(this.lView);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 397);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sử dụng dịch vụ";
            // 
            // txtBaoCao
            // 
            this.txtBaoCao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaoCao.Location = new System.Drawing.Point(10, 28);
            this.txtBaoCao.Multiline = true;
            this.txtBaoCao.Name = "txtBaoCao";
            this.txtBaoCao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBaoCao.Size = new System.Drawing.Size(614, 157);
            this.txtBaoCao.TabIndex = 27;
            this.txtBaoCao.TextChanged += new System.EventHandler(this.txtBaoCao_TextChanged);
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenDV,
            this.Ngay,
            this.SoLuong,
            this.Gia});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(10, 185);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(614, 203);
            this.lView.TabIndex = 14;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            // 
            // TenDV
            // 
            this.TenDV.Text = "Tên dịch vụ";
            this.TenDV.Width = 200;
            // 
            // Ngay
            // 
            this.Ngay.Text = "Ngày sử dụng";
            this.Ngay.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            // 
            // Gia
            // 
            this.Gia.Text = "Giá";
            // 
            // cmdThanhToan
            // 
            this.cmdThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdThanhToan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThanhToan.Location = new System.Drawing.Point(86, 489);
            this.cmdThanhToan.Name = "cmdThanhToan";
            this.cmdThanhToan.Size = new System.Drawing.Size(202, 46);
            this.cmdThanhToan.TabIndex = 31;
            this.cmdThanhToan.Text = "Thanh toán";
            this.cmdThanhToan.Click += new System.EventHandler(this.cmdThanhToan_Click);
            // 
            // frmTraPhong
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(664, 578);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng thanh toán phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		void Load_Phong()
		{
			try
			{
				DataTable dtLoaiP=SqlHelper.ExecuteQuery(
					"select distinct thuephong.maphong, chitietthuephong.sHDthuephong from thuephong,khachhang,chitietthuephong where thuephong.sHDthuephong not in (select sHDthuephong from HDThanhtoanphong)and thuephong.sHDthuephong = chitietthuephong.sHDthuephong and khachhang.makhach = chitietthuephong.makhach",
					CommandType.Text);
				cboMaP.DataSource=dtLoaiP;
				cboMaP.DisplayMember="maphong";
				cboMaP.ValueMember="sHDthuephong";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_Phong();

		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void cmdShow_Click(object sender, System.EventArgs e)
		{
			try
			{
				

				DataTable dtTT=SqlHelper.ExecuteQuery(
					"pr_list_SuDungDV",
					CommandType.StoredProcedure,
					"@SHDTHUEPHONG",cboMaP.SelectedValue);

				lView.Items.Clear();
				double giaDV=0;
				lView.Items.Clear();
				if (dtTT.Rows.Count>0)
				{
					foreach (DataRow row in dtTT.Rows)
					{
						ListViewItem item=new ListViewItem();
						item.Text=row["TENTHIETBI"].ToString();
						item.SubItems.Add(DateTime.Parse(row["NGAYSD"].ToString()).ToString("d"));
						item.SubItems.Add(row["SOLUONG"].ToString());
						item.SubItems.Add(Double.Parse(row["GIATB"].ToString()).ToString("c"));
						giaDV=giaDV+Double.Parse(row["GIATB"].ToString())*Double.Parse(row["SOLUONG"].ToString());
						lView.Items.Add(item);			
					}
				}
				DataTable dtNgayThue=SqlHelper.ExecuteQuery(
					"select NGAYTHUE from THUEPHONG where SHDTHUEPHONG="+cboMaP.SelectedValue,
					CommandType.Text);
				DateTime ngaythue= DateTime.Parse(dtNgayThue.Rows[0]["NGAYTHUE"].ToString());
				ngaytra=DateTime.Now;
				double giaPhong=Lay_Tien_Phong(cboMaP.Text.Trim(),ngaythue,ngaytra);
			
				tong_tien=giaDV+giaPhong;
				txtBaoCao.Text="Nhân viên thanh toán: \t"+frmMain.tenNV+"\r\n";
				txtBaoCao.Text=txtBaoCao.Text+"Mã số phòng thuê: \t\t"+cboMaP.Text.Trim()+"\r\n";
				txtBaoCao.Text=txtBaoCao.Text+"Ngày thuê: \t\t"+ngaythue.ToShortDateString()+"\r\n";
				txtBaoCao.Text=txtBaoCao.Text+"Ngày trả: \t\t\t"+ngaytra.ToShortDateString()+"\r\n";
				txtBaoCao.Text=txtBaoCao.Text+"Phí thuê phòng: \t\t"+giaPhong.ToString("c")+"\r\n";
				txtBaoCao.Text=txtBaoCao.Text+"Phí sử dụng dịch vụ: \t"+giaDV.ToString("c")+"\r\n";
				txtBaoCao.Text=txtBaoCao.Text+"--------------------------------------------------------\r\n";
				txtBaoCao.Text=txtBaoCao.Text+"Tổng cộng: \t\t"+tong_tien.ToString("c");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		double Lay_Tien_Phong(string msphong, DateTime ngaythue, DateTime ngaytra)
		{
			DataTable dtGiaP=SqlHelper.ExecuteQuery(
				"select LOAIPHONG.GIATIEN from DMPHONG, LOAIPHONG where LOAIPHONG.MALOAIPHONG=DMPHONG.MALOAIPHONG and DMPHONG.MAPHONG="+msphong,
				CommandType.Text);
			double giatien=double.Parse(dtGiaP.Rows[0]["GIATIEN"].ToString());
			TimeSpan t;
			t=ngaytra.Subtract(ngaythue);
			double songay=t.TotalDays;
			
			giatien=giatien* Math.Round(songay);
			return Math.Round(giatien);
		}

		private void cmdThanhToan_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				SqlHelper.ExecuteNonQuery(
					"pr_ins_HDThanhToan",
					CommandType.StoredProcedure,
					"@SHDTHUEPHONG",cboMaP.SelectedValue,
					"@MANHANVIEN",frmMain.msNV,
					"@NGAYTHANHTOAN",ngaytra,
					"@TIENPHONG",Double.Parse(tong_tien.ToString()));
				
				SqlHelper.ExecuteNonQuery(
					"Update DMPHONG set TINHTRANG='0' WHERE MAPHONG='"+cboMaP.Text.Trim()+"'",
					CommandType.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txtBaoCao_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
