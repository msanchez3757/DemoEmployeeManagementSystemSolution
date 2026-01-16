namespace BaseLibrary.Entities
{
    public class Country : BaseEntity
    {
        //one to many relationship with cities
        public List<City>? Cities { get; set; }
    }
}
