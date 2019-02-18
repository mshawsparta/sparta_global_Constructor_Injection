using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjection
{
    class Program
    {
        static void Main(string[] args)
        {


            
            
            string greet1 = Student.sayHello();
            string greet2 = Staff.sayHello();
            Console.WriteLine(greet1);
            Console.WriteLine(greet2);
            Console.Read();
            
            
            
        }
    }
    interface IPerson
    {
        void setName(string name);
        string sayHello();

    }
     class  Student
    {
        string name;
       
       public  void setName(string name)
        {
            this.name = name;
        }
        public static string sayHello()
        {
            return "Hello I like learning ";
        }
        
    }
    class Staff 
    {
        string name;

        public void setName(string name)
        {
            this.name = name;
        }

        public static string sayHello()
        {
            return "Hello I like School";
        }


    }
    class Teacher : Staff, IPerson
    {
        string name;

        public void setName(string name)
        {
            this.name = name;
        }

        public string sayHello()
        {
            return "Hello I like Teaching";
        }
    }

}
    

