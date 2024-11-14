using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Coins : MonoBehaviour
{
    public float coins;
    public TextMeshProUGUI coinText;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
            coins += 10;
        }
        
        coinText.text = "Coins: " + coins;
    }
}
