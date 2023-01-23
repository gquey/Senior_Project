using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TeleportationSpot : MonoBehaviour {

    private CharacterController charController;
    public GameObject TeleportSpot;
    public Vector3 destinationVector;

    void Start() {
        charController = gameObject.GetComponent<CharacterController>();
        destinationVector = TeleportSpot.transform.position;
        //Debug.Log(destinationVector);
    }

    void Update() {
        //Debug.Log("here");
        if (Input.GetKey(KeyCode.Q)) {
            teleportPlayer(destinationVector);
        }
    }

    void teleportPlayer(Vector3 location) {
        gameObject.transform.position = location;
        //Debug.Log(location + "!!!!");
    }
}