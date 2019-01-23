namespace DataBaseMigrator
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
            this.gridDatabase = new System.Windows.Forms.DataGridView();
            this.txtSqlConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDatabase
            // 
            this.gridDatabase.BackgroundColor = System.Drawing.Color.Maroon;
            this.gridDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatabase.GridColor = System.Drawing.Color.White;
            this.gridDatabase.Location = new System.Drawing.Point(704, 12);
            this.gridDatabase.Name = "gridDatabase";
            this.gridDatabase.Size = new System.Drawing.Size(474, 602);
            this.gridDatabase.TabIndex = 3;
            // 
            // txtSqlConnectionString
            // 
            this.txtSqlConnectionString.Location = new System.Drawing.Point(13, 12);
            this.txtSqlConnectionString.Name = "txtSqlConnectionString";
            this.txtSqlConnectionString.Size = new System.Drawing.Size(685, 20);
            this.txtSqlConnectionString.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 106);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(318, 51);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(379, 106);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(318, 51);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(318, 51);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 626);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtSqlConnectionString);
            this.Controls.Add(this.gridDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDatabase;
        private System.Windows.Forms.TextBox txtSqlConnectionString;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnUpdate;
    }
}

