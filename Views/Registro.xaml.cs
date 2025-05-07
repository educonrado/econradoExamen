
namespace econradoExamen.Views;

public partial class Registro : ContentPage
{
    private string usuario;
    private readonly int MONTO = 1500;
    double monto_cuota = 0;
    double pago_total = 0;

    public Registro()
    {

        InitializeComponent();

    }

    public Registro(string usuario)
    {
        InitializeComponent();
        this.usuario = usuario;
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        bool camposValidos = Validar_Campos(txtNombre, txtApellido, txtEdad);
        if (camposValidos)
        {
            try
            {
                string pais = pckPais.Items[pckPais.SelectedIndex].ToString();
                string ciudad = pckCiudad.Items[pckCiudad.SelectedIndex].ToString();
                Navigation.PushAsync(new Views.Resumen(txtNombre.Text, txtApellido.Text, txtEdad.Text, pckFecha.Date, pais, ciudad, txtMonto.Text, txtMontoCalculado.Text, monto_cuota, pago_total));
            }
            catch (Exception ex)
            {

                DisplayAlert("Error", "No ha seleccionado ningún país y/o ciudad", "Aceptar");
            }
            
        } 
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        bool camposValidos = Validar_Campos(txtMonto);
        if (camposValidos)
        {
            if (int.Parse(txtMonto.Text) > 0 && int.Parse(txtMonto.Text) <= MONTO)
            {
                int cuota = (MONTO - int.Parse(txtMonto.Text));
                double interes = cuota * 0.04;
                monto_cuota = (cuota / 4) + interes;
                pago_total = int.Parse(txtMonto.Text) + (monto_cuota * 4);
                txtMontoCalculado.Text = monto_cuota.ToString();

            }
            else
            {
                DisplayAlert("Error", "El monto debe ser mayor a 0 y menor a 1500", "Aceptar");
            }
        }
    }

    private bool Validar_Campos(params Entry[] parametros)
    {
        foreach (Entry entry in parametros)
        {
            if (string.IsNullOrEmpty(entry.Text))
            {
                DisplayAlert("Error", "El campo es obligartio", "Aceptar");
                return false;
            }
        }
        return true;
    }
   

    
}