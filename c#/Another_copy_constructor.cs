using System;
namespace program
{
    class employee
    {
        private string name;
        private int age;
       
        public employee(employee emp)
        {
            this.name = name;
            this.age = age;
        }
        public employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Details
        {
             get
             {
                return " the age of " + name + "is" + age.ToString();
             }
        }
    }
    class empDetail
    {
        static void Main()
        {
            employee emp1 = new employee("priya",23);
            employee emp2 = new employee(emp1);
            Console.WriteLine(emp2.Details);
            Console.ReadLine();
        }
    }
}


        
            
           
           
        
  
    
        

    


    

 