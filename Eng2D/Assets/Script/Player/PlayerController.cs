using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () {

        // 移动
        if (GameController.isPause == false)
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(0, 0.1f, 0, Space.World);

            if (Input.GetKey(KeyCode.S))
                transform.Translate(0, -0.1f, 0, Space.World);

            if (Input.GetKey(KeyCode.A))
                transform.Translate(-0.1f, 0, 0, Space.World);

            if (Input.GetKey(KeyCode.D))
                transform.Translate(0.1f, 0, 0, Space.World);

            if (Input.GetMouseButton(0))
                Debug.Log("Fire!");
        }
    }
}
