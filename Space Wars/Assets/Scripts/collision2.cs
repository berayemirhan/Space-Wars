using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision2 : MonoBehaviour
{
    private int dead;
    public GameObject canvas;
    void Start()
    {
        dead = 0;
    }

    
    void Update()
    {
        if(dead==3)
        {
            canvas.SetActive(true);
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision2)
    {
        if(collision2.gameObject.tag=="enemys")
        {
            dead = dead + 1;
            Destroy(collision2.gameObject);
            
            
        }
    }
}
