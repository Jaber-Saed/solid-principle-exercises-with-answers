//ensure that you can substitute an instance of Orange for an instance of Apple without any problems

namespace LSP.Model
{
    public class Fruit
    {
        public virtual string GetColor()
        {
            return "Unknown";
        }
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
