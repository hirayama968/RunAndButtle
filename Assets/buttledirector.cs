using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttledirector : MonoBehaviour {

    GameObject timerText;
    float time = 60.0f;
    GameObject pointText;
    int point = 0;
    GameObject daruma;
    GameObject msg1;
    GameObject msg2;
    GameObject msg3;
    GameObject msg4;
    GameObject msg5;

    public void LoseMoney(int lose) {
        this.point -= lose;
    }

    public int HowMuch() {
        return this.point;
    }

    public void PutMsg(string text) {
        this.msg1.GetComponent<Text>().text = this.msg2.GetComponent<Text>().text;
        this.msg2.GetComponent<Text>().text = this.msg3.GetComponent<Text>().text;
        this.msg3.GetComponent<Text>().text = this.msg4.GetComponent<Text>().text;
        this.msg4.GetComponent<Text>().text = this.msg5.GetComponent<Text>().text;
        this.msg5.GetComponent<Text>().text = text;
    }

	// Use this for initialization
	void Start () {
        this.timerText = GameObject.Find("ButtleTime");
        this.pointText = GameObject.Find("ButtlePoint");
        this.point = rundirector.HowMuch() + rundirector.RestTime() * 10;
        daruma = GameObject.Find("daruma");
        this.msg1 = GameObject.Find("Text1");
        this.msg2 = GameObject.Find("Text2");
        this.msg3 = GameObject.Find("Text3");
        this.msg4 = GameObject.Find("Text4");
        this.msg5 = GameObject.Find("Text5");
	}
	
	// Update is called once per frame
	void Update () {
        this.time -= Time.deltaTime;
        if (this.time < 0.0f) {
            SceneManager.LoadScene("Over");
        }
        if (this.daruma.GetComponent<darumacontroller>().GetHp() < 0.0f) {
            SceneManager.LoadScene("Clear");
        }
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");

        this.pointText.GetComponent<Text>().text = "¥" + this.point.ToString();
	}
}
