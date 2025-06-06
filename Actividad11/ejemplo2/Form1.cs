namespace ejemplo2
{
    public partial class Form1 : Form
    {
        double acumulador = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            acumulador += Convert.ToDouble(tbValor.Text);
            contador++;

            tbValor.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;
            lbPromedio.Text = $"{promedio:f2}";

            tbPromedio.Text = $@"Promedio:
{promedio,10:f2}";
        }
    }
}
