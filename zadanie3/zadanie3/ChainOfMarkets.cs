using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class ChainOfMarkets
    {
        List<Market> marketList = new List<Market>();
        double Q;
        string NameOfChain { get; set; }

        int CountOfSales { get; set; }

        double MonthlyRevenue { get; set; }
        string Owner { get; set; }
        
        public ChainOfMarkets(int _count_of_sales, double _montly_revenue,string _name_of_markets,string _owner)
        {            
            CountOfSales = _count_of_sales;
            MonthlyRevenue = _montly_revenue;
            NameOfChain = _name_of_markets;
            Owner = _owner;
            Q = Quality();
        }
        public ChainOfMarkets(int _count_of_sales, double _montly_revenue, string _name_of_markets)
        {
            CountOfSales = _count_of_sales;
            MonthlyRevenue = _montly_revenue;
            NameOfChain = _name_of_markets;
            Q = Quality();
        }
        public virtual double Quality()
        {
            return MonthlyRevenue / MonthlyRevenue;
        }
        public virtual string Info()
        {
            return $"Сеть магазинов {NameOfChain}\nКоличество продаж: {CountOfSales}\nВыручка за месяц: {MonthlyRevenue}\nКоличество магазинов:" +
                $" {CountOfMarkets()}\nВладелец: {Owner}";
        }
        public void AddMarketInList(Market market)
        {
            marketList.Add(market);
        }
        public int CountOfMarkets()
        {
            return marketList.Count();
        }
        public int GetCountOfSales
        {
            get { return CountOfSales; }
            set { }
        }
        public double GetMonthlyRevenue
        {
            get { return MonthlyRevenue; }
            set { }
        }
        public string GetNameOfChain
        {
            get { return NameOfChain; }
            set { }
        }
    }
}
