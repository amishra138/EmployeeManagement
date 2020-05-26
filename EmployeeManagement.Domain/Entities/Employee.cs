namespace EmployeeManagement.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string Desgination { get; set; }
    }
}
