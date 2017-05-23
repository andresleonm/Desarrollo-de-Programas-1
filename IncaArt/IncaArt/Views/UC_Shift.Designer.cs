namespace WindowsFormsApp1.Views
{
    partial class UC_Shift
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
            this.groupBox_Shift = new System.Windows.Forms.GroupBox();
            this.label_End = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Begin = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Begin = new System.Windows.Forms.DateTimePicker();
            this.label_Description = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.tabContr_List = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_NameSearch = new System.Windows.Forms.TextBox();
            this.label_NameSearch = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Begin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Shift.SuspendLayout();
            this.tabContr_List.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Shift
            // 
            this.groupBox_Shift.Controls.Add(this.label_End);
            this.groupBox_Shift.Controls.Add(this.textBox_Description);
            this.groupBox_Shift.Controls.Add(this.label_Begin);
            this.groupBox_Shift.Controls.Add(this.dateTimePicker_End);
            this.groupBox_Shift.Controls.Add(this.dateTimePicker_Begin);
            this.groupBox_Shift.Controls.Add(this.label_Description);
            this.groupBox_Shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Shift.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox_Shift.Location = new System.Drawing.Point(24, 41);
            this.groupBox_Shift.Name = "groupBox_Shift";
            this.groupBox_Shift.Size = new System.Drawing.Size(297, 222);
            this.groupBox_Shift.TabIndex = 3;
            this.groupBox_Shift.TabStop = false;
            this.groupBox_Shift.Text = "Datos de turno";
            // 
            // label_End
            // 
            this.label_End.AutoSize = true;
            this.label_End.Location = new System.Drawing.Point(25, 137);
            this.label_End.Name = "label_End";
            this.label_End.Size = new System.Drawing.Size(74, 13);
            this.label_End.TabIndex = 5;
            this.label_End.Text = "Hora de fin:";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(130, 44);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(122, 20);
            this.textBox_Description.TabIndex = 4;
            // 
            // label_Begin
            // 
            this.label_Begin.AutoSize = true;
            this.label_Begin.Location = new System.Drawing.Point(25, 89);
            this.label_Begin.Name = "label_Begin";
            this.label_Begin.Size = new System.Drawing.Size(90, 13);
            this.label_Begin.TabIndex = 3;
            this.label_Begin.Text = "Hora de inicio:";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_End.Location = new System.Drawing.Point(133, 131);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.ShowUpDown = true;
            this.dateTimePicker_End.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker_End.TabIndex = 2;
            this.dateTimePicker_End.Value = new System.DateTime(2017, 5, 9, 8, 0, 0, 0);
            // 
            // dateTimePicker_Begin
            // 
            this.dateTimePicker_Begin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Begin.Location = new System.Drawing.Point(130, 89);
            this.dateTimePicker_Begin.Name = "dateTimePicker_Begin";
            this.dateTimePicker_Begin.ShowUpDown = true;
            this.dateTimePicker_Begin.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker_Begin.TabIndex = 1;
            this.dateTimePicker_Begin.Value = new System.DateTime(2017, 5, 9, 8, 0, 0, 0);
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
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Cancel.Location = new System.Drawing.Point(223, 306);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Edit.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Edit.Location = new System.Drawing.Point(132, 306);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 13;
            this.button_Edit.Text = "Editar";
            this.button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.Color.SteelBlue;
            this.button_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_New.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_New.Location = new System.Drawing.Point(40, 306);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 12;
            this.button_New.Text = "Nuevo";
            this.button_New.UseVisualStyleBackColor = false;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // tabContr_List
            // 
            this.tabContr_List.Controls.Add(this.tabPage1);
            this.tabContr_List.Location = new System.Drawing.Point(345, 31);
            this.tabContr_List.Name = "tabContr_List";
            this.tabContr_List.SelectedIndex = 0;
            this.tabContr_List.Size = new System.Drawing.Size(447, 389);
            this.tabContr_List.TabIndex = 15;
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
            this.tabPage1.Text = "Lista de turnos";
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
            this.Column_Begin,
            this.Column_End});
            this.dataGridView1.Location = new System.Drawing.Point(30, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 204);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Nombre";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Begin
            // 
            this.Column_Begin.HeaderText = "Hora de inicio";
            this.Column_Begin.Name = "Column_Begin";
            // 
            // Column_End
            // 
            this.Column_End.HeaderText = "Hora de fin";
            this.Column_End.Name = "Column_End";
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabContr_List);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.groupBox_Shift);
            this.Name = "Shift";
            this.Size = new System.Drawing.Size(819, 447);
            this.groupBox_Shift.ResumeLayout(false);
            this.groupBox_Shift.PerformLayout();
            this.tabContr_List.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Shift;
        private System.Windows.Forms.Label label_End;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Begin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Begin;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.TabControl tabContr_List;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_NameSearch;
        private System.Windows.Forms.Label label_NameSearch;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Begin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_End;
    }
}
