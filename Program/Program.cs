using Program;
using Program.Polymorphism;
#pragma warning disable
public class test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the input");
        string input = Console.ReadLine();



        IInterface source = input switch
        {
            "Test" => new MyFirstProgram(),
            "Person" => new PersonObject(),
            "static" => new Program.Math(),
            "polymorphism" => new cardTransaction(),
            "Occ" => new NoOfOcc(),
            "RD" => new RemoveDuplicate(),
            "InvalidAge" => new InvaliAge(),
            "Enc" => new Encapsulation(),
            "max" => new LargestElement(),
            "Sort" => new Sort(),
            "R" => new ReverseTheGivenNumber(),
            "R1" => new ReverseTheSentance(),
            _ => null
        };

        if(source != null)
        {
            source.Execute();
        }        
    }
}