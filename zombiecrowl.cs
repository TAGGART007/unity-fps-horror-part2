using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiecrowl : MonoBehaviour {


    public Transform sourcePos;
    public Transform destinationPos;
    public float distance;
    Vector3 OriginalPosition;
    public Animator Zombie2;



    void Start()
    {
        OriginalPosition = destinationPos.position;

    }


    void Update()
    {
        if (Vector3.Distance(sourcePos.position, destinationPos.position) < 17.0f)
        {
            Debug.Log(distance);


            if (Vector3.Distance(sourcePos.position, destinationPos.position) > 0.1f)
                destinationPos.position = Vector3.MoveTowards(destinationPos.position, sourcePos.position, 0.01f);
            transform.LookAt(sourcePos);
            Zombie2.SetInteger("State", 3);
        }
        else
        {
            destinationPos.position = Vector3.MoveTowards(destinationPos.position, OriginalPosition, 0.1f);
            Zombie2.SetInteger("State", 2);
        }


    }
}