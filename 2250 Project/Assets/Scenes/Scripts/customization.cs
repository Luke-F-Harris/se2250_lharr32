using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customization : MonoBehaviour
{
    private bool _playerInZone;
    public GameObject pressX;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        pressX.SetActive(false);
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
        pressX.transform.position = Camera.main.WorldToScreenPoint(other.transform.position) + new Vector3(0, 25, 0);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playerInZone = false;
        }
    }
}
