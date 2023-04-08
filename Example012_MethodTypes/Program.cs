// ВИД 1 Не принимают аргументы / Не возвращают
void method1()
{
    Console.WriteLine("Автор - Я!");
}
//method1();



// ВИД 2 Принимают аргументы / Не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("текст");
//Method2(msg:"текст");
void Method21(string msg, int count)
{
    int i= 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("текст", 4);
//Method21(count: 4, msg:"новый текст");



// ВИД 3 Не принимают аргументы / Возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


// ВИД 4 Принимают аргументы / Возвращают
string Method4(int count, string text)
{
    string result= string.Empty;
    for (int i=0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);