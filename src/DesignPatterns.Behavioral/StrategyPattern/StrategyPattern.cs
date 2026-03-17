using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.StrategyPattern
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Making payment of {amount} via credit card");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Making payment of {amount} via PayPal");
        }
    }

    public class DebitCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Making payment of {amount} via debit card");
        }
    }

    public class UpiPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Making payment of {amount} via UPI");
        }
    }

    class PaymentService
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }

    public class StrategyPattern
    {
        //public static void Main()
        //{
        //    PaymentService paymentService = new PaymentService(new CreditCardPayment());
        //    paymentService.ProcessPayment(100);
        //    paymentService = new PaymentService(new PayPalPayment());
        //    paymentService.ProcessPayment(200);
        //    paymentService = new PaymentService(new DebitCardPayment());
        //    paymentService.ProcessPayment(300);
        //    paymentService = new PaymentService(new UpiPayment());
        //    paymentService.ProcessPayment(400);
        //}
    }
}
