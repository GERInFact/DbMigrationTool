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
    public class brandkuerzel : XPLiteObject, ISerializable
    {
        private int _brandId;
        private string _brand;
        private string _kuerzel;

        public brandkuerzel(Session session) : base(session)
        {
        }

        public brandkuerzel(SerializationInfo info, StreamingContext context)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            this.GetType()
                .GetProperties(BindingFlags.Public)
                .ToList()
                .ForEach(p =>
                {
                     p.SetValue(p, info.GetValue(p.Name, p.PropertyType));
                });

             /*this.BrandId = (int)info.GetValue(nameof(this.BrandId), typeof(int));
             this.Brand = info.GetValue(nameof(this.Brand), typeof(string)) as string ?? string.Empty;
             this._kuerzel = info.GetValue(nameof(this.Kuerzel), typeof(string)) as string ?? string.Empty;*/


        }

        public brandkuerzel()
        {
            
        }

        [Key, Persistent]
        public int BrandId
        {
            get => this._brandId;
            set => this.SetPropertyValue(nameof(this.BrandId).ToLower(), ref this._brandId, value);
        }
       
        public string Brand
        {
            get => this._brand;
            set => this.SetPropertyValue(nameof(this.Brand).ToLower(), ref this._brand, value);
        }

        public string Kuerzel
        {
            get => this._kuerzel;
            set => this.SetPropertyValue(nameof(this.Kuerzel).ToLower(), ref this._kuerzel, value);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            
          this.GetType().GetProperties(BindingFlags.Public)
              .ToList()
              .ForEach(p => info.AddValue(nameof(p), p));
        }
    }
}
