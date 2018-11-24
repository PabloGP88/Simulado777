using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBox : MonoBehaviour {

    public bool hanged;

    int grabed;

    private void Start()
    {
        hanged = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hanged = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            hanged = false;
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Object" && hanged == true && grabed != 1)
        {
            grabed = 1;
            col.transform.parent = gameObject.transform.parent;
            col.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (hanged == false )
        {
            grabed = 0;
            col.GetComponent<Rigidbody>().isKinematic = false;
            col.transform.parent = GameObject.Find("Objects").transform;

        }
    }


}
