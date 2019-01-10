using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cleardirector : MonoBehaviour {

    float time = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.time -= Time.deltaTime;
        if (this.time < 0.0f) {
            if (Input.GetMouseButtonDown(0)) {
                SceneManager.LoadScene("Run Scene");
            }
        }
	}
}
