namespace CarDealer.Web.Services.DTO.Car
{
    public class FullDetailCarSericeModel : CarMakeServiceModel
    {
        public int Id { get; set; }       

        public string Model { get; set; }

        public long TravelledDistance { get; set; }
    }
}
