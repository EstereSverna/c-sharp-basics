namespace exercise_3
{
    internal class FuelGauge
    {
        protected int _amountOfFuel;

        public FuelGauge()
        {
            _amountOfFuel = 0;
        }

        public void Fuel()
        {
            if(_amountOfFuel<70)
            {
                _amountOfFuel++;
            }
        }

        public void Driving()
        {
            if (_amountOfFuel > 0)
            {
                _amountOfFuel--;
            }
        }

        public int GetAmountOfFuel()
        {
            return _amountOfFuel;
        }
    }
}
