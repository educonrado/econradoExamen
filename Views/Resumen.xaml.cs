

namespace econradoExamen.Views;

public partial class Resumen : ContentPage
{
    private string text1;
    private string text2;
    private string text3;
    private DateTime date;
    private string pais;
    private string ciudad;
    private string text4;
    private string text5;
    private double monto_cuota;
    private double pago_total;

    public Resumen()
	{
		InitializeComponent();
	}

    public Resumen(string text1, string text2, string text3, DateTime date, string pais, string ciudad, string text4, string text5, double monto_cuota, double pago_total)
    {
        InitializeComponent();
        this.text1 = text1;
        this.text2 = text2;
        this.text3 = text3;
        this.date = date;
        this.pais = pais;
        this.ciudad = ciudad;
        this.text4 = text4;
        this.text5 = text5;
        this.monto_cuota = monto_cuota;
        this.pago_total = pago_total;

        lblNombre.Text = this.text1;
        lblApellido.Text = this.text2;
        lblEdad.Text = this.text3;
        lblFecha.Text = this.date.ToShortDateString();
        lblCiudad.Text = this.ciudad;
        lblPais.Text = this.pais;
        lblMontoInicial.Text = this.text4;
        lblPagoMensual.Text = this.text5;
        lblPagoTotal.Text = this.pago_total.ToString("C");


    }
}