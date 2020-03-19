using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;

    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    
    public Bag playerBag;
    public ExpBar expBar;

    private int _level = 0, _skillTokens = 0, _attack = 3, _health=20, _speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        instance=this;

        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;

        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        updateAnimationAndMove();

        if(Input.GetKey("e")){
            OpenMenu();
        }

    }

    void updateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }

    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }

    public void LevelUp(){
        this._level++;
        this._skillTokens++;

        this._attack+=_level;
        this._health+=_level*10;
        this._speed+=_level;
    }

    public int GetLevel(){
        return this._level;
    }

    void OpenMenu(){

    }

    void SelectSkills(){

    }

    void OpenBag(){
        Debug.Log(playerBag.items);
    }
}
