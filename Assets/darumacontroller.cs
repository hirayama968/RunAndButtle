using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darumacontroller : MonoBehaviour {

    GameObject buttledirector;
    int fulllife = 12000;
    int restlife = 12000;

    public float GetHp() {
        float hp = (float)restlife / (float)fulllife;
        return hp;
    }

	// Use this for initialization
	void Start () {
        this.buttledirector = GameObject.Find("buttledirector");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            if (this.buttledirector.GetComponent<buttledirector>().HowMuch() >= 200) {
                this.buttledirector.GetComponent<buttledirector>().LoseMoney(200);
                restlife -= 200;
                this.buttledirector.GetComponent<buttledirector>().PutMsg("パンチの効果は抜群だ！");
            } else if (this.buttledirector.GetComponent<buttledirector>().HowMuch() >= 50) {
                this.buttledirector.GetComponent<buttledirector>().LoseMoney(50);
                restlife -= 50;
                this.buttledirector.GetComponent<buttledirector>().PutMsg("まあまあのパンチ！");
            } else {
                if (this.buttledirector.GetComponent<buttledirector>().HowMuch() != 0) {
                    this.buttledirector.GetComponent<buttledirector>().LoseMoney(10);
                }
                restlife -= 10;
                int s = Random.Range(0, 4);
                switch (s) {
                    case 0:
                        this.buttledirector.GetComponent<buttledirector>().PutMsg("ショボパンチ　エイヤ");
                        break;
                    case 1:
                        this.buttledirector.GetComponent<buttledirector>().PutMsg("ショボパンチ ホイ");
                        break;
                    case 2:
                        this.buttledirector.GetComponent<buttledirector>().PutMsg("ショボパンチ　ソレ");
                        break;
                    case 3:
                        this.buttledirector.GetComponent<buttledirector>().PutMsg("ショボパンチ　アラヨット");
                        break;
                    case 4:
                        this.buttledirector.GetComponent<buttledirector>().PutMsg("ショボパンチ　ドシタ");
                        break;
                }
            }
        }
	}
}
