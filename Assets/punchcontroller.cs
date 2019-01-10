using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchcontroller : MonoBehaviour {

    GameObject buttledirector;

	// Use this for initialization
	void Start () {
        this.buttledirector = GameObject.Find("buttledirector");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.buttledirector.GetComponent<buttledirector>().HowMuch() < 1000) {
            Destroy(gameObject);
        }
	}
}
