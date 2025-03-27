namespace OnlineOrdering
{
    class Product
    {
        private string _name;
        private string _id;
        private double _price;
        private int _amount;


        public Product(string name, string id, double price, int amount)
        {
            _name = name;
            _id = id;
            _price = price;
            _amount = amount;
        }


        public string GetName()
        {
            return _name;
        }
        public string GetId()
        {
            return _id;
        }





        public double TotalCost()
        {
            return _price * _amount;
        }



    }
}
