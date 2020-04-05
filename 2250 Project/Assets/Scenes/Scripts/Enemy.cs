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
        if (SceneManager.GetActiveScene().name == "Arena")
        {
            _inCombat = true;
        }
        else
        {
            _inCombat = false;
            Instantiate(enemyTrigger, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_inCombat)
        {

        }
        else
        {

        }
    }


    // void Attack()
    // {
    //     BattleItemScript item = gameObject.GetComponent<BattleItemScript>();
    //     int rangeX = item.item.rangeX, rangeZ = item.item.rangeZ;

    //     GameObject attack = Instantiate(AttackHitBox, gameObject.transform.position + gameObject.transform.forward, Quaternion.identity); //spawns a boxcollider in the attack range
    //     attack.GetComponent<AttackCollider>().damage = item.item.damage;
    //     attack.GetComponent<BoxCollider2D>().size = new Vector3(rangeX, 1, rangeZ);
    //     attack.tag = gameObject.tag == "Player" ? "PlayerAttack" : "EnemyAttack";
    // }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyAttack")
        {
            gameObject.GetComponent<Health>().Damage(collision.gameObject.GetComponent<AttackCollider>().damage);
        }
    }
}