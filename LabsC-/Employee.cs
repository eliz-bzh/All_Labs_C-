using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    delegate void Message(MyClassEventArgs myEvent);
    class MyClassEventArgs : EventArgs
    {
        private Action action;
        public string Message { get; set; }
        public MyClassEventArgs() { }
        public MyClassEventArgs(string message)
        {
            Message = message;
        }
        public MyClassEventArgs(Action action)
        {
            this.action = action;
        }

        public void ShowMessage()
        {
            if(action == null)
            {
                Console.WriteLine(Message);
            }
            else
            {
                action.Invoke();
            }
        }
    }

    class Employee
    {
        public event Message EmployeeChanged;

        private int workerHours;
        private double tariffForHour;
        private int personnelNumber;
        private double zP;

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int PersonnelNumber
        {
            get => personnelNumber;
            set
            {
                if (value.ToString().Length < 6)
                {
                    throw new Exception("No such personnel number");
                }
                personnelNumber = value;
            }
        }
        public int WorkerHours
        {
            get => workerHours;
            set
            {
                if (value < 126)
                {
                    throw new Exception("Less than the minimum working hours");
                }
                workerHours = value;
            }
        }
        public double TariffForHour
        {
            get => tariffForHour;
            set
            {
                if (value < 1.5)
                {
                    throw new Exception("Less than the minimum tariff for hour");
                }
                tariffForHour = value;
            }
        }
        public double ZP
        {
            get => zP;
            set
            {
                zP = value;

                var handler = EmployeeChanged;
                if (handler != null)
                {
                    handler.Invoke(new MyClassEventArgs(() =>
                    {
                        Console.WriteLine("ZP Employee changed");
                    }));
                }
            }
        }

        public Employee() : this("Ivanov", "Ivan", "Ivanovich", 345265, 144, 1.5) { }
        public Employee(string surname, string name, string patronymic, int personnelNumber, int workerHours, double tariffForHour)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PersonnelNumber = personnelNumber;
            WorkerHours = workerHours;
            TariffForHour = tariffForHour;

            EmployeeChanged += Employee_Changed;
        }

        private void Employee_Changed(MyClassEventArgs args)
        {
            args.ShowMessage();
        }

        public override string ToString()
        {
            return "Surname: " + Surname +
                    "\nName: " + Name +
                    "\nPatronymic: " + Patronymic +
                    "\nPersonnelNumber: " + PersonnelNumber +
                    "\nWorkerHours: " + WorkerHours +
                    "\nTariffForHour: № " + TariffForHour +
                    "\nZP: " + ZP + "\n";
        }
    }

    class Employees
    {
        public event Message EmployessChanged;

        private List<Employee> employees;
        private List<Employee> result;
        public Employees()
        {
            EmployessChanged(new MyClassEventArgs("List Employee Created"));
        }
        public Employees(List<Employee> employees)
        {
            this.employees = employees;
            this.result = new List<Employee>();

            EmployessChanged += Employees_EmployessChanged;
            if(EmployessChanged != null)
            {
                EmployessChanged.Invoke(new MyClassEventArgs(() =>
                {
                    Console.WriteLine("List Employee Created");
                }));
            }

            InitilizeLists();
        }

        private void Employees_EmployessChanged(MyClassEventArgs myEvent)
        {
            myEvent.ShowMessage();
        }

        private void InitilizeLists()
        {
            foreach(Employee item in employees)
            {
                if(item.WorkerHours > 144)
                {
                    item.ZP = 144 * item.TariffForHour +
                        ((item.WorkerHours - 144) * (item.TariffForHour * 2));
                    item.ZP -= item.ZP * 0.13;
                    result.Add(item);
                }
                else
                {
                    item.ZP = item.WorkerHours * item.TariffForHour;
                    item.ZP -= item.ZP * 0.13;
                    result.Add(item);
                }
            }
        }

        public void PrintList()
        {
            foreach(Employee item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
