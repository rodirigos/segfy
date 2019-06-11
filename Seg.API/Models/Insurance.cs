namespace Seg.API.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public string CPFCNPJ { get; set; }
        public string IdAuto { get; set; }
        public decimal PrizeValue{get;set;}
    }
}