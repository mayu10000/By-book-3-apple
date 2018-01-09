﻿using System.Collections;
//  using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{


    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;

    void start()
    {
        this.aud = GetComponent<AudioSource>();

    }



    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Apple")
        {

            this.aud.PlayOneShot(this.appleSE);

            Debug.Log("Tag = Apple");

        }
        else
        {
            this.aud.PlayOneShot(this.bombSE);

            Debug.Log("Tag = Bomb");

        }

        Destroy(other.gameObject);
    }





    //	Debug.Log("キャッチ! ");




    // Use this for initialization
    //  void Start () {

    //	}




    // Update is called once per frame

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {

                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0.0f, z);

            }
        }
    }



}


		
	

