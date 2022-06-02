static int SongDate() 
{
    return 1985;
}

static bool IsGood()
{
    return true;
}

static string ByAha()
{
    string chorus = TakeOnMe();
    chorus += TakeMeOn();
    chorus += IllBeGone();
    chorus += InADayOrTwo();

    return chorus;
}

static string TakeOnMe()
{
    return "Take on me";
}

static string TakeMeOn()
{
    return ", Take me on";
}

static string IllBeGone()
{
    return ", I'll be gone";
}

static string InADayOrTwo()
{
    return ", In a day or twooooooo";
}

string verse = ByAha();
Console.WriteLine(verse);
int date = SongDate();
Console.WriteLine("When did this song release?: " + date);
bool opinion = IsGood();
Console.WriteLine("Do AI think this song is a banger?: " + opinion);
