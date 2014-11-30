using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dkong22_Assignment_2
{
    // all the classes are declared here. So we only need to include this one file.
    public class Order
    {
        private int orderTime, orderSize;
        private double orderPrice;
        //can be buy,sell, or complete
        private String type;

        public Order(double price, int volume, String type)
        {
            this.orderPrice = price;
            this.orderSize = volume;
            this.type = type;
        }
        public void setPrice(double price) { this.orderPrice = price; }
        public double getPrice() { return orderPrice; }
        public int getSize() { return orderSize; }
        public String getType() { return type; }
        //comparators

        public static int CompareByPrice(Order order1, Order order2)
        {
            return order1.orderPrice.CompareTo(order2.orderPrice);
        }
        public static int CompareByInvPrice(Order order1, Order order2)
        {
            return order2.orderPrice.CompareTo(order1.orderPrice);
        }
    };
    public class Company
    {
        private String companyName;
        private double openPrice, lastPrice, changeNet;
        private String icon;
        List<Order> orders;
        List<Order> completed;

        public Company(String name, double openPrice)
        {
            this.companyName = name;
            this.openPrice = openPrice;
            this.lastPrice = 0;
            this.orders = new List<Order>();
            this.completed = new List<Order>();
        }
        void setLastPrice() { this.lastPrice = orders[0].getPrice(); }
        public double getLastPrice() { return this.lastPrice; }
        public int getVolume()
        {
            int volume = 0;
            foreach (Order order in completed)
            {
                volume += order.getSize();
            }
            return volume;
        }
        public double getChange()
        {
            double change=0;
            foreach (Order order in completed)
            {
                change += (order.getPrice() - this.lastPrice);
            }
            return change;
        }
        public double getPercentChange()
        {
            return (getChange() - lastPrice) / lastPrice;
        }
        public string getIcon()
        {
            double change = getChange();
            if (change > 0)
            {
                return "up.bmp";
            }
            else if (change == 0)
            {
                return "noChange.bmp";
            }
            else
            {
                return "down.bmp";
            }
        }
        public void makeOrder(Order newOrder)
        {
            if (newOrder.getType() == "buy")
            {//check if there's any corresponding sell order
                foreach (Order sellOrder in orders)
                {
                    if (sellOrder.getType() == "sell" && newOrder.getPrice() == sellOrder.getPrice()
                        && newOrder.getSize() == sellOrder.getSize())
                    {
                        //there's an order in!
                        orders.Remove(sellOrder);
                        Order completedOrder = new Order(newOrder.getPrice(), newOrder.getSize(), "complete");
                        completed.Add(completedOrder);
                        this.lastPrice = newOrder.getPrice();
                        return;
                    }
                }
            }
            else
            {
                foreach (Order buyOrder in orders)
                {
                    if (buyOrder.getType() == "buy" && newOrder.getPrice() == buyOrder.getPrice()
                        && newOrder.getSize() == buyOrder.getSize())
                    {
                        //there's an order in!
                        orders.Remove(buyOrder);
                        Order completedOrder = new Order(newOrder.getPrice(), newOrder.getSize(), "complete");
                        completed.Add(completedOrder);
                        this.lastPrice = newOrder.getPrice();
                        return;
                    }
                }
            }

            orders.Insert(0, newOrder);
        }
        public List<Order> getOrders() { return orders; }
        public List<Order> getCompleted() { return completed; }

        //getters setters
        public String getCompanyName()
        {
            return this.companyName;
        }
        public double getOpenPrice(){return openPrice;}

    };
    public interface StockMarketDisplay
    {

        void Update(List<Company> companies);

    };

    public abstract class StockMarket
    {

        public StockMarket()
        {
            observers = new List<StockMarketDisplay>();
        }
        public void Register(StockMarketDisplay observer)
        {
            observers.Add(observer);
            Console.Write("Added observer");
            notify();
        }
        public void unRegister(StockMarketDisplay observer) { }
        public abstract void notify();
        protected List<StockMarketDisplay> observers;
    };
    public class RealTimeData : StockMarket
    {
        public RealTimeData()
        {
            Company msft = new Company("Microsoft(MSFT)", 58.92);
            Company aapl = new Company("Apple(AAPL)", 67.31);
            Company fb = new Company("Facebook(FB)", 31.29);
            companies = new List<Company>();
            companies.Add(msft);
            companies.Add(aapl);
            companies.Add(fb);
        }
        private List<Company> companies;
        private String TradingDate;
        public override void notify()
        {
            foreach (StockMarketDisplay registeredObserver in observers)
            {
                registeredObserver.Update(companies);
            }
        }
        public List<String> getNames()
        {
            List<String> names = new List<String>();
            foreach (Company company in companies)
            {
                names.Add(company.getCompanyName());
            }
            return names;
        }
        public void makeOrder(String companyName, Order newOrder)
        {
            foreach (Company company in companies)
            {
                if (companyName == company.getCompanyName())
                {
                    company.makeOrder(newOrder);
                }
            }
        }
    }
    public class OrderPlacedArgs : EventArgs
    {
        public Order newOrder;
        public String companyName;
    }

};
