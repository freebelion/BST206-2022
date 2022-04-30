using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje
{
    public class Market : ObservableCollection<Category> { }
    public class Category
    {
        public Guid ID { get; private set; }
        public string Name { get; set; }
        public ObservableCollection<Product> Products { get; set; }

        public Category()
        {
            this.ID = Guid.NewGuid();
            this.Name = "Category_" + this.ID.ToString().Split('-')[0];
            Products = new ObservableCollection<Product>();
        }
    }
}
