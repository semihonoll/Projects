using School.Manager.Entities;
using School.Manager.Services;

namespace School.WindowsForm
{
    public partial class Form1 : Form
    {
        StudentService studentService;
        public Form1()
        {
            InitializeComponent();
            studentService = new StudentService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newStudent = new Student
            {
                Id = int.Parse(txtId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = int.Parse(txtAge.Text),
                Class = txtClass.Text
            };

            studentService.Add(newStudent);

            var students = studentService.GetAll();

            foreach (var item in students)
            {
                listView1.Items.Add(item.GetInformation());
            }
        }
    }
}
