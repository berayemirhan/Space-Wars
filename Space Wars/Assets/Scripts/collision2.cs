using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision2)
    {
        if(collision2.gameObject.tag=="enemys")
        {
            Destroy(collision2.gameObject);
            
        }
    }
}
