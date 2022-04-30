using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot.Models.Notion
{
    public class Video
    {
        public string url { get; set; }
    }

    public class Date
    {
        public string start { get; set; }
        public object end { get; set; }
        public object time_zone { get; set; }
    }

    public class Time
    {
        public string id { get; set; }
        public string type { get; set; }
        public Date date { get; set; }
    }

    public class MultiSelect
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Tag
    {
        public List<MultiSelect> multi_select { get; set; }
    }

    public class Text
    {
        public string content { get; set; }
        public object link { get; set; }
    }

    public class Title
    {
        public Text text { get; set; }
    }

    public class User
    {
        public List<Title> title { get; set; }
    }

    public class Properties
    {
        public Video Video { get; set; }
        public Time Time { get; set; }
        public Tag Tag { get; set; }
        public User User { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public Properties properties { get; set; }
    }

    public class Root
    {
        public List<Result> results { get; set; }
    }
}
