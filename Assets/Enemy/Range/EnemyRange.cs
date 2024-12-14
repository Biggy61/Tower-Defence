using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    public int hp;
    public Rigidbody2D rb;
    public Animator animator;
    public float characterSpeed;
    private float _Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Walk");
        _Timer += Time.deltaTime;
        rb.linearVelocity = new Vector2(-characterSpeed, rb.linearVelocity.y);
     if(hp <= 0) { Destroy(this.gameObject); }   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Attack");
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        Debug.Log("BLud!");

        if (collision.gameObject.tag == "FriendlyMelee" && _Timer > 0.5f)
        {
            Debug.Log("Melee!");
            collision.gameObject.GetComponent<FriendlyMelee>().hp -= 10;
            _Timer = 0;
        }
        else if (collision.gameObject.tag == "FriendlyRange" && _Timer > 0.5f)
        {
            Debug.Log("Range!");
            collision.gameObject.GetComponent<FriendlyRange>().hp -= 10;
            _Timer = 0;
        }
        else if (collision.gameObject.tag == "MyTower" && _Timer > 0.5f)
        {
            Debug.Log("Tower!");
            collision.gameObject.GetComponent<Tower.Tower>().hp -= 10;
            _Timer = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        animator.SetTrigger("Walk");
    }
    
}
