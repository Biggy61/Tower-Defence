using Unity.VisualScripting;
using UnityEngine;

public class FriendlyMelee : MonoBehaviour
{
    public int hp;
    public Rigidbody2D rb;
    public Animator animator;
    public float characterSpeed;

    private float _meleeTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Walk");
        rb.linearVelocity = new Vector2(characterSpeed, rb.linearVelocity.y);
        _meleeTimer += Time.deltaTime;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Attack");
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        Debug.Log("BLud!");

        if (collision.gameObject.tag == "EnemyMelee" && _meleeTimer > 0.5f)
        {
            Debug.Log("BLAAAA!");
            collision.gameObject.GetComponent<EnemyMelee>().hp -= 10;
            _meleeTimer = 0;
        }
    }
}