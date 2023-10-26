public class Fighter
{
    public string name;
    public Weapon weapon;
    public int hp = 100;
    

    public int attack(Fighter target)
    {
        int damage = weapon.damageAmmount();
        target.hp -= damage;
        return damage;
        
    }

}
