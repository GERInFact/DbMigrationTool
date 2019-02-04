using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.Serialization;
using AccessManager.AccessLayer;
using AccessManager.AccessLayer.Interfaces;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Models;

namespace AccessManager.Helper
{
    public static class Factory
    {

        private static UnitOfWork _session;

        public static UnitOfWork CreateWorkUnit(IDataLayer dataLayer)
        {
            return _session  ?? (_session = new UnitOfWork(dataLayer));
        }

        public static UnitOfWork GetWorkUnit()
        {
            return _session ?? (_session = new UnitOfWork());
        }

        public static IDatabaseInformation CreateDefaultDatabaseInformation()
        {
            return new DatabaseInformation(AutoCreateOption.DatabaseAndSchema);
        }

        public static brandkuerzel CreateBrand(Session session)
        {
            if (session == null)
                session = GetWorkUnit();

            return new brandkuerzel(session);
        }

        public static brandkuerzel CreateBrand(Session session, brandkuerzel brandkuerzel)
        {
            if (session != null && brandkuerzel != null)
                return new brandkuerzel(session)
                    {BrandId = brandkuerzel.BrandId, Brand = brandkuerzel.Brand, Kuerzel = brandkuerzel.Kuerzel};


            session = GetWorkUnit();
            return new brandkuerzel(session);
        }

        public static assets CreateAsset(Session session)
        {
            if (session == null)
                session = GetWorkUnit();

            return new assets(session);
        }

        public static assets CreateAsset(Session session, assets asset)
        {
            if (session != null && asset != null)
                return new assets(session)
                {
                    Name = asset.Name,
                    Agentur = asset.Agentur,
                    Archive = asset.Archive,
                    AssetId = asset.AssetId,
                    Attribut1 = asset.Attribut1,
                    Attribut2 = asset.Attribut2,
                    Brand = asset.Brand,
                    Copyright = asset.Copyright,
                    DateiGroesse = asset.DateiGroesse,
                    DatenMenge = asset.DatenMenge,
                    DatumEnd = asset.DatumEnd,
                    DatumStart = asset.DatumStart,
                    EanSekundaer = asset.EanSekundaer,
                    Ean_Klein = asset.Ean_Klein,
                    EmailSended = asset.EmailSended,
                    Export = asset.Export,
                    FileNameAlt = asset.FileNameAlt,
                    FileNameEu = asset.FileNameEu,
                    FileNameLang = asset.FileNameLang,
                    FileNameOriginal = asset.FileNameOriginal,
                    Fotograf = asset.Fotograf,
                    Geschmack = asset.Geschmack,
                    MediaType = asset.MediaType,
                    Nicht_Exportieren = asset.Nicht_Exportieren,
                    ParentAssetID = asset.ParentAssetID,
                    Position = asset.Position,
                    Promotion = asset.Promotion,
                    Segment = asset.Segment,
                    SichtbarAb = asset.SichtbarAb,
                    Size = asset.Size,
                    Vbn_Ean = asset.Vbn_Ean,
                    Veroeffentlichung = asset.Veroeffentlichung,
                    VerpackungsArt = asset.VerpackungsArt,
                    Version = asset.Version,
                    Vse_Ean = asset.Vse_Ean
                };

            session = GetWorkUnit();
            return new assets(session);
        }

        public static AssetInfo CreateAssetInfo(Session session, assets asset)
        {
            if (session != null && asset != null)
                return new AssetInfo(session)
                {
                    AssetId = asset.AssetId,
                    ParentAssetID = asset.ParentAssetID,
                    DateiGroesse = asset.DateiGroesse,
                    DatenMenge = asset.DatenMenge,
                    FileNameAlt = asset.FileNameAlt,
                    FileNameEu = asset.FileNameEu,
                    FileNameLang = asset.FileNameLang,
                    FileNameOriginal = asset.FileNameOriginal
                };

            return new AssetInfo(GetWorkUnit());
        }

        public static ProductInfo CreateProductInfo(Session session, assets asset)
        {
            if (session != null && asset != null)
                return new ProductInfo(session)
                {
                   // AssetId = asset.AssetId,
                    Name = asset.Name,
                    Archive = asset.Archive,
                    Attribut1 = asset.Attribut1,
                    Attribut2 = asset.Attribut2,
                    Brand = asset.Brand,
                    DatumEnd = asset.DatumEnd,
                    DatumStart = asset.DatumStart,
                    EmailSended = asset.EmailSended,
                    Export = asset.Export,
                    Geschmack =asset.Geschmack,
                    MediaType = asset.MediaType,
                    Nicht_Exportieren = asset.Nicht_Exportieren,
                    Position = asset.Position,
                    Segment = asset.Segment,
                    Size = asset.Size,
                    VerpackungsArt = asset.VerpackungsArt,
                    Version = asset.Version
                };

            return new ProductInfo(GetWorkUnit());
        }

        public static SalesInfo CreateSalesInfo(Session session, assets asset)
        {
            if (session != null && asset != null)
            {
                return new SalesInfo(session)
                {
                    AssetId = asset.AssetId,
                    EanSekundaer = asset.EanSekundaer,
                    Ean_Klein = asset.Ean_Klein,
                    Vbn_Ean = asset.Vbn_Ean,
                    Vse_Ean = asset.Vse_Ean
                };
            }

            return new SalesInfo(GetWorkUnit());
        }


        public static ISerializer<T> CreateDefaultSerializer<T>() where T : ISerializable
        {
            return new CustomXmlSerializer<T>();
        }
    }
}
