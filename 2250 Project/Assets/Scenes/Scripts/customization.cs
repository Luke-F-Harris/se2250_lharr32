using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customization : MonoBehaviour
{

    public Sprite newSprite;



    private bool _playerInZone;
    public GameObject pressX;
    public GameObject target;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

        pressX.SetActive(false);
        animator = target.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (_playerInZone)
        {
            pressX.SetActive(true);
            FollowObject(target);
            if (Input.GetKey("x"))
            {
                Debug.Log("You just changed clothes!");
                Debug.Log(target.GetComponent<SpriteRenderer>().sprite);
                animator.Play("IdleChangeClothes");
                Debug.Log(target.GetComponent<SpriteRenderer>().sprite);

            }
        }
        else
        {
            pressX.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playerInZone = true;
        }
    }
    private void FollowObject(GameObject other)
    {
        pressX.transform.position = Camera.main.WorldToScreenPoint(other.transform.position) + new Vector3(0, 30, 0);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playerInZone = false;
        }
    }
}
