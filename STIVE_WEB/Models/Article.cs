namespace STIVE_WEB.Models
{
    public class Article
    {
        public string Id { get; set; }
        public string YearId { get; set; }
        public int? Year { get; set; }
        public string CapacityId { get; set; }
        public string? Capacity { get; set; }
        public string CepageId { get; set; }
        public string? Cepage { get; set; }
        public string FamilyId { get; set; }
        public string? Family { get; set; }
        public string SupplierId { get; set; }
        public string? Supplier { get; set; }
        public string Name { get; set; }
        public string Ref { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }

        //Constructeur de l'article
        public Article(string id, string yearId, int? year, string capacityId, string capacity, string cepageId, string cepage, string familyId, string family, string supplierId, string supplier, string name, string @ref, string description, double unitPrice)
        {
            Id = id;
            YearId = yearId;
            Year = year;
            CapacityId = capacityId;
            Capacity = capacity;
            CepageId = cepageId;
            Cepage = cepage;
            FamilyId = familyId;
            Family = family;
            SupplierId = supplierId;
            Supplier = supplier;
            Name = name;
            Ref = @ref;
            Description = description;
            UnitPrice = unitPrice;
        }

    }
}
