using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class darumafallcontroller : MonoBehaviour {

    Rigidbody2D rigid2D;
    float ypos = 999999999f;
    float time = 8.0f;
    int step = 0;
    GameObject player;
    float howfast;

	// Use this for initialization
	void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
        ypos = transform.position.y;
        this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        if (step == 10) {
            if (ypos == transform.position.y) {
                if (this.player.GetComponent<playercontroller>().isIphone()) {
                    howfast = -100f;
                } else {
                    howfast = -40.0f;
                }
                this.rigid2D.AddForce(transform.right * howfast);
            }
            step = 0;
        }
        step += 1;
        ypos = transform.position.y;
        this.time -= Time.deltaTime;
        if (this.time < 0.0f) {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.8f;
        if (d < r1 + r2) {
            SceneManager.LoadScene("Over");
        }
	}
}
