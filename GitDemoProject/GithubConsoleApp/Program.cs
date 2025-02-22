Console.WriteLine("doğum yılınız");
int yil = Convert.ToInt32(Console.ReadLine());
int age = DateTime.Now.Year - yil;
Console.WriteLine("yaşınız: " + age);
Console.ReadLine();
