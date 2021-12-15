using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision3)
    {
        if (collision3.gameObject.tag == "enemys")
        {
            Destroy(collision3.gameObject);
            Destroy(this.gameObject);
        }
    }
}
