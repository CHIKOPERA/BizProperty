namespace Domain.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public int ParentLocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ZipCode { get; set; }
    }
}