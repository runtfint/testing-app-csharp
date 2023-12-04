using lab_1.

namespace lab_1
{
    public partial class MainMenu : Form
    {
        public MainMenu(TestDataVM testDataVM)
        {
            InitializeComponent();
            InitializeBindings();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void InitializeBindings()
        {
            createTestButton.DataBindings.Add(new Binding( 'createTestButton',  );
        }
    }
}