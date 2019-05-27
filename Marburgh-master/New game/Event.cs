using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Event
{
    public string name;
    public string flavor;
    public int eventType;
    public int effect;
    public int success;
    public static Random rand = new Random();

    public Event(string name, string flavor, int eventType, int effect, int success)
    {
        this.name = name;
        this.flavor = flavor;
        this.eventType = eventType;
        this.effect = effect;
        this.success = success;
    }
    public static void EventTable(Room roomRoll, Hero player, List<string> EventDisplay, Equipment weapon, Equipment armour)
    {
        Console.SetCursorPosition(0, 25);
        for (int i = 0; i < EventDisplay.Count; i++)
        {
            if (EventDisplay[i] == "Some gold")
            {
                int goldAdd = rand.Next(-3, roomRoll.modifier);
                player.gold += roomRoll.EventArray[0].effect + (goldAdd * 12);
                Console.WriteLine($"You gain {roomRoll.EventArray[0].GetEffect() + (goldAdd * 12)} gold");
                Thread.Sleep(500);
            }
            if (EventDisplay[i] == "A health potion")
            {
                if (player.potions == player.maxPotions)
                    Console.WriteLine($"Somebody already drank the potion!", "It's just an empty bottle!", "", "Oh well...");
                else
                {
                    player.potions += roomRoll.EventArray[0].effect;
                    Console.WriteLine($"You gain {roomRoll.EventArray[0].GetEffect()} health potion");
                }
                Thread.Sleep(500);
            }
            if (EventDisplay[i] == "An old book")
            {
                int XPAdd = rand.Next(-3, roomRoll.modifier);
                player.xp += roomRoll.EventArray[0].effect + XPAdd;
                Console.WriteLine($"Reading the book, you gain insight into the dungeon and its inhabitants");
                Console.WriteLine($"You gain {roomRoll.EventArray[0].GetEffect() + XPAdd} experience");
                Thread.Sleep(500);
            }
        }
        New_game.Program.Keypress();
        for (int i = 0; i < EventDisplay.Count; i++)
        {
            if (EventDisplay[i] == "Some equipment")
            {
                int itemRoll = rand.Next(1, 3);
                if (itemRoll == 1)
                {
                    if (weapon.effect > player.Weapon.effect)
                    {
                        player.Weapon = weapon;
                        Console.WriteLine($"You find some {armour.name}! Cheering your good luck, you equip it right away");
                    }
                    else Console.WriteLine($"You find a broken old weapon", "It is of no use to anyone");

                }
                if (itemRoll == 2)
                {
                    if (armour.effect > player.Armor.effect)
                    {
                        player.Armor = armour;
                        Console.WriteLine($"You find some {armour.name}! Cheering your good luck, you equip it right away");
                    }
                        
                    else Console.WriteLine($"You find a broken old set of armour", "It is of no use to anyone");
                }
                Thread.Sleep(500);
            }
        }
        New_game.Program.Keypress();
    }
    public string GetName() { return name; }
    public string GetFlavor() { return flavor; }
    public int GetEventType() { return eventType; }
    public int GetEffect() { return effect; }
    public int GetSuccess() { return success; }
}

