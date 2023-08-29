namespace Laboratorio02_ejericio09_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1, N2, N3;
            N1 = Convert.ToInt32(txt1.Text);
            N2 = Convert.ToInt32(txt2.Text);
            N3 = Convert.ToInt32(txt3.Text);
            int mayor = N1;
            if (N2 > mayor)
            {
                mayor = N2;
            }
            if (N3 > mayor)
            {
                mayor = N3;
            }
            MessageBox.Show("El número mayor es: " + mayor);
        }
    }
}