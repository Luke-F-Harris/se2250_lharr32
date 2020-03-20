using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ExpBar : ScriptableObject
{
    public int experience = 0;
    private int[] _thresholds = { 10, 20, 30, 40, 50 };

    public void gainExperience(int experience)
    {
        if ((this.experience += experience) > _thresholds[PlayerMovement.instance.GetLevel()])
        {

        }
    }
}
