namespace WindowsFormsApp1.Views
{
    partial class UC_Profile
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox_Permissions = new System.Windows.Forms.GroupBox();
            this.dataGridView_Permissions = new System.Windows.Forms.DataGridView();
            this.Permission_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPermission_Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl_List = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_NameSearch = new System.Windows.Forms.TextBox();
            this.label_NameSearch = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView_Profiles = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Permissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Permissions)).BeginInit();
            this.tabControl_List.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Profiles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox_Permissions);
            this.groupBox2.Location = new System.Drawing.Point(3, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 326);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "";
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.AccessibleDescription = "dvdvsd";
            this.textBox_Name.Location = new System.Drawing.Point(106, 28);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(184, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // groupBox_Permissions
            // 
            this.groupBox_Permissions.Controls.Add(this.dataGridView_Permissions);
            this.groupBox_Permissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Permissions.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox_Permissions.Location = new System.Drawing.Point(14, 102);
            this.groupBox_Permissions.Name = "groupBox_Permissions";
            this.groupBox_Permissions.Size = new System.Drawing.Size(343, 212);
            this.groupBox_Permissions.TabIndex = 5;
            this.groupBox_Permissions.TabStop = false;
            this.groupBox_Permissions.Text = "Permisos";
            // 
            // dataGridView_Permissions
            // 
            this.dataGridView_Permissions.AllowUserToDeleteRows = false;
            this.dataGridView_Permissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Permissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Permissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Permissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Permission_Column,
            this.AddPermission_Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Permissions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Permissions.Location = new System.Drawing.Point(13, 30);
            this.dataGridView_Permissions.Name = "dataGridView_Permissions";
            this.dataGridView_Permissions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Permissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Permissions.Size = new System.Drawing.Size(291, 161);
            this.dataGridView_Permissions.TabIndex = 2;
            // 
            // Permission_Column
            // 
            this.Permission_Column.HeaderText = "Permiso";
            this.Permission_Column.Name = "Permission_Column";
            this.Permission_Column.ReadOnly = true;
            // 
            // AddPermission_Column
            // 
            this.AddPermission_Column.HeaderText = "Agregar";
            this.AddPermission_Column.Name = "AddPermission_Column";
            this.AddPermission_Column.ReadOnly = true;
            this.AddPermission_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddPermission_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabControl_List
            // 
            this.tabControl_List.Controls.Add(this.tabPage1);
            this.tabControl_List.Location = new System.Drawing.Point(405, 25);
            this.tabControl_List.Name = "tabControl_List";
            this.tabControl_List.SelectedIndex = 0;
            this.tabControl_List.Size = new System.Drawing.Size(439, 412);
            this.tabControl_List.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button_Delete);
            this.tabPage1.Controls.Add(this.dataGridView_Profiles);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de perfiles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_NameSearch);
            this.groupBox3.Controls.Add(this.label_NameSearch);
            this.groupBox3.Controls.Add(this.button_Search);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(30, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 68);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // textBox_NameSearch
            // 
            this.textBox_NameSearch.Location = new System.Drawing.Point(78, 29);
            this.textBox_NameSearch.Name = "textBox_NameSearch";
            this.textBox_NameSearch.Size = new System.Drawing.Size(134, 20);
            this.textBox_NameSearch.TabIndex = 17;
            // 
            // label_NameSearch
            // 
            this.label_NameSearch.AutoSize = true;
            this.label_NameSearch.Location = new System.Drawing.Point(18, 32);
            this.label_NameSearch.Name = "label_NameSearch";
            this.label_NameSearch.Size = new System.Drawing.Size(54, 13);
            this.label_NameSearch.TabIndex = 4;
            this.label_NameSearch.Text = "Nombre:";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(245, 24);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(103, 27);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Buscar";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Delete.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Delete.Location = new System.Drawing.Point(330, 352);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Eliminar";
            this.button_Delete.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Profiles
            // 
            this.dataGridView_Profiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Profiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Profiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn});
            this.dataGridView_Profiles.Location = new System.Drawing.Point(30, 103);
            this.dataGridView_Profiles.Name = "dataGridView_Profiles";
            this.dataGridView_Profiles.Size = new System.Drawing.Size(375, 231);
            this.dataGridView_Profiles.TabIndex = 1;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Nombre";
            this.nameColumn.Name = "nameColumn";
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Edit.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Edit.Location = new System.Drawing.Point(148, 377);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 15;
            this.button_Edit.Text = "Editar";
            this.button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Cancel.Location = new System.Drawing.Point(251, 377);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.Color.SteelBlue;
            this.button_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_New.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_New.Location = new System.Drawing.Point(46, 377);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 13;
            this.button_New.Text = "Nuevo";
            this.button_New.UseVisualStyleBackColor = false;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.tabControl_List);
            this.Controls.Add(this.groupBox2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(873, 461);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Permissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Permissions)).EndInit();
            this.tabControl_List.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Profiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.GroupBox groupBox_Permissions;
        private System.Windows.Forms.DataGridView dataGridView_Permissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permission_Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddPermission_Column;
        private System.Windows.Forms.TabControl tabControl_List;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_NameSearch;
        private System.Windows.Forms.Label label_NameSearch;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridView dataGridView_Profiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_New;
    }
}
