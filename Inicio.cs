namespace ProdTools
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            Conexion c = new Conexion();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void openquery_Click(object sender, EventArgs e)
        {
            var myForm = new likeexceltable();
            myForm.Show();
        }
    }
}
