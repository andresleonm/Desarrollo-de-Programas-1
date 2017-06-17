namespace WindowsFormsApp1.Views
{
    partial class Frm_AdvancedSimulationConfig
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_iterations = new MetroFramework.Controls.MetroTextBox();
            this.txt_tabu_list_size = new MetroFramework.Controls.MetroTextBox();
            this.txt_neighborhood_size = new MetroFramework.Controls.MetroTextBox();
            this.txt_combination_frecuency = new MetroFramework.Controls.MetroTextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel5.Location = new System.Drawing.Point(12, 341);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(445, 36);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Estos parámetros sirven para calibrar la simulación y están orientados para usuar" +
    "ios especializados.";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.WrapToLine = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(47, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 15);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Número de iteraciones :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(74, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 15);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Tamaño Lista Tabú :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel3.Location = new System.Drawing.Point(53, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(134, 15);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Tamaño de vecindario :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(12, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(175, 15);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Frecuencia de combinaciones :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // txt_iterations
            // 
            this.txt_iterations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_iterations.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_iterations.CustomButton.Image = null;
            this.txt_iterations.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_iterations.CustomButton.Name = "";
            this.txt_iterations.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_iterations.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_iterations.CustomButton.TabIndex = 1;
            this.txt_iterations.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_iterations.CustomButton.UseSelectable = true;
            this.txt_iterations.CustomButton.Visible = false;
            this.txt_iterations.Lines = new string[] {
        "8000"};
            this.txt_iterations.Location = new System.Drawing.Point(193, 32);
            this.txt_iterations.MaxLength = 32767;
            this.txt_iterations.Name = "txt_iterations";
            this.txt_iterations.PasswordChar = '\0';
            this.txt_iterations.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_iterations.SelectedText = "";
            this.txt_iterations.SelectionLength = 0;
            this.txt_iterations.SelectionStart = 0;
            this.txt_iterations.ShortcutsEnabled = true;
            this.txt_iterations.Size = new System.Drawing.Size(207, 29);
            this.txt_iterations.TabIndex = 50;
            this.txt_iterations.Text = "8000";
            this.txt_iterations.UseCustomBackColor = true;
            this.txt_iterations.UseSelectable = true;
            this.txt_iterations.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_iterations.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_iterations.Leave += new System.EventHandler(this.txt_iterations_Leave);
            // 
            // txt_tabu_list_size
            // 
            this.txt_tabu_list_size.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tabu_list_size.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_tabu_list_size.CustomButton.Image = null;
            this.txt_tabu_list_size.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_tabu_list_size.CustomButton.Name = "";
            this.txt_tabu_list_size.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_tabu_list_size.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_tabu_list_size.CustomButton.TabIndex = 1;
            this.txt_tabu_list_size.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_tabu_list_size.CustomButton.UseSelectable = true;
            this.txt_tabu_list_size.CustomButton.Visible = false;
            this.txt_tabu_list_size.Lines = new string[] {
        "10"};
            this.txt_tabu_list_size.Location = new System.Drawing.Point(193, 88);
            this.txt_tabu_list_size.MaxLength = 32767;
            this.txt_tabu_list_size.Name = "txt_tabu_list_size";
            this.txt_tabu_list_size.PasswordChar = '\0';
            this.txt_tabu_list_size.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tabu_list_size.SelectedText = "";
            this.txt_tabu_list_size.SelectionLength = 0;
            this.txt_tabu_list_size.SelectionStart = 0;
            this.txt_tabu_list_size.ShortcutsEnabled = true;
            this.txt_tabu_list_size.Size = new System.Drawing.Size(207, 29);
            this.txt_tabu_list_size.TabIndex = 51;
            this.txt_tabu_list_size.Text = "10";
            this.txt_tabu_list_size.UseCustomBackColor = true;
            this.txt_tabu_list_size.UseSelectable = true;
            this.txt_tabu_list_size.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_tabu_list_size.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_tabu_list_size.Leave += new System.EventHandler(this.txt_tabu_list_size_Leave);
            // 
            // txt_neighborhood_size
            // 
            this.txt_neighborhood_size.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_neighborhood_size.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_neighborhood_size.CustomButton.Image = null;
            this.txt_neighborhood_size.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_neighborhood_size.CustomButton.Name = "";
            this.txt_neighborhood_size.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_neighborhood_size.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_neighborhood_size.CustomButton.TabIndex = 1;
            this.txt_neighborhood_size.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_neighborhood_size.CustomButton.UseSelectable = true;
            this.txt_neighborhood_size.CustomButton.Visible = false;
            this.txt_neighborhood_size.Lines = new string[] {
        "50"};
            this.txt_neighborhood_size.Location = new System.Drawing.Point(193, 156);
            this.txt_neighborhood_size.MaxLength = 32767;
            this.txt_neighborhood_size.Name = "txt_neighborhood_size";
            this.txt_neighborhood_size.PasswordChar = '\0';
            this.txt_neighborhood_size.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_neighborhood_size.SelectedText = "";
            this.txt_neighborhood_size.SelectionLength = 0;
            this.txt_neighborhood_size.SelectionStart = 0;
            this.txt_neighborhood_size.ShortcutsEnabled = true;
            this.txt_neighborhood_size.Size = new System.Drawing.Size(207, 29);
            this.txt_neighborhood_size.TabIndex = 52;
            this.txt_neighborhood_size.Text = "50";
            this.txt_neighborhood_size.UseCustomBackColor = true;
            this.txt_neighborhood_size.UseSelectable = true;
            this.txt_neighborhood_size.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_neighborhood_size.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_neighborhood_size.Leave += new System.EventHandler(this.txt_neighborhood_size_Leave);
            // 
            // txt_combination_frecuency
            // 
            this.txt_combination_frecuency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_combination_frecuency.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_combination_frecuency.CustomButton.Image = null;
            this.txt_combination_frecuency.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_combination_frecuency.CustomButton.Name = "";
            this.txt_combination_frecuency.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_combination_frecuency.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_combination_frecuency.CustomButton.TabIndex = 1;
            this.txt_combination_frecuency.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_combination_frecuency.CustomButton.UseSelectable = true;
            this.txt_combination_frecuency.CustomButton.Visible = false;
            this.txt_combination_frecuency.Lines = new string[] {
        "100"};
            this.txt_combination_frecuency.Location = new System.Drawing.Point(193, 221);
            this.txt_combination_frecuency.MaxLength = 32767;
            this.txt_combination_frecuency.Name = "txt_combination_frecuency";
            this.txt_combination_frecuency.PasswordChar = '\0';
            this.txt_combination_frecuency.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_combination_frecuency.SelectedText = "";
            this.txt_combination_frecuency.SelectionLength = 0;
            this.txt_combination_frecuency.SelectionStart = 0;
            this.txt_combination_frecuency.ShortcutsEnabled = true;
            this.txt_combination_frecuency.Size = new System.Drawing.Size(207, 29);
            this.txt_combination_frecuency.TabIndex = 53;
            this.txt_combination_frecuency.Text = "100";
            this.txt_combination_frecuency.UseCustomBackColor = true;
            this.txt_combination_frecuency.UseSelectable = true;
            this.txt_combination_frecuency.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_combination_frecuency.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_combination_frecuency.Leave += new System.EventHandler(this.txt_combination_frecuency_Leave);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ok.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(130, 291);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(82, 25);
            this.btn_ok.TabIndex = 61;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(268, 291);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 25);
            this.btn_cancel.TabIndex = 62;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(301, 262);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 13);
            this.linkLabel1.TabIndex = 63;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Valores por defecto";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Frm_AdvancedSimulationConfig
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(469, 386);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_combination_frecuency);
            this.Controls.Add(this.txt_neighborhood_size);
            this.Controls.Add(this.txt_tabu_list_size);
            this.Controls.Add(this.txt_iterations);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel5);
            this.Name = "Frm_AdvancedSimulationConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración Avanzada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_iterations;
        private MetroFramework.Controls.MetroTextBox txt_tabu_list_size;
        private MetroFramework.Controls.MetroTextBox txt_neighborhood_size;
        private MetroFramework.Controls.MetroTextBox txt_combination_frecuency;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}