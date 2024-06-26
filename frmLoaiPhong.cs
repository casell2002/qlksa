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
    /// Summary description for Form2.//Download source code tại Sharecode.vn
	/// </summary>
	public class frmLoaiPhong : System.Windows.Forms.Form
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

		private System.Windows.Forms.ColumnHeader GIA;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader MLP;
		private System.Windows.Forms.ColumnHeader LP;
		private System.Windows.Forms.TextBox txtMaLoaiP;
		private System.Windows.Forms.TextBox txtLoaiP;
		private System.Windows.Forms.TextBox txtGia;

		private System.ComponentModel.Container components = null;

		public frmLoaiPhong()
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
            this.MLP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtMaLoaiP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiP = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFunction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MLP,
            this.LP,
            this.GIA});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(10, 129);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(576, 166);
            this.lView.TabIndex = 3;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
            // 
            // MLP
            // 
            this.MLP.Text = "Mã số loại phòng";
            this.MLP.Width = 100;
            // 
            // LP
            // 
            this.LP.Text = "Loại phòng";
            this.LP.Width = 200;
            // 
            // GIA
            // 
            this.GIA.Text = "Giá";
            this.GIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GIA.Width = 100;
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
            this.grpFunction.Size = new System.Drawing.Size(106, 295);
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
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtMaLoaiP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLoaiP);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            // txtMaLoaiP
            // 
            this.txtMaLoaiP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiP.Location = new System.Drawing.Point(144, 18);
            this.txtMaLoaiP.Name = "txtMaLoaiP";
            this.txtMaLoaiP.Size = new System.Drawing.Size(154, 23);
            this.txtMaLoaiP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã số loại phòng:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại phòng:";
            // 
            // txtLoaiP
            // 
            this.txtLoaiP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiP.Location = new System.Drawing.Point(144, 55);
            this.txtLoaiP.Name = "txtLoaiP";
            this.txtLoaiP.Size = new System.Drawing.Size(259, 23);
            this.txtLoaiP.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(144, 92);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(86, 23);
            this.txtGia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giá tiền:";
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(592, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.lView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại phòng";
            this.Activated += new System.EventHandler(this.frmPhong_Activated);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.grpFunction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		void Load_LoaiPhong()
		{
			try
			{
				DataTable dtLP=SqlHelper.ExecuteQuery(
					"pr_list_LoaiPhong",
					CommandType.StoredProcedure);
				lView.Items.Clear();
				if (dtLP.Rows.Count>0)
				{
					foreach (DataRow row in dtLP.Rows)
					{
						ListViewItem item=new ListViewItem();
						item.Text=row["MaLOAIPHONG"].ToString();
						item.SubItems.Add(row["LOAIPHONG"].ToString());
						item.SubItems.Add(Double.Parse(row["GIATIEN"].ToString()).ToString("c"));
						
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
			txtMaLoaiP.ReadOnly=true;
			txtLoaiP.ReadOnly=false;
			txtGia.ReadOnly=false;

			cmdSave.Visible=true;
			cmdCancel.Visible=true;
			

			lView.Enabled=false;

			grpFunction.Enabled=false;

			_option=2;
		}
		void SetAdd(bool edit)
		{
			txtMaLoaiP.Text="";

			txtMaLoaiP.ReadOnly=!edit;	
			txtLoaiP.ReadOnly=!edit;
			txtGia.ReadOnly=!edit;
			txtLoaiP.Text="";
			txtGia.Text="";

			cmdSave.Visible=edit;
			cmdCancel.Visible=edit;

			lView.Enabled=!edit;

			grpFunction.Enabled=!edit;

			_option=edit?1:0;
		}
		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_LoaiPhong();
			SetAdd(false);
		}

		private void lView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lView.SelectedItems.Count==0)
				return;
			
			ListViewItem item=lView.SelectedItems[0];
			pos=item.Index;
			txtMaLoaiP.Text=item.SubItems[0].Text;
			txtLoaiP.Text=item.SubItems[1].Text;
			txtGia.Text=item.SubItems[2].Text;
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			if (txtMaLoaiP.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn có chắc muốn xóa loại phòng này không?",
				"Xóa loại phòng",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"pr_del_LoaiPhong",
					CommandType.StoredProcedure,
					"@MaLOAIPHONG",txtMaLoaiP.Text);

				MessageBox.Show("Đã xóa loại phòng!");
				if (pos==lView.Items.Count-1)
					pos=0;
				Load_LoaiPhong();
			}
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			SetAdd(true);
		}

		private void cmdEdit_Click(object sender, System.EventArgs e)
		{
			if (txtMaLoaiP.Text=="")
				return;

			SetEdit();
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			SetAdd(false);
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			if (txtMaLoaiP.Text.Trim()=="")
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
					"pr_ins_LoaiPhong",
					CommandType.StoredProcedure,
					"@option",_option,
					"@MaLOAIPHONG",txtMaLoaiP.Text.Trim(),
					"@LOAIPHONG",txtLoaiP.Text.Trim(),
					"@GIATIEN",Double.Parse( gia));
				Load_LoaiPhong();
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
