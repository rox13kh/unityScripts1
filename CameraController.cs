using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera firstPerson;
    public Camera thirdPerson;
    public Camera mapView;

    public GameObject target;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        firstPerson.transform.position = new Vector3(target.transform.position.x, 
                                                     target.transform.position.y, 
                                                     target.transform.position.z);

        thirdPerson.transform.position = new Vector3(target.transform.position.x, 
                                                     target.transform.position.y + 2, 
                                                     target.transform.position.z - 5);
                                                     
    }
}
