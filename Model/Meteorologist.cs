namespace Lab2_Solution.Model;
/// <summary>
/// Implementation of API for Lab7P2 (Lab8) done by Group 5.
/// BusinessLogic layer file for Weather page.
/// </summary>
public class Meteorologist
{
    private string metarReport; //unchanged from provided API
    private string tafReport;   //unchanged from provided API

    public string MetarReport { get; set; } //unchanged from provided API
    public string TafReport { get; set; }   //unchanged from provided API

    /// <summary>
    /// 
    /// </summary>
    public Meteorologist()
    {
        GetReports(); //???
    }

    /// <summary>
    /// 
    /// </summary>
    public void GetReports()
    {
        //leverage external API to get metar and taf information and store internally
    }
}
