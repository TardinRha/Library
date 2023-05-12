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
        public string IdentificadorOpenLibrary { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string PublishingCompany { get; set; }
        public string PictureMedium { get; set; }
    }
    public class Autor
    {
        public string URL { get; set; }
        public string Name { get; set; }
    }

}
