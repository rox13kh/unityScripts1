using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour {

	public Camera firstPerson;
	public Camera thirdPerson;

    public PlayerController player;

	// Use this for initialization
	void Start () {

		//which camera do you want to enable first? 
		firstPerson.enabled = false;
		thirdPerson.enabled = true;
        player.CurrentCamera(thirdPerson);
	}
	
	// Update is called once per frame
	void Update () {

		//change POV with different keys
		if(Input.GetKeyDown(KeyCode.F5)){
			firstPerson.enabled = !firstPerson.enabled;
			thirdPerson.enabled = !thirdPerson.enabled;

            if (thirdPerson != true){
                player.CurrentCamera(firstPerson);
            }
		}

			
	}
}
