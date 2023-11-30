
namespace Задачи
{
    enum Hobbys
    {
        игры,
        спорт,
        сериалы,
        прогать,
        гулять
    }
    internal class Person
    {
        internal string name {  get; set; }
        internal Hobbys hobby { get; set; }
        public Person (string name, Hobbys hobby)
        {
            this.name = name;
            this.hobby = hobby;
        }

    }
}
