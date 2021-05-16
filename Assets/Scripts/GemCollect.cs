using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour {
    public AudioClip fxCollect;
    void OnTriggerEnter2D (Collider2D other) { 
    if (other.CompareTag("Player")) {

            GameManager.instance.pontos++;
            SoundManager.instance.PlayFxGemCollect (fxCollect);
            Destroy(gameObject);
    
    }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
