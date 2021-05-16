using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public Sprite []overlaySprites;
    public Image overlay;
    public Text timeHud;
    public Text scoreHud;

    public float tempo;
    public int pontos;

    public enum GameStatus { WIN, LOSE, DIE, PLAY }
    public GameStatus status;



    void Awake() { 
    
    if (instance == null) {
            instance = this;

        }
        else {
            Destroy(gameObject);
        
        }

    }

    // Use this for initialization
    void Start () {

        tempo = 30f;
        pontos = 0;
        status = GameStatus.PLAY;
        overlay.enabled = false;
        Physics2D.IgnoreLayerCollision(9, 10, false);

    }

    // Update is called once per frame
    void Update()
    {

        if (status == GameStatus.PLAY)
        {

            tempo -= Time.deltaTime;
            int timeInt = (int)tempo;

            if (timeInt >= 0)
            {
                timeHud.text = "Tempo: " + timeInt.ToString();
                scoreHud.text = "Pontos: " + pontos.ToString();

            }

        }
        else if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {

            if (status == GameStatus.WIN)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            }

        }
    }
public void SetOverlay(GameStatus parStatus) {

        status = parStatus;
        overlay.enabled = true;
        overlay.sprite = overlaySprites[(int)parStatus];

}


}
