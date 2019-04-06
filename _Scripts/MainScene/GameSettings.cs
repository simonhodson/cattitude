// Game Settings job is to take options from namespace Entrypoint and use them in current scene
//Behaving as a bridge to Entrypoint namespcace.
// If scene changes this can rebuild from options scene reducing risk of carrying altered settings over
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntryPoint;

public class GameSettings : MonoBehaviour
{
    private PlayerOptions playerOptions;
    private float _scrollspeed;
    private int _scoreThreshold;

    void Start()
    {
        playerOptions = FindObjectOfType<PlayerOptions>();
        _scrollspeed = playerOptions.StartSpeed;
        _scoreThreshold = playerOptions.ScoreThreshold;
    }

    // Get/Set speed of scrolling building
    public float SpeedSet
    {
        get { return _scrollspeed; }
        set { _scrollspeed = value;}
    }

    // Adjustable Score Threshold for options screen
    public int ScoreThreshold
    {
        get {return  _scoreThreshold; }
        set {_scoreThreshold = value; }
    }
}
