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
    public class AssetInfo : XPLiteObject, ISerializable
    {
        private int _assetId;
        private string _fileNameOriginal;
        private string _fileNameEu;
        private string _fileNameLang;
        private string _fileNameAlt;
        private int _parentAssetId;
        private string _datenMenge;
        private string _dateiGroesse;
        private ProductInfo _productInfo;
        private SalesInfo _salesInfo;
        private MarketingInfo _marketingInfo;

        public AssetInfo()
        {
            
        }

        public AssetInfo(Session session) : base(session)
        {
            
        }

        public AssetInfo(SerializationInfo info, StreamingContext context)
        {
            this.GetType()
                .GetProperties(BindingFlags.Public)
                .ToList()
                .ForEach(p =>
                {
                    p.SetValue(p, info.GetValue(p.Name, p.PropertyType));
                });
        }

        [Association]
        public ProductInfo ProductInfo
        {
            get => this._productInfo;
            set => this.SetPropertyValue(nameof(this.ProductInfo).ToLower(), ref this._productInfo, value);
        }

        [Association]
        public SalesInfo SalesInfo
        {
            get => this. _salesInfo;
            set => this.SetPropertyValue(nameof(this.SalesInfo).ToLower(), ref this._salesInfo, value);
        }

        [Association]
        public MarketingInfo MarketingInfo
        {
            get => this._marketingInfo;
            set => this.SetPropertyValue(nameof(this.MarketingInfo).ToLower(), ref this._marketingInfo, value);
        }

        [Key, Persistent]
        public int AssetId
        {
            get => this._assetId;
            set => this.SetPropertyValue(nameof(this.AssetId).ToLower(), ref this._assetId, value);
        }

        [DbType("varchar(500)")]
        public string FileNameOriginal
        {
            get => this._fileNameOriginal;
            set => this.SetPropertyValue(nameof(this.FileNameOriginal).ToLower(), ref this._fileNameOriginal, value);
        }
        [DbType("varchar(500)")]
        public string FileNameEu
        {
            get => this._fileNameEu;
            set => this.SetPropertyValue(nameof(this.FileNameEu).ToLower(), ref this._fileNameEu, value);
        }

        [DbType("varchar(500)")]
        public string FileNameLang
        {
            get => this._fileNameLang;
            set => this.SetPropertyValue(nameof(this.FileNameLang).ToLower(), ref this._fileNameLang, value);
        }
        [DbType("varchar(500)")]
        public string FileNameAlt
        {
            get => this._fileNameAlt;
            set => this.SetPropertyValue(nameof(this.FileNameAlt).ToLower(), ref this._fileNameAlt, value);
        }
        public int ParentAssetID
        {
            get => this._parentAssetId;
            set => this.SetPropertyValue(nameof(this.ParentAssetID), ref this._parentAssetId, value);
        }

        [DbType("varchar(500)")]
        public string DatenMenge
        {
            get => this._datenMenge;
            set => this.SetPropertyValue(nameof(this.DatenMenge).ToLower(), ref this._datenMenge, value);
        }
        [DbType("varchar(500)")]
        public string DateiGroesse
        {
            get => this._dateiGroesse;
            set => this.SetPropertyValue(nameof(this.DateiGroesse).ToLower(), ref this._dateiGroesse, value);
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
