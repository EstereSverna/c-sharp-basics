namespace AdApp
{
    public class TVAd: Advert
    {
        private int _feePerSecond;
        private int _seconds;
        private bool _isPeakTime;

        public TVAd(int fee, int feePerSecond, int seconds, bool isPeakTime) : base(fee)
        {
            _feePerSecond = feePerSecond;
            _seconds = seconds;
            _isPeakTime = isPeakTime;
        }
        
        public override int Cost() 
        {
            if (_isPeakTime)
            {
                return base.Cost() + _feePerSecond * _seconds * 2;
            }
            else
            { 
                return base.Cost() + _feePerSecond * _seconds;
            }
        }

        public override string ToString() 
        {
            return "TV add: " + Cost();
        }
    }
}