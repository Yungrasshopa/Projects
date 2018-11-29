using System;

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string empName;

        // Accessor (get method)
        public string GetName()
        {
            return empName;
        }
        // Mutator (set method)
        public void SetName(string name)
        {
            // Do a check on incoming value
            if(name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            else
                empName = name;
        }

        /***** Updating get/set using property syntax *****/
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }


        private int empID;

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        private float currPay;

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        // Constructors.
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, id, pay, 0) { }

        public Employee(string name, int id, float pay, int age)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }

        // Methods
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Age: {0}", Age);
        }

        private int empAge;
        public int Age
        {
            get => empAge;
            set => empAge = value;
        }
    }
}
