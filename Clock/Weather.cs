using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Clock
{
    class Weather
    {
        string APIKey = "a9d5ce1560a6ad20dcee6624e2f1b1dd";

        XmlDocument xmlDocument;
        public void DownloadWeather(string Place)
        {
            string WeatherURL = "http://api.openweathermap.org/data/2.5/weather?q=" + Place + "&mode=xml&units=imperial&APPID=" + APIKey;
            using (WebClient client = new WebClient())
            {
                string xmlContent = client.DownloadString(WeatherURL);
                xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);
            }
        }



        public string GetCityWeather()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//weather");
            XmlAttribute temp_value = temp_node.Attributes["value"];
            string temp_string = temp_value.Value;
            temp_string = char.ToUpper(temp_string[0]) + temp_string.Substring(1);
            temp_node = xmlDocument.SelectSingleNode("//temperature");
            temp_value = temp_node.Attributes["value"];
            temp_string = temp_value.Value.Substring(0, 2) + " Degrees and " + temp_string;
            return temp_string;
        }




        /* 
        NOTIFICATION CODES
        0 = LOGO
        1 = WARNING
        2 = DATE
        3 = EVENT
        4 = BDAY
        5 = SUNNY
        6 = CLOUDY
        7 = PARTLY CLOUDY
        8 = RAIN
        9 = SNOW
        10 = FOG
        11 = THUNDER
        */

        public int WeatherIcon()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//weather");
            XmlAttribute temp_value = temp_node.Attributes["icon"];
            string code = temp_value.Value;

            if (code == "01d" || code == "01n") return 5;
            else if (code == "02d" || code == "02n" || code == "03d" || code == "03n") return 7;
            else if (code == "04d" || code == "04n") return 6;
            else if (code == "09d" || code == "09n" || code == "10n" || code == "10n") return 8;
            else if (code == "11d" || code == "11n") return 11;
            else if (code == "13d" || code == "13n") return 9;
            else if (code == "50d" || code == "50n") return 10;
            else return 0;
        }




    }
}
