using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string eventType, string title, string description, string date, string time, string address) : base(eventType, title, description, date, time, address)
    {
        
        _weather = "**In Case of inclement weather the event will be moved to the LDS Church Building on Melville Rd Cheney**";
    }

    public string GetOutdoorFullDetails()
    {
        string outdoorDetails = GetFullDetails();
        return $"{outdoorDetails} {_weather}";
    }
}
}