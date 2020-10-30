namespace Factory_Method
{
    class CruiseFactory : ITurFactory
    {
        public ITurPaket CreateTur()
        {
            return new Cruise();
        }
    }

}
