namespace DragRace
{
    public class Lada : ICar
    {
        private int _currentSpeed = 0;
        public int ShowCurrentSpeed()
        {
            return _currentSpeed;
        }

        public void SlowDown()
        {
            _currentSpeed -= 50;
        }

        public void SpeedUp()
        {
            _currentSpeed += 50;
        }

        public string StartEngine()
        {
            return ".--- rum rum rum ----";
        }
    }
}
