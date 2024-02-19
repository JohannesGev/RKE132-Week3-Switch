Console.WriteLine("Mis hinde kasutaja sai?");

char userGrade = char.Parse(Console.ReadLine());
string userGrade = Console.ReadLine();


if (userGrade == A) ;
{
    Console.WriteLine("Suurepärane!");
}
else if (userGrade == B);
{
    Console.WriteLine("Väga hea!");
}
else if (userGrade == C) ;
{
    Console.WriteLine("Hea!");
}
else if (userGrade == D) ;
{
    Console.WriteLine("Rahuldav!");
}
else if (userGrade == E) ;
{
    Console.WriteLine("Kasin!");
}
else if (userGrade == F) ;
{
    Console.WriteLine("Puudulik!");
}

else
{
    Console.WriteLine("Vale väärtus.");
}