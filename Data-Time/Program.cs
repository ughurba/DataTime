using System;

namespace Data_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user = new User("Sahil");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1.Share status\n2.Get all statuses\n3.Get status by id\n4.Filter status by date\n0.Quit");

                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("qeyd edin nece status paylawmaq isetyirsiniz ");
                        int num2 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < num2; i++)
                        {
                            Status status = new Status(GetInputStr("Write Title please:"), GetInputStr("Write content please:"));
                            user.ShareStatus(status);
                            status.GetStatusInfo();
                        }

                        break;
                    case 2:
                        user.GetAllStatuses();
                        break;
                    case 3:
                        user.GetStatusById(GetInputInt("write id please:"));
                        break;
                    case 4:
                        string str = "22.03.2022";
                        DateTime myDate = DateTime.Parse(str);
                        Console.WriteLine("User id qeyd edin");
                        int id = int.Parse(Console.ReadLine());
                        user.FilterStatusByDate(id, myDate);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }

        }
        static string GetInputStr(string sentence)
        {

            string input;
            Console.Write(sentence);
            input = Console.ReadLine();
            return input;

        }
        static int GetInputInt(string sentence)
        {
            int input;
            Console.Write(sentence);
            input = Convert.ToInt32(Console.ReadLine());

            return input;
        }
    }
}
