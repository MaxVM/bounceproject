using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    private Transform heldObject;
    private bool isPickedUp;
    private GameObject Obj;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (Input.GetButtonDown("Fire1"))
            {
            Obj = hit.collider.gameObject;
                
               if (!isPickedUp)
               {
                Obj.GetComponent<Rigidbody>().isKinematic = true;
                Obj.GetComponent<Rigidbody>().useGravity = false;
                Obj.transform.position = heldObject.position;
                Obj.transform.rotation = this.transform.rotation;
                Obj.transform.parent = this.transform;
                isPickedUp = !isPickedUp;
               }
            }
     
        }
        if (Input.GetButtonUp("Fire1"))
        {
            if (isPickedUp)
            {
             Obj.GetComponent<Rigidbody>().isKinematic = false;
             Obj.GetComponent<Rigidbody>().useGravity = true;
             Obj.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000);
             Obj.transform.parent = null;
             isPickedUp = !isPickedUp;
             Obj = null;
            }
        }
    }
}
