using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Models
{
    public class brandkuerzel : XPLiteObject 
    {
        private int _brandid;
        private string _brand;
        private string _kuerzel;

        public brandkuerzel(Session session) : base(session)
        {
            
        }

        public brandkuerzel()
        {
            
        }

        [Key, Persistent]
        public int brandid
        {
            get => this._brandid;
            set => this.SetPropertyValue(nameof(brandid), ref this._brandid, value);
        }
       
        public string brand
        {
            get => this._brand;
            set => this.SetPropertyValue(nameof(brand), ref this._brand, value);
        }

        public string kuerzel
        {
            get => this._kuerzel;
            set => this.SetPropertyValue(nameof(kuerzel), ref this._kuerzel, value);
        }
    }
}
