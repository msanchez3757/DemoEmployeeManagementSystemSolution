namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        // one to many with employee
        public List<Employee>? Employees { get; set; }

        //many to one relationship with City
        public City? City { get; set; }
        public int CityId { get; set; }
    }
}
