using System;
using System.IO;
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
	public class frmNV : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpFunction;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Button cmdDelete;
		private System.Windows.Forms.Button cmdEdit;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.ListView lView;
		#region User Varibles
		public static string _connectString="data source=vanlang;database=demo;uid=sa;password=";
		int _option=0,pos=0;
		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ColumnHeader MNV;
		private System.Windows.Forms.ColumnHeader TEN;
		private System.Windows.Forms.ColumnHeader NSINH;
		private System.Windows.Forms.ColumnHeader DCHI;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.TextBox txtMKhau;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDChi;
		private System.Windows.Forms.TextBox txtDThoai;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColumnHeader DTHOAI;
		private System.Windows.Forms.ColumnHeader NGAYVAOLAM;
		private System.Windows.Forms.ColumnHeader MK;
		private System.Windows.Forms.ColumnHeader GTinh;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton optNam;
		private System.Windows.Forms.RadioButton optNu;
		private System.Windows.Forms.DateTimePicker dTPicker_NSinh;
		private System.Windows.Forms.DateTimePicker dTPicker_NVaoLam;
		private System.Windows.Forms.TextBox txtMKhau_R;
		private System.Windows.Forms.Label lbMKhau_R;
		private System.Windows.Forms.PictureBox picNV;
		private System.Windows.Forms.LinkLabel linklbInsertPic;
		private System.Windows.Forms.OpenFileDialog OFileDialog;
		private System.Windows.Forms.ColumnHeader HINH;
		private System.Windows.Forms.LinkLabel linklbDelPic;

		private System.ComponentModel.Container components = null;

		public frmNV()
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
            this.lView = new System.Windows.Forms.ListView();
            this.MNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NSINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DCHI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DTHOAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYVAOLAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linklbInsertPic = new System.Windows.Forms.LinkLabel();
            this.picNV = new System.Windows.Forms.PictureBox();
            this.dTPicker_NSinh = new System.Windows.Forms.DateTimePicker();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.txtDThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMKhau_R = new System.Windows.Forms.TextBox();
            this.lbMKhau_R = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.dTPicker_NVaoLam = new System.Windows.Forms.DateTimePicker();
            this.linklbDelPic = new System.Windows.Forms.LinkLabel();
            this.OFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpFunction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MNV,
            this.TEN,
            this.GTinh,
            this.MK,
            this.NSINH,
            this.DCHI,
            this.DTHOAI,
            this.NGAYVAOLAM,
            this.HINH});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(10, 323);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(758, 231);
            this.lView.TabIndex = 3;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
            // 
            // MNV
            // 
            this.MNV.Text = "Mã nhân viên";
            this.MNV.Width = 50;
            // 
            // TEN
            // 
            this.TEN.Text = "Họ tên";
            this.TEN.Width = 150;
            // 
            // GTinh
            // 
            this.GTinh.Text = "Giới tính";
            // 
            // MK
            // 
            this.MK.Text = "Mật khẩu";
            this.MK.Width = 0;
            // 
            // NSINH
            // 
            this.NSINH.Text = "Ngày sinh";
            this.NSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSINH.Width = 100;
            // 
            // DCHI
            // 
            this.DCHI.Text = "Địa chỉ";
            this.DCHI.Width = 100;
            // 
            // DTHOAI
            // 
            this.DTHOAI.Text = "Điện thoại";
            this.DTHOAI.Width = 70;
            // 
            // NGAYVAOLAM
            // 
            this.NGAYVAOLAM.Text = "Ngày vào làm";
            this.NGAYVAOLAM.Width = 100;
            // 
            // HINH
            // 
            this.HINH.Text = "Hình";
            this.HINH.Width = 0;
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.cmdExit);
            this.grpFunction.Controls.Add(this.cmdDelete);
            this.grpFunction.Controls.Add(this.cmdEdit);
            this.grpFunction.Controls.Add(this.cmdAdd);
            this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpFunction.Location = new System.Drawing.Point(662, 0);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Size = new System.Drawing.Size(106, 314);
            this.grpFunction.TabIndex = 5;
            this.grpFunction.TabStop = false;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExit.Location = new System.Drawing.Point(10, 129);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(86, 27);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDelete.Location = new System.Drawing.Point(10, 92);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(86, 27);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEdit.Location = new System.Drawing.Point(10, 55);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(86, 27);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Sửa";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(10, 18);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(86, 27);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linklbInsertPic);
            this.groupBox1.Controls.Add(this.picNV);
            this.groupBox1.Controls.Add(this.dTPicker_NSinh);
            this.groupBox1.Controls.Add(this.optNam);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMKhau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDChi);
            this.groupBox1.Controls.Add(this.txtDThoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMKhau_R);
            this.groupBox1.Controls.Add(this.lbMKhau_R);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.optNu);
            this.groupBox1.Controls.Add(this.dTPicker_NVaoLam);
            this.groupBox1.Controls.Add(this.linklbDelPic);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 314);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // linklbInsertPic
            // 
            this.linklbInsertPic.Location = new System.Drawing.Point(432, 286);
            this.linklbInsertPic.Name = "linklbInsertPic";
            this.linklbInsertPic.Size = new System.Drawing.Size(134, 19);
            this.linklbInsertPic.TabIndex = 14;
            this.linklbInsertPic.TabStop = true;
            this.linklbInsertPic.Text = "Chèn hình nhân viên";
            this.linklbInsertPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklbInsertPic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbInsertPic_LinkClicked);
            // 
            // picNV
            // 
            this.picNV.BackColor = System.Drawing.Color.Silver;
            this.picNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNV.Location = new System.Drawing.Point(470, 157);
            this.picNV.Name = "picNV";
            this.picNV.Size = new System.Drawing.Size(135, 129);
            this.picNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNV.TabIndex = 13;
            this.picNV.TabStop = false;
            // 
            // dTPicker_NSinh
            // 
            this.dTPicker_NSinh.CustomFormat = "\"dd mm yyyy\"";
            this.dTPicker_NSinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPicker_NSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_NSinh.Location = new System.Drawing.Point(144, 129);
            this.dTPicker_NSinh.Name = "dTPicker_NSinh";
            this.dTPicker_NSinh.Size = new System.Drawing.Size(154, 23);
            this.dTPicker_NSinh.TabIndex = 5;
            // 
            // optNam
            // 
            this.optNam.Checked = true;
            this.optNam.Location = new System.Drawing.Point(144, 166);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(77, 28);
            this.optNam.TabIndex = 6;
            this.optNam.TabStop = true;
            this.optNam.Text = "Nam";
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(538, 55);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(90, 27);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "Hủy bỏ";
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(538, 18);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(90, 27);
            this.cmdSave.TabIndex = 11;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(144, 18);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(154, 23);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(144, 55);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(230, 23);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMKhau
            // 
            this.txtMKhau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKhau.Location = new System.Drawing.Point(144, 92);
            this.txtMKhau.Name = "txtMKhau";
            this.txtMKhau.PasswordChar = '*';
            this.txtMKhau.Size = new System.Drawing.Size(106, 23);
            this.txtMKhau.TabIndex = 3;
            this.txtMKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKhau_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDChi
            // 
            this.txtDChi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDChi.Location = new System.Drawing.Point(144, 203);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(230, 23);
            this.txtDChi.TabIndex = 8;
            // 
            // txtDThoai
            // 
            this.txtDThoai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDThoai.Location = new System.Drawing.Point(144, 240);
            this.txtDThoai.Name = "txtDThoai";
            this.txtDThoai.Size = new System.Drawing.Size(154, 23);
            this.txtDThoai.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày vào làm:";
            // 
            // txtMKhau_R
            // 
            this.txtMKhau_R.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKhau_R.Location = new System.Drawing.Point(403, 92);
            this.txtMKhau_R.Name = "txtMKhau_R";
            this.txtMKhau_R.PasswordChar = '*';
            this.txtMKhau_R.Size = new System.Drawing.Size(106, 23);
            this.txtMKhau_R.TabIndex = 4;
            this.txtMKhau_R.Visible = false;
            // 
            // lbMKhau_R
            // 
            this.lbMKhau_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKhau_R.Location = new System.Drawing.Point(269, 92);
            this.lbMKhau_R.Name = "lbMKhau_R";
            this.lbMKhau_R.Size = new System.Drawing.Size(134, 28);
            this.lbMKhau_R.TabIndex = 8;
            this.lbMKhau_R.Text = "Nhập lại mật khẩu:";
            this.lbMKhau_R.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giới tính:";
            // 
            // optNu
            // 
            this.optNu.Location = new System.Drawing.Point(278, 166);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(68, 28);
            this.optNu.TabIndex = 7;
            this.optNu.Text = "Nữ";
            // 
            // dTPicker_NVaoLam
            // 
            this.dTPicker_NVaoLam.CustomFormat = "\"dd mm yyyy\"";
            this.dTPicker_NVaoLam.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPicker_NVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_NVaoLam.Location = new System.Drawing.Point(144, 277);
            this.dTPicker_NVaoLam.Name = "dTPicker_NVaoLam";
            this.dTPicker_NVaoLam.Size = new System.Drawing.Size(154, 23);
            this.dTPicker_NVaoLam.TabIndex = 10;
            // 
            // linklbDelPic
            // 
            this.linklbDelPic.Location = new System.Drawing.Point(566, 286);
            this.linklbDelPic.Name = "linklbDelPic";
            this.linklbDelPic.Size = new System.Drawing.Size(68, 19);
            this.linklbDelPic.TabIndex = 14;
            this.linklbDelPic.TabStop = true;
            this.linklbDelPic.Text = "Xóa hình";
            this.linklbDelPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklbDelPic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbDelPic_LinkClicked);
            // 
            // OFileDialog
            // 
            this.OFileDialog.AddExtension = false;
            this.OFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|Gif files (*.gif)|*.gif|Bitmap files (*.bmp)|*.bmp";
            this.OFileDialog.Title = "Chọn hình";
            // 
            // frmNV
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(650, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lView);
            this.Controls.Add(this.grpFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Activated += new System.EventHandler(this.frmPhong_Activated);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.grpFunction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		void Load_NV()
		{
			try
			{
				DataTable dtTB=SqlHelper.ExecuteQuery(
					"pr_list_NV",
					CommandType.StoredProcedure);
				lView.Items.Clear();
				if (dtTB.Rows.Count>0)
				{
					foreach (DataRow row in dtTB.Rows)
					{
						ListViewItem item=new ListViewItem();
						item.Text=row["Manhanvien"].ToString();
						item.SubItems.Add(row["HOTEN"].ToString());
						item.SubItems.Add(row["GIOITINH"].ToString()=="1"?"Nam":"Nữ");
						item.SubItems.Add(row["MatKhau"].ToString());
						item.SubItems.Add(DateTime.Parse(row["NGAYSINH"].ToString()).ToString("d"));
						item.SubItems.Add(row["DIACHI"].ToString());
						item.SubItems.Add(row["SODIENTHOAI"].ToString());
						item.SubItems.Add(DateTime.Parse(row["NGAYVAOLAM"].ToString()).ToString("d"));
					
						lView.Items.Add(item);
					}
					lView.Items[pos].Selected=true;
					lView_SelectedIndexChanged(lView.Items[pos], System.EventArgs.Empty);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void SetEdit()
		{
			txtMaNV.ReadOnly=true;
			txtDChi.ReadOnly=false;
			txtDThoai.ReadOnly=false;
			txtMKhau.ReadOnly=false;
			txtMKhau_R.Text=txtMKhau.Text;
			txtTenNV.ReadOnly=false;
			linklbInsertPic.Enabled=true;
			linklbDelPic.Enabled=true;

			dTPicker_NSinh.Enabled=true;
			dTPicker_NVaoLam.Enabled=true;

			cmdSave.Visible=true;
			cmdCancel.Visible=true;
			
			lView.Enabled=false;

			grpFunction.Enabled=false;

			_option=2;
		}
		void SetAdd(bool edit)
		{
			picNV.Image=null;
			linklbInsertPic.Tag="";
			txtMaNV.Text="";
			txtDChi.Text="";
			txtDThoai.Text="";
			txtMKhau.Text="";
			txtMKhau_R.Text="";
			txtTenNV.Text="";
			dTPicker_NVaoLam.Value=DateTime.Now;
			int year=DateTime.Now.Year-18;
			dTPicker_NSinh.Value=DateTime.Parse(DateTime.Now.Day.ToString()+"/"+DateTime.Now.Month.ToString()+"/"+ year.ToString());
			
			linklbInsertPic.Enabled=edit;
			linklbDelPic.Enabled=edit;
			txtMaNV.ReadOnly=!edit;
			txtDChi.ReadOnly=!edit;
			txtDThoai.ReadOnly=!edit;
			txtMKhau.ReadOnly=!edit;
			txtTenNV.ReadOnly=!edit;
			dTPicker_NSinh.Enabled=edit;
			dTPicker_NVaoLam.Enabled=edit;
			optNam.Enabled=edit;
			optNu.Enabled=edit;

			txtMKhau_R.Visible=edit;
			lbMKhau_R.Visible=edit;

			cmdSave.Visible=edit;
			cmdCancel.Visible=edit;

			lView.Enabled=!edit;

			grpFunction.Enabled=!edit;

			_option=edit?1:0;
		}
		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_NV();
			SetAdd(false);
		}

		private void lView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lView.SelectedItems.Count==0)
				return;
			
			ListViewItem item=lView.SelectedItems[0];
			pos=item.Index;
			txtMaNV.Text=item.SubItems[0].Text;
			txtTenNV.Text=item.SubItems[1].Text;
			if (item.SubItems[2].Text=="Nam")
				optNam.Checked=true;
			else
				optNu.Checked=true;
			txtMKhau.Text=item.SubItems[3].Text;
			dTPicker_NSinh.Text=item.SubItems[4].Text;
			txtDChi.Text=item.SubItems[5].Text;
			txtDThoai.Text=item.SubItems[6].Text;
			dTPicker_NVaoLam.Text=item.SubItems[7].Text;
			
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			if (txtMaNV.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?",
				"Xóa nhân viên",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"pr_del_NhanVien",
					CommandType.StoredProcedure,
					"@Manhanvien",txtMaNV.Text);

				MessageBox.Show("Đã xóa nhân viên!");
				if (pos==lView.Items.Count-1)
					pos=0;
				Load_NV();
			}
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			SetAdd(true);
		}

		private void cmdEdit_Click(object sender, System.EventArgs e)
		{
			if (txtMaNV.Text=="")
				return;

			SetEdit();
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			SetAdd(false);
		}

		private bool Check_Form()
		{
			int y = dTPicker_NSinh.Value.Year+18;
			if (y > DateTime.Now.Year)
			{
				MessageBox.Show("Nhân viên nhỏ hơn 18 tuổi!","Lỗi");
				dTPicker_NSinh.Focus();
				return false;
			}
			else if(dTPicker_NVaoLam.Value > DateTime.Now)
			{
				MessageBox.Show("Ngày vào làm không hợp lệ!","Lỗi");
				dTPicker_NVaoLam.Focus();
				return false;
			}
			else if (txtMKhau.Text!=txtMKhau_R.Text)
			{
				MessageBox.Show("Mật khẩu nhập lại không chính xác!","Lỗi");
				txtMKhau_R.Focus();
				return false;
			}
			else
			{
				return true;
			}
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			if (txtMaNV.Text.Trim()=="")
				return;
			if (Check_Form())
			{
				try
				{
					SqlHelper.ExecuteNonQuery(
						"pr_ins_NV",
						CommandType.StoredProcedure,
						"@option",_option,
						"@MSNV",txtMaNV.Text.Trim(),
						"@HOTENNV",txtTenNV.Text.Trim(),
						"@MatKhau",txtMKhau.Text.Trim(),
						"@NGAYSINHNV",dTPicker_NSinh.Value,
						"@GIOITINHNV",optNam.Checked?"1":"0",
						"@DIACHINV",txtDChi.Text.Trim(),
						"@DIENTHOAINV",txtDThoai.Text.Trim(),
						"@NGAYVAOLAM",dTPicker_NVaoLam.Value,
						"@HINH",linklbInsertPic.Tag.ToString().Trim());
					Load_NV();
					SetAdd(false);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void frmPhong_Activated(object sender, System.EventArgs e)
		{
			lView_SelectedIndexChanged(lView, System.EventArgs.Empty);
		}

		private void txtMKhau_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			txtMKhau_R.Text="";
			txtMKhau_R.Visible=true;
			lbMKhau_R.Visible=true;
		}

		private void linklbInsertPic_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			OFileDialog.ShowDialog();
			if (OFileDialog.FileName=="")
				return;
			string filename;
			filename=OFileDialog.FileName;
			linklbInsertPic.Tag= filename.Substring(filename.LastIndexOf("\\")+1);
			picNV.Image=Image.FromFile(linklbInsertPic.Tag.ToString());
		}

		private void linklbDelPic_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			linklbInsertPic.Tag="";
			picNV.Image=null;
		}
	}
}
