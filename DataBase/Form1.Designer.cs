namespace DataBase
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblStudentID = new System.Windows.Forms.Label();
			this.txtboxID = new System.Windows.Forms.TextBox();
			this.txtboxNume = new System.Windows.Forms.TextBox();
			this.lblNume = new System.Windows.Forms.Label();
			this.txtboxPrenume = new System.Windows.Forms.TextBox();
			this.lblPrenume = new System.Windows.Forms.Label();
			this.txtboxStudii = new System.Windows.Forms.TextBox();
			this.lblStudii = new System.Windows.Forms.Label();
			this.txtboxVarsta = new System.Windows.Forms.TextBox();
			this.lblAni = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvDate = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lblGen = new System.Windows.Forms.Label();
			this.cmbGen = new System.Windows.Forms.ComboBox();
			this.studentiDataSet = new DataBase.StudentiDataSet();
			this.studentiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentiDataSet1 = new DataBase.StudentiDataSet1();
			this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentiTableAdapter = new DataBase.StudentiDataSet1TableAdapters.studentiTableAdapter();
			this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scoalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStudentID
			// 
			this.lblStudentID.AutoSize = true;
			this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
			this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblStudentID.Location = new System.Drawing.Point(54, 91);
			this.lblStudentID.Name = "lblStudentID";
			this.lblStudentID.Size = new System.Drawing.Size(127, 29);
			this.lblStudentID.TabIndex = 0;
			this.lblStudentID.Text = "ID_student";
			// 
			// txtboxID
			// 
			this.txtboxID.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtboxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtboxID.Location = new System.Drawing.Point(212, 88);
			this.txtboxID.Name = "txtboxID";
			this.txtboxID.ReadOnly = true;
			this.txtboxID.Size = new System.Drawing.Size(239, 34);
			this.txtboxID.TabIndex = 1;
			// 
			// txtboxNume
			// 
			this.txtboxNume.BackColor = System.Drawing.SystemColors.Info;
			this.txtboxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtboxNume.Location = new System.Drawing.Point(212, 143);
			this.txtboxNume.Name = "txtboxNume";
			this.txtboxNume.Size = new System.Drawing.Size(239, 34);
			this.txtboxNume.TabIndex = 3;
			// 
			// lblNume
			// 
			this.lblNume.AutoSize = true;
			this.lblNume.BackColor = System.Drawing.Color.Transparent;
			this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblNume.Location = new System.Drawing.Point(54, 146);
			this.lblNume.Name = "lblNume";
			this.lblNume.Size = new System.Drawing.Size(78, 29);
			this.lblNume.TabIndex = 2;
			this.lblNume.Text = "Nume";
			this.lblNume.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtboxPrenume
			// 
			this.txtboxPrenume.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtboxPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtboxPrenume.Location = new System.Drawing.Point(212, 200);
			this.txtboxPrenume.Name = "txtboxPrenume";
			this.txtboxPrenume.Size = new System.Drawing.Size(239, 34);
			this.txtboxPrenume.TabIndex = 5;
			// 
			// lblPrenume
			// 
			this.lblPrenume.AutoSize = true;
			this.lblPrenume.BackColor = System.Drawing.Color.Transparent;
			this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPrenume.Location = new System.Drawing.Point(54, 203);
			this.lblPrenume.Name = "lblPrenume";
			this.lblPrenume.Size = new System.Drawing.Size(111, 29);
			this.lblPrenume.TabIndex = 4;
			this.lblPrenume.Text = "Prenume";
			// 
			// txtboxStudii
			// 
			this.txtboxStudii.BackColor = System.Drawing.SystemColors.Info;
			this.txtboxStudii.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtboxStudii.Location = new System.Drawing.Point(212, 261);
			this.txtboxStudii.Name = "txtboxStudii";
			this.txtboxStudii.Size = new System.Drawing.Size(239, 34);
			this.txtboxStudii.TabIndex = 7;
			this.txtboxStudii.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// lblStudii
			// 
			this.lblStudii.AutoSize = true;
			this.lblStudii.BackColor = System.Drawing.Color.Transparent;
			this.lblStudii.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblStudii.Location = new System.Drawing.Point(54, 264);
			this.lblStudii.Name = "lblStudii";
			this.lblStudii.Size = new System.Drawing.Size(100, 29);
			this.lblStudii.TabIndex = 6;
			this.lblStudii.Text = "Instituția";
			// 
			// txtboxVarsta
			// 
			this.txtboxVarsta.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtboxVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtboxVarsta.Location = new System.Drawing.Point(212, 319);
			this.txtboxVarsta.Name = "txtboxVarsta";
			this.txtboxVarsta.Size = new System.Drawing.Size(239, 34);
			this.txtboxVarsta.TabIndex = 9;
			// 
			// lblAni
			// 
			this.lblAni.AutoSize = true;
			this.lblAni.BackColor = System.Drawing.Color.Transparent;
			this.lblAni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAni.Location = new System.Drawing.Point(54, 322);
			this.lblAni.Name = "lblAni";
			this.lblAni.Size = new System.Drawing.Size(80, 29);
			this.lblAni.TabIndex = 8;
			this.lblAni.Text = "Vârsta";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(90, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(301, 38);
			this.label6.TabIndex = 10;
			this.label6.Text = "Colectarea datelor";
			// 
			// dgvDate
			// 
			this.dgvDate.AutoGenerateColumns = false;
			this.dgvDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.dgvDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.scoalaDataGridViewTextBoxColumn,
            this.varstaDataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn});
			this.dgvDate.DataSource = this.studentiBindingSource;
			this.dgvDate.Location = new System.Drawing.Point(501, 91);
			this.dgvDate.Name = "dgvDate";
			this.dgvDate.RowHeadersWidth = 51;
			this.dgvDate.RowTemplate.Height = 24;
			this.dgvDate.Size = new System.Drawing.Size(803, 489);
			this.dgvDate.TabIndex = 11;
			this.dgvDate.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDate_RowHeaderMouseClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(31, 442);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(202, 54);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Adaugă";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Blue;
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(31, 526);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(202, 54);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Actualizează";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Red;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(275, 442);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(202, 54);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Șterge";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Orange;
			this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(275, 526);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(202, 54);
			this.btnClear.TabIndex = 14;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(746, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(323, 38);
			this.label7.TabIndex = 16;
			this.label7.Text = "Vizualizarea datelor";
			// 
			// lblGen
			// 
			this.lblGen.AutoSize = true;
			this.lblGen.BackColor = System.Drawing.Color.Transparent;
			this.lblGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGen.Location = new System.Drawing.Point(54, 375);
			this.lblGen.Name = "lblGen";
			this.lblGen.Size = new System.Drawing.Size(77, 29);
			this.lblGen.TabIndex = 17;
			this.lblGen.Text = "Genul";
			// 
			// cmbGen
			// 
			this.cmbGen.BackColor = System.Drawing.SystemColors.Info;
			this.cmbGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbGen.FormattingEnabled = true;
			this.cmbGen.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
			this.cmbGen.Location = new System.Drawing.Point(212, 375);
			this.cmbGen.Name = "cmbGen";
			this.cmbGen.Size = new System.Drawing.Size(239, 33);
			this.cmbGen.TabIndex = 18;
			// 
			// studentiDataSet
			// 
			this.studentiDataSet.DataSetName = "StudentiDataSet";
			this.studentiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentiDataSetBindingSource
			// 
			this.studentiDataSetBindingSource.DataSource = this.studentiDataSet;
			this.studentiDataSetBindingSource.Position = 0;
			// 
			// studentiDataSet1
			// 
			this.studentiDataSet1.DataSetName = "StudentiDataSet1";
			this.studentiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentiBindingSource
			// 
			this.studentiBindingSource.DataMember = "studenti";
			this.studentiBindingSource.DataSource = this.studentiDataSet1;
			// 
			// studentiTableAdapter
			// 
			this.studentiTableAdapter.ClearBeforeFill = true;
			// 
			// idstudentDataGridViewTextBoxColumn
			// 
			this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
			this.idstudentDataGridViewTextBoxColumn.HeaderText = "id_student";
			this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
			this.idstudentDataGridViewTextBoxColumn.ReadOnly = true;
			this.idstudentDataGridViewTextBoxColumn.Width = 125;
			// 
			// numeDataGridViewTextBoxColumn
			// 
			this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
			this.numeDataGridViewTextBoxColumn.HeaderText = "nume";
			this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
			this.numeDataGridViewTextBoxColumn.Width = 125;
			// 
			// prenumeDataGridViewTextBoxColumn
			// 
			this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "prenume";
			this.prenumeDataGridViewTextBoxColumn.HeaderText = "prenume";
			this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
			this.prenumeDataGridViewTextBoxColumn.Width = 125;
			// 
			// scoalaDataGridViewTextBoxColumn
			// 
			this.scoalaDataGridViewTextBoxColumn.DataPropertyName = "scoala";
			this.scoalaDataGridViewTextBoxColumn.HeaderText = "scoala";
			this.scoalaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.scoalaDataGridViewTextBoxColumn.Name = "scoalaDataGridViewTextBoxColumn";
			this.scoalaDataGridViewTextBoxColumn.Width = 125;
			// 
			// varstaDataGridViewTextBoxColumn
			// 
			this.varstaDataGridViewTextBoxColumn.DataPropertyName = "varsta";
			this.varstaDataGridViewTextBoxColumn.HeaderText = "varsta";
			this.varstaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.varstaDataGridViewTextBoxColumn.Name = "varstaDataGridViewTextBoxColumn";
			this.varstaDataGridViewTextBoxColumn.Width = 125;
			// 
			// genDataGridViewTextBoxColumn
			// 
			this.genDataGridViewTextBoxColumn.DataPropertyName = "gen";
			this.genDataGridViewTextBoxColumn.HeaderText = "gen";
			this.genDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
			this.genDataGridViewTextBoxColumn.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1337, 612);
			this.Controls.Add(this.cmbGen);
			this.Controls.Add(this.lblGen);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvDate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtboxVarsta);
			this.Controls.Add(this.lblAni);
			this.Controls.Add(this.txtboxStudii);
			this.Controls.Add(this.lblStudii);
			this.Controls.Add(this.txtboxPrenume);
			this.Controls.Add(this.lblPrenume);
			this.Controls.Add(this.txtboxNume);
			this.Controls.Add(this.lblNume);
			this.Controls.Add(this.txtboxID);
			this.Controls.Add(this.lblStudentID);
			this.Name = "Form1";
			this.Text = "Baza de date";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStudentID;
		private System.Windows.Forms.TextBox txtboxID;
		private System.Windows.Forms.TextBox txtboxNume;
		private System.Windows.Forms.Label lblNume;
		private System.Windows.Forms.TextBox txtboxPrenume;
		private System.Windows.Forms.Label lblPrenume;
		private System.Windows.Forms.TextBox txtboxStudii;
		private System.Windows.Forms.Label lblStudii;
		private System.Windows.Forms.TextBox txtboxVarsta;
		private System.Windows.Forms.Label lblAni;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvDate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblGen;
		private System.Windows.Forms.ComboBox cmbGen;
		private System.Windows.Forms.BindingSource studentiDataSetBindingSource;
		private StudentiDataSet studentiDataSet;
		private StudentiDataSet1 studentiDataSet1;
		private System.Windows.Forms.BindingSource studentiBindingSource;
		private StudentiDataSet1TableAdapters.studentiTableAdapter studentiTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn scoalaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
	}
}

