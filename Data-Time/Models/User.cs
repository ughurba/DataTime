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
            if(id == null)
            {
                throw new NullReferenceException("Id-nulldi");
            }
            else
            {
                Status statuss = Statuses.Find(item => item.Id == id);
                Console.WriteLine();
                Console.WriteLine($"UserName:{Username}\nId{statuss.Id}\nTitle:{statuss.Title}\nContent:{statuss.Content}");
                Console.WriteLine("shared {0:hh\\:mm\\:ss} seconds ago", statuss.timer);
                return statuss.Id;
            } 
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


            if(id == Id)
            {
                
                List<Status>statuscoy=new List<Status>();
        
                statuscoy=Statuses.FindAll(item => item.SharedData > date);
                foreach (var item in statuscoy)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Title:{item.Title}\nContent:{item.Content}\nData:{item.SharedData}");
                    Console.WriteLine();
                }
               
            }else if(id == null)
            {
                throw new NullReferenceException("Id-nulldir");
            }
            else
            {
                throw new NotFoundException("gonderilen tarixden sonra hec bir status paylawilmayib");
            }
      

         



        }
    }
}
