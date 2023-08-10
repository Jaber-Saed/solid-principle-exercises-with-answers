//You should design your code in a way that allows you to add new functionality without modifying existing code.
//implementation of the Open/Closed Principle (OCP) using the strategy pattern
// It includes several classes and an interface to handle different discount calculation strategies for different types of invoices
namespace OCP2.Model
{
    public class Invoice
    {
        private IDiscountStrategy _discountStrategy;
        // _discountStrategy will be able to store instances of classes that implement the IDiscountStrategy interface
        //This is the name of the field. It follows the naming convention of using an underscore
        //(_) prefix to indicate that it's a private field.
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double GetInvoiceDiscount(double amount)
        {
            return _discountStrategy.CalculateDiscount(amount);
        }
    }

    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    };
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);
    }

    public class FinalInvoiceDiscountStrategy : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount - 100;
        }
    }

    public class ProposedInvoiceDiscountStrategy : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount - 50;
        }
    }

}
