using Data_Time.Exeption;
using System;
using System.Collections.Generic;

namespace Data_Time
{
    public class User
    {
     
        public int Id { get; set; }
        private static int id { get; set; }
        public string Username { get; set; }
        List<Status> Statuses = new List<Status>();
        public User(string username)
        {
            id++;
            Id = id;
            Username = username;
        }

        public void ShareStatus(Status status)
        {
            Statuses.Add(status);
        }
        public int GetStatusById(int? id)
        {
            foreach (var item in Statuses)
            {
                if (id == null)
                {
                    throw new NullReferenceException("Id-nulldi");
                }
                else if (item.Id == id)
                {

                    Console.WriteLine();
                    Console.WriteLine($"UserName:{Username}\nId{item.Id}\nTitle:{item.Title}\nContent:{item.Content}");
                    Console.WriteLine("shared {0:hh\\:mm\\:ss} seconds ago", item.timer);
                    return item.Id;
                }
            }
            return 0;
        }
        public List<Status> GetAllStatuses()
        {
            if (Statuses == null)
            {

                throw new NullReferenceException("Userin statusu yoxdur");
            }
            foreach (var item in Statuses)
            {
                Console.WriteLine();

                Console.WriteLine($"UserName:{Username}\nId{item.Id}\nTitle:{item.Title}\nContent:{item.Content}");
                Console.WriteLine("shared {0:hh\\:mm\\:ss} seconds ago", item.timer);
            }
            return Statuses;
        }
        public void FilterStatusByDate(int? id, DateTime date)
        {
            if (id == Id)
            {
                foreach (var item in Statuses)
                {

                    if (item.SharedData > date)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Title:{item.Title}\nContent:{item.Content}\nData:{item.SharedData}");
                        Console.WriteLine();

                    }
                    else
                    {
                        throw new NotFoundException("gonderilen tarixden sonra hec bir status paylawilmayib");
                    }
                }
            }
            else if (id == null)
            {
                throw new NullReferenceException("Id-null");
            }

            

        }
    }
}
