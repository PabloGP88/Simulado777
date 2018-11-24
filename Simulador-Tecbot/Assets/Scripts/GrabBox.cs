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
        Debug.Log(hanged);
        if (hanged == false && Input.GetKeyDown(KeyCode.Space))
        {
            hanged = true;
        }
        if (hanged == true && Input.GetKeyUp(KeyCode.Space))
        {
            hanged = false;
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("a la verga");
        if (col.gameObject.tag == "Object" && hanged == true)
        {

            col.transform.parent = gameObject.transform;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            
        }
        if (hanged == false)
        {
            col.transform.parent = GameObject.Find("Objects").transform;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;

        }

    }
   

}
