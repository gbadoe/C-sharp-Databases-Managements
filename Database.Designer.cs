namespace Management_Base_De_Donnees
{
    partial class Database
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managementsDataSet3 = new Management_Base_De_Donnees.ManagementsDataSet3();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DataView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEdit1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.databaseTableAdapter = new Management_Base_De_Donnees.ManagementsDataSet3TableAdapters.DatabaseTableAdapter();
            this.Table = new System.Windows.Forms.TextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managementsDataSet4 = new Management_Base_De_Donnees.ManagementsDataSet4();
            this.label5 = new System.Windows.Forms.Label();
            this.DataView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databasenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Database_name = new System.Windows.Forms.Label();
            this.Databasetable = new System.Windows.Forms.TextBox();
            this.Idtable = new System.Windows.Forms.Label();
            this.Tableid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCreate1 = new System.Windows.Forms.Button();
            this.tableTableAdapter = new Management_Base_De_Donnees.ManagementsDataSet4TableAdapters.TableTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATABASES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATABASE MANAGEMENTS";
            // 
            // TxtDescription
            // 
            this.TxtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "description", true));
            this.TxtDescription.Location = new System.Drawing.Point(193, 197);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(138, 20);
            this.TxtDescription.TabIndex = 10;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataMember = "Database";
            this.databaseBindingSource.DataSource = this.managementsDataSet3;
            // 
            // managementsDataSet3
            // 
            this.managementsDataSet3.DataSetName = "ManagementsDataSet3";
            this.managementsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "name", true));
            this.TxtName.Location = new System.Drawing.Point(193, 157);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(138, 20);
            this.TxtName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Crimson;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(288, 459);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 44);
            this.BtnHome.TabIndex = 20;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(207, 459);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 44);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Crimson;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(126, 459);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 44);
            this.BtnEdit.TabIndex = 18;
            this.BtnEdit.Text = "Edit and Save";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Crimson;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(46, 459);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 44);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DataView1
            // 
            this.DataView1.AllowUserToAddRows = false;
            this.DataView1.AllowUserToOrderColumns = true;
            this.DataView1.AutoGenerateColumns = false;
            this.DataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.DataView1.DataSource = this.databaseBindingSource;
            this.DataView1.Location = new System.Drawing.Point(47, 241);
            this.DataView1.Name = "DataView1";
            this.DataView1.Size = new System.Drawing.Size(343, 203);
            this.DataView1.TabIndex = 21;
            this.DataView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // BtnEdit1
            // 
            this.BtnEdit1.BackColor = System.Drawing.Color.Crimson;
            this.BtnEdit1.FlatAppearance.BorderSize = 0;
            this.BtnEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit1.Location = new System.Drawing.Point(571, 459);
            this.BtnEdit1.Name = "BtnEdit1";
            this.BtnEdit1.Size = new System.Drawing.Size(75, 44);
            this.BtnEdit1.TabIndex = 24;
            this.BtnEdit1.Text = "Edit and Save";
            this.BtnEdit1.UseVisualStyleBackColor = false;
            this.BtnEdit1.Click += new System.EventHandler(this.BtnEdit1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Id";
            // 
            // Txtid
            // 
            this.Txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "Id", true));
            this.Txtid.Location = new System.Drawing.Point(193, 113);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(138, 20);
            this.Txtid.TabIndex = 27;
            // 
            // databaseTableAdapter
            // 
            this.databaseTableAdapter.ClearBeforeFill = true;
            // 
            // Table
            // 
            this.Table.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Table.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "table_name", true));
            this.Table.Location = new System.Drawing.Point(677, 199);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(138, 20);
            this.Table.TabIndex = 28;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.managementsDataSet4;
            // 
            // managementsDataSet4
            // 
            this.managementsDataSet4.DataSetName = "ManagementsDataSet4";
            this.managementsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Table name";
            // 
            // DataView2
            // 
            this.DataView2.AllowUserToAddRows = false;
            this.DataView2.AutoGenerateColumns = false;
            this.DataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.databasenameDataGridViewTextBoxColumn,
            this.tablenameDataGridViewTextBoxColumn});
            this.DataView2.DataSource = this.tableBindingSource;
            this.DataView2.Location = new System.Drawing.Point(488, 231);
            this.DataView2.Name = "DataView2";
            this.DataView2.Size = new System.Drawing.Size(356, 213);
            this.DataView2.TabIndex = 30;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // databasenameDataGridViewTextBoxColumn
            // 
            this.databasenameDataGridViewTextBoxColumn.DataPropertyName = "database_name";
            this.databasenameDataGridViewTextBoxColumn.HeaderText = "database_name";
            this.databasenameDataGridViewTextBoxColumn.Name = "databasenameDataGridViewTextBoxColumn";
            // 
            // tablenameDataGridViewTextBoxColumn
            // 
            this.tablenameDataGridViewTextBoxColumn.DataPropertyName = "table_name";
            this.tablenameDataGridViewTextBoxColumn.HeaderText = "table_name";
            this.tablenameDataGridViewTextBoxColumn.Name = "tablenameDataGridViewTextBoxColumn";
            // 
            // Database_name
            // 
            this.Database_name.AutoSize = true;
            this.Database_name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database_name.Location = new System.Drawing.Point(495, 153);
            this.Database_name.Name = "Database_name";
            this.Database_name.Size = new System.Drawing.Size(177, 25);
            this.Database_name.TabIndex = 32;
            this.Database_name.Text = "Database name";
            // 
            // Databasetable
            // 
            this.Databasetable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Databasetable.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "database_name", true));
            this.Databasetable.Location = new System.Drawing.Point(677, 158);
            this.Databasetable.Name = "Databasetable";
            this.Databasetable.Size = new System.Drawing.Size(138, 20);
            this.Databasetable.TabIndex = 31;
            // 
            // Idtable
            // 
            this.Idtable.AutoSize = true;
            this.Idtable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtable.Location = new System.Drawing.Point(495, 107);
            this.Idtable.Name = "Idtable";
            this.Idtable.Size = new System.Drawing.Size(32, 25);
            this.Idtable.TabIndex = 34;
            this.Idtable.Text = "Id";
            // 
            // Tableid
            // 
            this.Tableid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tableid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.Tableid.Location = new System.Drawing.Point(677, 113);
            this.Tableid.Name = "Tableid";
            this.Tableid.Size = new System.Drawing.Size(138, 20);
            this.Tableid.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(652, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCreate1
            // 
            this.BtnCreate1.BackColor = System.Drawing.Color.Crimson;
            this.BtnCreate1.FlatAppearance.BorderSize = 0;
            this.BtnCreate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate1.Location = new System.Drawing.Point(488, 459);
            this.BtnCreate1.Name = "BtnCreate1";
            this.BtnCreate1.Size = new System.Drawing.Size(75, 44);
            this.BtnCreate1.TabIndex = 35;
            this.BtnCreate1.Text = "Create";
            this.BtnCreate1.UseVisualStyleBackColor = false;
            this.BtnCreate1.Click += new System.EventHandler(this.BtnCreate1_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 10);
            this.panel2.TabIndex = 37;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCreate1);
            this.Controls.Add(this.Idtable);
            this.Controls.Add(this.Tableid);
            this.Controls.Add(this.Database_name);
            this.Controls.Add(this.Databasetable);
            this.Controls.Add(this.DataView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEdit1);
            this.Controls.Add(this.DataView1);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Database";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Database_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DataView1;
        private System.Windows.Forms.Button BtnEdit1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtid;
        private ManagementsDataSet3 managementsDataSet3;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private ManagementsDataSet3TableAdapters.DatabaseTableAdapter databaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Table;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataView2;
        private System.Windows.Forms.Label Database_name;
        private System.Windows.Forms.TextBox Databasetable;
        private System.Windows.Forms.Label Idtable;
        private System.Windows.Forms.TextBox Tableid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCreate1;
        private ManagementsDataSet4 managementsDataSet4;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ManagementsDataSet4TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn databasenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
    }
}