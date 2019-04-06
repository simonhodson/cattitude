using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    //**** UI Manaer to manage only  visual compnenets, using Get/Set  *****

    [SerializeField]
    private Text swagText;
    [SerializeField]
    private Text livesText;
    //End TEMPOARY

    //Private 
    private int _swag = 0;
    private int _lives = 9;

	// Use this for initialization
	void Awake () {
        //initials Text
        //swagText.color = Color.red;
        swagText.text = "Swag  " + _swag ;
        livesText.text = _lives + " Lives";
	}

    void Start()
    {
      
    }

    void Update()
    {
        swagText.text = "Swag  " + _swag;
        livesText.text = _lives + " Lives";
    }


    // *********** GETTERS AND SETTERS ************

	public int Swag
    {
        get { return _swag; }
        // += next score value
        set { _swag += value; }
    }

    public int Lives
    {
        get { return _lives; }
        set { _lives = value; }
    }

}
