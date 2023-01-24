using Library;

namespace Session_11 {
    public partial class Form1 : Form {

        
        private ProductCategory _productCategory;
        List<Product> products;


        public Form1() {


            InitializeComponent();
            PopulateCoffee();
            //Test push
        }

        private void Form1_Load(object sender, EventArgs e) {

            
        }
        public void PopulateCoffee() {

            //_productCategory = new ProductCategory();

            products= new List<Product>();

            Product product1 = new Product() {
                Code = 1,
                Description = "Fredo",
                TypeOfProduct = Product.ProductType.Coffee,
                Price=10,
                Cost= 5
                
            };

            products.Add(product1);

            Product product2 = new Product() {
                Code = 2,
                Description = "Frape",
                TypeOfProduct = Product.ProductType.Coffee,
                Price = 8,
                Cost = 4,

            };
            products.Add(product2);
            MessageBox.Show(product1.Description+" "+product2.Description);
            MessageBox.Show(product1.Description + " " + product2.Description);
        }
    }
}