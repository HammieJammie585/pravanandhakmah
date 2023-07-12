using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackcode : MonoBehaviour
{
    public health helthofguy;
    public GameObject ThePersonYourFighting;
    void Start()
    {
        
    }
    private void Update()
    {
        ThePersonYourFighting = GetComponent<AIDestinationSetter>().target.gameObject;
        if (helthofguy == null)
        {
            helthofguy = ThePersonYourFighting.GetComponent<health>();
        }
    }

    // Update is called once per frame
    void TakeDamaxge()
    {
        helthofguy.TakeDamage(3);
    }
}
