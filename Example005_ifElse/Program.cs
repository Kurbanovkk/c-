System.Console.Write("ВВедите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")  // ToLower аозволят понимать внезависимости от то заглавная буква или обычная
{
    System.Console.WriteLine("Ура, это же Маша!!!");
}
else
{
    System.Console.WriteLine($"привет " + username);

}