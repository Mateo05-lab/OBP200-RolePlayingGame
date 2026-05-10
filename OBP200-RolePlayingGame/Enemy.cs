namespace OBP200_RolePlayingGame;

public class Enemy : Entity
{
    public int Defense { get; private set; }
    public int Attack { get; private set; }
    public int GoldReward { get; private set; }
    public int XpReward { get; private set; }

    public Enemy(string name, int maxHp, int attack, int defense, int goldReward, int xpReward) : base(name, maxHp)
    {
        this.Attack = attack;
        this.Defense = defense;
        this.GoldReward = goldReward;
        this.XpReward = xpReward;
    }

    public override void TakeDamage(int damage)
    {
        int reducedDamage = damage - Defense;

        if (reducedDamage < 0)
            reducedDamage = 0;

        base.TakeDamage(reducedDamage);
    }
}


