using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Livro
    {
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public string ISSNS { get; set; }
        public string ICCNS { get; set; }
        public string OCLCS { get; set; }
        public string OLIDS { get; set; }
        public string IdentifierOpenLibrary { get; set; }
        public DateTime PublishDate { get; set; }
        public string URL { get; set; }
        public string Key { get; set; }
        public string BibKey { get; set; }
        public string Preview { get; set; }
        public string PreviewURL { get; set; }
        public string ThumbnailURL { get; set; }
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public string Notes { get; set; }
        public string PictureSmall { get; set; }
        public string PictureMedium { get; set; }
        public string PictureLarge { get; set; }
        public string PhysicalFormat { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
    public class Autor
    {
        public string URL { get; set; }
        public string Name { get; set; }
    }
    public class Covers
    {
        public string Number { get; set; }
        public string LatestRevision { get; set; }
        public string Revision { get; set; }
    }
    
}
