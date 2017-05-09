﻿namespace WindowsFormsApp1.Views
{
    partial class Profile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_name = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox_Permissions);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 326);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "";
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.profile_name);
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
            // profile_name
            // 
            this.profile_name.AccessibleDescription = "dvdvsd";
            this.profile_name.Location = new System.Drawing.Point(106, 28);
            this.profile_name.Name = "profile_name";
            this.profile_name.Size = new System.Drawing.Size(184, 20);
            this.profile_name.TabIndex = 0;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Permissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Permissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Permissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Permission_Column,
            this.AddPermission_Column});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Permissions.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Permissions.Location = new System.Drawing.Point(13, 30);
            this.dataGridView_Permissions.Name = "dataGridView_Permissions";
            this.dataGridView_Permissions.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Permissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.tabControl_List.Location = new System.Drawing.Point(425, 38);
            this.tabControl_List.Name = "tabControl_List";
            this.tabControl_List.SelectedIndex = 0;
            this.tabControl_List.Size = new System.Drawing.Size(439, 412);
            this.tabControl_List.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button_Delete);
            this.tabPage1.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 231);
            this.dataGridView1.TabIndex = 1;
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
            this.button_Edit.Location = new System.Drawing.Point(147, 412);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 12;
            this.button_Edit.Text = "Editar";
            this.button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Cancel.Location = new System.Drawing.Point(250, 412);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.Color.SteelBlue;
            this.button_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_New.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_New.Location = new System.Drawing.Point(45, 412);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 10;
            this.button_New.Text = "Nuevo";
            this.button_New.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(891, 549);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.tabControl_List);
            this.Controls.Add(this.groupBox2);
            this.Name = "Profile";
            this.Text = "Perfil";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Permissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Permissions)).EndInit();
            this.tabControl_List.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profile_name;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_New;
    }
}