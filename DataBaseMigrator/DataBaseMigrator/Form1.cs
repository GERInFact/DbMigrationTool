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
        private IEnumerable<assets> _assets;


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
                this._assets = await this._accessLayer.ReadAsync();
                this._assets = this._assets.OrderBy(x => x.AssetId).ToList();
                this._serializer.Write(this._assets, Path.Combine(Application.StartupPath, $"{nameof(assets)}.xml"));
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
                var list = await Task.Run(() => this._serializer.Read(Path.Combine(Application.StartupPath, $"{nameof(assets)}.xml")).ToList());
                this.gridDatabase.DataSource = list;
                this.gridDatabase.Refresh();
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
                this._assets = this._serializer
                                       .Read(Path.Combine(Application.StartupPath, $"{nameof(assets)}.xml"))
                                       .ToList();

      

                this._assets
                    .ToList()
                    .ForEach(a =>
                                       {
                                            var session = Factory.GetWorkUnit();
                                            var assetInfo = Factory.CreateAssetInfo(session, a);
                                            var productInfo = Factory.CreateProductInfo(session, a);
                                            var salesInfo = Factory.CreateSalesInfo(session, a);
                                            assetInfo.SalesInfo = salesInfo;
                                            productInfo.SalesInfo = salesInfo;
                                            assetInfo.ProductInfo = productInfo;
                                            productInfo.AssetInfo = assetInfo;
                                            salesInfo.ProductInfo = productInfo;
                                            salesInfo.AssetInfo = assetInfo;
                                       });

    

                 await this._accessLayer.UpdateAsync();

                // await this.WriteToDbAsync(this._assets);

                MessageBox.Show("Upload completed.");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private async Task WriteToDbAsync(IEnumerable<assets> assets)
        {
            //TAKE LIST, TAKE CERTAIN ELEMENT AMOUNT; REMOVE ELEMENTS; REDO

            var enumerable = assets.ToList();
            if (!enumerable.Any())
                return;

            var assetCount = enumerable.Count() >= 1000 ? 1000 : enumerable.Count();
            var assetsToCommit = enumerable.Take(assetCount);


            assetsToCommit.ToList().ForEach(x =>
                                                Factory.CreateAsset(Factory.GetWorkUnit(), x));

            await this._accessLayer.UpdateAsync();
            this.WriteToDbAsync(enumerable.Skip(assetCount));
        }
    }
}
