namespace BaseLibrary.Entities
{
    public class SanctionType : BaseEntity
    {
        // many to one relationship with vacation
        public List<Sanction>? Sanctions { get; set; }
    }
}
