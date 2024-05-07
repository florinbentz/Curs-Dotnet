namespace Studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuam = "y";
            int contorStudenti=0;
            string nume;
            int age;
            Student[] student = new Student[5]; 
            while (continuam == "y" && contorStudenti < 5) 
            {
                Console.Write("Introduceti numele studentului: ");
                nume = Console.ReadLine();
                Console.Write("Introduceti varsta studentului: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Continuam? (y/n)");
                continuam = Console.ReadLine();
                student[contorStudenti] = new Student(nume,age);
                Console.WriteLine(student[contorStudenti].Info);
                contorStudenti++;
            }

            int averageMark = 0;
            for (int i = 0; i < contorStudenti; i++)
            {
                Console.Write("Introduceti nota studentului: " + student[i].Info + " - ");
                student[i].Mark = int.Parse(Console.ReadLine());
                if (student[i].Mark != null)
                {
                    averageMark += (int) student[i].Mark;
                }
            }
            Console.WriteLine("Media studentilor este: " + averageMark / contorStudenti);

        }
    }
}
