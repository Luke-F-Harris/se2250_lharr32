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
        // spawn attack collider
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
