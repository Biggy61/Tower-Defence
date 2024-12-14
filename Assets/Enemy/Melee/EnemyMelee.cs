using System;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    public int hp;
    public Rigidbody2D rb;
    public Animator animator;
    private float _Timer;
    public float characterSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Walk");
        _Timer += Time.deltaTime;
        rb.linearVelocity = new Vector2(characterSpeed, -rb.linearVelocity.y);
        if (hp <= 0) { Destroy(this.gameObject); }
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