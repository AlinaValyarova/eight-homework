using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_8._2
{
    public class Program
    {
        public class Project
        {
            public int number; 
            public string about;
            public DateTime dedline;
            public string status;
            public string client;
            class Client
            {
                public string name;
            }
            class TeamLead
            {
                public string name;
            }

            class Tasks : Project
            {
                public int numOfTask;
                public string name;
                //class Initiator
                //{
                //    public string name;
                //} - всегда тимлид, зачем?\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

                class Taskmaker
                {
                    public string name;
                }
                class Report : Tasks
                {
                    public string text;
                    public DateTime date;
                    public string implementer;
                }



                static void Main()
                {
                    /////////// objects///////////////
                    TeamLead you = new TeamLead();
                    Client cl = new Client();
                    Tasks NewTask = new Tasks();
                    Taskmaker TM = new Taskmaker();
                    Project NewProject = new Project();
                    Report NewReport = new Report();
                    ///////////lists////////////////////
                    List<Project> ListOfProjects = new List<Project>();
                    List<Tasks> ListOfTasks = new List<Tasks>();
                    List<Tasks> Dump = new List<Tasks>();
                    List<Report> ListOfReports = new List<Report>();
                    Console.WriteLine("Congradulations! Now you are a team lead!" + "\nPlease, enter your name!");
                    string name = Console.ReadLine();
                    you.name = name;
                    

                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////

                    byte ch;

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    do
                    {
                        
                        Console.WriteLine("Please, enter what you need to do");
                        Console.WriteLine("1 - Add a new project");//////////////// done ///////////////////////////////////////
                        Console.WriteLine("2 - Add a new task");////////////////// done ////////////////////////////////////////
                        Console.WriteLine("3 - Find your tasks");/////////////////// done //////////////////////////////////////
                        Console.WriteLine("4 - Create a report");/////////////////////// 
                        Console.WriteLine("5 - redelegate declined projects");
                        Console.WriteLine("6 - exit");
                        while (!Byte.TryParse(Console.ReadLine(), out ch))
                        {
                            Console.WriteLine("Wrong enter. Please try again");
                        }
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("let's create a project");
                                int colvo = ListOfProjects.Count;
                                Console.WriteLine("This project's number is {0} ", colvo);
                                Console.WriteLine("Enter description of the project");
                                string des = Console.ReadLine();
                                NewProject.about = des;
                                Console.WriteLine("Enter dedline of the project");
                                DateTime dl;
                                while (!DateTime.TryParse(Console.ReadLine(), out dl))
                                {
                                    Console.WriteLine("Wrong enter. Please try again");
                                }
                                NewProject.dedline = dl; 
                                Console.WriteLine("Enter name of the client");
                                string client = Console.ReadLine();
                                cl.name = client;
                                NewProject.client = client;
                                Console.WriteLine("Enter status of the project");
                                Console.WriteLine("1 - project");
                                Console.WriteLine("2 - in process");
                                Console.WriteLine("3 - closed");
                                int st;
                                while (!Int32.TryParse(Console.ReadLine(), out st))
                                {
                                    Console.WriteLine("Wrong enter. Please try again");
                                }
                                if (st == 1)
                                {
                                    NewProject.status = "project";
                                }
                                else if (st == 2)
                                {
                                    NewProject.status = "in process";
                                }
                                else if (st == 3)
                                {
                                    NewProject.status = "closed";
                                }
                                else
                                {
                                    Console.WriteLine("You entered something wrong");
                                }
                                byte check;
                                do
                                {
                                    Console.WriteLine("Description of the project: " + des);
                                    Console.WriteLine("Dedline of the project: " + dl);
                                    Console.WriteLine("Name of the client: " + client);
                                    Console.WriteLine("Status: " + NewProject.status);
                                    Console.WriteLine("Is the information correct?");
                                    Console.WriteLine("1 - yes");
                                    Console.WriteLine("2 - no");
                                    while (!Byte.TryParse(Console.ReadLine(), out check))
                                    {
                                        Console.WriteLine("Wrong enter. Please try again");
                                    }
                                    switch (check)
                                    {
                                        case 1:
                                            ListOfProjects.Add(NewProject);
                                            continue;

                                        case 2:
                                            Console.WriteLine("What information os incorrect");
                                            Console.WriteLine("1 - description");
                                            Console.WriteLine("2 - deadline");
                                            Console.WriteLine("3 - name of the client");
                                            Console.WriteLine("4 - status");
                                            byte check2;
                                            while (!Byte.TryParse(Console.ReadLine(), out check2))
                                            {
                                                Console.WriteLine("Wrong enter. Please try again");
                                            }
                                            switch (check2)
                                            {
                                                case 1:
                                                    Console.WriteLine("Enter new description");
                                                    NewProject.about = Console.ReadLine();
                                                    continue;

                                                case 2:
                                                    Console.WriteLine("Enter new deadline");
                                                    while (!DateTime.TryParse(Console.ReadLine(), out dl))
                                                    {
                                                        Console.WriteLine("Wrong enter. Please try again");
                                                    }
                                                    NewProject.dedline = dl;
                                                    continue;

                                                case 3:
                                                    Console.WriteLine("Enter new name");
                                                    cl.name = Console.ReadLine();
                                                    NewProject.client = cl.name;
                                                    continue;

                                                case 4:
                                                    Console.WriteLine("Enter status of the project");
                                                    Console.WriteLine("1 - project");
                                                    Console.WriteLine("2 - in process");
                                                    Console.WriteLine("3 - closed");
                                                    while (!Int32.TryParse(Console.ReadLine(), out st))
                                                    {
                                                        Console.WriteLine("Wrong enter. Please try again");
                                                    }
                                                    if (st == 1)
                                                    {
                                                        NewProject.status = "project";
                                                    }
                                                    else if (st == 2)
                                                    {
                                                        NewProject.status = "in process";
                                                    }
                                                    else if (st == 3)
                                                    {
                                                        NewProject.status = "closed";
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("You entered something wrong");
                                                    }
                                                    continue;
                                            }
                                            continue;
                                    }
                                }
                                while (check != 1);
                                continue;
                            case 2:
                                Console.WriteLine("Enter the number of the project you want to add the tasks to");
                                int nm;
                                while (!Int32.TryParse(Console.ReadLine(), out nm))
                                {
                                    Console.WriteLine("Wrong enter. Please try again");
                                }
                                Project project = ListOfProjects[nm];
                                Console.WriteLine("Description: " + project.about + "\nDedline: " + project.dedline + "\nName of the client" + project.client +
                                    "\nStatus of the project: " + project.status);
                                byte yn;
                                if (project.status.Equals("project") & project.dedline > DateTime.Now)
                                {
                                    do
                                    {
                                        Console.WriteLine("Is this a needed project?");
                                        Console.WriteLine("1 - yes");
                                        Console.WriteLine("2 - no");
                                        while (!Byte.TryParse(Console.ReadLine(), out yn))
                                        {
                                            Console.WriteLine("Wrong enter. Please try again");
                                        }

                                        switch (yn)
                                        {
                                            case 1:
                                                NewTask.numOfTask = ListOfTasks.Count;
                                                NewTask.number = nm;
                                                NewTask.client = project.client;
                                                NewTask.number = nm;
                                                Console.WriteLine("Enter description of the task");
                                                string desc = Console.ReadLine();
                                                NewTask.about = desc;
                                                Console.WriteLine("Enter deadline of the task");
                                                DateTime ddl;
                                                while (!DateTime.TryParse(Console.ReadLine(), out ddl))
                                                {
                                                    Console.WriteLine("Wrong enter. Please try again");
                                                }
                                                NewTask.dedline = ddl;
                                                Console.WriteLine("Enter status of the task");
                                                Console.WriteLine("1 - project");
                                                Console.WriteLine("2 - in process");
                                                Console.WriteLine("3 - closed");
                                                int st2;
                                                while (!Int32.TryParse(Console.ReadLine(), out st2))
                                                {
                                                    Console.WriteLine("Wrong enter. Please try again");
                                                }
                                                if (st2 == 1)
                                                {
                                                    NewTask.status = "project";
                                                }
                                                else if (st2 == 2)
                                                {
                                                    NewTask.status = "in process";
                                                }
                                                else if (st2 == 3)
                                                {
                                                    NewTask.status = "closed";
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You entered something wrong");
                                                }
                                                Console.WriteLine("Enter name of implementer");
                                                string NameIm = Console.ReadLine();
                                                TM.name = NameIm;
                                                NewTask.name = NameIm;
                                                byte check3;
                                                do
                                                {
                                                    Console.WriteLine("Description of the task: " + desc);
                                                    Console.WriteLine("Dedline of the task: " + ddl);
                                                    Console.WriteLine("Status: " + NewTask.status);
                                                    Console.WriteLine("Name of the implementer: " + NameIm);
                                                    Console.WriteLine("Is the information correct?");
                                                    Console.WriteLine("1 - yes");
                                                    Console.WriteLine("2 - no");
                                                    while (!Byte.TryParse(Console.ReadLine(), out check3))
                                                    {
                                                        Console.WriteLine("Wrong enter. Please try again");
                                                    }
                                                    switch (check3)
                                                    {
                                                        case 1:
                                                            ListOfTasks.Add(NewTask);
                                                            continue;

                                                        case 2:
                                                            Console.WriteLine("What information is incorrect");
                                                            Console.WriteLine("1 - description");
                                                            Console.WriteLine("2 - deadline");
                                                            Console.WriteLine("3 - name of the implementer");
                                                            Console.WriteLine("4 - status");
                                                            byte check4;
                                                            while (!Byte.TryParse(Console.ReadLine(), out check4))
                                                            {
                                                                Console.WriteLine("Wrong enter. Please try again");
                                                            }
                                                            switch (check4)
                                                            {
                                                                case 1:
                                                                    Console.WriteLine("Enter new description");
                                                                    NewTask.about = Console.ReadLine();
                                                                    continue;

                                                                case 2:
                                                                    Console.WriteLine("Enter new deadline");
                                                                    while (!DateTime.TryParse(Console.ReadLine(), out ddl))
                                                                    {
                                                                        Console.WriteLine("Wrong enter. Please try again");
                                                                    }
                                                                    NewTask.dedline = ddl;
                                                                    continue;

                                                                case 3:
                                                                    Console.WriteLine("Enter new name");
                                                                    NewTask.name = Console.ReadLine();
                                                                    continue;

                                                                case 4:
                                                                    Console.WriteLine("Enter status of the project");
                                                                    Console.WriteLine("1 - project");
                                                                    Console.WriteLine("2 - in process");
                                                                    Console.WriteLine("3 - closed");
                                                                    while (!Int32.TryParse(Console.ReadLine(), out st2))
                                                                    {
                                                                        Console.WriteLine("Wrong enter. Please try again");
                                                                    }
                                                                    if (st2 == 1)
                                                                    {
                                                                        NewTask.status = "project";
                                                                    }
                                                                    else if (st2 == 2)
                                                                    {
                                                                        NewTask.status = "in process";
                                                                    }
                                                                    else if (st2 == 3)
                                                                    {
                                                                        NewTask.status = "closed";
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("You entered something wrong");
                                                                    }
                                                                    continue;
                                                            }
                                                            continue;
                                                    }
                                                }
                                                while (check3 != 1);
                                                continue;

                                            case 2:
                                                Console.WriteLine("Enter new number");
                                                while (!Int32.TryParse(Console.ReadLine(), out nm))
                                                {
                                                    Console.WriteLine("Wrong enter. Please try again");
                                                }
                                                Project project2 = ListOfProjects[nm];
                                                Console.WriteLine("Description: " + project2.about + "\nDedline: " + project2.dedline + "\nName of the client" + project2.client +
                                                    "\nStatus of the project: " + project2.status);
                                                continue;
                                        }
                                    }
                                    while (yn != 1);
 
                                }

                                else
                                {
                                    Console.WriteLine("Sorry, no task can be added now");
                                }
                                continue;

                            case 3:
                                Console.WriteLine("Enter your name");
                                string findname = Console.ReadLine();
                                Console.WriteLine("Your tasks: ");
                                for(int i = 0; i < ListOfTasks.Count; i++)
                                {
                                    Tasks task = ListOfTasks[i];
                                    if (task.name.Equals(findname))
                                    {
                                        Console.WriteLine("Number: " + i + "\nDescription: " + task.about + "\nDeadline: " + task.dedline + "\nStatus: " + task.status);
                                        Console.WriteLine("What do you want to do with this task?");
                                        Console.WriteLine("1 - delegate");
                                        Console.WriteLine("2 - take");
                                        Console.WriteLine("3 - decline");
                                        byte yn2;
                                        while (!Byte.TryParse(Console.ReadLine(), out yn2))
                                        {
                                            Console.WriteLine("Wrong enter. Please try again");
                                        }

                                        switch (yn2)
                                        {
                                            case 1:
                                                Console.WriteLine("Enter name of the person you want to delegate this task to");
                                                string delegat = Console.ReadLine();
                                                task.name = delegat;
                                                continue;

                                            case 2:
                                                task.status = "in process";
                                                continue;

                                            case 3:
                                                Dump.Add(task);
                                                ListOfTasks.RemoveAt(i);
                                                continue;
                                        }

                                    }
                                }

                                continue;

                            case 4:
                                Console.WriteLine("Enter the number of your task");
                                int num;
                                while (!Int32.TryParse(Console.ReadLine(), out num))
                                {
                                    Console.WriteLine("Wrong enter. Please try again");
                                }
                                NewTask = ListOfTasks[num];
                                NewTask.status = "done";
                                Console.WriteLine("Enter text of your report");
                                NewReport.text = Console.ReadLine();
                                Console.WriteLine("Date of report: {0}", DateTime.Now);
                                NewReport.date = DateTime.Now;
                                Console.WriteLine("Enter the name of implementer of the Task");
                                NewReport.implementer = Console.ReadLine();
                                byte yn3;
                                do
                                {
                                    Console.WriteLine("Text of report: " + NewReport.text);
                                    Console.WriteLine("Date of report: {0}", NewReport.date);
                                    Console.WriteLine("Name of implementer: " + NewReport.implementer);
                                    Console.WriteLine("Is information right?");
                                    Console.WriteLine("1 - yes");
                                    Console.WriteLine("2 - no");
                                    while (!Byte.TryParse(Console.ReadLine(), out yn3))
                                    {
                                        Console.WriteLine("Wrong enter. Please try again");
                                    }
                                    int a = 0;
                                    switch (yn3)
                                    {
                                        case 1:
                                            ListOfReports.Add(NewReport);
                                            for (int j = 0; j < ListOfTasks.Count; j++)
                                            {
                                                Tasks task = ListOfTasks[j];
                                                if (task.number.Equals(NewTask.number) & task.status != "done")
                                                {
                                                    a += 1;
                                                }
                                            }
                                            if(a == 0)
                                            {
                                                ListOfProjects.RemoveAt(NewTask.number);
                                            }
                                            continue;

                                        case 2:
                                            byte wh;
                                            Console.WriteLine("What information was wrong?");
                                            Console.WriteLine("1 - text");
                                            Console.WriteLine("2 - name of implementer");
                                            while (!Byte.TryParse(Console.ReadLine(), out wh))
                                            {
                                                Console.WriteLine("Wrong enter. Please try again");
                                            }

                                            switch (wh)
                                            {
                                                case 1:
                                                    Console.WriteLine("Enter new text");
                                                    NewReport.text = Console.ReadLine();
                                                    continue;

                                                case 2:
                                                    Console.WriteLine("Enter new name");
                                                    NewReport.implementer = Console.ReadLine();
                                                    continue;

                                            }
                                            continue;

                                    }
                                    continue;
                                }
                                while (yn3 != 1);
                                continue;

                            case 5:
                                for (int b = 0; b < Dump.Count; b++)
                                {
                                    Tasks task = ListOfTasks[b];
                                    Console.WriteLine("\nDescription: " + task.about + "\nDeadline: " + task.dedline);
                                    Console.WriteLine("Who do you want to delegate it to?");
                                    task.name = Console.ReadLine();
                                    ListOfTasks.Add(task);
                                    Dump.RemoveAt(b);
                                }
                                continue;
                        }

                    }
                    while (ch != 5);
                    

                }


            }
        }
    }
}
