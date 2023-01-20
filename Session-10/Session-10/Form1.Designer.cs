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
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.grvSchedeCourses = new System.Windows.Forms.DataGridView();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblScheduledCourses = new System.Windows.Forms.Label();
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
            this.grvStudents.Location = new System.Drawing.Point(45, 27);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(899, 90);
            this.grvStudents.TabIndex = 2;
            // 
            // grvCourses
            // 
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 630);
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
    }
}