using Tables;

namespace Employees_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region REGION
            Region europe = new Region(1, "Europe");
            List<Region> regions = new List<Region>();
            regions.Add(europe);
            #endregion

            #region COUNTRY
            Country ukraine = new Country(1, "Ukraine");
            List<Country> countries = new List<Country>();
            countries.Add(ukraine);
            #endregion

            #region LOCATION
            Location kyiv = new Location(1, "Peremogy str. 1", "Kyiv", "Kyiv", ukraine);
            Location lviv = new Location(2, "Rynok sqr. 2", "Lviv", "Lviv", ukraine);
            Location kharkiv = new Location(3, "Symskya str. 3", "Kharkiv", "Kharkiv", ukraine);
            Location severodonetsk = new Location(4, "Khimikiv av. 4", "Severodonetsk", "Lychansk", ukraine);
            List<Location> locations = new List<Location>();
            locations.Add(kyiv);
            locations.Add(lviv);
            locations.Add(kharkiv);
            locations.Add(severodonetsk);
            #endregion

            #region DEPARTMENS
            Department it = new Department(1, "IT", 1, 1);
            Department sales = new Department(2, "Sales", 2, 2);
            Department projects = new Department(3, "Projects", 3, 3);
            Department humanResourses = new Department(4, "Human resourses", 0, 4);
            List<Department> departments = new List<Department>();
            departments.Add(it);
            departments.Add(sales);
            departments.Add(projects);
            departments.Add(humanResourses);
            #endregion

            #region JOB
            Job teamlid = new Job(1, "Teamlid", 10000, 15000);
            Job seniorDeveloper = new Job(2, "Senior developer", 8000, 9000);
            Job midleDeveloper = new Job(3, "Midle developer", 6000, 7000);
            Job juniorDeveloper = new Job(4, "Junior developer", 4000, 5000);

            Job salesManager = new Job(5, "Sales manager", 10000, 15000);
            Job accountant = new Job(6, "Accountant", 5000, 6000);
            Job managerAssistant = new Job(7, "Manager assistant", 2000, 3000);

            Job projectManager = new Job(8, "Project manager", 10000, 15000);
            Job analyst = new Job(9, "Analyst", 4000, 7000);

            List<Job> jobs = new List<Job>();
            jobs.Add(teamlid);
            jobs.Add(seniorDeveloper);
            jobs.Add(midleDeveloper);
            jobs.Add(juniorDeveloper);
            jobs.Add(salesManager);
            jobs.Add(accountant);
            jobs.Add(managerAssistant);
            jobs.Add(projectManager);
            jobs.Add(analyst);

            #endregion

            #region EMPLOYEE
            Employee employee1 = new Employee(1, "Alexander", "Mitchel", "050-123-4567", 1, 15000, 500, 0, 1);
            Employee employee2 = new Employee(2, "Olivia", "Johnson", "066-234-5678", 5, 12000, 200, 0, 2);
            Employee employee3 = new Employee(3, "Benjamin", "Turner", "093-345-6789", 8, 13000, 300, 0, 3);
            Employee employee4 = new Employee(4, "Sophia", "Reynolds", "067-456-7890", 2, 8500, 100, 1, 1);
            Employee employee5 = new Employee(5, "Henry", "Baker", "050-567-8901", 3, 6800, 50, 1, 1);
            Employee employee6 = new Employee(6, "Emma", "Thompson", "066-678-9012", 4, 4500, 0, 1, 1);
            Employee employee7 = new Employee(7, "Liam", "Davis", "093-789-0123", 4, 4000, 0, 1, 1);
            Employee employee8 = new Employee(8, "Ava", "Martinez", "067-890-1234", 6, 5500, 50, 2, 2);
            Employee employee9 = new Employee(9, "Jackson", "White", "050-901-2345", 6, 5100, 0, 2, 2);
            Employee employee10 = new Employee(10, "Grace", "Taylor", "066-012-3456", 7, 2100, 0, 2, 2);
            Employee employee11 = new Employee(11, "Oliver", "Harris", "093-123-4567", 9, 6900, 700, 3, 3);
            Employee employee12 = new Employee(12, "Isabella", "Clark", "067-234-5678", 9, 4800, 0, 3, 3);
            Employee employee13 = new Employee(13, "Elijah", "Walker", "050-345-6789", 7, 2500, 0, 3, 3);
            Employee employee14 = new Employee(14, "Henry", "Moore", "066-456-7890", 7, 2900, 0, 3, 3);

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);
            employees.Add(employee11);
            employees.Add(employee12);
            employees.Add(employee13);
            employees.Add(employee14);
            #endregion

            //a)	Получить список с информацией обо всех сотрудниках
            //var query = from e in employees
            //            orderby e.EmployeeId
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //b)	Получить список всех сотрудников с именем 'Henry'
            //var query = from e in employees
            //                     where e.FirstName == "Henry"
            //            orderby e.LastName
            //            select e;            
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //c)	Получить список всех сотрудников с JobId равным '7'
            //var query = from e in employees
            //                          where e.JobId == 7
            //                          select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //d)	Получить список всех сотрудников из 1 отдела (DepartmentId) с зарплатой(salary), большей 5000
            //var query = from e in employees
            //            where e.DepartmentId == 1 && e.Salary > 5000
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //e)	Получить список всех сотрудников из 1 и из 3 отдела (DepartmentId)
            //var query = from e in employees
            //            where e.DepartmentId == 1 || e.DepartmentId == 3
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //f)	Получить список всех сотрудников у которых последняя буква в имени равна 'a'
            //var query = from e in employees
            //            where e.FirstName.EndsWith("a")
            //            orderby e.FirstName
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //g)	Получить список всех сотрудников из 1 и из 2 отдела (DepartmentId) у которых есть бонус (значение в колонке CommissionPct не равно 0)
            //var query = from e in employees
            //            where (e.DepartmentId == 1 || e.DepartmentId == 2) && e.CommissionPct != 0
            //            orderby e.CommissionPct
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //h)	Получить список всех сотрудников у которых в имени содержатся минимум 2 буквы 'n'
            //var query = from e in employees
            //            where e.FirstName.Count(c => c == 'n') >= 2
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //i)	Получить список всех сотрудников у которых зарплата находится в промежутке от 4500 до 5500 (включительно)
            //var query = from e in employees
            //            where e.Salary >= 4500 && e.Salary <= 5500
            //            orderby e.Salary
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //j)	Получить список всех сотрудников у которых в имени содержится символ 'j'
            //var query = from e in employees
            //            where e.FirstName.Contains('j')
            //            orderby e.EmployeeId
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //k)	Получить список всех ID менеджеров
            //var query = (from e in employees where e.ManagerId !=0 select e.ManagerId).Distinct();
            //foreach (var id in query)
            //{
            //    Console.WriteLine($"Manager ID: {id}");
            //}

            //l)	Получить список всех сотрудников у которых длина имени больше 6 букв
            //var query = from e in employees
            //            where e.FirstName.Length > 6
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //m)	Получить список всех сотрудников у которых в имени есть буква 'b' (без учета регистра)
            //var query = from e in employees
            //            where e.FirstName.Contains("b", StringComparison.OrdinalIgnoreCase)                        
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //n)	Получить список всех сотрудников у которых в имени содержатся минимум 2 буквы 'a'
            //var query = from e in employees
            //            where e.FirstName.Count(c => c == 'a') >= 2
            //            select e;
            //foreach (var employee in query)
            //{
            //    Console.WriteLine(employee);
            //}

            //o)	Получить список всех сотрудников зарплата которых кратна 1000
            var query = from e in employees
                        where e.Salary % 1000 == 0
                        select e;
            foreach (var employee in query)
            {
                Console.WriteLine(employee);
            }


            Console.ReadKey();
        }
    }
}