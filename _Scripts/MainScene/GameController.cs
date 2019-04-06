using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global;
using OtherObjects;

public class GameController : MonoBehaviour
{

    //Object Links
    private GameSettings gameSettings;
    private UiManager uiManager;
    private SceneController sceneControl;
    private SpawnBehaviour spawnBehaviour;
    private CatController catController;

    private float currentSpeed;
    private int swagValue;
    private int threshold = 0;

	void Start ()
    {
        spawnBehaviour = FindObjectOfType<SpawnBehaviour>();
        sceneControl = FindObjectOfType<SceneController>();
        gameSettings = FindObjectOfType<GameSettings>();
        uiManager = FindObjectOfType<UiManager>();
        catController = FindObjectOfType<CatController>();
        currentSpeed = gameSettings.SpeedSet;
    }

    void Update()
    {
        // Death Checking
        if (uiManager.Lives <= 0)
        {
            sceneControl.Death();
        }
        //Score threshold check, If threshod is reached, up game speed and trigger extra spawn event.
        if (threshold >= gameSettings.ScoreThreshold)
        {
            Debug.Log("Threshold reaached " + threshold);
            SpeedThreshold();
            spawnBehaviour.TrigggerSpawn();
            catController.SpeedAdjust();
        }
    }

    //Score and Score/Speed relationship
    public void SwagTaken()
    {
        Debug.Log("Swag");
        swagValue = Random.Range(750,1001);
        uiManager.Swag = swagValue;
        threshold += swagValue;
    }

    public void Damage()
    {
        Debug.Log("Damage");
        uiManager.Lives -= 1;
    }

    //**************** SPEED CONTROL AREA******************************

    public float SpeedLimiter
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
    }

    void SpeedThreshold()
    {
        threshold = 0;
        SpeedLimiter += 0.25f;
    }

    //***************END SPEED CONTROL*********************************

}
