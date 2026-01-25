namespace _04_linq;

class Mob
{
    internal bool isDead;
    internal int hp = 10;
    internal string name;

    public void TakeDamage(int damage)
    {
        hp-= damage;
        if(hp<=0)
        {
            isDead= true;
        }
    }

}



