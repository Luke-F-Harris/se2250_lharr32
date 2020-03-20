using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool _inCombat;
    public EnemyTrigger enemyTrigger; 
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name=="Arena"){
            _inCombat=true;
        }
        else{
            _inCombat=false;
            Instantiate(enemyTrigger, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_inCombat){

        }
        else{

        }
    }
}
