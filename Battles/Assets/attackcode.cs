using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackcode : MonoBehaviour
{
    public health helthofguy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void TakeDamaxge()
    {
        helthofguy.TakeDamage(3);
    }
}
