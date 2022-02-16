namespace DragRace
{
    public class Volvo : ICar, IBoostable
    {
        private int _currentSpeed = 0;
        public int ShowCurrentSpeed()
        {
            return _currentSpeed;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public void SpeedUp()
        {
            _currentSpeed += 5;
        }

        public string StartEngine()
        {
            return "...rrrrrr.....";
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 100;
        }
    }
}
