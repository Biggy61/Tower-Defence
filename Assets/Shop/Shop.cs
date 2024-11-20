using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject coins;
    private float _coin;
    public GameObject friendlyRange;
    public Transform friendlySpawn;
    public GameObject friendlyMelee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _coin = coins.GetComponent<Coins>().coins;
    }
    public void BuyRange()
    {
        if (_coin >= 100)
        {
            coins.GetComponent<Coins>().coins -= 100;
            Debug.Log("Click"); 
            Instantiate(friendlyRange, friendlySpawn.position, Quaternion.identity);
        }
    }
    public void BuyMelee()
    {
        if (_coin >= 50)
        {
            coins.GetComponent<Coins>().coins -= 50;
            Debug.Log("Click"); 
            Instantiate(friendlyMelee, friendlySpawn.position, Quaternion.identity);
        }
    }


}
