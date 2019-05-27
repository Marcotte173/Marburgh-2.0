using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Boss : Monster
{
    public bool IsAlive = true;

    public Boss(string name, string taunt, pClass pClass, int rewardGold, int rewardXP, string summonName, bool IsAlive)
    : base( name,  taunt,  pClass,  rewardGold,  rewardXP,  summonName)
    {
        this.IsAlive = IsAlive;
    }

    public bool KillBoss() { return IsAlive = false; }

}
