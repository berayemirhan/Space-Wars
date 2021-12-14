using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    Rigidbody2D rb;
    bool sol;
    bool sag;

    public GameObject bullet;
    public Transform AtesNoktası;
    public float atıshızı;
    public float sayac;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        sayac -= Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
        {
            if (sayac <= 0)
            {
                shoot();
                sayac = 0.4f;

            }
        }

        Vector3 sag_git = new Vector3(1.5f, transform.position.y);
        Vector3 sol_git = new Vector3(-1.5f, transform.position.y);
        if(Input.touchCount>0)
        {

            Touch parmak = Input.GetTouch(0);

            if(parmak.deltaPosition.x>6.0f)
            {
                sag = true;
                sol = false; 
                if (sayac <= 0)
                {
                    shoot();
                    sayac = 0.3f;

                }
            }
            if (parmak.deltaPosition.x < -6.0f)
            {
                sag = false;
                sol = true;
                if (sayac <= 0)
                {
                    shoot();
                    sayac = 0.3f;

                }
            }
            if(sag==true)
            {
                transform.position = Vector3.Lerp(transform.position, sag_git, 5 * Time.deltaTime);
            }
            if (sol == true)
            {
                transform.position = Vector3.Lerp(transform.position, sol_git, 5 * Time.deltaTime);
            }
            
        }
    }
    public void shoot()
    {
        GameObject mermi = Instantiate(bullet,AtesNoktası.position,Quaternion.identity);
        mermi.GetComponent<Rigidbody2D>().velocity = new Vector2(0,atıshızı*Time.deltaTime);
    }
}
