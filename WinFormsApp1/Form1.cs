using _50_OOP_PersonelLib.Concretes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Company company = new Company();
            company.GetEmployees();

            //Employee employee = new Employee(txtName.tex)
        }
    }
}
