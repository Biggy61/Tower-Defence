using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RangeButton : MonoBehaviour
{
    public GameObject coins;
    // Start is called before the first frame update
    void Start()
    {
        coins = GameObject.FindGameObjectWithTag("Background"); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Debug.Log("Click");
    }

}
