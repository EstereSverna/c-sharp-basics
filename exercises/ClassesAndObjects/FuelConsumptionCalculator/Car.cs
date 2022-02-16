namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers; 
        private double _endKilometers; 
        private double _liters;

        public Car(double startOdo)
        {     
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) / _liters;
        }

        public double ConsumptionPer100Km()
        {
            return _liters * 100 / (_endKilometers - _startKilometers);
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = _endKilometers + mileage;
            _liters += liters;
        }
    }
}
