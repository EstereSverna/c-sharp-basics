namespace exercise_3
{
    internal class Odometer
    {
        private int _mileage;
        private readonly FuelGauge _fuelGauge;

        public Odometer(int mileage, FuelGauge fuelGauge)
        {
            _mileage = mileage;
            _fuelGauge = fuelGauge;
        }

        public int GetMilage()
        {
            return _mileage;
        }

        public void Drive()
        {
            if (_mileage < 1000000)
            {
               _mileage++;
            }
            else
            {
               _mileage = 0;
            }

            if (_mileage % 10 == 0)
            {
                _fuelGauge.Driving();
            }
        }
    }
}
