using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player"){
            SceneManager.LoadScene("Arena");
        }
    }
}
