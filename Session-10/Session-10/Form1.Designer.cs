namespace Session_10 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.grvSchedeCourses = new System.Windows.Forms.DataGridView();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblScheduledCourses = new System.Windows.Forms.Label();
            this.btnShowGridResults = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCallendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProfessorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedeCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(779, 578);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 40);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grvStudents
            // 
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmRegistrationNumber,
            this.clmName,
            this.clmCourses,
            this.clmAge});
            this.grvStudents.Location = new System.Drawing.Point(45, 27);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(899, 90);
            this.grvStudents.TabIndex = 2;
            this.grvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvStudents_CellContentClick);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmRegistrationNumber
            // 
            this.clmRegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.clmRegistrationNumber.HeaderText = "RegistrationNumber";
            this.clmRegistrationNumber.Name = "clmRegistrationNumber";
            this.clmRegistrationNumber.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmCourses
            // 
            this.clmCourses.DataPropertyName = "Courses";
            this.clmCourses.HeaderText = "Courses";
            this.clmCourses.Name = "clmCourses";
            this.clmCourses.ReadOnly = true;
            // 
            // clmAge
            // 
            this.clmAge.DataPropertyName = "Age";
            this.clmAge.HeaderText = "Age";
            this.clmAge.Name = "clmAge";
            this.clmAge.ReadOnly = true;
            // 
            // grvCourses
            // 
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmSubject,
            this.clmCode});
            this.grvCourses.Location = new System.Drawing.Point(45, 156);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(899, 104);
            this.grvCourses.TabIndex = 3;
            this.grvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCourses_CellContentClick);
            // 
            // grvGrades
            // 
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.clmStudentID,
            this.clmCourseID,
            this.clmMark});
            this.grvGrades.Location = new System.Drawing.Point(45, 299);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(899, 110);
            this.grvGrades.TabIndex = 4;
            this.grvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvGrades_CellContentClick);
            // 
            // grvSchedeCourses
            // 
            this.grvSchedeCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSchedeCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.clmCallendar,
            this.clmProfessorID});
            this.grvSchedeCourses.Location = new System.Drawing.Point(57, 457);
            this.grvSchedeCourses.Name = "grvSchedeCourses";
            this.grvSchedeCourses.RowTemplate.Height = 25;
            this.grvSchedeCourses.Size = new System.Drawing.Size(887, 99);
            this.grvSchedeCourses.TabIndex = 5;
            this.grvSchedeCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvSchedeCourses_CellContentClick);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(445, 9);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(78, 15);
            this.lblStudents.TabIndex = 6;
            this.lblStudents.Text = "Students Grid";
            this.lblStudents.Click += new System.EventHandler(this.lblStudents_Click);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(449, 129);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(74, 15);
            this.lblCourses.TabIndex = 7;
            this.lblCourses.Text = "Courses Grid";
            this.lblCourses.Click += new System.EventHandler(this.lblCourses_Click);
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new System.Drawing.Point(455, 272);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(68, 15);
            this.lblGrades.TabIndex = 8;
            this.lblGrades.Text = "Grades Grid";
            this.lblGrades.Click += new System.EventHandler(this.lblGrades_Click);
            // 
            // lblScheduledCourses
            // 
            this.lblScheduledCourses.AutoSize = true;
            this.lblScheduledCourses.Location = new System.Drawing.Point(432, 428);
            this.lblScheduledCourses.Name = "lblScheduledCourses";
            this.lblScheduledCourses.Size = new System.Drawing.Size(132, 15);
            this.lblScheduledCourses.TabIndex = 9;
            this.lblScheduledCourses.Text = "Scheduled Courses Grid";
            this.lblScheduledCourses.Click += new System.EventHandler(this.lblScheduledCourses_Click);
            // 
            // btnShowGridResults
            // 
            this.btnShowGridResults.Location = new System.Drawing.Point(432, 578);
            this.btnShowGridResults.Name = "btnShowGridResults";
            this.btnShowGridResults.Size = new System.Drawing.Size(115, 40);
            this.btnShowGridResults.TabIndex = 10;
            this.btnShowGridResults.Text = "Show Grid Results";
            this.btnShowGridResults.UseVisualStyleBackColor = true;
            this.btnShowGridResults.Click += new System.EventHandler(this.btnShowGridResults_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clmSubject
            // 
            this.clmSubject.DataPropertyName = "Subject";
            this.clmSubject.HeaderText = "Subject";
            this.clmSubject.Name = "clmSubject";
            this.clmSubject.ReadOnly = true;
            // 
            // clmCode
            // 
            this.clmCode.DataPropertyName = "Code";
            this.clmCode.HeaderText = "Code";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clmStudentID
            // 
            this.clmStudentID.DataPropertyName = "StudentID";
            this.clmStudentID.HeaderText = "StudentID";
            this.clmStudentID.Name = "clmStudentID";
            this.clmStudentID.ReadOnly = true;
            // 
            // clmCourseID
            // 
            this.clmCourseID.DataPropertyName = "CourseID";
            this.clmCourseID.HeaderText = "CourseID";
            this.clmCourseID.Name = "clmCourseID";
            this.clmCourseID.ReadOnly = true;
            // 
            // clmMark
            // 
            this.clmMark.DataPropertyName = "Mark";
            this.clmMark.HeaderText = "Mark";
            this.clmMark.Name = "clmMark";
            this.clmMark.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CourseID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // clmCallendar
            // 
            this.clmCallendar.DataPropertyName = "Callendar";
            this.clmCallendar.HeaderText = "Callendar";
            this.clmCallendar.Name = "clmCallendar";
            this.clmCallendar.ReadOnly = true;
            // 
            // clmProfessorID
            // 
            this.clmProfessorID.DataPropertyName = "ProfessorID";
            this.clmProfessorID.HeaderText = "ProfessorID";
            this.clmProfessorID.Name = "clmProfessorID";
            this.clmProfessorID.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 630);
            this.Controls.Add(this.btnShowGridResults);
            this.Controls.Add(this.lblScheduledCourses);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.grvSchedeCourses);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.grvStudents);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedeCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnLoad;
        private DataGridView grvStudents;
        private DataGridView grvCourses;
        private DataGridView grvGrades;
        private DataGridView grvSchedeCourses;
        private Label lblStudents;
        private Label lblCourses;
        private Label lblGrades;
        private Label lblScheduledCourses;
        private Button btnShowGridResults;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmRegistrationNumber;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCourses;
        private DataGridViewTextBoxColumn clmAge;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn clmSubject;
        private DataGridViewTextBoxColumn clmCode;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn clmStudentID;
        private DataGridViewTextBoxColumn clmCourseID;
        private DataGridViewTextBoxColumn clmMark;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn clmCallendar;
        private DataGridViewTextBoxColumn clmProfessorID;
    }
}