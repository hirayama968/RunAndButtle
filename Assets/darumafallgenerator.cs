using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darumafallgenerator : MonoBehaviour {

    public GameObject darumafallprefab;
    float span = 8.0f;
    float delta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if (this.delta > this.span) {
            this.delta = 0;
            GameObject go = Instantiate(darumafallprefab) as GameObject;
            int px = Random.Range(0, 20);
            int py = Random.Range(0, 0);
            go.transform.position = new Vector3(px, py, 0);
        }


	}
}
