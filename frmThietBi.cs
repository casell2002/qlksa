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
	public class frmThietBi : System.Windows.Forms.Form
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
		private System.Windows.Forms.ColumnHeader MTB;
		private System.Windows.Forms.ColumnHeader TENTB;
		private System.Windows.Forms.ColumnHeader GIA;
		private System.Windows.Forms.TextBox txtMaTB;
		private System.Windows.Forms.TextBox txtTenTB;
		private System.Windows.Forms.TextBox txtDVT;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGia;
		private System.Windows.Forms.ColumnHeader DVT;
		private System.Windows.Forms.CheckBox chkCoDinh;
		private System.Windows.Forms.ColumnHeader CODINH;

		private System.ComponentModel.Container components = null;

		public frmThietBi()
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
            this.MTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TENTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CODINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCoDinh = new System.Windows.Forms.CheckBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.grpFunction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MTB,
            this.TENTB,
            this.GIA,
            this.DVT,
            this.CODINH});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(10, 129);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(576, 259);
            this.lView.TabIndex = 3;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
            // 
            // MTB
            // 
            this.MTB.Text = "Mã thiết bị";
            this.MTB.Width = 100;
            // 
            // TENTB
            // 
            this.TENTB.Text = "Tên thiết bị";
            this.TENTB.Width = 150;
            // 
            // GIA
            // 
            this.GIA.Text = "Giá";
            this.GIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GIA.Width = 100;
            // 
            // DVT
            // 
            this.DVT.Text = "Đơn vị tính";
            this.DVT.Width = 100;
            // 
            // CODINH
            // 
            this.CODINH.Text = "Thiết bị cố định";
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.cmdExit);
            this.grpFunction.Controls.Add(this.cmdDelete);
            this.grpFunction.Controls.Add(this.cmdEdit);
            this.grpFunction.Controls.Add(this.cmdAdd);
            this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpFunction.Location = new System.Drawing.Point(595, 0);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Size = new System.Drawing.Size(106, 388);
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
            this.groupBox1.Controls.Add(this.chkCoDinh);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtMaTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenTB);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // chkCoDinh
            // 
            this.chkCoDinh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCoDinh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkCoDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCoDinh.Location = new System.Drawing.Point(250, 18);
            this.chkCoDinh.Name = "chkCoDinh";
            this.chkCoDinh.Size = new System.Drawing.Size(172, 28);
            this.chkCoDinh.TabIndex = 12;
            this.chkCoDinh.Text = "Cố định trong phòng:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(470, 55);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(90, 27);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Hủy bỏ";
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(470, 18);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(90, 27);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtMaTB
            // 
            this.txtMaTB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTB.Location = new System.Drawing.Point(144, 18);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(96, 23);
            this.txtMaTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã thiết bị:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên thiết bị:";
            // 
            // txtTenTB
            // 
            this.txtTenTB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Location = new System.Drawing.Point(144, 55);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(278, 23);
            this.txtTenTB.TabIndex = 5;
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(144, 92);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(86, 23);
            this.txtDVT.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(317, 92);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(105, 23);
            this.txtGia.TabIndex = 5;
            // 
            // frmThietBi
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(592, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.lView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết bị";
            this.Activated += new System.EventHandler(this.frmPhong_Activated);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.grpFunction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		void Load_TB()
		{
			try
			{
				DataTable dtTB=SqlHelper.ExecuteQuery(
					"pr_list_ThietBi",
					CommandType.StoredProcedure,
					"@option","3");
				lView.Items.Clear();
				if (dtTB.Rows.Count>0)
				{
					foreach (DataRow row in dtTB.Rows)
					{
						ListViewItem item=new ListViewItem();
						item.Text=row["Mathietbi"].ToString();
						item.SubItems.Add(row["TENTHIETBI"].ToString());
						item.SubItems.Add(Double.Parse(row["GIATB"].ToString()).ToString("c"));
						item.SubItems.Add(row["DVT"].ToString());
					

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
			txtMaTB.ReadOnly=true;
			txtTenTB.ReadOnly=false;
			txtDVT.ReadOnly=false;
			txtGia.ReadOnly=false;
			
			chkCoDinh.Enabled=true;

			cmdSave.Visible=true;
			cmdCancel.Visible=true;
			
			lView.Enabled=false;

			grpFunction.Enabled=false;

			_option=2;
		}
		void SetAdd(bool edit)
		{
			txtMaTB.Text="";
			txtMaTB.ReadOnly=!edit;
			
			txtTenTB.ReadOnly=!edit;
			txtDVT.ReadOnly=!edit;
			txtGia.ReadOnly=!edit;
			txtTenTB.Text="";
			txtDVT.Text="";
			txtGia.Text="";
			
			chkCoDinh.Checked=!edit;
			chkCoDinh.Enabled=edit;

			cmdSave.Visible=edit;
			cmdCancel.Visible=edit;

			lView.Enabled=!edit;

			grpFunction.Enabled=!edit;

			_option=edit?1:0;
		}
		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_TB();
			SetAdd(false);
		}
       
		private void lView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lView.SelectedItems.Count==0)
				return;
			
			ListViewItem item=lView.SelectedItems[0];
			pos=item.Index;
			txtMaTB.Text=item.SubItems[0].Text;
			txtTenTB.Text=item.SubItems[1].Text;
			txtGia.Text=item.SubItems[2].Text;
			txtDVT.Text=item.SubItems[3].Text;
			if (item.SubItems[4].Text=="1")
				chkCoDinh.Checked=true;
			else
				chkCoDinh.Checked=false;
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			if (txtMaTB.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn có chắc muốn xóa thiết bị này không?",
				"Xóa thiết bị",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"pr_del_THIETBI_DV",
					CommandType.StoredProcedure,
					"@MSTB",txtMaTB.Text);

				MessageBox.Show("Đã xóa thiết bị!");
				if (pos==lView.Items.Count-1)
					pos=0;
				Load_TB();
			}
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			SetAdd(true);
		}

		private void cmdEdit_Click(object sender, System.EventArgs e)
		{
			if (txtMaTB.Text=="")
				return;

			SetEdit();
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			SetAdd(false);
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			if (txtMaTB.Text.Trim()=="")
				return;
			string gia = txtGia.Text;
			if (gia.Substring(0,1)=="$")
				gia = txtGia.Text.Substring(1,txtGia.Text.Length-1);
			try
			{
				if (Double.Parse(gia)<0)
				{
					MessageBox.Show("Giá tiền không được là số âm.","Lỗi");
					txtGia.Text="0";
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Giá tiền không hợp lệ.");
				return;
			}
			try
			{
				SqlHelper.ExecuteNonQuery(
					"pr_ins_THIETBI_DV",
					CommandType.StoredProcedure,
					"@option",_option,
					"@Mathietbi",txtMaTB.Text.Trim(),
					"@TENTHIETBI",txtTenTB.Text.Trim(),
					"@DVT",txtDVT.Text.Trim(),
					"@GIATB",Double.Parse(gia),
					"@THIETBICODINH",chkCoDinh.Checked);
				Load_TB();
				SetAdd(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
  
		private void frmPhong_Activated(object sender, System.EventArgs e)
		{
			lView_SelectedIndexChanged(lView, System.EventArgs.Empty);
		}


	}
}
