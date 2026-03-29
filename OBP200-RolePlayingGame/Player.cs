namespace OBP200_RolePlayingGame;

public class Player : Entity
{
    public string Inventory { get; set; } = "";
    public int Potions { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Xp { get; set; }
    public int Defense { get; set; }
    public int Attack { get; set; }
    public string ClassName { get; set; } = "";
}






