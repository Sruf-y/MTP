
using MTP;

class Program
{
    static void Main()
    {


        Console.WriteLine(TimeOnly.Parse(DateTime.Now.ToString()));
    }




   static void exercitiul4()
    {
        Student a=new Student("Andrei");
        a.name = "Botofan";
        Console.WriteLine(a.name);
    }




    static void exercitiul3()
    {
        // incearca o adunare ce v-a da overflow, verificand overflow cu cuvantul 'checked'

        short a = short.MaxValue;
        short b = 1;

        try
        {
            short suma = checked((short)(a + b));
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }



    static void exercitiul2()
    {
        //compara o data citita de la tastatura cu data de azi si spune cat timp a trecut de atunci pana acum
        
        Console.Write("Introdu data: ");
        int zi = int.Parse(Console.ReadLine());
        int luna = int.Parse(Console.ReadLine());
        int an = int.Parse(Console.ReadLine());

        DateTime date = DateTime.Parse(an + "-" + luna + "-" + zi);

        int yearssince = DateTime.Now.Subtract(date).Days/365;

        Console.WriteLine(yearssince);
    }




    static void exercitiul1()
    {
        // scrie o lista de elemente dinamice, si folosind o comanda de tip SQL gaseste unele care indeplinesc o conditie anume

        List<dynamic> list = new List<dynamic>();

        list.Add(new { id = 3134, nume = "Andrei", nota = 9 });
        list.Add(new { id = 1827, nume = "Alex", nota = 2 });
        list.Add(new { id = 1827, nume = "Eris", nota = 5 });
        list.Add(new { id = 2155, nume = "Sasa", nota = 8 });
        list.Add(new { id = 8536, nume = "Baloo", nota = 4 });


        foreach (dynamic item in list.Where(n => n.nota >= 5))
        {
            Console.WriteLine(item);
        }
        // acelasi lucru, dar scris diferit
        foreach (dynamic item in (from n in list where n.nota>=5 select n))
        {
            Console.WriteLine(item);
        }
    }
}

