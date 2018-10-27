using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody player;
    public int speed = 3;

    private Camera enabledCamera;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.W)){

            player.AddForce(transform.forward * speed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            player.AddForce(-transform.forward * speed);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed, Space.World);
            enabledCamera.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * speed, Space.World);
            enabledCamera.transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * speed, Space.World);
        }

    }

    public void CurrentCamera (Camera current){
        enabledCamera = current;
    }
}
