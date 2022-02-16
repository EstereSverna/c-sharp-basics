using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp() 
        {
            currentSpeed += 15;
        }

        public void SlowDown() 
        {
            currentSpeed -= 15;
        }

        public int ShowCurrentSpeed() 
        {
            return currentSpeed;
        }

        public string StartEngine() 
        {
            return "-- silence ---";
        }
    }
}