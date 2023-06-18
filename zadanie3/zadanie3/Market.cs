using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Market : ChainOfMarkets
    {
        double P;
        ChainOfMarkets chainOfMarkets;
        string Adress
        {
            set { Adress = value;}
            get { return Adress; }
        }
        int NumberOfBuyers
        {
            set { NumberOfBuyers = value; }
            get { return NumberOfBuyers; }
        }
        string SurnameOfDirector
        {
            set { SurnameOfDirector = value; }
            get { return SurnameOfDirector; }
        }
        int NumberOfEmployees
        {
            set { NumberOfEmployees = value; }
            get { return NumberOfEmployees; }
        }
        public Market(ChainOfMarkets _chainOfMarkets, string _adress, string surnameOfDirector, int numberOfEmployees, int _number_of_buyers) :
            base(_chainOfMarkets.GetCountOfSales, _chainOfMarkets.GetMonthlyRevenue, _chainOfMarkets.GetNameOfChain)
        {
            chainOfMarkets = _chainOfMarkets;
            Adress = _adress;
            SurnameOfDirector = surnameOfDirector;
            NumberOfEmployees = numberOfEmployees;
            NumberOfBuyers = _number_of_buyers;
            P = Quality();
        }
        public override double Quality()
        {
            if (NumberOfBuyers > 50000)
            {
                return 2 * base.Quality();
            }
            else
                return base.Quality() * 0.5;
        }
        public override string Info()
        {
            return $"Магазин {chainOfMarkets.GetNameOfChain}\nАдрес: {Adress}\nКоличество покупателей: {NumberOfBuyers}\n" +
                $"Количество сотрудников:{NumberOfEmployees}\nФамилия директора: {SurnameOfDirector}";
        }
    }
}
