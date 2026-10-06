using System;
using System.Collections;

class Student
{
    private String nume;
    private int an;
    private float nota1,nota2,nota3;

    public Student(String nume,int an,float nota1,float nota2,float nota3)
    {
        this.nume = nume;
        this.an = an;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
    }

    public String toString()
    {
        return "nume: " + nume + '\n' + "an: " + an + '\n' + "note: " + nota1 + ' ' + nota2 + ' ' + nota3;
    }
    public float Medie()
    {
        return (nota1 + nota2 + nota3)/3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());
        Student[] student = new Student[n];
        Student ceaMaiMareMedie = null;
        String name;
        int an;
        float nota1,nota2,nota3;

        for(int i = 0;i < n;i++)
        {
            Console.Write("Nume: ");
            name = Console.ReadLine();
            Console.Write("An: ");
            an = int.Parse(Console.ReadLine());
            Console.Write("Nota 1: ");
            nota1 = float.Parse(Console.ReadLine()); 
            Console.Write("Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            student[i] = new Student(name,an,nota1,nota2,nota3);
            if(ceaMaiMareMedie == null)
            {
                ceaMaiMareMedie = student[i];
            }
            else
            {
                if(ceaMaiMareMedie.Medie() < student[i].Medie())
                    ceaMaiMareMedie = student[i];
            }
        }
        Console.WriteLine("Studentul cu cea mai mare medie: ");
        Console.WriteLine(ceaMaiMareMedie.toString());
    }
}