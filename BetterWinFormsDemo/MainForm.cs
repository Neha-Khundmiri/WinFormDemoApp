namespace BetterWinFormsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sayHelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"Hello {firstNameText.Text} {lastNameText.Text}");
        }
    }
}