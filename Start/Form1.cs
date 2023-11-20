using DeweySystem.ReplaceBooks;
    
 namespace DeweySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void replacebooksbtn_Click(object sender, EventArgs e)
        {
            DeweySystem.ReplaceBooks.ReplaceBooks replaceBooksForm = new DeweySystem.ReplaceBooks.ReplaceBooks();
            replaceBooksForm.Show();
            this.Hide();
        }


        private void identifyareasbtn_Click(object sender, EventArgs e)
        {
            DeweySystem.IdentifyAreas.IdentifyAreas identifyAreasForm = new DeweySystem.IdentifyAreas.IdentifyAreas();
            identifyAreasForm.Show();
            this.Hide();
        }

        private void findcallbtn_Click(object sender, EventArgs e)
        {
            DeweySystem.FindCalls.FindCallNumber findCallNumberForm = new DeweySystem.FindCalls.FindCallNumber();
            findCallNumberForm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}