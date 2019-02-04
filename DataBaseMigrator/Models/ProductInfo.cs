using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using DevExpress.Xpo;

namespace Models
{
    public class ProductInfo : XPLiteObject, ISerializable
    {
        private string _brand;
        private string _name;
        private int _version;
        private int _mediaType;
        private int _archive;
        private string _segment;
        private string _verpackungsArt;
        private string _size;
        private string _attribut1;
        private string _attribut2;
        private string _datumStart;
        private string _datumEnd;
        private int _export;
        private int _position;
        private int _nichtExportieren;
        private byte _emailSended;
        private string _geschmack;
        private int _assetId;
        private AssetInfo _assetInfo;
        private SalesInfo _salesInfo;
        private MarketingInfo _marketingInfo;

        public ProductInfo()
        {

        }

        public ProductInfo(Session session) : base(session)
        {
            if (session == null) throw new ArgumentNullException(nameof(session));

        }

        public ProductInfo(SerializationInfo info, StreamingContext context)
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
        public MarketingInfo MarketingInfo
        {
            get => this._marketingInfo;
            set => this.SetPropertyValue(nameof(this.MarketingInfo).ToLower(), ref this._marketingInfo, value);
        }
        [Key, Persistent]
        [DbType("varchar(500)")]
        public int AssetId
        {
            get => this._assetId;
            set => this.SetPropertyValue(nameof(this.AssetId).ToLower(), ref this._assetId, value);
        }

        [DbType("varchar(500)")]
        public string Brand
        {
            get => this._brand;
            set => this.SetPropertyValue(nameof(this.Brand).ToLower(), ref this._brand, value);
        }
        [DbType("varchar(500)")]
        public string Name
        {
            get => this._name;
            set => this.SetPropertyValue(nameof(this.Name).ToLower(), ref this._name, value);
        }
        [DbType("varchar(500)")]
        public int Version
        {
            get => this._version;
            set => this.SetPropertyValue(nameof(this.Version).ToLower(), ref this._version, value);
        }

        public int MediaType
        {
            get => this._mediaType;
            set => this.SetPropertyValue(nameof(this.MediaType).ToLower(), ref this._mediaType, value);
        }

        public int Archive
        {
            get => this._archive;
            set => this.SetPropertyValue(nameof(this.Archive).ToLower(), ref this._archive, value);
        }

        [DbType("varchar(500)")]
        public string Segment
        {
            get => this._segment;
            set => this.SetPropertyValue(nameof(this.Segment).ToLower(), ref this._segment, value);
        }
        [DbType("varchar(500)")]
        public string VerpackungsArt
        {
            get => this._verpackungsArt;
            set => this.SetPropertyValue(nameof(this.VerpackungsArt).ToLower(), ref this._verpackungsArt, value);
        }
        [DbType("varchar(500)")]
        public string Size
        {
            get => this._size;
            set => this.SetPropertyValue(nameof(this.Size).ToLower(), ref this._size, value);
        }
      
        [DbType("varchar(500)")]
        public string Attribut1
        {
            get => this._attribut1;
            set => this.SetPropertyValue(nameof(this.Attribut1).ToLower(), ref this._attribut1, value);
        }
        [DbType("varchar(500)")]
        public string Attribut2
        {
            get => this._attribut2;
            set => this.SetPropertyValue(nameof(this.Attribut2).ToLower(), ref this._attribut2, value);
        }
       
      
       
       
        [DbType("varchar(500)")]
        public string DatumStart
        {
            get => this._datumStart;
            set => this.SetPropertyValue(nameof(this.DatumStart).ToLower(), ref this._datumStart, value);
        }
        [DbType("varchar(500)")]
        public string DatumEnd
        {
            get => this._datumEnd;
            set => this.SetPropertyValue(nameof(this.DatumEnd).ToLower(), ref this._datumEnd, value);
        }
     
        public int Export
        {
            get => this._export;
            set => this.SetPropertyValue(nameof(this.Export).ToLower(), ref this._export, value);
        }
       

        public int Position
        {
            get => this._position;
            set => this.SetPropertyValue(nameof(this.Position).ToLower(), ref this._position, value);
        }
       

        public int Nicht_Exportieren
        {
            get => this._nichtExportieren;
            set => this.SetPropertyValue(nameof(this.Nicht_Exportieren).ToLower(), ref this._nichtExportieren, value);
        }

        public byte EmailSended
        {
            get => this._emailSended;
            set => this.SetPropertyValue(nameof(this.EmailSended), ref this._emailSended, value);
        }

     
        [DbType("varchar(500)")]
        public string Geschmack
        {
            get => this._geschmack;
            set => this.SetPropertyValue(nameof(this.Geschmack).ToLower(), ref this._geschmack, value);
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
