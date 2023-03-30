using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrestamosWindowsForms
{
    public partial class Form1 : Form
    {   // Declarar variables
        double descuento = 0;
        double montoPrestamo = 0;
        float tasaInteres = 0;
        int opcionPrestamo = 0;
        int cantidadAnios = 0;
        String tipoCliente = "";

        public double PagoMensual;

        public Form1()
        {
            InitializeComponent();
        }
        // Manejador de eventos para el botón de salir
        public void button4_Click(object sender, EventArgs e)
        {   //Acá creamos un mensaje flotante para confirmar que queremos salir del app
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir de la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Manejador de eventos para cargar el formulario
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        // Manejador de eventos para el clic en label1
        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {

        }
        // Manejador de eventos para cambiar el tipo de cliente
        public void tipoClienteMenu_SelectedIndexChanged(object sender, EventArgs e)
        {   //Este código es para leer la opción para descuento o no. Establece el descuento según el tipo de cliente seleccionado
            descuento = 0;
            tipoCliente = tipoClienteBox.SelectedItem.ToString().ToUpper();

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
        // Manejador de eventos para calcular el préstamo
        public void calcularPrestamo_Click(object sender, EventArgs e)
        {
            PagoMensual = (montoPrestamo - montoPrestamo * descuento) * (tasaInteres / 12) /
                          (1 - 1 / Math.Pow(1 + tasaInteres, cantidadAnios * 12));
            pagoMensualBox.Text = PagoMensual.ToString("₡", CultureInfo.InvariantCulture);

            var pagoTotal = PagoMensual * cantidadAnios * 12;
            var montoDescuento = montoPrestamo * descuento;

            var nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            nfi.NumberGroupSeparator = ",";

            pagoMensualBox.Text = "₡" + PagoMensual.ToString("N2", nfi);
            costoTotalBox.Text = "₡" + pagoTotal.ToString("N2", nfi);

            var costoTotal = pagoTotal + montoDescuento;
            costoTotalBox.Text = "₡" + costoTotal.ToString("N2", nfi);
        }
        // Manejador de eventos para el cambio de texto en montoPrestamo
        public void montoPrestamo_TextChanged(object sender, EventArgs e)
        {   // Verifica si el monto del préstamo ingresado es válido y lo almacena en la variable
            if (double.TryParse(montoPrestamoBox.Text, NumberStyles.Currency, CultureInfo.InvariantCulture, out montoPrestamo))
            {
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para el monto del préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Manejador de eventos para cargar el formulario
        public void Form1_Load_1(object sender, EventArgs e)
        {

        }
        // Manejador de eventos para seleccionar la opción de préstamo
        public void opcionPrestamoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String opcionPrestamo = opcionPrestamoBox.Text;
            {   // Establece la tasa de interés según la opción de préstamo seleccionada
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
        // Manejador de eventos para reiniciar la calculadora
        public void reiniciarCalculadora_Click(object sender, EventArgs e)
        {
            montoPrestamoBox.Clear();
            tipoClienteBox.SelectedIndex = -1;
            opcionPrestamoBox.SelectedIndex = -1;
            pagoMensualBox.Text = "";
            cantidadAniosBox.Clear();
        }
        // Manejador de eventos para el cambio de texto en cantidadAniosBox
        public void cantidadAniosBox_TextChanged(object sender, EventArgs e)
        {   // Verifica si la cantidad de años ingresada es válida y la almacena en la variable
            if (int.TryParse(cantidadAniosBox.Text, out cantidadAnios))
            {
                // usa el valor recibido en la conversión de String a int
            }
            else
            {
                // entrada no válida
            }
        }
        // Manejador de eventos para el clic en descuentoBox
        public void descuentoBox_Click(object sender, EventArgs e)
        {


        }
        // Manejador de eventos para el clic en pagoMensualBox
        public void pagoMensualBox_Click(object sender, EventArgs e)
        {


        }
        // Manejador de eventos para el clic en costoTotalBox
        public void costoTotalBox_Click(object sender, EventArgs e)
        {


        }
    }
}
