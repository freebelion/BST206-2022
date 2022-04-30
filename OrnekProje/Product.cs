using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace OrnekProje
{
    public class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property_name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property_name));
            }
        }

        private string imgFileName;

        public Guid ID { get;private set; }
        public string Name { get; set; }
        public string ImageFile
        {
            get { return imgFileName; }
            set
            {
                imgFileName = value;
                OnPropertyChanged("ImageFile");
            }
        }

        public Product()
        {
            this.ID = Guid.NewGuid();
            this.Name = "Product_" + this.ID.ToString().Split('-')[0];
            this.ImageFile = string.Empty;
        }
    }
}
