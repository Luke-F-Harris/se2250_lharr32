using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleItemScript : MonoBehaviour
{
    public BattleItem item;

    public void setItem(BattleItem battleItem){
        this.item = battleItem;
    }

    public void removeItem(){
        this.item=null;
    }
}
