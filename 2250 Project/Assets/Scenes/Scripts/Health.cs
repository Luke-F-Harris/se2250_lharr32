using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //can be used for many entities
    public float health = 100f;
    private bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health < 0)
        {
            dead = true; 
        }

        
    }
    void setDead(bool val)
    {
        dead = val;
    }
    bool getDead()
    {
        return dead;
    }

}
