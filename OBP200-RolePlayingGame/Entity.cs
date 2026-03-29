namespace OBP200_RolePlayingGame;

public class Entity
{
    public int Hp { get; set; }
    public int MaxHp { get; set; }
    public string Name { get; set; } = "";

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