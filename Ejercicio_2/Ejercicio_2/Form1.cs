namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] ArregloN = new String[35];
        int[] ArregloEdad = new int[35];
        int i = 0;
        int C = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Cantidad total de registros aceptada.");
            
            C = Convert.ToInt32(CantidadTextBox.Text);
            CantidadTextBox.Clear();

            button1.Enabled = false;
            CantidadTextBox.Enabled = false;
            MostrarButton.Enabled = false;

            contadorLabel.Text = (i + " de " + C + " registros" );
        }


        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            if (i < C)
            {
                ArregloN[i] = NombreTextBox.Text;
                ArregloEdad[i] = Convert.ToInt32(EdadTextBox.Text);
                i++;
            }
            NombreTextBox.Clear();
            EdadTextBox.Clear();

            if (i == C)
            {
                MostrarButton.Enabled = true;
                RegistrarButton.Enabled = false;
                NombreTextBox.Enabled = false;
                EdadTextBox.Enabled = false;
            }
            contadorLabel.Text = (i + " de " + C + " registros");
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            AlumnosComboBox.Items.Add("Nombre y Edad ");
            for (int i = 0; i < C; i++)
            {
                AlumnosComboBox.Items.Add(ArregloN[i] +"   " + ArregloEdad[i]);
            }
            MostrarButton.Enabled=false;
        }

        
    }
}