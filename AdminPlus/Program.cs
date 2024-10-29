using System.Collections;

namespace AdminPlus
{
    internal class Program
    {
        static void Main()
        {
            ArrayList adminPlus = new ArrayList();
            Console.Write("How many students: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AddStudent(adminPlus);
            }
            Remove(adminPlus);
            AddStudent(adminPlus);
            Youngest(adminPlus);
        }
        static void AddStudent(ArrayList arrlist)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            arrlist.Add(name);
            Console.Write("Enter age:  ");
            int age = int.Parse(Console.ReadLine());
            arrlist.Add(age);
            Console.Write("Enter grades: ");
            double grade = double.Parse(Console.ReadLine());
            arrlist.Add(grade);
        }
        static void Remove(ArrayList list)
        {
            Console.Write("Enter name of a student to remove: ");
            string name = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is string)
                {
                    if (list[i] == name)
                    {
                        list.RemoveAt(i);
                        list.RemoveAt(i + 1);
                        list.RemoveAt(i + 2);
                    }
                }
            }
        }
        static void Youngest(ArrayList list)
        {
            int minimumage = int.MaxValue;
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is int)
                {
                    if (minimumage > (int)list[i])
                    {
                        minimumage = (int)list[i];
                        index = i;
                    }
                }
            }
            Console.WriteLine($"youngest person: {list[index - 1]}, age: {minimumage} years , grade: {list[index + 1]}.");
        }
    }
}
