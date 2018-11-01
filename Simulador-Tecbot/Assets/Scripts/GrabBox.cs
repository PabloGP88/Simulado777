using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBox : MonoBehaviour {
    public bool hanged;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hanged == false && Input.GetKeyDown(KeyCode.Space))
        {
            hanged = true;
        }
        if (hanged == true && Input.GetKeyUp(KeyCode.Space))
        {
            hanged = false;
        }
    }
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Object" && hanged == true)
        {
            col.transform.parent = GameObject.Find("Robot").transform;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            
        }
        if (hanged == false)
        {
            col.transform.parent = GameObject.Find("Objects").transform;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;

        }

    }
    

}
