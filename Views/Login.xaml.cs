using System.Diagnostics;

namespace econradoExamen.Views;

public partial class Login : ContentPage
{
    private readonly string[][] usuarios = [
        ["estudiante", "moviles"],
        ["uisrael", "2024"]

        ]; 
	public Login()
	{
		InitializeComponent();
	}

    private void Btn_Login_Clicked(object sender, EventArgs e)
    {
        string usuario = "";
        string password = "";

        if(!string.IsNullOrEmpty(Txt_Usuario.Text) && !string.IsNullOrEmpty(Txt_Password.Text))
        {
            for (int i = 0; i < usuarios.Length; i++)
            {
                for (int j = 0; j < usuarios[i].Length; j++)
                {
                    if (usuarios[i][j] == Txt_Usuario.Text)
                    {
                        usuario = usuarios[i][j];
                        password = usuarios[i][j + 1];
                        break;
                    }

                }
            }

            if (Txt_Usuario.Text == usuario && Txt_Password.Text == password)
            {
                Navigation.PushAsync(new Views.Registro(usuario));

            }
            else
            {
                DisplayAlert("Error", "Usuario y/o password incorrectos.\nIntente nuevamente", "Aceptar");
            }
        }
        else
        {
            DisplayAlert("Error", "Usuario y/o password incorrectos.\nIntente nuevamente", "Aceptar");
        }


        Txt_Usuario.Text = "";
        Txt_Password.Text = "";

    }
}