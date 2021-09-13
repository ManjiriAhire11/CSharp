//Rectify compile time errors if any , let us know the output of following code:

using System;
class samplee
{
    public static void IFutureMethod()
    {
        Console.WriteLine("IFutureMethod method");
    }
    public void ZensarMethod(string s)
    {
        first();
        Console.WriteLine("ZensarMethod method");
    }

    public void first()
    {

    }

    public void ZensarMethod(int i)
    {
        Console.WriteLine(i);
        ZensarMethod();
    }

    private void ZensarMethod()
    {
        throw new NotImplementedException();
    }
}
class Program
{
    static void Main(string[] args)
    {
        samplee obj = new samplee();
        obj.first();
        obj.ZensarMethod("Akkki");
        Console.Read();
    }
}


 
           
                
