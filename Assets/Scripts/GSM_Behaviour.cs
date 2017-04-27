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
            goldLabel.text = "Gold: " + gold;
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
            essenceLabel.text = "Essence: " + essence;
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
            lifeLabel.text = "Lives: " + lives;

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
            waveLabel.text = "Wave: " + wave;
        }
    }
    //Trait System
    [System.Serializable]
    public class Trait
    {
        public int id;
        public string name;
        public string description;
        public int cost;
        public int level;
        public int max_level;
        public bool enabled;
        public void upgrade()
        {
            if(this.level < max_level)
            { 
                this.level = this.level + 1;
            }
        }
        public void learn()
        {
            if(this.enabled == false)
            {
                this.enabled = true;
            }
        }
    }
    [System.Serializable]
    public class TraitTree
    {
        public Trait[] traits;
        public bool has_max_level = false;
        public void levelup(Trait trait)
        {
            if(has_max_level == false)
            { 
                foreach (Trait looped_trait in traits)
                {
                    if (looped_trait.level < looped_trait.max_level && trait.id == looped_trait.max_level)
                    {
                        looped_trait.upgrade();
                        if(looped_trait.level == looped_trait.max_level)
                        {
                            has_max_level = true;
                        }
                    }
                }
            }
        }
    }
    public TraitTree Player_Trait;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
