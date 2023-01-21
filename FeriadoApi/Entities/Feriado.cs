using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FeriadoApi.Entities
{
    public class Feriado
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("legislation")]
        public string Legislation { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        //[JsonProperty("variableDates")]
        //public VariableDates VariableDates { get; set; }

        public Feriado(string date, string title, string description, string legislation, string type, string startTime, string endTime)
        {
            Date = date;
            Title = title;
            Description = description;
            Legislation = legislation;
            Type = type;
            StartTime = startTime;
            EndTime = endTime;
        }
       
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
