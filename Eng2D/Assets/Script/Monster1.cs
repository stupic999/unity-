using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : MonoBehaviour {

    public GameObject door;
    public GameObject monster1;
	
	// Update is called once per frame
	void Update () {
        if (GameController.GunDone== true)
        {
            door.SetActive(false);
            monster1.SetActive(true);        
        }
	}
}
