namespace Survivor.Data.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; }
    }
}
