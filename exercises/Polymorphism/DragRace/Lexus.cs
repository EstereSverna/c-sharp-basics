using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
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

        public void UseNitrousOxideEngine() 
        {
            currentSpeed += 30;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}