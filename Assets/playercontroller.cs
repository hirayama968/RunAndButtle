using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour {

    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 200.0f;
    float jumpForceIphone = 400.0f;
    float jumpForceIs;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float maxJumpSpeed = 0.8f;
    float threshold = 0.2f;
    bool isiphone = false;

    public void moneysound() {
        GetComponent<AudioSource>().Play();
    }

    public bool isIphone() {
        return isiphone;
    }

	// Use this for initialization
	void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float jumpx = Mathf.Abs(this.rigid2D.velocity.y);
        if ((Input.GetKeyDown(KeyCode.Space)) || (Input.GetMouseButtonDown(0)) && (this.rigid2D.velocity.y == 0)) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                jumpForceIs = jumpForce;
            } else {
                jumpForceIs = jumpForceIphone;
                isiphone = true;
            }
            if (jumpx < this.maxJumpSpeed) {
                this.animator.SetTrigger("JumpTrigger");
                this.rigid2D.AddForce(transform.up * this.jumpForceIs);
            }
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow) || (Input.acceleration.x > this.threshold)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.acceleration.x < -this.threshold)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        if (speedx < this.maxWalkSpeed) {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (this.rigid2D.velocity.y == 0) {
            this.animator.speed = speedx / 2.0f;
        } else {
            this.animator.speed = 1.0f;
        }

	}

    private void OnTriggerEnter2D(Collider2D other) {
        SceneManager.LoadScene("Buttle");
	}
}
