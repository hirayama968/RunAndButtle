using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneycontroller : MonoBehaviour {

    GameObject player;
    GameObject rundirector;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player");
        this.rundirector = GameObject.Find("rundirector");
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.8f;
        if (d < r1 + r2) {
            this.rundirector.GetComponent<rundirector>().GetMoney();
            this.player.GetComponent<playercontroller>().moneysound();
            Destroy(gameObject);
        }
	}
}
