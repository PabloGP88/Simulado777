using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsTrigger : MonoBehaviour {
    public int objetos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Object"){
            objetos++;
            Points.FindObjectOfType<Points>().AddPoints(1);
        }
    }
    private void OnTriggerStay(Collider col)
    {
        print(col.gameObject);
       if(objetos >= 4)
        {
            
            Destroy(col.gameObject);
            Points.FindObjectOfType<Points>().AddPoints(20);
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Object")
        {
            objetos--;
        }
    }
}
