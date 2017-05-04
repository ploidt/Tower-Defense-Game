using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCotroller : MonoBehaviour {

    public Text lifeText;
    public Text wavesText;
    public Text expText;

    private int life;
    private int waves;
    private int exp;

    // Use this for initialization
    void Start () {
        life = 20;
        waves = 0;
        exp = 0;
        SetText();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SetText()

    {
        lifeText.text = "Life: " + life.ToString();
        wavesText.text = "Waves: " + waves.ToString();
        expText.text = "Exp: " + exp.ToString();
    }


}
