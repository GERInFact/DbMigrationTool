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
        private readonly IAccessLayer<assets> _accessLayer;
        private readonly ISerializer<assets> _serializer;
        private IEnumerable<assets> _assetInfos;


        public Form1(IAccessLayer<assets> accessLayer, ISerializer<assets> serializer)
        {
            this._serializer = serializer ?? Factory.CreateDefaultSerializer<assets>();
            this._accessLayer = accessLayer ?? throw new ArgumentNullException(nameof(accessLayer));
            this.InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this._accessLayer.SetConnectionString(this.txtSqlConnectionString.Text);
                await this._accessLayer.ConnectToDbAsync();
                MessageBox.Show("Connected to database: " + Factory.GetWorkUnit().Connection);

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
                this._assetInfos = await this._accessLayer.ReadAsync();
                this._assetInfos = this._assetInfos.OrderBy(x => x.AssetId).ToList();
                this._serializer.Write(this._assetInfos, Path.Combine(Application.StartupPath, $"{nameof(assets)}.xml"));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
         
        }

        private async void btnDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridDatabase.DataSource = null;
                var list = await Task.Run(() =>this._serializer.Read(Path.Combine(Application.StartupPath, $"{nameof(assets)}.xml")).ToList());
                this.gridDatabase.DataSource = list;
                this.gridDatabase.Refresh();
                this.gridDatabase.Update();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnWriteToDb_Click(object sender, EventArgs e)
        {
            try
            {
                this._assetInfos = this._serializer.Read(Path.Combine(Application.StartupPath, $"{nameof(assets)}.xml"))
                                                            .ToList();

                this.WriteToDb(this._assetInfos);


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private  async void WriteToDb(IEnumerable<assets> assets)
        {
            //TAKE LIST, TAKE CERTAIN ELEMENT AMOUNT; REMOVE ELEMENTS; REDO

            if (!assets.Any())
                return;

            await this._accessLayer.UpdateAsync();

            var assetCount = assets.Count() >= 100 ? 100 : assets.Count();
            var assetsToCommit = assets.Take(assetCount);

            assetsToCommit.ToList().ForEach(x => Factory.CreateAsset(Factory.GetWorkUnit(), x));
            this.WriteToDb(assets.Skip(assetCount));

        }
    }
}
