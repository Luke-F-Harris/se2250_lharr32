using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleItem : Item
{
    public static string [] attackTypes = {"stab", "slice", "throw"};
    public int damage, rangeX, rangeZ;

    public BattleItem(){
        damage = 0;
        rangeX = 1;
        rangeZ = 1;
    }
}
