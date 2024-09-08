namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var user = new User();

            //user.SetName("Eslam");
            //user.SetAge(25);

            Console.WriteLine($" name = {user.GetName()} - age = {user.GetAge()}");
        }
    }


}

class User
{
    private int age;
    public string name;


    public User()
    {
        age = 10;
        name = "Empty";
    }


    public void SetAge(int _age) => age = _age;
    public int GetAge() => age;

    public void SetName(string _name) => name = _name;
    public string GetName() => name;

}
