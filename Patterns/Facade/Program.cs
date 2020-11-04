namespace Facade
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var tripInfo = new TripInfo()
            {
                TypeOfTransport = "Air",
                TypeOfAccomondation = "Apartment",
                TypeOfGuidance = "Online",
                NumberOfAccomendationStars = 4,
                IsVisaRequred = true
            };
            TripOrginizerFacade.OrginizeTrip(tripInfo);
        }
    }
}
