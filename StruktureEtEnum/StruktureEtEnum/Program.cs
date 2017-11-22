using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StruktureEtEnum
{          
   public enum Food
    {
        carrot=1,
        fish,
        mouse,
        bird,
        rabbit,
        meat
    }
    public class Cat
    {
        public string name;
        public int full { get; set; }

        public Cat() { }
        public Cat(int full, string name)
        {
            this.name = name;
            this.full = full;
        }

        public void Eat(Food s)
        {
           bool hungry = true;
                Console.WriteLine();
            while (hungry)
            {
                Console.WriteLine("Покорми кота!");
                switch (s)
                {
                    case Food.carrot:
                        Console.WriteLine("Вы покормили кота");
                        full += 10;
                        Console.WriteLine("уровень сытости = " + full);
                     break;
                    case Food.fish:
                        Console.WriteLine("Вы покормили кота");
                        full += 15;
                        Console.WriteLine("уровень сытости  = " + full);
                       break;
                    case Food.mouse:
                        Console.WriteLine("Вы покормили кота");
                        full += 35;
                        Console.WriteLine("уровень сытости  = " + full);
                        break;
                    case Food.bird:
                        Console.WriteLine("Вы покормили кота");
                        full += 48;
                        Console.WriteLine("уровень сытости  = " + full);
                       break;
                    case Food.rabbit:
                        Console.WriteLine("Вы покормили кота");
                        full += 55;
                        Console.WriteLine("уровень сытости  = " + full);
                       break;
                    case Food.meat:
                        Console.WriteLine("Вы покормили кота");
                        full += 75;
                        Console.WriteLine("уровень сытости  = " + full);
                       break;
                    default:
                        Console.WriteLine("Котэ сыт");
                        break;
                }
                if (full >=90)
                {
                    Console.WriteLine("Остановись, кот не резиновый, пора худеть..!!");
                    hungry = false;
                 }
                else
                {
                    Console.WriteLine("\t\tПокорми кота!");
                    Console.Read();
                }

            }
        }

    }


    class Program
    {

        
        struct Employee
        {
            public string name;
            public Vacancies vacancy;
            public int salaries;
            public int[] dateStart;


            public Employee(string n, Vacancies v, int s, int[] dS)
            {
                this.name = n;
                this.vacancy = v;
                this.salaries = s;
                this.dateStart = dS = new int[3];
                
            }

            public void print()
            {
                Console.Write("{0}: Профессия-{1},\n Доход в месяц - {2} $,\n Дата поступления- ",name, vacancy,salaries);
                for(int i = 0; i < 3; i++)
                {
                    Console.Write(dateStart[i] + ".");
                }
            }
        }
        enum Vacancies {
            Boss=1,
            Manager,
            Clerk,
            Secretaire,
            Salesman,
            Cleaner,
            Postman,
            Driver
        }

       
struct Student
        {
            public string name;
            public string group;
            public double rating;
            public double benefit;
            public Gender genders;
            public Study studyTime;

            public Student(string name,string group,double rating,double benefit,Gender genders,Study studyTime)
            {
                this.name=name;
                this.group=group;
                this.rating=rating;
                this.benefit=benefit;
                this.genders=genders;
                this.studyTime=studyTime;
        }
            /*
2.	Для получения места в общежитии формируется список студентов, 
который включает Ф.И.О. студента, группу, средний балл, доход на члена семьи, пол (перечисление),
форма обучения(перечисление). 

           Общежитие в первую очередь предоставляется тем, 
у кого доход на члена семьи меньше двух минимальных зарплат, затем остальным в порядке 
уменьшения среднего балла. Вывести список очередности предоставления мест в общежитии.
*/
           /* public void Dormitory()
            {
                List<Student> students = new List<Student>();
                List<Student> st2 = new List<Student>();
                double MZP = 24459.0;
                if (benefit < (MZP * 2))
                {
                    students.Add();
                }
                else
                {
                    st2.Add(s);
                }
                students.Sort();
                st2.Sort();
                foreach(var i in students)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                foreach (var i in st2)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
            }*/
        }
      enum Gender
        {
            masculine,
            female
}

      enum Study
        {
            fullTime,
            distance,

        }
        static void Main(string[] args)
        {
         

            #region

            /*
4.	Создайте класс Кошка. У кошки будет свойство «уровень сытости» и метод «съесть что-то».
Создайте перечисление Еда (рыба, мышь…). Каждый вид еды должен по-разному изменять уровень сытости.
*/
            /*     Console.WriteLine("Покорми кота!");

                 Console.WriteLine("Сегодня на ужин");
                 Console.WriteLine();
                 Food catFood;
                 for (catFood = Food.carrot; catFood <= Food.meat; catFood++)
                 {
                     Console.WriteLine((int)catFood+" "+ catFood+" ");
                 }
                 var cat = new Cat();
                 Console.WriteLine("Выбери чем будешь кормить кота");
                int getFood = Int32.Parse(Console.ReadLine());
                 switch (getFood)
                 {
                     case 1:
                         cat.Eat(Food.carrot);
                         break;
                     case 2:
                         cat.Eat(Food.fish);
                         break;
                     case 3:
                         cat.Eat(Food.mouse);
                         break;
                     case 4:
                         cat.Eat(Food.bird);
                         break;
                     case 5:
                         cat.Eat(Food.rabbit);
                         break;
                     case 6:
                         cat.Eat(Food.meat);
                         break;
                     default:

                         break;
                 }


                 Console.WriteLine();*/


            #endregion

            #region
            /*
5.	Создать структуру «Employee» состоящую из:
a.	поля name строкового типа;
b.	поля vacancy типа Vacancies;
c.	поля зарплата целого типа;
d.	поля дата приема на работу типа int[3].
*/
            /*
             ConsoleWriteLie("Создать структуру «Employee» ..");
                        Employee empoie;
                        empoie.name = "Nicolas";
                        empoie.vacancy = Vacancies.Manager;
                        empoie.salaries = 250;
                        empoie.dateStart = new int[3];
                        empoie.dateStart[0] = 01;
                        empoie.dateStart[1] = 07;
                        empoie.dateStart[2] = 2010;

                        empoie.print();
                        Console.WriteLine();
                        */
            #endregion

            #region
            // 3.Создать перечисление должностей Vacancies { Manager, Boss, Clerk, Salesman, и т.д.}

            /*    Console.WriteLine("Создать перечисление должностей Vacancies..."); 
                 Vacancies jobs;
                 for (jobs = Vacancies.Boss; jobs <= Vacancies.Driver; jobs++)
                 {
                     Console.WriteLine("Должность:\"{0}\", уровень {1}", jobs, (int)jobs);
                 }
                 Console.WriteLine();

         */

            #endregion

        }
    }
}
