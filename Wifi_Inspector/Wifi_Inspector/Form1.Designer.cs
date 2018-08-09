namespace Wifi_Inspector
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Member_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Member_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Member_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Save = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.checkall = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Member_0
            // 
            this.Member_0.Text = "";
            this.Member_0.Width = 158;
            // 
            // Member_1
            // 
            this.Member_1.Text = "";
            this.Member_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Member_1.Width = 164;
            // 
            // Member_2
            // 
            this.Member_2.Text = "";
            this.Member_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Member_2.Width = 231;
            // 
            // Result
            // 
            this.Result.CheckBoxes = true;
            this.Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.SSID});
            this.Result.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Result.Location = new System.Drawing.Point(12, 149);
            this.Result.MultiSelect = false;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1166, 565);
            this.Result.TabIndex = 5;
            this.Result.UseCompatibleStateImageBehavior = false;
            this.Result.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 300;
            // 
            // SSID
            // 
            this.SSID.Text = "SSID";
            this.SSID.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 164;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 231;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 158;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 164;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 231;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 158;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 164;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 231;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "";
            this.columnHeader12.Width = 158;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 164;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 231;
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Enabled = false;
            this.Save.Font = new System.Drawing.Font("Consolas", 11.14286F);
            this.Save.Image = global::Wifi_Inspector.Properties.Resources.Save_as_96px;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(392, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(372, 119);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save Results";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Find
            // 
            this.Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Find.Enabled = false;
            this.Find.Font = new System.Drawing.Font("Consolas", 11.14286F);
            this.Find.Image = global::Wifi_Inspector.Properties.Resources.Show_Password_96px;
            this.Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Find.Location = new System.Drawing.Point(806, 12);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(372, 119);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find Passswords";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Process
            // 
            this.Process.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Process.Font = new System.Drawing.Font("Consolas", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.Image = global::Wifi_Inspector.Properties.Resources.Search_96px;
            this.Process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Process.Location = new System.Drawing.Point(12, 12);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(344, 119);
            this.Process.TabIndex = 0;
            this.Process.Text = "Search for saved networks";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // checkall
            // 
            this.checkall.AutoSize = true;
            this.checkall.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkall.Enabled = false;
            this.checkall.Font = new System.Drawing.Font("Sitka Small", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkall.Location = new System.Drawing.Point(164, 157);
            this.checkall.Name = "checkall";
            this.checkall.Size = new System.Drawing.Size(151, 39);
            this.checkall.TabIndex = 7;
            this.checkall.Text = "Check all";
            this.checkall.UseVisualStyleBackColor = true;
            this.checkall.CheckedChanged += new System.EventHandler(this.checkall_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1194, 726);
            this.Controls.Add(this.checkall);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Process);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.Text = "Wifi Inspector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.ColumnHeader Member_0;
        private System.Windows.Forms.ColumnHeader Member_1;
        private System.Windows.Forms.ColumnHeader Member_2;
        private System.Windows.Forms.ListView Result;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader SSID;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckBox checkall;
    }
}

