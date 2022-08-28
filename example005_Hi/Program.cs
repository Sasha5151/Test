Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower()=="маша")
{
  Console.WriteLine("Маша - дура");
}
else
{
  Console.Write("привет, ");  
  Console.WriteLine(username);
}
