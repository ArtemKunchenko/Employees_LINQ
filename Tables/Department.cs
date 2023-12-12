namespace Tables
{
    public class Department
    {
        public int DepartmentId { get; set; }   // Идентификатор отдела
        public string DepartmentName { get; set; } // Название отдела
        public int ManagerId { get; set; }        // Идентификатор менеджера отдела
        public int LocationId { get; set; }       // Идентификатор локации, где расположен отдел

        public Department(int departmentId, string departmentName, int managerId, int locationId)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            ManagerId = managerId;
            LocationId = locationId;
        }
    }
}
