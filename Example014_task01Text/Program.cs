//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


string letterChanger(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i=0; i<length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = letterChanger(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = letterChanger(newText, 'к', 'К');
Console.WriteLine(newText); 

/* // Счетчик символов

int letterCounter(string text)
{
    int length = text.Length;
    return length;
}
Console.WriteLine(letterCounter(text));*/ 
