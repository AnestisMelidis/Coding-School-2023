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

namespace Session_11 {
    public partial class EntryPoint : Form {



        public EntryPoint() {
            InitializeComponent();

        }

        private void btnManager_Click(object sender, EventArgs e) {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show(); 
           
            
        }

        private void btnCustomer_Click(object sender, EventArgs e) {

        }

        private void EntryPoint_Load(object sender, EventArgs e) {

            //CoffeeShopData data = new CoffeeShopData();
            ////EDO SE kai DE
            //Form1 form1 = new Form1();
            //form1.Data= data;
            //form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
