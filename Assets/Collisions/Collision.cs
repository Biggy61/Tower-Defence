using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //public Animator animator;
    public Transform[] friendlyMelee;
    public GameObject[] fmelee;
    public GameObject[] emelee;
    public GameObject[] erange;
    public GameObject etower;

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        emelee = GameObject.FindGameObjectsWithTag("EnemyMelee");
        erange = GameObject.FindGameObjectsWithTag("EnemyRange");
        etower = GameObject.FindGameObjectWithTag("EnemyTower");
        foreach (GameObject e in emelee)
        {
            foreach (GameObject f in fmelee)
            {
                _meleeDistance = Vector3.Distance(f.transform.position, e.transform.position);

                if (_meleeDistance <= 10f)
                {
                    Debug.Log("blud3");
                    //animator.SetTrigger("Attack");
                    e.GetComponent<EnemyMelee>().hp -= 1;
                }
            }
        }

        foreach (GameObject e in erange)
        {
            foreach (GameObject f in fmelee)
            {
                _rangeDistance = Vector3.Distance(f.transform.position, e.transform.position);
                if (_rangeDistance <= 10f)
                {
                    Debug.Log("blud2");
                    //animator.SetTrigger("Attack");
                    e.GetComponent<EnemyRange>().hp -= 1;
                }
            }
        }

        foreach (GameObject f in fmelee)
        {
            _towerDistance = Vector3.Distance(f.transform.position, etower.transform.position);
        

        if (_towerDistance <= 10f)
        {
            Debug.Log("blud");
            //animator.SetTrigger("Attack");
            etower.GetComponent<EnemyTower>().hp -= 1;
        }
        }
        // else
        // {
        //     Debug.Log("blud4");
        //     animator.SetTrigger("Walk");
        //     rb.linearVelocity = new Vector2(characterSpeed, rb.linearVelocity.y); 
        // }
    }
}