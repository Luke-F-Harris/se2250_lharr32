using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customization : MonoBehaviour
{


    private bool _playerInZone;
    public GameObject pressX;
    public PlayerMovement player;
    private Animator _animator;
    public string[] outfits = { "IdleChangeClothes", "Idle" };
    public int outfitsPicker = 0;

    // Start is called before the first frame update
    void Start()
    {

        pressX.SetActive(false);
        _animator = player.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (_playerInZone)
        {
            pressX.SetActive(true);
            FollowObject(player);
            if (Input.GetKeyUp("x"))
            {
                Debug.Log("You just changed clothes!");
                _animator.Play((string)outfits[outfitsPicker % 2]);
                outfitsPicker++;

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
    private void FollowObject(PlayerMovement other)
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
