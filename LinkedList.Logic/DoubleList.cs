using System.Collections.Generic;

namespace LinkedList.Logic
{
    public class DoubleList<T>
    {
        public Node<T>? first;

        private Node<T>? _last;

        public DoubleList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }
        public int Count { get; set; }
        public bool IsEmpty => Count == 0;


        public void Add(T item)
        {
            var node = new Node<T>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }
        public LinkedList<T> GetBrand(string Brand)
        {
            LinkedList<T> brandList = new LinkedList<T>();
            Node<T> current = _first;

            while (current != null)
            {
                Car data = current.Data as Car;
                if (data.Brand.Equals(Brand))
                {
                    brandList.AddLast(current.Data);
                }
                current = current.Right;
            }

            return brandList;
        }
        public LinkedList<T> GetYear(int lower, int upper)
        {
            LinkedList<T> yearList = new LinkedList<T>();
            Node<T> current = _first;

            while (current != null)
            {
                Car data = current.Data as Car;
                if (data.Year >= lower && data.Year <= upper)
                {
                    yearList.AddLast(current.Data);
                }
                current = current.Right;
            }

            return yearList;
        }

        public LinkedList<T> GetPrice(decimal lower, decimal upper)
        {
            LinkedList<T> list = new LinkedList<T>();
            Node<T> current = _first;

            while (current != null)
            {
                Car data = current.Data as Car;
                if (data.Price >= lower && data.Price <= upper)
                {
                    list.AddLast(current.Data);
                }
                current = current.Right;
            }

            return list;
        }

        public LinkedList<T> GetSeveralFilters(string brand, string model, string color, int minimunYear, decimal maximunYear)
        {
            LinkedList<T> list = new LinkedList<T>();
            Node<T> current = _first;

            while (current != null)
            {
                Car data = current.Data as Car;
                if (brand.Equals("*") && model.Equals("*") && color.Equals("*")) {
                    list.AddLast(current.Data);
                }else
                if (data.Brand.Equals(brand) && data.Model.Equals(model) && data.Color.Equals(color) && minimunYear > data.Year && maximunYear < data.Year)
                {
                    list.AddLast(current.Data);
                }
                current = current.Right;
            }

            return list;
        }

        public T[] GetMinMax()
        {

            T[] result = new T[2];
            decimal min = 0;
            decimal max = 0;
            Node<T> current = _first;
            while (current != null)
            {

                Car data = current.Data as Car;
                if (min == 0)
                {
                    min = data.Price;
                    result[0] = current.Data;
                }
               
                if (data.Price > max)
                {
                    max = data.Price;
                    result[1] = current.Data;
                }
                if (data.Price < min)
                {
                    min = data.Price;
                    result[0] = current.Data;
                }
                current = current.Right;
                Console.WriteLine(data.Model);
            }
            

            return result;
        }
    }
}