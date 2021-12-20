using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int puan;
    public Text scoretext;
    
    void Start()
    {
        puan = 0;
        
    }

    
    void Update()
    {
        scoretext.text = puan.ToString();
    }
}
