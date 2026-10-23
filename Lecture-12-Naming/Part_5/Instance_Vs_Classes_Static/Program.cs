using System;

class PlayerData
{
    public static int playerCount = 0;

    public string name;
    public int age;

    public PlayerData(string name, int age)
    {
        this.name = name;
        this.age = age;

        playerCount++;
        //this.plplayerCount=playerCount++;
    }
}

class Program
{
    static void Main()
    {
        PlayerData p1 = new PlayerData("Peter", 20);
        PlayerData p2 = new PlayerData("Mads", 22);
        PlayerData p3 = new PlayerData("Sebastian", 25);

        Console.WriteLine(p1.name);
        Console.WriteLine(p2.name);
        Console.WriteLine(p3.name);

        Console.WriteLine(PlayerData.playerCount);
    }
}
