using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class findnearest : VersionedMonoBehaviour
{
    public GameObject[] bestTarget;
    public Transform target;
   

    public GameObject GetClosestEnemy(GameObject[] enemies)
    {
        GameObject bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (GameObject potentialTarget in enemies)
        {
            Vector3 directionToTarget = potentialTarget.transform.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
                target = potentialTarget.transform;
            }
        }
        Debug.Log(bestTarget);

        return bestTarget.gameObject;
    }

    public void Update()
    {
       if(gameObject.tag == "PlayerSummonedCharacters")
        {
            bestTarget = GameObject.FindGameObjectsWithTag("AISummonedCharacters");
        }
        GetClosestEnemy(bestTarget);
        
    }

}




