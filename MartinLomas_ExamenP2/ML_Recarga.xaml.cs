using Android.OS;
using static Android.Graphics.ImageDecoder;

namespace MartinLomas_ExamenP2;

public partial class ML_Recarga : ContentPage

    
{
    Entry entry = new Entry { Placeholder = "Enter text" };
    Label operadoropcion = new Label();
    int recarga = 0;
    
    

    public ML_Recarga()
	{
        
        entry.TextChanged += OnEntryTextChanged;
        entry.Completed += OnEntryCompleted;
        InitializeComponent();
        var lista = new List<string>();
        lista.Add("Claro");
        lista.Add("Movistar");
        lista.Add("Tuenti");
        lista.Add("CNT");

        Picker picker = new Picker { Title = "Selecciona un operador" };
        picker.ItemsSource = lista;
        operadoropcion.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker));
    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            operadoropcion.Text = (string)picker.ItemsSource[selectedIndex];
        }
    }

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }
    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }



    private async void Click(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Mensaje", "Quiere realizar la recarga de " + recarga, "Si", "No"+this.DisplayAlert("Finalizado", "Recarga exitosa","si"));
       


        

    }
}