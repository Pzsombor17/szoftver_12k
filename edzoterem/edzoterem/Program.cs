namespace edzoterem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Member newwmember1 = new Member("Kovacs Pista",19,true);
            Member newmember2 = new Member("Kalács Roland",21,false);
            membership newmembership1 = new membership(newwmember1,20000,12);
            membership newmembership2 = new membership(newmember2,10000,6);
        }
    }
}
