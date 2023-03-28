namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (cmbOpciones.SelectedIndex == -1)
            {
                MessageBox.Show("No has selecionado nada");
            }
            else
            {
                string opcion = cmbOpciones.SelectedItem.ToString();
                int valor01 = Convert.ToInt32(valor1.Text);
                int valor02 = Convert.ToInt32(valor2.Text);
                int respuesta = this.resolverOperacion(valor01, valor02, opcion);

                resultado.Text = respuesta.ToString();
            }
        }
        public int resolverOperacion(int valor01, int valor02, string opcion)
        {
            int respuesta = 0;
            switch (opcion)
            {
                case "sumar":
                    respuesta = valor01 + valor02;
                    break;
                case "restar":
                    respuesta = valor01 - valor02;
                    break;
                case "multiplicar":
                    respuesta = valor01 * valor02;
                    break;
                case "dividir":
                    respuesta = valor01 / valor02;
                    break;
                default:
                    MessageBox.Show("No es una opcion valida");
                    break;

            }
            return respuesta;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}