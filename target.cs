using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float health = 50f;
    public void TakeDAmage(float amount)
    {

        health -= amount;
        if (health <= 0f)
        {
            die();
        }
    }
 
    void die()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
}
