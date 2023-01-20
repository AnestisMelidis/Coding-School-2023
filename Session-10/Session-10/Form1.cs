
using Libraries;


namespace Session_10 {
    public partial class Form1 : Form {

        //Student student = new Student();
        private University _university;

        List<Student> students;
        public Form1() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {
            
            PopulateStudents();



        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnLoad_Click(object sender, EventArgs e) {

        }
        private void PopulateStudents() {

            
            _university = new University() {
                Name = "University Of Sheffield"
            };

            

            Student student1 = new Student() {
                Name = "Dimitris",
               
                Age = 40
                
                
            };
            

            Student student2 = new Student() {
                Name = "Fotis",
               
                Age = 44
                
                
            };
            

            _university.Students.Add(student1);
            _university.Students.Add(student2);
           grvStudents.DataSource = _university.Students;

        }

        private void bsStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}