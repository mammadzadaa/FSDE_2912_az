namespace Factory_Method
{
    class SafariFactory : ITurFactory
    {
        public ITurPaket CreateTur()
        {
            return new Safari();
        }
    }

}
