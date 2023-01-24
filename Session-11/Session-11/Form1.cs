using Library;

namespace Session_11 {
    public partial class Form1 : Form {

        
        private ProductCategory _productCategory;



        public Form1() {


            InitializeComponent();
            PopulateCoffee();
            //Test push
        }

        private void Form1_Load(object sender, EventArgs e) {

            
        }
        public void PopulateCoffee() {

            _productCategory = new ProductCategory();
            Product product = new Product() {
                Code = 1,
                Description = "Fredo",
                TypeOfProduct = Product.ProductType.Coffee,
                Price=10,
                Cost= 5
                
            };

            _productCategory.products.Add(product);

            Product product1 = new Product() {
                Code = 2,
                Description = "Frape",
                TypeOfProduct = Product.ProductType.Coffee,
                Price = 8,
                Cost = 4,

            };
            _productCategory.products.Add(product1);

        }
    }
}