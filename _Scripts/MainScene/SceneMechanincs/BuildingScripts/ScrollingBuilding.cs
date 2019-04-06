using System.Collections;
using UnityEngine;

public class ScrollingBuilding : MonoBehaviour
{
    [SerializeField]
    private GameObject UpperAnchor;
    [SerializeField]
    private GameObject LowerAnchor;
    private GameController gameControl;
    private BalconyObjectSpawner bos;
    private float speed;
    

    // Use this for initialization
    void Start()
    {
        gameControl = FindObjectOfType<GameController>();
        bos = FindObjectOfType<BalconyObjectSpawner>();
        speed = gameControl.SpeedLimiter;
    }

    void Update()
    {
        speed = gameControl.SpeedLimiter;
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
    }

    void OnBecameInvisible()
    {
        //Generate a new set of hazards, on whichever building was just moved
        if (this.tag == "Upper")
        {
            // Snaps tile to bottom of active tile
            if (LowerAnchor != null)
            {
                transform.position = LowerAnchor.transform.position;
                bos.RowRange();
            }
        }
        else
        {
            // Snaps tile to bottom of active tile
            if (UpperAnchor != null)
            {
                transform.position = UpperAnchor.transform.position;
                bos.RowRangeLower();
            }
        }
    }

}
