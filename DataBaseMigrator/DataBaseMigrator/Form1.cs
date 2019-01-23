using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessManager.AccessLayer.Interfaces;
using Models;

namespace DataBaseMigrator
{
    public partial class Form1 : Form
    {
        private readonly IAccessLayer<brandkuerzel> _accessLayer;


        public Form1(IAccessLayer<brandkuerzel> accessLayer)
        {
            this._accessLayer = accessLayer ?? throw new ArgumentNullException(nameof(accessLayer));
            this.InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this._accessLayer.SetConnectionString(this.txtSqlConnectionString.Text);
                await this._accessLayer.ConnectToDbAsync();
                var data = await this._accessLayer.ReadAsync();
                this.gridDatabase.DataSource = data.ToList();
                this.gridDatabase.Update();

                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
               
            }
            
        }
    }
}
