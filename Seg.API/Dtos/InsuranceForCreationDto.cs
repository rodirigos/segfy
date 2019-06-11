namespace Seg.API.Dtos
{
    public class InsuranceForCreationDto
    {
        public string PolicyNumber { get; set; }
        public string CPFCNPJ { get; set; }
        public string IdAuto { get; set; }
        public decimal PrizeValue{get;set;}
    }
}