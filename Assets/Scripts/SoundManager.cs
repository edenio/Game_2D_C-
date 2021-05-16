using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;
    public AudioSource fxPlayer;
    public AudioSource FxGemCollect;

    void Awake() {
        if (instance == null) { 
        instance = this;

        }
        else {
            Destroy(gameObject);

        }

        DontDestroyOnLoad(gameObject);
    }
    public void playFxPlayer(AudioClip clip) {

        fxPlayer.clip = clip;
        fxPlayer.Play();
    
    }
    public void PlayFxGemCollect(AudioClip clip)
    {
        FxGemCollect.clip = clip;
        FxGemCollect.Play();


    }

}
   
   