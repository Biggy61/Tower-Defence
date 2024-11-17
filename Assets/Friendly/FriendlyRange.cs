using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyRange : MonoBehaviour
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
        rb.velocity = new Vector2(characterSpeed, rb.velocity.y);
     if(hp <= 0) { Destroy(this.gameObject); }   
    }
    
}
