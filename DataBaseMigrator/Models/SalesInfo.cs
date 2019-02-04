using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Models
{
    public class SalesInfo : XPLiteObject, ISerializable
    {
        public SalesInfo()
        {
            
        }

        public SalesInfo(Session session) : base(session)
        {
                
        }

        public SalesInfo(SerializationInfo info, StreamingContext context)
        {
            this.GetType()
                .GetProperties(BindingFlags.Public)
                .ToList()
                .ForEach(p =>
                {
                    p.SetValue(p, info.GetValue(p.Name, p.PropertyType));
                });
        }

        private int _assetId;
        private string _vbnEan;
        private string _eanSekundaer;
        private string _eanKlein;
        private string _vseEan;
        private AssetInfo _assetInfo;
        private ProductInfo _productInfo;
        private MarketingInfo _marketingInfo;


        [Key, Persistent]
        public int AssetId
        {
            get => this._assetId;
            set => this.SetPropertyValue(nameof(this.AssetId).ToLower(), ref this._assetId, value);
        }

        [Association]
        public AssetInfo AssetInfo
        {
            get => this._assetInfo;
            set => this.SetPropertyValue(nameof(this.AssetInfo).ToLower(), ref this._assetInfo, value);
        }

        [Association]
        public ProductInfo ProductInfo
        {
            get => this._productInfo;
            set => this.SetPropertyValue(nameof(this.ProductInfo).ToLower(), ref this._productInfo, value);
        }

        [Association]
        public MarketingInfo MarketingInfo
        {
            get => this._marketingInfo;
            set => this.SetPropertyValue(nameof(this.MarketingInfo).ToLower(), ref this._marketingInfo, value);
        }

        [DbType("varchar(500)")]
        public string Vbn_Ean
        {
            get => this._vbnEan;
            set => this.SetPropertyValue(nameof(this.Vbn_Ean).ToLower(), ref this._vbnEan, value);
        }

    
        [DbType("varchar(500)")]
        public string EanSekundaer
        {
            get => this._eanSekundaer;
            set => this.SetPropertyValue(nameof(this.EanSekundaer).ToLower(), ref this._eanSekundaer, value);
        }
      
        [DbType("varchar(500)")]
        public string Ean_Klein
        {
            get => this._eanKlein;
            set => this.SetPropertyValue(nameof(this.Ean_Klein).ToLower(), ref this._eanKlein, value);
        }

      
        [DbType("varchar(500)")]
        public string Vse_Ean
        {
            get => this._vseEan;
            set => this.SetPropertyValue(nameof(this.Vse_Ean).ToLower(), ref this._vseEan, value);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            this.GetType()
                .GetProperties(BindingFlags.Public)
                .ToList()
                .ForEach(p =>
                {
                    info.AddValue(p.Name, p);
                });
        }
    }
}
