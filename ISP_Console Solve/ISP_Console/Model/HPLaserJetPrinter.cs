namespace ISP.Model
{
    public interface IPrinter
    {
        void Print(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }

    public interface IFax
    {
        void Fax(string content);
    }

    public interface IDuplexPrinter
    {
        void PrintDuplex(string content);
    }

    public class HPLaserJetPrinter : IPrinter, IScanner, IFax, IDuplexPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string content)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string content)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string content)
        {
            Console.WriteLine("Print Duplex content");
        }
    }
    public class LiquidInkjetPrinter : IPrinter, IScanner
    {
        public void Print(string content)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string content)
        {
            Console.WriteLine("Scan content");
        }
      
    }
}
