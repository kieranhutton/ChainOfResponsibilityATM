namespace ChainOfResponsibilityATM
{
    public class Client
    {
        private string _name;
        private double _inputamount;

        public Client(string name, double inputamount)
        {
            this._name = name;
            this._inputamount = inputamount;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double InputAmount
        {
            get { return _inputamount; }
            set { _inputamount = value; }
        }

        public string InputName
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}