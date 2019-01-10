using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rundirector : MonoBehaviour {

    GameObject timerText;
    float time = 60.0f;
    GameObject pointText;
    public static int point;
    public static int resttime;

    public void GetMoney() {
        point += 1000;
    }

    public static int HowMuch() {
        return point;
    }

    public static int RestTime() {
        return resttime;
    }

	// Use this for initialization
	void Start () {
        point = 0;
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
	}
	
	// Update is called once per frame
	void Update () {
        this.time -= Time.deltaTime;
        resttime = (int) this.time;
        if (this.time < 0.0f) {
            SceneManager.LoadScene("Over");
        }
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");

        this.pointText.GetComponent<Text>().text = "¥" + point.ToString();
	}
}
