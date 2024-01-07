using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Desxription { get; set; }
        
    }
}
