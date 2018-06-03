using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    
    private int evilPoint;
    private int goodPoint;

    public int EvilPoint
    {
        get
        {
            return evilPoint;
        }

        set
        {
            evilPoint = value;
        }
    }

    public int GoodPoint
    {
        get
        {
            return goodPoint;
        }

        set
        {
            goodPoint = value;
        }
    }

    // Use this for initialization
    void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnLevelWasLoaded(int level)
    {
        AdScript ads = new AdScript();
        ads = FindObjectOfType<AdScript>();
        ads.showInterstitialAd();
    }
}
