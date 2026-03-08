using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscr : MonoBehaviour {

    public Transform sourcePos;
    public Transform destinationPos;
    public float distance;
    Vector3 OriginalPosition;
    public Animator enemy;



    void Start()
    {
        OriginalPosition = destinationPos.position;

    }


    void Update()
    {
       


            
            if (Vector3.Distance(sourcePos.position, destinationPos.position) < 2f)
            {
                enemy.SetInteger("State", 3);


            }
            else if(Vector3.Distance(sourcePos.position, destinationPos.position) < 17f)
            {
                destinationPos.position = Vector3.MoveTowards(destinationPos.position, sourcePos.position, 0.022f);
                transform.LookAt(sourcePos);
                enemy.SetInteger("State", 8);
            }
            else
            {
                 enemy.SetInteger("State", 1);
                 destinationPos.position = Vector3.MoveTowards(destinationPos.position, OriginalPosition, 0.1f);
           
            }



    }
}