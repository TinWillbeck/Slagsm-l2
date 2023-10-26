public class Weapon
{
    public string name;
    public int damage ;
    Random generator = new Random();

    public int damageAmmount()
    {
        return generator.Next(damage-10,damage+10);
    }
}
