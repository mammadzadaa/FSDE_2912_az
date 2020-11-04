namespace Facade
{
    partial class Program
    {
        public static class TripOrginizerFacade
        {
            public static void OrginizeTrip(TripInfo tripInfo)
            {
                if (tripInfo.TypeOfTransport == "Air")
                {
                    TransportOrginizer.OrderAirplaneTickets();
                }
                else if (tripInfo.TypeOfTransport == "Ground")
                {
                    TransportOrginizer.OrderBusTickets();
                }

                if (tripInfo.TypeOfAccomondation == "Hotel")
                {
                    AcomondationOrginizer.BookHotel(tripInfo.NumberOfAccomendationStars);
                }
                else if (tripInfo.TypeOfAccomondation == "Apartment")
                {
                    AcomondationOrginizer.BookApartment(tripInfo.NumberOfAccomendationStars);
                }
                if (tripInfo.TypeOfGuidance == "Online")
                {
                    GuidenceOrginizer.GetOnlineGuidance();
                }
                else if (tripInfo.TypeOfGuidance == "Offline")
                {
                    GuidenceOrginizer.GetOfflineGuidance();
                }
                if (tripInfo.IsVisaRequred)
                {
                    VisaOrginizer.GetVisa();
                }

            }
        }
    }
}
