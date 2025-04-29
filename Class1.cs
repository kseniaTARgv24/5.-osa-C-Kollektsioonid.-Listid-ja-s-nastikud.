using System;

public class Class1
{
	public Class1()
	{
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt"); //@"..\..\..\Kuud.txt"
            StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
            Console.WriteLine("Sisesta mingi tekst: ");
            string lause = Console.ReadLine();
            text.WriteLine(lause);
            text.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Mingi viga failiga");
        }
    }
}
