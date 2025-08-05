using Services;
using System.Drawing.Text;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}