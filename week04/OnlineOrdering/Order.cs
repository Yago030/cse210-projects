namespace OnlineOrdering
{
    class Order
    {

        private Customer _customer;
        private List<Product> _products = new List<Product>();




        public Order(Customer customer)
        {
            _customer = customer;
        }



        public void AddProduct(Product product)
        {
            _products.Add(product);
        }


        public double GetTotalPrice()
        {
            double total = 0;

            foreach (var product in _products)
            {
                total += product.TotalCost();
            }

            if (_customer.IsInUsaCustomer())
            {
                total += 5;
            }
            else
            {
                total += 35;
            }
            return total;
        }


        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in _products)
            {
                label += $"- {product.GetName()} (ID: {product.GetId()})\n";
            }
            return label;
        }


        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
        }



    }
}
