namespace WindowsFormsApp1.Views.Currency_Module
{
    partial class UC_CurrencyMain
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.select_currency = new MetroFramework.Controls.MetroTile();
            this.select_exchange = new MetroFramework.Controls.MetroTile();
            this.uC_Currency1 = new WindowsFormsApp1.Views.Currency_Module.UC_Currency();
            this.uC_Exchange1 = new WindowsFormsApp1.Views.Currency_Module.UC_Exchange();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.select_currency);
            this.metroPanel1.Controls.Add(this.select_exchange);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(669, 71);
            this.metroPanel1.TabIndex = 44;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uC_Exchange1);
            this.panel1.Controls.Add(this.uC_Currency1);
            this.panel1.Location = new System.Drawing.Point(6, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 465);
            this.panel1.TabIndex = 45;
            // 
            // select_currency
            // 
            this.select_currency.ActiveControl = null;
            this.select_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.select_currency.Location = new System.Drawing.Point(3, 3);
            this.select_currency.Name = "select_currency";
            this.select_currency.Size = new System.Drawing.Size(177, 62);
            this.select_currency.TabIndex = 40;
            this.select_currency.Text = "Moneda";
            this.select_currency.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.select_currency.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.select_currency.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.select_currency.UseCustomBackColor = true;
            this.select_currency.UseSelectable = true;
            this.select_currency.UseTileImage = true;
            this.select_currency.Click += new System.EventHandler(this.select_currency_Click);
            // 
            // select_exchange
            // 
            this.select_exchange.ActiveControl = null;
            this.select_exchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.select_exchange.Location = new System.Drawing.Point(205, 3);
            this.select_exchange.Name = "select_exchange";
            this.select_exchange.Size = new System.Drawing.Size(177, 62);
            this.select_exchange.TabIndex = 41;
            this.select_exchange.Text = "Tipo de Cambio";
            this.select_exchange.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.select_exchange.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.select_exchange.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.select_exchange.UseCustomBackColor = true;
            this.select_exchange.UseSelectable = true;
            this.select_exchange.UseTileImage = true;
            this.select_exchange.Click += new System.EventHandler(this.select_exchange_Click);
            // 
            // uC_Currency1
            // 
            this.uC_Currency1.Location = new System.Drawing.Point(0, 0);
            this.uC_Currency1.Name = "uC_Currency1";
            this.uC_Currency1.Size = new System.Drawing.Size(666, 465);
            this.uC_Currency1.TabIndex = 0;
            this.uC_Currency1.UseSelectable = true;
            // 
            // uC_Exchange1
            // 
            this.uC_Exchange1.Location = new System.Drawing.Point(0, 4);
            this.uC_Exchange1.Name = "uC_Exchange1";
            this.uC_Exchange1.Size = new System.Drawing.Size(663, 458);
            this.uC_Exchange1.TabIndex = 1;
            this.uC_Exchange1.UseSelectable = true;
            // 
            // UC_CurrencyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UC_CurrencyMain";
            this.Size = new System.Drawing.Size(675, 549);
            this.Load += new System.EventHandler(this.UC_CurrencyMain_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile select_currency;
        private MetroFramework.Controls.MetroTile select_exchange;
        private System.Windows.Forms.Panel panel1;
        private UC_Currency uC_Currency1;
        private UC_Exchange uC_Exchange1;
    }
}
