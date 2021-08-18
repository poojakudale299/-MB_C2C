using System;
using System.Collections;
using System.Collections.Generic;
namespace Task
{

    class Message
    {
        List<Message> user_message = new List<Message>();
        DateTime completeBy;
        DateTime CreatedOn;
        String name;
        String title;
        String msg;
        string[] userlist;
        int priority;
        string status;
        // int task_id=0;

        public void initilise()
        {

            DateTime cmpleteBy;
            DateTime CeatedOn;
            String nme;
            String ttle;
            String mg;
            // List<string> uerList = new List<string>();
            int prior;
            int choice;
            cmpleteBy = DateTime.Parse(" 22 / 08 / 2022");
            CeatedOn = DateTime.Now;
            nme = "Name task 1";
            ttle = "Title task 1 ";
            mg = "Here goes my 1st message";
            prior = 1;
            Message admss1 = new Message(cmpleteBy, CeatedOn, nme, ttle, mg, prior);
            user_message.Add(admss1);

            cmpleteBy = DateTime.Parse(" 30 / 08 / 2021");
            CeatedOn = DateTime.Now;
            nme = "Name task 2";
            ttle = "Title task 2 ";
            mg = "Here goes my 2nd message";
            prior = 0;
            Message admss2 = new Message(cmpleteBy, CeatedOn, nme, ttle, mg, prior);
            user_message.Add(admss2);

            cmpleteBy = DateTime.Parse(" 16 / 09 / 2021");
            CeatedOn = DateTime.Now;
            nme = "Name task 3";
            ttle = "Title task 3 ";
            mg = "Here goes my 3rd  message";
            prior = 2;
            Message admss3 = new Message(cmpleteBy, CeatedOn, nme, ttle, mg, prior);
            user_message.Add(admss3);


            //

        }
        public Message(DateTime cb, DateTime co, string n, string t, string m, int p)
        {
            this.completeBy = cb;
            this.CreatedOn = co;
            this.name = n;
            this.title = t;
            this.msg = m;
            this.userlist = new string[0];
            //this.userlist = str;
            this.priority = p;
            this.status = "pending";
            // this.task_id = task_id + 1;
        }
        public Message()
        {

        }
        public Message(DateTime cb, DateTime co, string n, string t, string[] str, int p)
        {

            //Console.WriteLine("inside list constructor");
            this.completeBy = cb;
            this.CreatedOn = co;
            this.name = n;
            this.title = t;
            //this.msg = s;
            this.userlist = str;
            this.priority = p;
            this.status = "pending";
            // Console.WriteLine("name :    " + name + "title:   " + title);
        }

        public void edit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int k,i;
            go :
            do
            {
                k = 0;
                Console.WriteLine("id of message to edit message: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                i = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (i < 0 || i >= user_message.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Id does not exist :<[");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                { k = 1; }
            } while (k != 1);

            int c;
            try
            {
                
                do { 
                Console.WriteLine("------What you choose to edit : ------\n 1:Name \n 2:Title \n 3:Message \n 4:Priority\n 5:Status\n 6:List\n 7:Exit");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (c)
                    {
                        case 1:
                            {
                                Console.WriteLine("enter Edited Name : ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                user_message[i].name = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("enter Edited Title : ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                user_message[i].title = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("enter Edited Message : ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                user_message[i].msg = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }

                        case 4:
                            {
                                Console.WriteLine("enter Edited Priority : ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                user_message[i].priority = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("enter Edited status : ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                user_message[i].status = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        case 6:
                            {
                                int ele;
                                Console.WriteLine("Enter number of elements in list  ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                ele = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.White;
                                string[] strings = new string[ele];
                                Console.WriteLine("Enter  your list :");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                for ( int j = 0; j < ele; j++)
                                    strings[j] = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                user_message[i].userlist = strings;
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("......Exiting.....");
                                break;
                            }
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Enter correct value.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                    }
                } while (c!=7) ;
                Console.WriteLine("\n||------------------------------------||\n");
                Console.WriteLine("||Priority    :    " + user_message[i].priority);

                Console.WriteLine("||Task id     :    " + (i));
                Console.WriteLine("||Task name   :    " + user_message[i].name);
                Console.WriteLine("||Task Title  :    " + user_message[i].title);
                Console.WriteLine("||Target date :    " + user_message[i].completeBy);
                Console.WriteLine("||created on  :    " + user_message[i].CreatedOn);
                Console.WriteLine("||Message     :    " + user_message[i].msg);
                for (int j = 0; j < user_message[i].userlist.Length; j++)
                {
                    Console.WriteLine("            #   " + user_message[i].userlist[j]);
                }
                Console.WriteLine("||Status      :    " + user_message[i].status);

                Console.WriteLine("\n||------------------------------------||\n");

            }
            catch (Exception ee)
            {
                Console.WriteLine("Enter correct values :( ");
                goto go;
            }
        }
        public void displaybyId()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int k,i;
            do
            {
                k = 0;
                Console.WriteLine("id of message to display message: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                i = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (i < 0 || i >= user_message.Count)
                { Console.WriteLine("Id does not exist :<["); }
                else
                { k = 1; }
            } while (k!=1);

            Console.WriteLine("\n||------------------------------------||\n");
          
            Console.WriteLine("||Priority    :    " + user_message[i].priority);
            Console.WriteLine("||Task id     :    " + (i));
            Console.WriteLine("||Task name   :    " + user_message[i].name);
            Console.WriteLine("||Task Title  :    " + user_message[i].title);
            Console.WriteLine("||Target date :    " + user_message[i].completeBy);
            Console.WriteLine("||created on  :    " + user_message[i].CreatedOn);
            Console.WriteLine("||Message     :    " + user_message[i].msg);
            for (int j = 0; j < user_message[i].userlist.Length; j++)
            {
                Console.WriteLine("             #   " + user_message[i].userlist[j]);
            }
            Console.WriteLine("||Status      :    " + user_message[i].status);

            Console.WriteLine("\n||------------------------------------||\n");

        }
        public void displayAll()
        {
            for (int i = 0; i < user_message.Count; i++)
            {
                Console.WriteLine("\n||------------------------------------||\n");
                Console.WriteLine("||Priority    :    " + user_message[i].priority);

                Console.WriteLine("||Task id     :    " + (i));
                Console.WriteLine("||Task name   :    " + user_message[i].name);
                Console.WriteLine("||Task Title  :    " + user_message[i].title);
                Console.WriteLine("||Target date :    " + user_message[i].completeBy);
                Console.WriteLine("||created on  :    " + user_message[i].CreatedOn);
                Console.WriteLine("||Message     :    " + user_message[i].msg);
                for (int j = 0; j < user_message[i].userlist.Length; j++)
                {
                    Console.WriteLine("              #   "+ user_message[i].userlist[j]);
                }
                Console.WriteLine("||Status      :    " + user_message[i].status);

                Console.WriteLine("\n||------------------------------------||\n");

            }
        }
        public void Sortt()
        {
            Console.WriteLine("\n------------Sorted by priority ------------\n");
            user_message.Sort((x, y) => y.priority.CompareTo(x.priority));
            displayAll();
            Console.WriteLine("\n------------Sorted by target date ------------\n");
            user_message.Sort((x, y) => x.completeBy.CompareTo(y.completeBy));
            displayAll();


        }

        public void delete()
        {
            int k,i;
            do
            {
                k = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("id of message to delete message: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                i = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (i < 0 || i >= user_message.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Id does not exist :<[");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    k = 1;
            } while (k != 1);

            user_message.RemoveAt(i);
            displayAll();
        }
        public void acceptMessage()
        {
            Program program = new Program(); // Creating Object  
            //program.createMessage(user_message);

            DateTime cmpleteBy;
            DateTime CeatedOn;
            String nme;
            String ttle;
            String mg;
            // List<string> uerList = new List<string>();
            int prior;
            int choice;
            try { 
           

               

                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Welcome to Task app");
            do
            {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter target date to complete task");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    cmpleteBy = DateTime.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    if (cmpleteBy < DateTime.Now)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("OOPPPSS wrong date!!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
            } while (cmpleteBy < DateTime.Now);

            CeatedOn = DateTime.Now;

              //  Console.WriteLine("creater on"+ CreatedOn+ "complete by "+ cmpleteBy); 

            Console.WriteLine("Enter Name of task");
                Console.ForegroundColor = ConsoleColor.Yellow;
                nme = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter title of task");
                Console.ForegroundColor = ConsoleColor.Yellow;
                ttle = Console.ReadLine();
                int t = 0;
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter priority 0,1,2,3  ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    prior = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    if (prior > 3 || prior < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("----Enter correct priority----");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                
                    else
                        t = 1;
                } while (t != 1);


            Console.WriteLine("Enter 1 for message 2 for list  ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (choice == 1)
            {
                    Console.WriteLine("Enter  message :");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    mg = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    //uerList.Add(" ");
                    // string[] s ;
                    Message admss = new Message(cmpleteBy, CeatedOn, nme, ttle, mg, prior);
                user_message.Add(admss);
            }
            else if (choice == 2)
            {
                    Console.ForegroundColor = ConsoleColor.White;
                    int ele;
                Console.WriteLine("Enter number of elements in list  ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    ele = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    string[] strings = new string[ele];
                    Console.WriteLine("Enter  your list :");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int i = 0; i < ele; i++)
                    strings[i] = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    //Console.WriteLine("Enter  List :");
                    //string m = Console.ReadLine();

                    //=m.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

                    //uerList.Add(m);
                    // Console.WriteLine("  entered string is :"+ m);
                    Message admss = new Message(cmpleteBy, CeatedOn, nme, ttle, strings, prior);
                user_message.Add(admss);
            }
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter correct values :( ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            int c;
            Message ms = new Message();
            ms.initilise();
            //
            //List<Message> user_list = new List<Message>();
            Console.ForegroundColor = ConsoleColor.White;
        here:
            try
            {
                
                Console.WriteLine("\n----------- WELCOME TO TASK-APP ---------\n");
                
                do
                {
                    
                    Console.WriteLine("< ***************************************>");
                    Console.WriteLine("Enter your choice \n1:add task\n2:Display all task \n3:Diplay task by element  \n4:Delete task  \n5:Edit task \n6:sort tasks\n7 : exit");
                    Console.WriteLine("< ***************************************>");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    switch (c)
                    {
                        case 1: { ms.acceptMessage(); break; }
                        case 2:
                            { ms.displayAll(); break; }
                        case 3:
                            {
                                
                                   // int k=0;
                                    //Console.WriteLine("id of message to display message: ");
                                  //  int id = Convert.ToInt32(Console.ReadLine());
                                    
                                    ms.displaybyId();
                              
                                break;
                            }
                        case 4:
                            {
                              //  Console.WriteLine("id of message to delete message: ");
                                //int idel = Convert.ToInt32(Console.ReadLine());
                                ms.delete();
                                break;
                            }

                        case 5:
                            {
                              //  Console.WriteLine("id of message to edit message: ");
                                //int ied = Convert.ToInt32(Console.ReadLine());
                                ms.edit();
                                //ms.edit();
                                break;
                            }
                        case 6:
                            {
                                ms.Sortt();
                                break;
                            }
                        case 7:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("......Exiting.....");
                                break;
                            }
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Enter correct value.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }

                    }
                } while (c != 7);
            }catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!Enter correct values :(  ");
                Console.ForegroundColor = ConsoleColor.White;
                goto here;
            }

        }

    }
}

