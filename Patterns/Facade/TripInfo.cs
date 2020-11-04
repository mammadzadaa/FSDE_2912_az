namespace Facade
{
    partial class Program
    {
        public class TripInfo
        {
            private int numberOfAccomendationStars;

            public string TypeOfTransport { get; set; }
            public string TypeOfAccomondation { get; set; }
            public string TypeOfGuidance { get; set; }
            public bool IsVisaRequred { get; set; }
            public int NumberOfAccomendationStars
                { 
                    get => numberOfAccomendationStars;
                set
                {
                    if (value >= 0 && value <= 5) numberOfAccomendationStars = value;
                }
                }
        }
    }
}
