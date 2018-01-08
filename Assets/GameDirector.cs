using System.Collections;
//  using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを使うときは忘れないように注意！



public class GameDirector : MonoBehaviour {

    // Use this for initialization


 GameObject timerText ;

float time = 60.0f ;


	void Start() {

        this.timerText = GameObject.Find("Time");

       }
	
	// Update is called once per frame
	void Update () {


        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text =
            this.time.ToString("F1");

        
    }
}
