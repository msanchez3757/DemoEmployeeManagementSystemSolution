namespace BaseLibrary.Entities
{
    public class Branch : BaseEntity
    {
        // many to one relationship with Department
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }

        // one to many relationship with Employee
        public List<Employee>? Employees { get; set; }
    }
}
