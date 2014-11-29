using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dkong22_Assignment_2
{
	// all the classes are declared here. So we only need to include this one file.
	class Order{
	private int orderTime,orderSize;
		private double orderPrice;
		private String type;
	
		public Order(double price,int volume,String type){
			this.orderPrice = price;
			this.orderSize = volume;
			this.type = type;
		}
		public void setPrice(double price){this.orderPrice = price;}
		public double getPrice(){return orderPrice;}
		public int getSize(){return orderSize;}
		public String getType(){return type;}
	};
	class Company{
	
		private String companyName;
		private double openPrice,lastPrice,changeNet;
		private String icon;
		List<Order> orders;
	
		public Company(String name, double openPrice){
		}
		void setLastPrice(){this.lastPrice = orders[0].getPrice();}
		double getLastPrice(){return this.lastPrice;}
		int getVolume(){
			int volume = 0;
			for(int i = 0;i>orders.Count();i+=1){
				volume+=orders[i].getSize();
			}
			return volume;
		}
		void makeOrder(Order newOrder){orders.Insert(0,newOrder);}
	};
	public abstract class StockMarketDisplay {

        public abstract void Update();
	};

	public abstract class StockMarket {

        public StockMarket() {
            observers = new List<StockMarketDisplay>();
        }
		public void Register(StockMarketDisplay observer){observers.Add(observer);}
		public void unRegister(StockMarketDisplay observer){}
		public void notify(){}
	private List<StockMarketDisplay> observers;
	};
	public class RealTimeData : StockMarket{
		private List<Company> companies;
		private String TradingDate;
		public RealTimeData(){}
		public void Update(){}

	};
}
