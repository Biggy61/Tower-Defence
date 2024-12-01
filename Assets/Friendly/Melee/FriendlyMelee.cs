using Unity.VisualScripting;
using UnityEngine;

public class FriendlyMelee : MonoBehaviour
{
    public int hp;
    public Rigidbody2D rb;
    public Animator animator;
    public float characterSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Walk");
        rb.linearVelocity = new Vector2(characterSpeed, rb.linearVelocity.y);
        if (hp <= 0) { Destroy(this.gameObject); }
    }
}