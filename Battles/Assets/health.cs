using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int Maxhealth = 100;
    public int CurHealth;
    private void Start()
    {
        CurHealth = Maxhealth;
    }
    public void TakeDamage(int health)
    {
        CurHealth -= health;
        if (CurHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(3);
        }
    }
}
