namespace DataAccess.ViewModels
{
    public class MaterialObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public decimal PricePerUnit { get; set; }
        public string UnitIndicator { get; set; }
        public int CategoryId { get; set; }
        
    }
}
