using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Session_11 {
    public partial class EntryPoint : Form {


        public CoffeeShopData Data { get; set; }
        private CoffeeShopData _CoffeeShopData = new CoffeeShopData();
        Serializer serializer = new Serializer();

        public EntryPoint() {
            InitializeComponent();
            if (File.Exists("test1.json"))
            {
                //_CoffeeShopData = serializer.DeserializeFromFile<CoffeeShopData>("test1.json");
                _CoffeeShopData = (CoffeeShopData)LoadJson("test1.json");
            }
        }

        public object LoadJson(string file)
        {
            object employees = serializer.DeserializeFromFile<CoffeeShopData>(file);
            return employees;

        }
        private void btnManager_Click(object sender, EventArgs e) {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show(); 
           
            
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            
            this.Hide();

            Customer customer = new Customer(_CoffeeShopData);
            customer.Show();

            
        }

        public void btnLoadJson(object sender, EventArgs e)
        {
            if (File.Exists("test1.json"))
            {
                _CoffeeShopData = (CoffeeShopData)LoadJson("test1.json");
            }


        }
        private void EntryPoint_Load(object sender, EventArgs e) {


        }
            
    }
}
