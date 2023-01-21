using Newtonsoft.Json;

namespace FeriadoApi.Entities
{
    public class FeriadoDto
    {
        
        public string Date { get; set; }


        public string Title { get; set; }


        public string Description { get; set; }


        public string Legislation { get; set; }

        public string Type { get; set; }

        public string StartTime { get; set; }


        public string EndTime { get; set; }

        //[JsonProperty("variableDates")]
        //public VariableDates VariableDates { get; set; }

        //public Feriado(string date, string title, string description, string legislation, string type, string startTime, string endTime)
        //{
        //    Date = date;
        //    Title = title;
        //    Description = description;
        //    Legislation = legislation;
        //    Type = type;
        //    StartTime = startTime;
        //    EndTime = endTime;
        //}
       
    }


    //public class VariableDates
    //{
    //    [JsonProperty("2015")]
    //    public string _2015 { get; set; }

    //    [JsonProperty("2016")]
    //    public string _2016 { get; set; }

    //    [JsonProperty("2017")]
    //    public string _2017 { get; set; }

    //    [JsonProperty("2018")]
    //    public string _2018 { get; set; }

    //    [JsonProperty("2019")]
    //    public string _2019 { get; set; }

    //    [JsonProperty("2020")]
    //    public string _2020 { get; set; }
    //}

}
