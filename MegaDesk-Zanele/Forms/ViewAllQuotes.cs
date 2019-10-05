using System.Windows.Forms;

namespace MegaDesk_Zanele.Forms
{
	public partial class ViewAllQuotes : Form
	{
		public ViewAllQuotes()
		{
			InitializeComponent();
		}

		private void ViewAllQuotes_FormClosed( object sender, FormClosedEventArgs e )
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}

        private void ViewAllQuotes_Load(object sender, System.EventArgs e)
        {

        }
    }
}
