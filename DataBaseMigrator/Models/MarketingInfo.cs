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
    public class MarketingInfo : XPLiteObject, ISerializable
    {

        private int _assetId;
        private string _veroeffentlichung;
        private string _promotion;
        private string _copyright;
        private string _fotograf;
        private string _agentur;
        private string _sichtbarAb;
        private AssetInfo _assetInfo;
        private SalesInfo _salesInfo;
        private ProductInfo _productInfo;

        public MarketingInfo()
        {

        }

        public MarketingInfo(Session session) : base(session)
        {
            if (session == null) throw new ArgumentNullException(nameof(session));

        }

        public MarketingInfo(SerializationInfo info, StreamingContext context)
        {
            this.GetType()
                .GetProperties(BindingFlags.Public)
                .ToList()
                .ForEach(p =>
                {
                    p.SetValue(p, info.GetValue(p.Name, p.PropertyType));
                });
        }

        [Key, Persistent]
        [DbType("varchar(500)")]
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
        public SalesInfo SalesInfo
        {
            get => this._salesInfo;
            set => this.SetPropertyValue(nameof(this.SalesInfo).ToLower(), ref this._salesInfo, value);
        }

        [Association]
        public ProductInfo ProductInfo
        {
            get => this._productInfo;
            set => this.SetPropertyValue(nameof(this.ProductInfo).ToLower(), ref this._productInfo, value);
        }

        [DbType("varchar(500)")]
        public string Veroeffentlichung
        {
            get => this._veroeffentlichung;
            set => this.SetPropertyValue(nameof(this.Veroeffentlichung).ToLower(), ref this._veroeffentlichung, value);
        }
      
        [DbType("varchar(500)")]
        public string Promotion
        {
            get => this._promotion;
            set => this.SetPropertyValue(nameof(this.Promotion).ToLower(), ref this._promotion, value);
        }
        [DbType("varchar(500)")]
        public string Copyright
        {
            get => this._copyright;
            set => this.SetPropertyValue(nameof(this.Copyright).ToLower(), ref this._copyright, value);
        }
        [DbType("varchar(500)")]
        public string Fotograf
        {
            get => this._fotograf;
            set => this.SetPropertyValue(nameof(this.Fotograf).ToLower(), ref this._fotograf, value);
        }
        [DbType("varchar(500)")]
        public string Agentur
        {
            get => this._agentur;
            set => this.SetPropertyValue(nameof(this.Agentur).ToLower(), ref this._agentur, value);
        }

        [DbType("varchar(500)")]
        public string SichtbarAb
        {
            get => this._sichtbarAb;
            set => this.SetPropertyValue(nameof(this.SichtbarAb).ToLower(), ref this._sichtbarAb, value);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            this.GetType()
                .GetProperties()
                .ToList()
                .ForEach(p =>
                {
                    info.AddValue(p.Name, p);
                });
        }
    }
}
