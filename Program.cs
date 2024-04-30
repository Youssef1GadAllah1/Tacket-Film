using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Youssef_1023073
{
    internal class Program
    {
        static LinkedList<VIPUser> VipUsers = new LinkedList<VIPUser>();
        static LinkedList<NormalUser>NormalUsers = new LinkedList<NormalUser>();
        static LinkedList<Movies> ListMovie = new LinkedList<Movies>();

        static void AddMovie()
        {      
            for (int i = 1; i <= 10; i++)
            {
                Movies movies = new Movies();
                movies.SetNameFilm($"film{i}");
                ListMovie.AddLast(movies);
            }
        }

        static void VipUser()
        {
            VIPUser vUsers = new VIPUser();
            foreach(Movies movies in ListMovie)
            {
                Console.WriteLine($"Name Film:{movies.GetNameFilm()},Price:{movies.GetPriceFilmV()}");
            }
            bool IsFound = false;
            Console.WriteLine("Enter Name Film");
            
            string nameFilm = Console.ReadLine();
            foreach (Movies movie in ListMovie)
            {
               
                    if (nameFilm.ToLower() == movie.GetNameFilm())
                    {
                       
                            IsFound = true;
                    }
                
            }
            if (IsFound == true)
            {
               
                Console.WriteLine("Enter Your Name");
                string nameUser = Console.ReadLine();
                 bool isFound = true;
                foreach (VIPUser vipUser in VipUsers)
                {
                    if (nameUser == vipUser.GetName() && nameFilm == vipUser.GetNameFilm())
                    {
                        isFound = false;
                    }
                }
                if (isFound == true)
                {
                    vUsers.SetName(nameUser);
                    VipUsers.AddLast(vUsers);
                    vUsers.SetNameFilm(nameFilm);
                    Console.WriteLine("Successfully Book");
                }
                else
                {
                    Console.WriteLine("booked");
                }

            }
            else
            {
                Console.WriteLine("No Films");
            }

        }

        static void NormalUser()
        {
            NormalUser NUser = new NormalUser();
            foreach (Movies movies in ListMovie)
            {
                Console.WriteLine($"Name Film:{movies.GetNameFilm()},Price:{movies.GetPriceFilm()}");
            }

            Console.WriteLine("Enter Name Film");
            string nameFilm = Console.ReadLine();
            bool IsFound = false;
          
            foreach (Movies movie in ListMovie)
            {
              if(nameFilm.ToLower() == movie.GetNameFilm())
                {
                    IsFound = true;
                }
            }
            if (IsFound == true)
            {
                Console.WriteLine("Enter Your Name");
                string nameUser = Console.ReadLine();
                bool isFound = true;
                foreach (VIPUser vipUser in VipUsers)
                {
                    if (nameUser == vipUser.GetName() && nameFilm == vipUser.GetNameFilm())
                    {
                        isFound = false;
                    }
                }
                if (isFound == true)
                {
                    Console.WriteLine("Successfully Book");
                    NUser.SetNameFilm(nameFilm);
                    NUser.SetName(nameUser);
                    NormalUsers.AddLast(NUser);

                }
                else
                {
                    Console.WriteLine("booked");
                }
                
               
            }
            else
            {

                Console.WriteLine("No Films");
            }
        }
        static void Main(string[] args)
        {
            Thread AddM = new Thread(AddMovie);
           AddM.Start();
            while (true)
            {
                Console.WriteLine("1- Show list movies ");
                Console.WriteLine("2- book ticket (Vip , Normal)");
                Console.WriteLine("3- List / Show booking Ticket");
                Console.WriteLine("4- Exit ");
                Console.Write("Enter Number 1,2,3 or 4 :");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        foreach(Movies movies in ListMovie)
                        {
                            Console.WriteLine($"Name Film:{movies.GetNameFilm()},Price Ticket Vip:{movies.GetPriceFilm()},Price Ticket Normal:{movies.GetPriceFilm()}");
                        }
                        break;
                        case 2:
                        Console.WriteLine("1- Resrvation Ticket Normal ");
                        Console.WriteLine("2- Resrvation Ticket VIP");
                        Console.WriteLine("Enter Number 1 OR 2");

                        int i = int.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                NormalUser();
                                break;
                            case 2:
                                VipUser();
                                break;
                            default:
                                Console.WriteLine("Error");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("1- Show Ticket Vip");
                        Console.WriteLine("2- Show Ticket Normal");
                        Console.WriteLine("Enter 1 or 2");
                        int x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1: 
                                foreach(VIPUser Users in VipUsers)
                                {
                                    
                                        Console.WriteLine($"Name Users:{Users.GetName()},-, Name Film:{Users.GetNameFilm()}");
                                    
                                }
                                break;
                                case 2:
                                foreach (NormalUser Users in NormalUsers)
                                {

                                    Console.WriteLine($"Name Users:{Users.GetName()},-, Name Film:{Users.GetNameFilm()}");
                                }
                                break;
                            default:
                                Console.WriteLine("Error");
                                break;
                        }
                        break;
                        case 4:
                        Console.WriteLine("Exit....Thank You");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }
                Console.WriteLine("=============================");
            }
        }
    }
}
