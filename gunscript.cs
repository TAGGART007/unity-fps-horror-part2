
using UnityEngine;

public class gunscript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpscam;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Mouse0))
        {
            shoot();
        }
        
    }

    void shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpscam.transform.position , fpscam.transform.forward , out hit , range))
        {
            Debug.Log(hit.transform.name);
          target target =  hit.transform.GetComponent<target>();

            if(target != null)
            {
                target.TakeDAmage(damage);
            }
        }
    }
}
