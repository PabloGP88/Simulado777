using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRobot : MonoBehaviour {
    public float speed;
    public float rotationSpeed;
    float translation;
    float rotation;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        translation = Input.GetAxis("Vertical") * speed;
        rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Mueve el robot

        transform.Translate(0, 0, translation);
        // Rota el robot
        transform.Rotate(0, rotation, 0);


    }
}
