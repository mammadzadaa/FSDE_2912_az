namespace Chain_of_Responsibility
{
    interface IBankOperationHandeler
    {
        public IBankOperationHandeler Next { get; set; }
        public void Handle(string cardNumber, string cardPin, decimal amount);
    }

}
