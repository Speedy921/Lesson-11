using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    //простой класс депозитного счета 
    class SavingsAccount
    {
        //данные уровня экземпляра
        public double currBalance;

        //cтатический эл-т данных
        public static double currInterestRate = 0.04;
        
        static SavingsAccount() //статический сконструктор
        {
            Console.WriteLine("In static ctor"); //в статическом конструкторе
            currInterestRate = 0.04;
            //перегружать статический конструктор нельзя
            //статический конструктор не может принимать параметры и иметь мод доступа
            //статический конструктор выполняется только один раз 
        }
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        //статические члены для установки/получения процентной ставки
        //статические данные безупречны в ситуации, когда есть значение,
        //которое должно быть общиим для всех обьектов в заданой категории
        public static void SetInterestRate(double newRate)
         => currInterestRate = newRate;

        public static double GetInterestRate()
         => currInterestRate;   
    }
}
