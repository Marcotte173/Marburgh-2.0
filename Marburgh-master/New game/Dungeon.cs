using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dungeon
{
    public string name;
    public Boss boss;
    public int rooms;
    public Room[] roomOptions;
    public bool dungeonAvailable;
    public Monster[] bestiary;
    public string flavor;
    public int lootTier;
    public int monsterSummon;
    double diminishingReturns;
    bool roomExplored;

    public Dungeon(string name, string flavor, int howManyRooms, int monsterSummon, Room[] roomOptions, Boss boss, bool dungeonAvailable, Monster[] bestiary, int loot, double diminishingReturns, bool roomExplored)
    {
        this.name = name;
        this.boss = boss;
        rooms = howManyRooms;
        this.dungeonAvailable = dungeonAvailable;
        this.bestiary = bestiary;
        this.roomOptions = roomOptions;
        this.flavor = flavor;
        lootTier = loot;
        this.monsterSummon = monsterSummon;
        this.diminishingReturns = diminishingReturns;
        this.roomExplored = roomExplored;
    }

    public void SetRoomExplored() { roomExplored = true; }
    public void SetRoomNotExplored() { roomExplored = false; }
    public void SetDiminishingReturns(double x) { diminishingReturns = x; }
    public void SetAvailable() { dungeonAvailable = true; }
    public bool GetAvailable() { return dungeonAvailable; }
    public int GetMonsterSummon() { return monsterSummon; }
    public double GetDiminishingReturns() { return diminishingReturns; }
    public bool GetRoomExplored() { return roomExplored; }
}