//Условие
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "айдар")
{
    Console.WriteLine("Ура, это же Айдар!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}