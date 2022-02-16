namespace DragRace
{
    public class Audi : ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp() 
        {
            currentSpeed += 10;
        }

        public void SlowDown() 
        {
            currentSpeed -= 10;
        }

        public int ShowCurrentSpeed() 
        {
            return currentSpeed;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}