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
        private List<Item> shoppingCartData = new List<Item>(); //new instance of the list which is empty
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();


        public Shop()
        {
            InitializeComponent();
            SetupData();

            //links our items to the binding source
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();  //binding to the class store list of items, filtering products that have not been sold
            itemsListbox.DataSource = itemsBinding; //binding to the field (form)

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            //links our items to the binding source
            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";
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

        private void addToCart_Click(object sender, EventArgs e)
        {
            
            //Figure out what is selected, Copy that item to the shopping cart
            //Do we remove the item from the items list

            // chooses the item from the listbox the one that is actually highlighted
            Item selectedItem = (Item)itemsListbox.SelectedItem;


            shoppingCartData.Add(selectedItem);

            //whenever we modify list we need to reset bindings
            cartBinding.ResetBindings(false);


        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //Mark each item in cart as sold
            //Clear the cart
            //implement pop up window asking for confirmation and potentially getting back

            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
            }

            shoppingCartData.Clear();

            //reseting the binding
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            //whenever we modify list we need to reset bindings
            cartBinding.ResetBindings(false);
            //this binding is for the list of items they will be updated once we purchase the item so they need to be updated as well
            itemsBinding.ResetBindings(false);


        }
    }
}
