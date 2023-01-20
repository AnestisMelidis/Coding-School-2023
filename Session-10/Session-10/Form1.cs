
using Libraries;


namespace Session_10 {
    public partial class Form1 : Form {

        //Student student = new Student();
        private University _university;
        private string? classes="Math";

        List<Student> students;
        public Form1() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {
            
            PopulateStudents();
            PopulateCourses();


        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnLoad_Click(object sender, EventArgs e) {

        }
        private void PopulateStudents() {

           
            _university = new University() {
                Name = "University Of Sheffield",
                YearsInService = 45
              
            };
            
            Student student1 = new Student() {
                Name = "Dimitris",
                RegistrationNumber = 1,
                Age = 40,
                //Courses = < classes >                
            };


            Student student2 = new Student() {
                Name = "Fotis",
                RegistrationNumber = 2,
                Age = 44                              
            };
            
            _university.Students.Add(student1);
            _university.Students.Add(student2);
           grvStudents.DataSource = _university.Students;
           
        }
        private void PopulateCourses() {

            _university = new University() {
                Name = "University Of Sheffield",
                YearsInService = 45
            };
            Course course1 = new Course() {

            };
            Course course2 = new Course() {

             };



            // grvCourses.DataSource = _university;

        }

        private void bsStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void grvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}