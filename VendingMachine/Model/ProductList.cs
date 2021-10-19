using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Products;
using System.Linq;

namespace VendingMachine.Model
{
    class ProductList : ICandyProducts, IToyProducts, ISoftDrinkProducts
    {
        //Merge product type lists from ICandyProducts, IToyProducts, ISoftDrinkProducts        

        public string Info()
        {
            //return $"{IInformation.INFOTEXT}\n {Name}\n {Phone}\n{ContactAdress}";
            return $"{ICandyProducts.}\n {Name}\n {Phone}\n{ContactAdress}";
        }

        //Misslyckade experiment
        //ICandyProducts candyProducts = new ICandyProducts();
        //string[] productList = base.
        //void ICandyProducts.CandyList() {      }
        //void ISoftDrinkProducts.Softdrinks();

        // Administrator = child, Employee = parent
        class Administrator : Employee
        {
            Employee[] employeesList;
            public int Bonus { get; set; }
            public Administrator(string name,
                                string phone,
                                string adress,
                                int salery,
                                string department,
                                Employee[] employees,
                                int bonus)
                : base(name, phone, adress, salery, department)
            {
                this.employeesList = employees;
                Bonus = bonus;
            }

            public new string Info()
            {
                return base.Info() + $"\nBonus: {Bonus}";
            }
            public override string[] TasksToDo()
            {
                string[] tasksToReturn = new string[tasks.Length];
                tasks.CopyTo(tasksToReturn, 0);
                Array.Resize(ref tasksToReturn, employeesList.Length + tasksToReturn.Length);

                int index = tasks.Length;
                foreach (Employee employee in employeesList)
                {
                    tasksToReturn[index] = "Employee: " + employee.Name;
                    index++;
                }
                return tasksToReturn;
            }
        }
}
