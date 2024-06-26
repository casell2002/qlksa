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
	public class frmPhong : System.Windows.Forms.Form
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
		private System.Windows.Forms.ComboBox cboLoaiP;
		private System.Windows.Forms.TextBox txtMaP;
		private System.Windows.Forms.ColumnHeader MSP;
		private System.Windows.Forms.ColumnHeader LP;
		private System.Windows.Forms.ListView lView;
		#region User Varibles
		public static string _connectString="data source=vanlang;database=demo;uid=sa;password=";
		int _option=0,pos=0;
		#endregion
		private System.Windows.Forms.RadioButton optTrong;
		private System.Windows.Forms.RadioButton optKhongTrong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader TT;

		private System.ComponentModel.Container components = null;

		public frmPhong()
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
            this.MSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optTrong = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cboLoaiP = new System.Windows.Forms.ComboBox();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.optKhongTrong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFunction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSP,
            this.LP,
            this.TT});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(10, 157);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(576, 221);
            this.lView.TabIndex = 3;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
            // 
            // MSP
            // 
            this.MSP.Text = "Mã số phòng";
            this.MSP.Width = 100;
            // 
            // LP
            // 
            this.LP.Text = "Loại phòng";
            this.LP.Width = 250;
            // 
            // TT
            // 
            this.TT.Text = "Tình trạng";
            this.TT.Width = 100;
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.cmdExit);
            this.grpFunction.Controls.Add(this.cmdDelete);
            this.grpFunction.Controls.Add(this.cmdEdit);
            this.grpFunction.Controls.Add(this.cmdAdd);
            this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpFunction.Location = new System.Drawing.Point(480, 9);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Size = new System.Drawing.Size(106, 139);
            this.grpFunction.TabIndex = 5;
            this.grpFunction.TabStop = false;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExit.Location = new System.Drawing.Point(10, 102);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(86, 26);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDelete.Location = new System.Drawing.Point(10, 73);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(86, 26);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEdit.Location = new System.Drawing.Point(10, 44);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(86, 26);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Sửa";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(10, 15);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(86, 27);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optTrong);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.cboLoaiP);
            this.groupBox1.Controls.Add(this.txtMaP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.optKhongTrong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // optTrong
            // 
            this.optTrong.Enabled = false;
            this.optTrong.Location = new System.Drawing.Point(144, 102);
            this.optTrong.Name = "optTrong";
            this.optTrong.Size = new System.Drawing.Size(77, 18);
            this.optTrong.TabIndex = 12;
            this.optTrong.Text = "Trống";
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(365, 65);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(90, 26);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Hủy bỏ";
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(365, 28);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(90, 26);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cboLoaiP
            // 
            this.cboLoaiP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiP.Location = new System.Drawing.Point(144, 65);
            this.cboLoaiP.Name = "cboLoaiP";
            this.cboLoaiP.Size = new System.Drawing.Size(173, 24);
            this.cboLoaiP.TabIndex = 6;
            // 
            // txtMaP
            // 
            this.txtMaP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaP.Location = new System.Drawing.Point(144, 28);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(115, 23);
            this.txtMaP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã số phòng:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại phòng:";
            // 
            // optKhongTrong
            // 
            this.optKhongTrong.Enabled = false;
            this.optKhongTrong.Location = new System.Drawing.Point(250, 102);
            this.optKhongTrong.Name = "optKhongTrong";
            this.optKhongTrong.Size = new System.Drawing.Size(105, 18);
            this.optKhongTrong.TabIndex = 12;
            this.optKhongTrong.Text = "Không trống";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tình trạng:";
            // 
            // frmPhong
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.lView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng";
            this.Activated += new System.EventHandler(this.frmPhong_Activated);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.grpFunction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		void Load_LoaiP()
		{
			try
			{
				DataTable dtLoaiP=SqlHelper.ExecuteQuery(
					"pr_list_LoaiPhong",
					CommandType.StoredProcedure);
				cboLoaiP.DataSource=dtLoaiP;
				cboLoaiP.DisplayMember="LOAIPHONG";
				cboLoaiP.ValueMember="MaLOAIPHONG";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void Load_Phong()
		{
			try
			{
				DataTable dtPhong=SqlHelper.ExecuteQuery(
					"pr_list_Phong",
					CommandType.StoredProcedure);
				lView.Items.Clear();
				if (dtPhong.Rows.Count>0)
				{
					foreach (DataRow row in dtPhong.Rows)
					{
						ListViewItem item=new ListViewItem();
						item.Text=row["LOAIPHONG"].ToString();
						item.SubItems.Add(row["LOAIPHONG"].ToString());
						item.SubItems.Add(row["TINHTRANG"].ToString()=="0"?"Trống":"Không trống");
						item.SubItems.Add(row["MaLOAIPHONG"].ToString());

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
			txtMaP.ReadOnly=true;
			cboLoaiP.Enabled=true;

			cmdSave.Visible=true;
			cmdCancel.Visible=true;

			lView.Enabled=false;

			grpFunction.Enabled=false;

			_option=2;
		}
		void SetAdd(bool edit)
		{
			txtMaP.Text="";
			cboLoaiP.SelectedIndex=-1;

			txtMaP.ReadOnly=!edit;
			cboLoaiP.Enabled=edit;
			optTrong.Checked=true;

			cmdSave.Visible=edit;
			cmdCancel.Visible=edit;

			lView.Enabled=!edit;

			grpFunction.Enabled=!edit;

			_option=edit?1:0;
		}
		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_LoaiP();
			Load_Phong();
			SetAdd(false);
		}

		private void lView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lView.SelectedItems.Count==0)
				return;
			
			ListViewItem item=lView.SelectedItems[0];
			pos=item.Index;
			txtMaP.Text=item.SubItems[0].Text;
			cboLoaiP.SelectedValue=item.SubItems[3].Text;
			if (item.SubItems[2].Text=="Trống")
				optTrong.Checked=true;
			else
				optKhongTrong.Checked=true;
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			if (txtMaP.Text=="")
				return;

			DialogResult result=MessageBox.Show("Bạn có chắc muốn xóa phòng này không?",
				"Xóa phòng",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result==DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"pr_del_Phong",
					CommandType.StoredProcedure,
					"@LOAIPhong",txtMaP.Text);

				MessageBox.Show("Đã xóa phòng!");
				if (pos==lView.Items.Count-1)
					pos=0;
				Load_Phong();
			}
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			SetAdd(true);
		}

		private void cmdEdit_Click(object sender, System.EventArgs e)
		{
			if (txtMaP.Text=="")
				return;

			SetEdit();
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			SetAdd(false);
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			if (txtMaP.Text.Trim()=="")
				return;
			try
			{
				SqlHelper.ExecuteNonQuery(
					"pr_ins_Phong",
					CommandType.StoredProcedure,
					"@option",_option,
					"@LOAIPHONG",txtMaP.Text.Trim(),
					"@MaLOAIPHONG",cboLoaiP.SelectedValue,
					"@TINHTRANG",optTrong.Checked?"0":"1");
				Load_Phong();
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
