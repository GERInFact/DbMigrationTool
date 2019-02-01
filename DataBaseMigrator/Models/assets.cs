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
    public class assets : XPLiteObject, ISerializable
    {
        private int _assetId;
        private string _vbnEan;
        private string _brand;
        private string _name;
        private int _version;
        private int _mediaType;
        private int _archive;
        private string _segment;
        private string _verpackungsArt;
        private string _size;
        private string _veroeffentlichung;
        private string _attribut1;
        private string _attribut2;
        private string _promotion;
        private string _copyright;
        private string _fotograf;
        private string _agentur;
        private string _datenMenge;
        private string _dateiGroesse;
        private string _datumStart;
        private string _datumEnd;
        private string _sichtbarAb;
        private string _eanSekundaer;
        private string _fileNameOriginal;
        private string _fileNameEu;
        private int _export;
        private string _eanKlein;
        private int _position;
        private string _fileNameLang;
        private string _fileNameAlt;
        private int _nichtExportieren;
        private byte _emailSended;
        private int _parentAssetId;
        private string _geschmack;
        private string _vseEan;

        public assets()
        {
            
        }

        public assets(Session session) : base(session)
        {
            if(session == null) throw new ArgumentNullException(nameof(session));
          
        }

        public assets(SerializationInfo info, StreamingContext context)
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
        public int AssetId
        {
            get => this._assetId;
            set => this.SetPropertyValue(nameof(this.AssetId).ToLower(), ref this._assetId, value);
        }

        public string Vbn_Ean
        {
            get => this._vbnEan;
            set => this.SetPropertyValue(nameof(this.Vbn_Ean).ToLower(), ref this._vbnEan, value);
        }

        public string Brand
        {
            get => this._brand;
            set => this.SetPropertyValue(nameof(this.Brand).ToLower(),ref this._brand , value);
        }

        public string Name
        {
            get => this._name;
            set => this.SetPropertyValue(nameof(this.Name).ToLower(), ref  this._name, value);
        }

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


        public string Segment
        {
            get => this._segment;
            set => this.SetPropertyValue(nameof(this.Segment).ToLower(), ref this._segment, value);
        }

        public string VerpackungsArt
        {
            get => this._verpackungsArt;
            set => this.SetPropertyValue(nameof(this.VerpackungsArt).ToLower(), ref this._verpackungsArt, value);
        }

        public string Size
        {
            get => this._size;
            set => this.SetPropertyValue(nameof(this.Size).ToLower(), ref this._size, value);
        }

        public string Veroeffentlichung
        {
            get => this._veroeffentlichung;
            set => this.SetPropertyValue(nameof(this.Veroeffentlichung).ToLower(), ref this._veroeffentlichung, value);
        }

        public string Attribut1
        {
            get => this._attribut1;
            set => this.SetPropertyValue(nameof(this.Attribut1).ToLower(), ref this._attribut1, value);
        }

        public string Attribut2
        {
            get => this._attribut2;
            set => this.SetPropertyValue(nameof(this.Attribut2).ToLower(), ref this._attribut2, value);
        }

        public string Promotion
        {
            get => this._promotion;
            set => this.SetPropertyValue(nameof(this.Promotion).ToLower(), ref this._promotion, value);
        }

        public string Copyright
        {
            get => this._copyright;
            set => this.SetPropertyValue(nameof(this.Copyright).ToLower(), ref this._copyright, value);
        }

        public string Fotograf
        {
            get => this._fotograf;
            set => this.SetPropertyValue(nameof(this.Fotograf).ToLower(), ref this._fotograf, value);
        }

        public string Agentur
        {
            get => this._agentur;
            set => this.SetPropertyValue(nameof(this.Agentur).ToLower(), ref this._agentur, value);
        }

        public string DatenMenge
        {
            get => this._datenMenge;
            set => this.SetPropertyValue(nameof(this.DatenMenge).ToLower(), ref this._datenMenge, value);
        }

        public string DateiGroesse
        {
            get => this._dateiGroesse;
            set => this.SetPropertyValue(nameof(this.DateiGroesse).ToLower(), ref this._dateiGroesse, value);
        }

        public string DatumStart
        {
            get => this._datumStart;
            set => this.SetPropertyValue(nameof(this.DatumStart).ToLower(), ref this._datumStart, value);
        }

        public string DatumEnd
        {
            get => this._datumEnd;
            set => this.SetPropertyValue(nameof(this.DatumEnd).ToLower(), ref this._datumEnd, value);
        }

        public string SichtbarAb
        {
            get => this._sichtbarAb;
            set => this.SetPropertyValue(nameof(this.SichtbarAb).ToLower(), ref this._sichtbarAb, value);
        }

        public string EanSekundaer
        {
            get => this._eanSekundaer;
            set => this.SetPropertyValue(nameof(this.EanSekundaer).ToLower(), ref this._eanSekundaer, value);
        }

        public string FileNameOriginal
        {
            get => this._fileNameOriginal;
            set => this.SetPropertyValue(nameof(this.FileNameOriginal).ToLower(), ref this._fileNameOriginal, value);
        }

        public string FileNameEu
        {
            get => this._fileNameEu;
            set => this.SetPropertyValue(nameof(this.FileNameEu).ToLower(), ref this._fileNameEu, value);
        }

        public int Export
        {
            get => this._export;
            set => this.SetPropertyValue(nameof(this.Export).ToLower(), ref this._export, value);
        }

        public string Ean_Klein
        {
            get => this._eanKlein;
            set => this.SetPropertyValue(nameof(this.Ean_Klein).ToLower(), ref this._eanKlein, value);
        }

        public int Position
        {
            get => this._position;
            set => this.SetPropertyValue(nameof(this.Position).ToLower(), ref this._position, value);
        }

        public string FileNameLang
        {
            get => this._fileNameLang;
            set => this.SetPropertyValue(nameof(this.FileNameLang).ToLower(), ref this._fileNameLang, value);
        }

        public string FileNameAlt
        {
            get => this._fileNameAlt;
            set => this.SetPropertyValue(nameof(this.FileNameAlt).ToLower(), ref this._fileNameAlt, value);
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

        public int ParentAssetID
        {
            get => this._parentAssetId;
            set => this.SetPropertyValue(nameof(this.ParentAssetID), ref this._parentAssetId, value);
        }

        public string Geschmack
        {
            get => this._geschmack;
            set => this.SetPropertyValue(nameof(this.Geschmack).ToLower(), ref this._geschmack, value);
        }

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
