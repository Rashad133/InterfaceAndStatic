using Static_Interface_16._10.Models;

namespace Static_Interface_16._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telebe adini daxil etsin: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Telebe soyadin daxil etsin: ");
            string stundentSurname = Console.ReadLine();

            if(Student.CheckName(studentName) && Student.CheckName(stundentSurname))
            {
                Student student = new Student(studentName, stundentSurname);
        
                Console.WriteLine($"Telebe adi: {student.Name}");
                Console.WriteLine($"Telebe soyadi: {student.Surname}");
                Console.WriteLine($"Telebe Id: {student.Id}");
                Console.WriteLine($"Telebenin E-mail: {student.CodeEmail}");
            }

            else
            {
                Console.WriteLine("Sehv ad ve soyad daxil edildi");
            }
        }
    }
}