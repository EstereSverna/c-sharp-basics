namespace AdApp
{
    internal class Poster : Advert
    {
        private int _copiesAmount;
        private int _costOfCopy;

        public Poster(int fee, int copies, int costOfCopy) : base(fee)
        {
            _copiesAmount = copies;
            _costOfCopy = costOfCopy;
        }

        public override int Cost()
        {
            return base.Cost() + _costOfCopy * _copiesAmount;
        }

        public override string ToString()
        {
            return "Poster: " + Cost();
        }
    }
}
