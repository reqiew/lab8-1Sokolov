try { 
Console.WriteLine("Введите число экзаменов");
int n = int.Parse(Console.ReadLine());
Ekz[] ekz = new Ekz[n];
for (int i = 0; i < n; i++)
{
    ekz[i] = new Ekz();

    Console.WriteLine("Введите год проведения экзамена");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите месяц проведения экзамена");
    int month = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите день экзамена");
    int day = int.Parse(Console.ReadLine());
    ekz[i].dt = new DateOnly(year, month, day);


    Console.WriteLine("Введите название предмета");
    ekz[i].pr = Console.ReadLine();

    Console.WriteLine("Введите ФИО преподавателя");
    ekz[i].fio = Console.ReadLine();

    Console.WriteLine("Введите название группы");
    ekz[i].grp = Console.ReadLine();

    Console.WriteLine("Введите номмер аудитории");
    ekz[i].num = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите час начала экзамена");
    int hour = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите минуты начала экзамена");
    int minut = int.Parse(Console.ReadLine());
    ekz[i].nach = new TimeOnly(hour, minut);

    Console.WriteLine("Введите час конца экзамена");
    int hour1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите минуты конца экзамена");
    int minut2 = int.Parse(Console.ReadLine());
    ekz[i].konch = new TimeOnly(hour, minut);
    ekz[i].konch1 = new TimeOnly(12, 00);
}
for (int i = 0; i < n; i++)
{
    if (ekz[i].nach <= ekz[i].konch1)
    {
        Console.WriteLine("Дата проведения экзамена  " + ekz[i].dt);
        Console.WriteLine("ФИО преподавателя  " + ekz[i].fio);
        Console.WriteLine("Название предмета  " + ekz[i].pr);
        Console.WriteLine("Группа  " + ekz[i].grp);
        Console.WriteLine("Начало проведения экзамена  " + ekz[i].nach);
        Console.WriteLine("Конец проведения экзамена  " + ekz[i].konch);
        Console.WriteLine("День недели  " + ekz[i].dt.DayOfWeek);
    }
    else { Console.WriteLine("Ничего нету:("); }
}
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Ekz
{
    public DateOnly dt;
    public string pr;
    public string fio;
    public string grp;
    public int num;
    public TimeOnly nach;
    public TimeOnly konch;
    public TimeOnly konch1;

}




