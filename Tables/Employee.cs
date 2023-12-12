namespace Tables
{
    public class Employee
    {
        public int EmployeeId { get; set; }     // Идентификатор сотрудника
        public string FirstName { get; set; }   // Имя сотрудника
        public string LastName { get; set; }    // Фамилия сотрудника
        public string PhoneNumber { get; set; } // Номер телефона сотрудника
        public int JobId { get; set; }       // Идентификатор должности, на которую нанят сотрудник
        public decimal Salary { get; set; }     // Зарплата сотрудника
        public decimal CommissionPct { get; set; } // Процент комиссии сотрудника (если применимо)
        public int ManagerId { get; set; }      // Идентификатор руководителя сотрудника
        public int DepartmentId { get; set; }   // Идентификатор отдела, к которому принадлежит сотрудник

        public Employee(int employeeId, string firstName, string lastName, string phoneNumber, int jobId, decimal salary, decimal commissionPct, int managerId, int departmentId)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            JobId = jobId;
            Salary = salary;
            CommissionPct = commissionPct;
            ManagerId = managerId;
            DepartmentId = departmentId;
        }
        public override string ToString()
        {
            string data = $"ID: {EmployeeId}\t" +
                $"{FirstName} " +
                $"{LastName}, " +
                $"{PhoneNumber} " +
                $"Salary: ${Salary} " +
                $"Bonus: ${CommissionPct} " +
                $"Job ID: {JobId} " +
                $"Manager ID: {ManagerId} " +
                $"Department ID: {DepartmentId}\n";
            return data;
        }
    }
}
