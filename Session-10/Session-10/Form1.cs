
using Libraries;
using System.Globalization;


namespace Session_10 {
    public partial class Form1 : Form {

        //Student student = new Student();
        private University _university;
        

        
        public Form1() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {
            
            PopulateStudents();
            PopulateCourses();
            PopulateGrades();
            PopulateSchedeCourses();


        }

        private void btnSave_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "test.json");
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            _university = serializer.Deserialize<University>("test.json");

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
                Code= "56",
                Subject="Mathematics"
            };
            Course course2 = new Course() {
                Code = "69",
                Subject = "Mathematics"
            };

            _university.Courses.Add(course1);
            _university.Courses.Add(course2);

            grvCourses.DataSource = _university.Courses;

        }
        private void PopulateGrades() {
            
            _university = new University() {
                Name = "University Of Sheffield",
                YearsInService = 45
            };
            Grade grade1 = new Grade() {
                Mark = 98,
                
                
            };
            Grade grade2 = new Grade() {
                Mark = 39,
                
                
            };

            _university.Grades.Add(grade1);
            _university.Grades.Add(grade2);

            grvGrades.DataSource = _university.Grades;

        }

        private void PopulateSchedeCourses() {
            
            _university = new University() {
                Name = "University Of Sheffield",
                YearsInService = 45
            };
            Schedule scheduledCourse1 = new Schedule() {
                Callendar = DateTime.Now


        };
            Schedule scheduledCourse2 = new Schedule() {
                Callendar = DateTime.Now


        };
            //_university.Add(Name);
            _university.ScheduleCourses.Add(scheduledCourse1);
            _university.ScheduleCourses.Add(scheduledCourse2);

            grvSchedeCourses.DataSource = _university.ScheduleCourses;

        }

        private void bsStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void grvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void grvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void grvSchedeCourses_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void lblStudents_Click(object sender, EventArgs e) {

        }

        private void lblCourses_Click(object sender, EventArgs e) {

        }

        private void lblGrades_Click(object sender, EventArgs e) {

        }

        private void lblScheduledCourses_Click(object sender, EventArgs e) {

        }
    }
}