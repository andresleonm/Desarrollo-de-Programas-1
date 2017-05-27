namespace WindowsFormsApp1.Views
{
    partial class UC_SalesOrder
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.btn_Search = new MetroFramework.Controls.MetroTile();
            this.txt_Doi = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_phone = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.cb_Currency = new MetroFramework.Controls.MetroComboBox();
            this.dt_DeliveryDate = new MetroFramework.Controls.MetroDateTime();
            this.txt_order = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mbStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Controls.Add(this.gbClient);
            this.panel1.Controls.Add(this.gbOrder);
            this.panel1.Location = new System.Drawing.Point(8, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 559);
            this.panel1.TabIndex = 1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 218);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(827, 319);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 40;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(819, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedido";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(728, 15);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 44;
            this.metroButton1.Text = "Nueva";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.btn_Search);
            this.gbClient.Controls.Add(this.txt_Doi);
            this.gbClient.Controls.Add(this.txt_address);
            this.gbClient.Controls.Add(this.txt_phone);
            this.gbClient.Controls.Add(this.label1);
            this.gbClient.Controls.Add(this.txt_name);
            this.gbClient.Controls.Add(this.label7);
            this.gbClient.Controls.Add(this.label9);
            this.gbClient.Controls.Add(this.label12);
            this.gbClient.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbClient.Location = new System.Drawing.Point(12, 20);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(431, 171);
            this.gbClient.TabIndex = 39;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Datos del Cliente";
            // 
            // btn_Search
            // 
            this.btn_Search.ActiveControl = null;
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Location = new System.Drawing.Point(373, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(46, 23);
            this.btn_Search.TabIndex = 43;
            this.btn_Search.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_Search.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.UseCustomBackColor = true;
            this.btn_Search.UseCustomForeColor = true;
            this.btn_Search.UseSelectable = true;
            this.btn_Search.UseStyleColors = true;
            this.btn_Search.UseTileImage = true;
            // 
            // txt_Doi
            // 
            // 
            // 
            // 
            this.txt_Doi.CustomButton.Image = null;
            this.txt_Doi.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_Doi.CustomButton.Name = "";
            this.txt_Doi.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Doi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Doi.CustomButton.TabIndex = 1;
            this.txt_Doi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Doi.CustomButton.UseSelectable = true;
            this.txt_Doi.CustomButton.Visible = false;
            this.txt_Doi.Lines = new string[0];
            this.txt_Doi.Location = new System.Drawing.Point(115, 59);
            this.txt_Doi.MaxLength = 32767;
            this.txt_Doi.Name = "txt_Doi";
            this.txt_Doi.PasswordChar = '\0';
            this.txt_Doi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Doi.SelectedText = "";
            this.txt_Doi.SelectionLength = 0;
            this.txt_Doi.SelectionStart = 0;
            this.txt_Doi.ShortcutsEnabled = true;
            this.txt_Doi.Size = new System.Drawing.Size(240, 25);
            this.txt_Doi.TabIndex = 42;
            this.txt_Doi.UseSelectable = true;
            this.txt_Doi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Doi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(115, 96);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(240, 25);
            this.txt_address.TabIndex = 41;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_phone
            // 
            // 
            // 
            // 
            this.txt_phone.CustomButton.Image = null;
            this.txt_phone.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_phone.CustomButton.Name = "";
            this.txt_phone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_phone.CustomButton.TabIndex = 1;
            this.txt_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_phone.CustomButton.UseSelectable = true;
            this.txt_phone.CustomButton.Visible = false;
            this.txt_phone.Lines = new string[0];
            this.txt_phone.Location = new System.Drawing.Point(115, 133);
            this.txt_phone.MaxLength = 32767;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.ShortcutsEnabled = true;
            this.txt_phone.Size = new System.Drawing.Size(240, 25);
            this.txt_phone.TabIndex = 40;
            this.txt_phone.UseSelectable = true;
            this.txt_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Teléfono :";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(115, 22);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(240, 25);
            this.txt_name.TabIndex = 38;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "N° Documento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nombres :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Dirección :";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.cb_Currency);
            this.gbOrder.Controls.Add(this.dt_DeliveryDate);
            this.gbOrder.Controls.Add(this.txt_order);
            this.gbOrder.Controls.Add(this.label11);
            this.gbOrder.Controls.Add(this.label8);
            this.gbOrder.Controls.Add(this.label2);
            this.gbOrder.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbOrder.Location = new System.Drawing.Point(460, 20);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(379, 171);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Datos del Pedido";
            // 
            // cb_Currency
            // 
            this.cb_Currency.FormattingEnabled = true;
            this.cb_Currency.ItemHeight = 23;
            this.cb_Currency.Location = new System.Drawing.Point(116, 62);
            this.cb_Currency.Name = "cb_Currency";
            this.cb_Currency.Size = new System.Drawing.Size(240, 29);
            this.cb_Currency.TabIndex = 48;
            this.cb_Currency.UseSelectable = true;
            // 
            // dt_DeliveryDate
            // 
            this.dt_DeliveryDate.Location = new System.Drawing.Point(116, 108);
            this.dt_DeliveryDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_DeliveryDate.Name = "dt_DeliveryDate";
            this.dt_DeliveryDate.Size = new System.Drawing.Size(240, 29);
            this.dt_DeliveryDate.TabIndex = 47;
            // 
            // txt_order
            // 
            this.txt_order.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_order.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_order.CustomButton.Image = null;
            this.txt_order.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_order.CustomButton.Name = "";
            this.txt_order.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_order.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_order.CustomButton.TabIndex = 1;
            this.txt_order.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_order.CustomButton.UseSelectable = true;
            this.txt_order.CustomButton.UseVisualStyleBackColor = false;
            this.txt_order.CustomButton.Visible = false;
            this.txt_order.Enabled = false;
            this.txt_order.Lines = new string[0];
            this.txt_order.Location = new System.Drawing.Point(116, 22);
            this.txt_order.MaxLength = 32767;
            this.txt_order.Name = "txt_order";
            this.txt_order.PasswordChar = '\0';
            this.txt_order.ReadOnly = true;
            this.txt_order.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_order.SelectedText = "";
            this.txt_order.SelectionLength = 0;
            this.txt_order.SelectionStart = 0;
            this.txt_order.ShortcutsEnabled = true;
            this.txt_order.Size = new System.Drawing.Size(240, 25);
            this.txt_order.TabIndex = 38;
            this.txt_order.UseCustomBackColor = true;
            this.txt_order.UseSelectable = true;
            this.txt_order.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_order.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(6, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Fecha Entrega :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "N° Orden :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moneda :";
            // 
            // mbStyle
            // 
            this.mbStyle.Owner = null;
            // 
            // UC_SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_SalesOrder";
            this.Size = new System.Drawing.Size(872, 592);
            this.Load += new System.EventHandler(this.UC_SalesOrder_Load);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbStyle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbClient;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btn_Search;
        private MetroFramework.Controls.MetroTextBox txt_Doi;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_phone;
        private MetroFramework.Controls.MetroTextBox txt_order;
        private MetroFramework.Controls.MetroDateTime dt_DeliveryDate;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Components.MetroStyleManager mbStyle;
        private MetroFramework.Controls.MetroComboBox cb_Currency;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
