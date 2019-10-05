using System.Windows.Forms;

namespace MegaDesk_Zanele.Forms
{
	public partial class SearchQuotes : Form
	{
		public SearchQuotes()
		{
			InitializeComponent();
		}

		private void SearchQuotes_FormClosed( object sender, FormClosedEventArgs e )
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}

        private void SearchQuotes_Load(object sender, System.EventArgs e)
        {

        }
    }
}
