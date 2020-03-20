using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Attack();
        }
    }

    void Attack(){
        BattleItemScript item = gameObject.GetComponent<BattleItemScript>();
        int rangeX = item.item.rangeX, rangeZ = item.item.rangeZ;
        
        GameObject attack = Instantiate(AttackCollider,gameObject.transform.position + gameObject.transform.forward,Quaternion.identity); //spawns a boxcollider in the attack range
        attack.GetComponent<AttackCollider>().Damage = item.item.attackDamage;
        attack.GetComponent<BoxCollider2D>().Scale = new Vector3(rangeX, 1, rangeZ);
        attack.tag = gameObject.tag == Player ? "PlayerAttack" : "EnemyAttack";
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "EnemyAttack" && gameObject.tag =="Player"){
            // gameObject.GetComponent<Health>.Damage(collision.gameObject.attackDamage);
        }
        else if (collision.gameObject.tag == "PlayerAttack" && gameObject.tag =="Enemy"){
            // gameObject.GetComponent<Health>.Damage(collision.gameObject.attackDamage);
        }
    }
    
}
