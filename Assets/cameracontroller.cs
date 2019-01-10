using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        float x;
        Vector3 playerPos = this.player.transform.position;
        if (playerPos.x >= 6.0f) {
            x = 15.0f;
        } else {
            x = playerPos.x + 9.0f;
        }
        x = x - 0.9f;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}
}
