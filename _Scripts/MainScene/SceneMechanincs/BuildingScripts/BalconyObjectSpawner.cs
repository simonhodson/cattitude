using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// TODO: ++++++++++++ Replace instantiate with and on off system for overhead cost reduction?? +++++
public class BalconyObjectSpawner : MonoBehaviour
{
    // Will hold intsatniatble objects required for scene. Currently Balconies
    // Adding Gameobjects positioned at each window in unity for an anchor
    [SerializeField]
    private GameObject[] rowOne;
    [SerializeField]
    private GameObject[] rowThree;
    [SerializeField]
    private GameObject[] lowerRowOne;
    [SerializeField]
    private GameObject[] lowerRowThree;
    //Private initialize a new list that carries all GO arrays above that are to be used for spawns
    //Below carry balcony objects
    private List<GameObject[]> balconyRows = new List<GameObject[]>();
    private List<GameObject[]> balconyRowsLower = new List<GameObject[]>();
    //TODO: Add lists of even numbers arrays upper and lower to utalise additional features
    private int randomValueOne;
    private int randomValueTwo;
    private AttachObject attachObject;

    void Start()
    {
        attachObject = FindObjectOfType<AttachObject>();
        //Populate list with rows arrays
        //We are only populating one and three to leave gamespace for other events
        balconyRows.Add(rowOne);
        balconyRows.Add(rowThree);
        balconyRowsLower.Add(lowerRowOne);
        balconyRowsLower.Add(lowerRowThree);
        //Starting methods that spawn objects
        RowRange();
        RowRangeLower();
    }

    //Method involved in choosing and assigning target and prefab for instantiate
    public void RowRange()
    {

        for (int i = 0; i < balconyRows.Count; i++)
        {
            //Generate random Int 1 & 2 first set min max to required length
            Randomizer(0, 3);
            // Choose a ROW in list balconyRows
            var targetObj = balconyRows[i];
            // Set the two target locations in that row
            GameObject targetLoc = targetObj[randomValueOne];
            GameObject targetLocTwo = targetObj[randomValueTwo];

            // Activate attach Class with given target vectors
            attachObject.ObjectAttachmentMethod (targetLoc);
            attachObject.ObjectAttachmentMethod(targetLocTwo);
        }
    }

    public void RowRangeLower()
    {

        for (int i = 0; i < balconyRowsLower.Count; i++)
        {
            //Generate random Int 1 & 2 first set min max to required length
            Randomizer(0, 3);
            // Choose a ROW in list balconyRows
            var targetObj = balconyRowsLower[i];
            // Set the two target locations in that row
            GameObject targetLoc = targetObj[randomValueOne];
            GameObject targetLocTwo = targetObj[randomValueTwo];

            // Activate attach Class with given target vectors
            attachObject.ObjectAttachmentMethod(targetLoc);
            attachObject.ObjectAttachmentMethod(targetLocTwo);
        }
    }

    void Randomizer(int min, int max)
    {
        for (int i = 0; i < 1; i++)
        {
            randomValueOne = UnityEngine.Random.Range(min, max);
            randomValueTwo = UnityEngine.Random.Range(min, max);
            if (randomValueTwo != randomValueOne)
            {
                return;
            }
            else
            {
                randomValueTwo = UnityEngine.Random.Range(min, max);
                i += i - 1;
            }

        }
    }


}
