using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garra : MonoBehaviour {

    bool setUp;

    GrabBox gb;

	// Use this for initialization
	void Start () {
       gb= FindObjectOfType<GrabBox>();
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && setUp == false )
        {
            StartCoroutine(getUp());
        }
        if (Input.GetKeyDown(KeyCode.E) && setUp == true && gb.hanged ==    false)
        {
            StartCoroutine(getDown());
        }
    }

    IEnumerator getUp()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;
        setUp = true;
    }

    IEnumerator getDown()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        setUp = false;
    }

}
