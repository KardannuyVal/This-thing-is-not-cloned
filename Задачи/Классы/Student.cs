
namespace Задачи
{
    enum Employment
    {
        Не_учавствующий,
        Учавствующий,
        Халявщик,
        Желающий
    } // Занятость
    internal class Student
    {
        internal string name {  get; set; }
        internal string group {  get; set; }
        internal Employment employment { get; set; }
        public Student(string name, string group)
        {
            this.name = name;
            this.group = group;
            employment = Employment.Не_учавствующий;
        }

        
    }
}
