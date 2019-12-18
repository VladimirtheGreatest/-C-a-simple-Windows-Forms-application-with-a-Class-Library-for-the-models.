using ShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Shop : Form
    {
        private Store store = new Store();

        public Shop()
        {
            InitializeComponent();
            SetupData();
        }
        //temporary method for some dummy data
        private void SetupData()
        {
            //creating new instance but this is not a constructor, just hardcoding the values
            store.Suppliers.Add(new Supplier { FirstName = "Vladimir", LastName = "Doktorov" });
            store.Suppliers.Add(new Supplier { FirstName = "Boris", LastName = "Johnson" });

            //M after price means decimal
            store.Items.Add(new Item
            {
                Title = "Post Malone",
                Description = "Rockstar",
                Price = 6.50M,
                Owner = store.Suppliers[0]
            });

            store.Items.Add(new Item
            {
                Title = "Linking Park",
                Description = "In the end",
                Price = 7.50M,
                Owner = store.Suppliers[1]
            });

            store.Items.Add(new Item
            {
                Title = "Wilkinson",
                Description = "Afterglow",
                Price = 4.50M,
                Owner = store.Suppliers[0]
            });

            store.Items.Add(new Item
            {
                Title = "Dimension",
                Description = "Blackchurch",
                Price = 3.75M,
                Owner = store.Suppliers[1]
            });

            store.Name = "Sputify";


        }
    }
}
