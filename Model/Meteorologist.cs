using RestSharp;

namespace Lab2_Solution.Model;
/// <summary>
/// Implementation of API for Lab7P2 (Lab8) done by Group 5.
/// BusinessLogic layer file for Weather page.
/// </summary>
public class Meteorologist
{
    private string metarReport;
    private string tafReport;
    private readonly string keyAPI = "53b1c7659260454e889e86c373"; //our api key for accessing https://www.checkwxapi.com
    private string airportId; //use the ID to fetch weather information on that specific airport; must be ICAO code

    //adding '/decoded' to the end will allow for passing a JSON input file that can be mapped to the output information
    private readonly string metarClientString = "https://api.checkwx.com/metar/{0}/nearest/decoded";
    private readonly string tafClientString = "https://api.checkwx.com/taf/{0}/nearest/decoded";

    public string MetarReport { get{ return metarReport; } }
    public string TafReport { get{ return tafReport; } }

    /// <summary>
    /// 
    /// </summary>
    public Meteorologist(string airportId)
    {
        this.airportId = airportId;

        GetReports();
    }

    /// <summary>
    /// 
    /// </summary>
    public void GetReports()
    {
        GetMetar();
        GetTaf();
    }

    /// <summary>
    /// 
    /// </summary>
    private void GetMetar()
    {
        RestClient client = new(string.Format(metarClientString, airportId));
        RestRequest request = new()
        {
            Method = Method.Get
        };

        request.AddHeader("X-API-Key", keyAPI);
        RestResponse response = client.Execute(request);

        metarReport = response.Content;
    }

    /// <summary>
    /// 
    /// </summary>
    private void GetTaf()
    {
        RestClient client = new(string.Format(tafClientString, airportId));
        RestRequest request = new()
        {
            Method = Method.Get
        };

        request.AddHeader("X-API-Key", keyAPI);
        RestResponse response = client.Execute(request);

        tafReport = response.Content;
    }
}
