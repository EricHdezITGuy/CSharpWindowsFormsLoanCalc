using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrestamosWindowsForms
{
    public partial class Form1 : Form
    {   //declaramos variables
        double descuento = 0;
        double montoPrestamo = 0;
        float tasaInteres = 0;
        int opcionPrestamo = 0;
        int cantidadAnios = 0;
        String tipoCliente = "";

        public int pagoMensual { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {   //Acá creamos un mensaje flotante para confirmar que queremos salir del app
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir de la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void tipoClienteMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Este código es para leer la opción para descuento o no
            double descuento = 0;
            string tipoCliente = tipoClienteBox.SelectedItem.ToString().ToUpper();

            switch (tipoCliente)
            {
                case "A1":
                case "A2":
                    descuento = 0.02;
                    break;
                case "C":
                    MessageBox.Show("Crédito denegado.");
                    return;
            }

        }

        public void calcularPrestamo_Click(object sender, EventArgs e)
        {

        }

        public void montoPrestamo_TextChanged(object sender, EventArgs e)
        {
            double montoPrestamo;
            if (double.TryParse(montoPrestamoBox.Text, NumberStyles.Currency, CultureInfo.InvariantCulture, out montoPrestamo))
            {
                // si montoPrestamo es un valor correcto, continuar con el dato
            }
            else
            {
                // si no, entonces mostrar error
                MessageBox.Show("Ingrese un valor numérico válido para el monto del préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Form1_Load_1(object sender, EventArgs e)
        {

        }

        public void opcionPrestamoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menu de opciones de préstamo
            float tasaInteres;
            String opcionPrestamo = opcionPrestamoBox.Text;
            {
                switch (opcionPrestamo)
                {
                    case "Personal Regular - Tasa de interés: 15%":
                        tasaInteres = (float)0.15;
                        break;
                    case "Personal Rápido - Tasa de interés: 18%":
                        tasaInteres = (float)0.18;
                        break;
                    case "Reparación y ampliación de vivienda - Tasa de interés: 12%":
                        tasaInteres = (float)0.12;
                        break;
                    case "Compra de Lote - Tasa de interés: 12%":
                        tasaInteres = (float)0.12;
                        break;
                    case "Compra de Vehículo Nuevo - Tasa de interés: 18%":
                        tasaInteres = (float)0.18;
                        break;
                    default:
                        MessageBox.Show("Opción de préstamo no válida.", "Error");
                        return;
                }
            }
        }

        public void reiniciarCalculadora_Click(object sender, EventArgs e)
        {
            // Para reiniciar la app y eliminar los datos
            montoPrestamoBox.Clear();
            tipoClienteBox.SelectedIndex = 0;
            opcionPrestamoBox.SelectedIndex = -1;
            pagoMensualBox.Text = "";
        }

        public void cantidadAniosBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void pagoMensualBox_Click(object sender, EventArgs e)
        {
            // Calcular el pago mensual
            // La fórmula es la siguiente:
            // PagoMensual = (MontoPrestamo - MontoPrestamo * descuento) * (tasaInteres / 12) / (1 - 1 / Math.Pow(1 + TasaInteres, CantidadAnios * 12));
            var pagoMensual = (montoPrestamo - montoPrestamo * descuento) * (tasaInteres / 12) /
                              (1 - 1 / Math.Pow(1 + tasaInteres, cantidadAnios * 12));
            // Mostrar el resultado en la caja de texto
            pagoMensualBox.Text = pagoMensual.ToString("₡", CultureInfo.InvariantCulture);
        }

        public void costoTotalBox_Click(object sender, EventArgs e)
        {
            // Calcular el pago total
            // La fórmula es la siguiente:
            // PagoTotal = PagoMensual * CantidadAnios * 12;
            var pagoTotal = pagoMensual * cantidadAnios * 12;

            // Calcular el monto del descuento
            var montoDescuento = montoPrestamo * descuento;

            // Crear un objeto NumberFormatInfo
            var nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            nfi.NumberGroupSeparator = ",";

            // Salida del pago mensual
            pagoMensualBox.Text = "₡" + pagoMensual.ToString("N2", nfi);

            // Salida del pago total
            costoTotalBox.Text = "₡" + pagoTotal.ToString("N2", nfi);


            // Calcular el costo total del préstamo
            var costoTotal = pagoTotal + montoDescuento;

            // Salida del costo total del préstamo
            costoTotalBox.Text = "₡" + costoTotal.ToString("N2", nfi);

        }

        public void descuentoBox_Click(object sender, EventArgs e)
        {


        }
    }
}