using Lab2_Solution.Model;


namespace Lab6_Starter;

public partial class Weather : ContentPage
{
    public Weather()
    {
        InitializeComponent();
    }

    public void OnSearch_Clicked (object sender, EventArgs e)
    {
        MetarLabel.Text = MeteorologistStatic.GetMetar(entry.Text);
        TafLabel.Text = MeteorologistStatic.GetTaf(entry.Text);

    }


}


