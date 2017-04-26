using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GSM_Behaviour : MonoBehaviour {
    //pause function
    public bool pause = false;
    public bool gameover = false;
    //in Game Gold
    public Text goldLabel;
    private int gold;
    public int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
        }
    }
    //In Game Trait
    public Text essenceLabel;
    private int essence;
    public int Essence
    {
        get
        {
            return essence;
        }
        set
        {
            essence = value;
        }
    }
    //In Game Lives
    public Text lifeLabel;
    private int lives;
    public int Lives
    {
        get
        {
            return lives;
        }
        set
        {
            lives = value;
        }
    }
    //In Game Wave
    public Text waveLabel;
    private int wave;
    public int Wave
    {
        get
        {
            return wave;
        }
        set
        {
            wave = value;
        }
    }
    //Trait System
    [System.Serializable]
    public class Trait
    {
        public string name;
        public string description;
        public int cost;
        public int level;
    }
    [System.Serializable]
    public class TraitTree
    {
        public string name;
        public string description;
        public Trait[] traits;
    }
    public TraitTree[] Player_Trait;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
