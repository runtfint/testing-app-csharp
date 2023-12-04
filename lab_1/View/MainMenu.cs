using lab_1.Models;
using lab_1.Models.Classes;
using lab_1.View;
using lab_1.ViewModel;
using System.Diagnostics;

namespace lab_1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            JSONworker json = new JSONworker();
            dynamic data = json.ReadData();
            Console.WriteLine(data.ToString());

        }

        private void createTestButton_Click(object sender, EventArgs e)
        {
            CreateTest newTestForm = new CreateTest();
            newTestForm.Show();
        }
    }
}