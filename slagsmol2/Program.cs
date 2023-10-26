Fighter fighter1 = new();

fighter1.weapon = new();

fighter1.weapon.name = "Sword";
fighter1.weapon.damage = 10;

Fighter fighter2 = new();

fighter2.weapon = new();

fighter2.weapon.name = "Longsword";
fighter2.weapon.damage = 12;


Console.WriteLine($"Ge ett namn till fighter 1:");
fighter1.name = Console.ReadLine();

Console.WriteLine($"Ge ett namn till fighter 2:");
fighter2.name = Console.ReadLine();

Console.Clear();
while(fighter1.hp > 0 && fighter2.hp > 0)
{
    Console.WriteLine($"{fighter1.name} HP:{fighter1.hp}, {fighter2.name} HP:{fighter2.hp}");
    int dmg1 = fighter1.attack(fighter2);
    Console.WriteLine($"{fighter1.name} gjorde {dmg1} skada");
    int dmg2 = fighter2.attack(fighter1);
    Console.WriteLine($"{fighter2.name} gjorde {dmg2} skada");

    Console.WriteLine("Tryck ENTER för att gå vidare");
    Console.ReadLine();
    Console.Clear();

}

if(fighter1.hp <= 0)
{
    Console.WriteLine($"{fighter1.name} dog!");
}
else
{
    Console.WriteLine($"{fighter2.name} dog!");

}
Console.ReadLine();