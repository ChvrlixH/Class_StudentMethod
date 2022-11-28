namespace Class_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mezun olmaq ucun minumum teleb olunan bal: 100/61");
            Console.WriteLine("(Isteye bagli) 2-ci imtahana girmek ucun minumum teleb olunan bal: 100/81");
            Console.WriteLine("");
            Console.WriteLine("Imtahan neticesi:");
            DataBase Student1 = new DataBase("Huseyn", "Ahadzada", "P327", 77, true);
            DataBase Student2 = new DataBase("Ayxan", "Memmedov", "P327", 89, true);
            DataBase Student3 = new DataBase("Sahin", "Rehmanov", "P327", 85, true);
            DataBase Student4 = new DataBase("Vusal", "Ibrahimov", "P405", 55, false);
            DataBase Student5 = new DataBase("Resid", "Suleymanzade", "P255", 43, false);
            DataBase Student6 = new DataBase("Fikret", "Emiraslanov", "P327", 100, true);
            DataBase Student7 = new DataBase("Saleh", "Imanov", "P132", 65, true);
            Student2.Graduated();
            Console.WriteLine(Student2.Point);
            Student2.Points();

        }
    }
}