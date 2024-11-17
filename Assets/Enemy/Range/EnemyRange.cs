using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    public int hp;
    public Rigidbody2D rb;
    public Animator animator;
    public float characterSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Walk");
        rb.linearVelocity = new Vector2(characterSpeed, rb.linearVelocity.y);
     if(hp <= 0) { Destroy(this.gameObject); }   
    }
    
}
