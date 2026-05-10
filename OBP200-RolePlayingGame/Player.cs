namespace OBP200_RolePlayingGame;

public class Player : Entity
{
    public string Inventory { get; private set; } = "";
    public int Potions { get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }
    public int Xp { get; private set; }
    public int Defense { get; private set; }
    public int Attack { get; private set; }
    public string ClassName { get; private set; }

    public Player(string name, string className) : base(name, 100)
    {
        this.ClassName = className;
        this.Potions = 3;
        this.Gold = 0;
        this.Level = 1;
        this.Xp = 0;
        this.Defense = 5;
        this.Attack = 10;
    }

    public override void TakeDamage(int damage)
    {
        int reducedDamage = damage - Defense;
        if (reducedDamage < 0)
            reducedDamage = 0;
        base.TakeDamage(reducedDamage);
    }

    public void SpendGold(int amount)
    {
        if (amount > 0 && Gold >= amount)
        {
            Gold -= amount;
        }
    }

    public bool UsePotion()
    {
        if (Potions <= 0)
            return false;

        Potions--;
        Hp = Math.Min(MaxHp, Hp + 12);
        return true;
    }

    public void RestoreToFullHealth()
    {
        Hp = MaxHp;
    }

    public void AddXp(int amount)
    {
        if (amount > 0)
        {
            Xp += amount;
        }
    }

    public void AddGold(int amount)
    {
        if (amount > 0)
        {
            Gold += amount;
        }
    }

    public void LevelUp()
    {
        Level++;
    }

    public void ApplyLevelUp(string cls)
    {
        if (cls == "Warrior")
        {
            MaxHp += 6;
            Attack += 2;
            Defense += 2;
        }
        else if (cls == "Mage")
        {
            MaxHp += 4;
            Attack += 4;
            Defense += 1;
        }
        else if (cls == "Rogue")
        {
            MaxHp += 5;
            Attack += 3;
            Defense += 1;
        }
        else
        {
            MaxHp += 4;
            Attack += 3;
            Defense += 1;
        }

        this.Hp = MaxHp;
    }

    public void AddItem(string item)
    {
        if (string.IsNullOrWhiteSpace(Inventory))
            Inventory = item;
        else
            Inventory += ";" + item;
    }

    public void AddPotion()
    {
        Potions++;
    }

    public void IncreaseAttack(int amount)
    {
        if (amount > 0)
            Attack += amount;
    }

    public void IncreaseDefense(int amount)
    {
        if (amount > 0)
            Defense += amount;
    }

    public void SetInventory(string newInventory)
    {
        Inventory = newInventory;
    }
}
