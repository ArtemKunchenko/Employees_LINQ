namespace Tables
{
    public class Job
    {
        public int JobId { get; set; }     // Идентификатор должности
        public string JobTitle { get; set; } // Название должности
        public decimal MinSalary { get; set; } // Минимальная зарплата
        public decimal MaxSalary { get; set; } // Максимальная зарплата

        public Job(int jobId, string jobTitle, decimal minSalary, decimal maxSalary)
        {
            JobId = jobId;
            JobTitle = jobTitle;
            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }
    }
}
