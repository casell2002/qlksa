using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace qlks
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		public System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnQuanLy;
		private System.Windows.Forms.MenuItem mnCauHinh;
		public System.Windows.Forms.MenuItem mnQLKhachHang;
		public System.Windows.Forms.MenuItem mnLoaiPhong;
		public System.Windows.Forms.MenuItem mnThietBi;
		private System.Windows.Forms.MenuItem mnTB;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnExit;
		private System.Windows.Forms.MenuItem mnPhong;
		private System.Windows.Forms.MenuItem mnHoSoNV;
		private System.Windows.Forms.MenuItem mnCaNhan;
		public System.Windows.Forms.MenuItem mnTBTrangTB;
		private System.Windows.Forms.MenuItem menuItem7;
		// User variables
		public static string msNV = "", tenNV="";
		private System.Windows.Forms.MenuItem mnTimKiem;
		private System.Windows.Forms.MenuItem mnTG;
		private System.Windows.Forms.StatusBar stBar;
		private System.Windows.Forms.StatusBarPanel NhanVien;
		private System.Windows.Forms.StatusBarPanel Date;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnSapXep;
		private System.Windows.Forms.MenuItem mnCascade;
		private System.Windows.Forms.MenuItem mnTileV;
		private System.Windows.Forms.MenuItem mnTileH;
		public System.Windows.Forms.MenuItem mnSDDichVu;
		private System.Windows.Forms.MenuItem mnThanhToan;
		private System.Windows.Forms.MenuItem mnSearchPhong;
		private System.Windows.Forms.MenuItem mnSearchKH;
		private System.Windows.Forms.MenuItem mnAbout;
		private IContainer components;

		public frmMain()
		{
			
			InitializeComponent();

		
		}
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new frmMain());			
		}
	
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		
		private void frmMain_Load(object sender, System.EventArgs e)
		{
			if (msNV=="")
			{
				frmLogin f = new frmLogin();
				f.Show ();
				this.Hide();
			}
		}

		private void mnPhong_Click(object sender, System.EventArgs e)
		{
			frmPhong f = new frmPhong();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnThietBi_Click(object sender, System.EventArgs e)
		{
			frmThietBi f = new frmThietBi();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnHoSoNV_Click(object sender, System.EventArgs e)
		{
			frmNV f = new frmNV();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnLoaiPhong_Click(object sender, System.EventArgs e)
		{
			frmLoaiPhong f = new frmLoaiPhong();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnTBTrangTB_Click(object sender, System.EventArgs e)
		{
			frmTBTrangTB f = new frmTBTrangTB();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		public void enableFormMain(string masoNV)
		{
			msNV = masoNV;
			DataTable dtNV= new DataTable();
			dtNV=SqlHelper.ExecuteQuery(
                "select top 1 MANHANVIEN from NHANVIEN order by MANHANVIEN",
				CommandType.Text);
			if (dtNV.Rows[0]["MANHANVIEN"].ToString()!=msNV)
				mnCauHinh.Visible=false;
			dtNV=SqlHelper.ExecuteQuery(
                "select HOTEN from NHANVIEN where MANHANVIEN='" + msNV+"'",
				CommandType.Text);
			tenNV=dtNV.Rows[0]["HOTEN"].ToString();
			stBar.Panels[0].Text="Nhân viên : " + tenNV;
			stBar.Panels[1].Text="Hôm nay : " + DateTime.Now.ToShortDateString();
		}

		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}

		private void mnQLKhachHang_Click(object sender, System.EventArgs e)
		{
			frmKH f = new frmKH();
			f.MdiParent=this;
			f.Show();
		}

		private void mnQLPhong_Click(object sender, System.EventArgs e)
		{
			frmSDDichVu f = new frmSDDichVu();
			f.MdiParent=this;
			f.Show();
		}

		private void mnCascade_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi( MdiLayout.Cascade );
		}

		private void mnTileH_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi( MdiLayout.TileHorizontal );
		}

		private void mnTileV_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi( MdiLayout.TileVertical );
		}

		private void mnThanhToan_Click(object sender, System.EventArgs e)
		{
			frmTraPhong f = new frmTraPhong();
			f.MdiParent=this;
			f.Show();
		}

		private void mnSearchKH_Click(object sender, System.EventArgs e)
		{
			frmSearchKH f = new frmSearchKH();
			f.MdiParent=this;
			f.Show();
		}

		private void mnSearchPhong_Click(object sender, System.EventArgs e)
		{
			frmSearchPhong f = new frmSearchPhong();
			f.MdiParent=this;
			f.Show();
		}

		private void mnCaNhan_Click(object sender, System.EventArgs e)
		{
			frmChangeProfile f = new frmChangeProfile();
			f.MdiParent=this;
			f.Show();
		}

		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(527, 300);
            this.Name = "frmMain";
            this.ResumeLayout(false);

		}

		private void mnAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Project - Chương trình quản lý khách sạn.\r\nĐồ Án C# Nhóm Hello -","Thông tin tác giả");
		}

	}
}
