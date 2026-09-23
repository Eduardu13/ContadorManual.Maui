using ContadorManual.Maui.Models;

namespace ContadorManual.Maui.Views;

public partial class MainPage : ContentPage
{
    private Contador _contador;
    public MainPage()
	{
		InitializeComponent();
        _contador = new Contador();
        //ConteoLabel.Text = _contador.Conteo.ToString();
        BindingContext = _contador;
    }
    private void OnContarButtonClicked(object sender, EventArgs e)
    {
        _contador.Contar();
        //ConteoLabel.Text = _contador.Conteo.ToString();
    }
    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
        _contador.Reiniciar();
        //ConteoLabel.Text = _contador.Conteo.ToString();
    }

    //Se quito el manejador de eventos para ponerlo como enlace de datos
    private void OnIncrementoStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        _contador.Incremento = (int)IncrementoStepper.Value;
    }
}