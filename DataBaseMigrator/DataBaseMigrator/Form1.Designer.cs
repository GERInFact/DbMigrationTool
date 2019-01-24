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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnWriteToDb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDatabase
            // 
            this.gridDatabase.AllowUserToOrderColumns = true;
            this.gridDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDatabase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDatabase.BackgroundColor = System.Drawing.Color.Maroon;
            this.gridDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatabase.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDatabase.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridDatabase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridDatabase.GridColor = System.Drawing.Color.White;
            this.gridDatabase.Location = new System.Drawing.Point(716, 0);
            this.gridDatabase.Name = "gridDatabase";
            this.gridDatabase.Size = new System.Drawing.Size(474, 626);
            this.gridDatabase.TabIndex = 3;
            // 
            // txtSqlConnectionString
            // 
            this.txtSqlConnectionString.Location = new System.Drawing.Point(14, 48);
            this.txtSqlConnectionString.Name = "txtSqlConnectionString";
            this.txtSqlConnectionString.Size = new System.Drawing.Size(685, 20);
            this.txtSqlConnectionString.TabIndex = 4;
            this.txtSqlConnectionString.Text = "Enter your connection string...";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(13, 169);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(685, 51);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(14, 250);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(318, 51);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(380, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(318, 51);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSerialize
            // 
            this.btnSerialize.AutoSize = true;
            this.btnSerialize.BackColor = System.Drawing.Color.Black;
            this.btnSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSerialize.Location = new System.Drawing.Point(13, 494);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(318, 51);
            this.btnSerialize.TabIndex = 8;
            this.btnSerialize.Text = "Save Data as XML";
            this.btnSerialize.UseMnemonic = false;
            this.btnSerialize.UseVisualStyleBackColor = false;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.AutoSize = true;
            this.btnDeserialize.BackColor = System.Drawing.Color.Black;
            this.btnDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserialize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeserialize.Location = new System.Drawing.Point(379, 494);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(318, 51);
            this.btnDeserialize.TabIndex = 9;
            this.btnDeserialize.Text = "Load from XML";
            this.btnDeserialize.UseMnemonic = false;
            this.btnDeserialize.UseVisualStyleBackColor = false;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnWriteToDb
            // 
            this.btnWriteToDb.AutoSize = true;
            this.btnWriteToDb.BackColor = System.Drawing.Color.Black;
            this.btnWriteToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteToDb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWriteToDb.Location = new System.Drawing.Point(12, 418);
            this.btnWriteToDb.Name = "btnWriteToDb";
            this.btnWriteToDb.Size = new System.Drawing.Size(685, 51);
            this.btnWriteToDb.TabIndex = 10;
            this.btnWriteToDb.Text = "Write to DB";
            this.btnWriteToDb.UseVisualStyleBackColor = false;
            this.btnWriteToDb.Click += new System.EventHandler(this.btnWriteToDb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data Integration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Extraction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1190, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWriteToDb);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtSqlConnectionString);
            this.Controls.Add(this.gridDatabase);
            this.Name = "Form1";
            this.Text = "Database Migrator";
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
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnWriteToDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

