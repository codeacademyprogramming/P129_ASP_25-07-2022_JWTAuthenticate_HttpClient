using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129FirstClientApp.Data.ViewModel
{
    public class CategoryCreateVM
    {
        public string Ad { get; set; }
        public bool Esasdirmi { get; set; }
        public Nullable<int> AidOlduguUstCategoryId { get; set; }
        public string Sekli { get; set; }
    }
}
