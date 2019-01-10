using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpcontroller : MonoBehaviour {

    Slider slider;
    GameObject daruma;

    // Use this for initialization
    void Start() {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        daruma = GameObject.Find("daruma");
    }

    // Update is called once per frame
    void Update() {
        slider.value = this.daruma.GetComponent<darumacontroller>().GetHp();
    }
}
