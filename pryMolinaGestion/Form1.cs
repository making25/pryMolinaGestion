using pryDiazGestionInventario;

namespace pryMolinaGestion
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();

            clsConexionBD.ConectarBD();
        }
    }
}
