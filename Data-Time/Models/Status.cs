﻿using System;

namespace Data_Time
{
    public class Status
    {


        public int Id { get; set; }
        private static int id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedData { get; set; }
        public int Second { get; set; }
        public TimeSpan timer => DateTime.Now - SharedData; //shardata elave olan kimi timer iwdemeye bawlayir


        public Status(string title, string content)
        {
            id++;
            Id = id;
            Title = title;
            Content = content;
            SharedData = DateTime.Now;

        }

        public DateTime GetStatusInfo()
        {
            Console.WriteLine($"Id{Id}\nTitle:{Title}\nContent:{Content}\nshared {timer} seconds ago");
            return SharedData;
        }

    }
}