using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    public Vector3 cameraOffset;

    private void Start()
    {

        cameraOffset = transform.position - Player.transform.position;

    }

    void LateUpdate ()
    {
        transform.position = Player.transform.position + cameraOffset;
        
		
	}
}
