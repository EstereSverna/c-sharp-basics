namespace exercise8
{
    public class InvalidBasePayOrHours : System.Exception
    { 
        public InvalidBasePayOrHours() : base("base pay should be larger than 8, hours less than 60")
        {
              
        }

        public InvalidBasePayOrHours(string message) : base(message)
        {

        }

        public InvalidBasePayOrHours(string message, System.Exception exception) : base(message, exception)
        {

        }

    }
}
