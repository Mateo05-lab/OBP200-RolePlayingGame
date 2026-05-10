namespace OBP200_RolePlayingGame;

public class Entity
{
    public int Hp { get; protected set; }
    public int MaxHp { get; protected set; }
    public string Name { get; protected set; }

    public Entity(string name, int maxHp)
    {
        this.Name = name;
        this.MaxHp = maxHp;
        this.Hp = maxHp;
    }
    public virtual void TakeDamage(int damage)
    {
        Hp -= damage;
        if (Hp <= 0)
            Hp = 0;
    }

    public bool IsDead()
    {
        return Hp <= 0;
    }
}