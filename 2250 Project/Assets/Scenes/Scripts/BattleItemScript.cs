using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleItemScript : MonoBehaviour
{
    private BattleItem battleItem;

    public void setItem(BattleItem battleItem){
        this.battleItem = battleItem;
    }

    public void removeItem(){
        this.battleItem=null;
    }

    public BattleItem item {
        get {
            return this.battleItem != null ? this.battleItem : new BattleItem();
        }
    }
}
