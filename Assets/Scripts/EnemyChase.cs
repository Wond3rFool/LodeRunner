using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    public Transform thePlayer;
    int moveSpeed = 2;
    int MaxDist = 10;
    int MinDist = 5;

    

    

    void Update()
    {

        transform.LookAt(thePlayer);

        if (Vector3.Distance(transform.position, thePlayer.position) >= MinDist)
        {

            transform.position += transform.forward * moveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, thePlayer.position) <= MaxDist)
            {
                return;
            }


        }
    }
}
