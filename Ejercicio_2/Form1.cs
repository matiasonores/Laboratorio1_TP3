namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        Torneo torneo;
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            int numeroAleatorio = random.Next(5, 11);
            torneo = new Torneo(numeroAleatorio);
            this.Text = "Torneo Laboratorio - Rondas: "+ numeroAleatorio.ToString();
        }

        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Value);
            string club = txtClub.Text;

            if (nombre == "" || club == "")
            {
                MessageBox.Show("Debe Rellenar todos los campos para agregar un jugador");
            }
            else
            {
                torneo.AgregarCompetidor(nombre, club, edad);
                listCompetidores.Items.Add(nombre);
                txtNombre.Text = "";
                txtClub.Text = "";
                txtEdad.Value = 1;
            }
        }

        private void btnComenzarTorneo_Click(object sender, EventArgs e)
        {
            RondasModal rondamodal = new RondasModal(torneo);
            rondamodal.labelRonda.Text = "1";
            MessageBox.Show("Cantidad de Competidores Mayores de Edad: " + torneo.cantidadMayores.ToString() +
             "\n" + "Cantidad de Competidores Menores de Edad: " + torneo.cantidadMenores.ToString());
            rondamodal.ShowDialog();
            // aca sigue 
            btnComenzarTorneo.Enabled = false;
            btnAgregarCompetidor.Enabled = false;
            this.Text = "Torneo Finalizado";
            for (int i = 0; i < torneo.cantCompetidores; i++)
            {
                
            }

            
        }

        private void listCompetidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listCompetidores.SelectedIndex;
            Competidor competidor = torneo.competidores[index];

            MessageBox.Show("Nombre Competidor: " + competidor.Nombre +
                "\n" +
                "Club: " + competidor.Club +
                "\n" +
                "Edad: " + competidor.Edad +
                "\n" +
                "Puntaje Total: " + competidor.CalcularPuntaje(torneo.cantRondas).ToString() +
                "\n");
        }
    }
}
