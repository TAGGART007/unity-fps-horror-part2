using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiechase : MonoBehaviour {


    public Transform sourcePos;
    public Transform destinationPos;
    public float distance;
    Vector3 OriginalPosition;
    public Animator Zombie;



    void Start()
    {
        OriginalPosition = destinationPos.position;

    }


    void Update()
    {
        if (Vector3.Distance(sourcePos.position, destinationPos.position) < 20f)
        {
            Debug.Log(distance);


            if (Vector3.Distance(sourcePos.position, destinationPos.position) > 0.1f)
                destinationPos.position = Vector3.MoveTowards(destinationPos.position, sourcePos.position, 0.011f);
            transform.LookAt(sourcePos);
            Zombie.SetInteger("State", 9);
        }
        else
        {
            Zombie.SetInteger("State", 8);
            destinationPos.position = Vector3.MoveTowards(destinationPos.position, OriginalPosition, 0.1f);
            
        }



    }
}