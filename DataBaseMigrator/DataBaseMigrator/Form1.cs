using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessManager.AccessLayer.Interfaces;
using AccessManager.Helper;
using Models;

namespace DataBaseMigrator
{
    public partial class Form1 : Form
    {
        private readonly IAccessLayer<brandkuerzel> _accessLayer;
        private readonly ISerializer<brandkuerzel> _serializer;
        private IEnumerable<brandkuerzel> _brandAbbreviations;


        public Form1(IAccessLayer<brandkuerzel> accessLayer, ISerializer<brandkuerzel> serializer)
        {
            this._serializer = serializer ?? Factory.CreateDefaultSerializer<brandkuerzel>();
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

        private async void btnSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                this._brandAbbreviations = await this._accessLayer.ReadAsync();
                this._serializer.Write(this._brandAbbreviations.ToList(), Path.Combine(Application.StartupPath, $"{nameof(brandkuerzel)}.xml"));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
         
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                var list = this._serializer.Read(Path.Combine(Application.StartupPath, $"{nameof(brandkuerzel)}.xml"))
                               .ToList();
                this.gridDatabase.DataSource = list;
                this.gridDatabase.Update();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private async void btnWriteToDb_Click(object sender, EventArgs e)
        {
            try
            {
                this._brandAbbreviations = this._serializer.Read(Path.Combine(Application.StartupPath, $"{nameof(brandkuerzel)}.xml"))
                               .ToList();

                this._brandAbbreviations.ToList().ForEach(x => Factory.CreateBrand(Factory.GetWorkUnit(), x));
                await this._accessLayer.UpdateAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}
