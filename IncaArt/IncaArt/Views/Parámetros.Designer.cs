namespace WindowsFormsApp1.Views
{
    partial class Parámetros
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
            this.tabContr_List = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_NameSearch = new System.Windows.Forms.TextBox();
            this.label_NameSearch = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Shift = new System.Windows.Forms.GroupBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Begin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabContr_List.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_Shift.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContr_List
            // 
            this.tabContr_List.Controls.Add(this.tabPage1);
            this.tabContr_List.Location = new System.Drawing.Point(352, 29);
            this.tabContr_List.Name = "tabContr_List";
            this.tabContr_List.SelectedIndex = 0;
            this.tabContr_List.Size = new System.Drawing.Size(447, 389);
            this.tabContr_List.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button_Delete);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parámetros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_NameSearch);
            this.groupBox2.Controls.Add(this.label_NameSearch);
            this.groupBox2.Controls.Add(this.button_Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(30, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 68);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // textBox_NameSearch
            // 
            this.textBox_NameSearch.Location = new System.Drawing.Point(78, 29);
            this.textBox_NameSearch.Name = "textBox_NameSearch";
            this.textBox_NameSearch.Size = new System.Drawing.Size(118, 20);
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
            this.button_Search.Location = new System.Drawing.Point(272, 24);
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
            this.button_Delete.Location = new System.Drawing.Point(344, 320);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 11;
            this.button_Delete.Text = "Eliminar";
            this.button_Delete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Begin});
            this.dataGridView1.Location = new System.Drawing.Point(30, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 204);
            this.dataGridView1.TabIndex = 10;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Cancel.Location = new System.Drawing.Point(231, 275);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 16;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            // 
            // groupBox_Shift
            // 
            this.groupBox_Shift.Controls.Add(this.textBox1);
            this.groupBox_Shift.Controls.Add(this.label1);
            this.groupBox_Shift.Controls.Add(this.textBox_Description);
            this.groupBox_Shift.Controls.Add(this.label_Description);
            this.groupBox_Shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Shift.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox_Shift.Location = new System.Drawing.Point(28, 102);
            this.groupBox_Shift.Name = "groupBox_Shift";
            this.groupBox_Shift.Size = new System.Drawing.Size(297, 142);
            this.groupBox_Shift.TabIndex = 13;
            this.groupBox_Shift.TabStop = false;
            this.groupBox_Shift.Text = "Datos del Parámetro";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(130, 44);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(122, 20);
            this.textBox_Description.TabIndex = 4;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(25, 47);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(54, 13);
            this.label_Description.TabIndex = 0;
            this.label_Description.Text = "Nombre:";
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Edit.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Edit.Location = new System.Drawing.Point(140, 275);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 15;
            this.button_Edit.Text = "Editar";
            this.button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.Color.SteelBlue;
            this.button_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_New.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_New.Location = new System.Drawing.Point(48, 275);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 14;
            this.button_New.Text = "Nuevo";
            this.button_New.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor:";
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Nombre";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Begin
            // 
            this.Column_Begin.HeaderText = "Valor";
            this.Column_Begin.Name = "Column_Begin";
            // 
            // Parámetros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(818, 447);
            this.Controls.Add(this.tabContr_List);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.groupBox_Shift);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_New);
            this.Name = "Parámetros";
            this.Text = "Parámetros";
            this.tabContr_List.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_Shift.ResumeLayout(false);
            this.groupBox_Shift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContr_List;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_NameSearch;
        private System.Windows.Forms.Label label_NameSearch;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_Shift;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Begin;
    }
}