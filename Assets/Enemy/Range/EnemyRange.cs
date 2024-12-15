using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    public int hp;
    public Rigidbody2D rb;
    public Animator animator;
    public float characterSpeed;
    private float _Timer;
    public Transform range;
    public LayerMask layer;

    public float attackRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _Timer += Time.deltaTime;
        Collider2D[] hit = Physics2D.OverlapCircleAll(range.position, attackRange, layer);

        bool IsArrayEmpty()
        {
            if (hit == null || hit.Length == 0) return true;
            else return false;
        }

        if (!IsArrayEmpty())
        {
            foreach (Collider2D enemy in hit)
            {
                if (enemy.gameObject.tag == "FriendlyMelee" && _Timer > 0.5f)
                {
                    animator.SetTrigger("Attack");
                    rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
                    enemy.GetComponent<FriendlyMelee>().hp -= 10;
                    _Timer = 0;
                }
                else if (enemy.gameObject.tag == "FriendlyRange" && _Timer > 0.5f)
                {
                    animator.SetTrigger("Attack");
                    rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
                    enemy.GetComponent<FriendlyRange>().hp -= 10;
                    _Timer = 0;
                }
                else if (enemy.gameObject.tag == "FriendlyTower" && _Timer > 0.5f)
                {
                    animator.SetTrigger("Attack");
                    rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
                    enemy.GetComponent<Tower.Tower>().hp -= 10;
                    _Timer = 0;
                }
            }
        }
        else
        {
            animator.SetTrigger("Walk");
            rb.linearVelocity = new Vector2(characterSpeed, rb.linearVelocity.y);
        }


        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(range.position, attackRange);
    }
  
}