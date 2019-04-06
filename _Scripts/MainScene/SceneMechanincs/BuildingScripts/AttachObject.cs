using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObject : MonoBehaviour {
    [SerializeField]
    private GameObject[] PosativeEvents;
    [SerializeField]
    private GameObject[] NegativeEvents;
    [SerializeField]
    private GameObject[] Prefabs;
    private bool posNeg = true;

    public void ObjectAttachmentMethod(GameObject target)
    {
        // create a posative and a negative event to parse
        if (posNeg)
        {
            // Create a random event from array of posatives
            GameObject.Instantiate(PosativeEvents[Random.Range(0, 3)], target.transform.position, Quaternion.identity, target.transform.parent);
            GameObject.Instantiate(Prefabs[0], target.transform.position, Quaternion.identity, target.transform.parent);
            //Switch posNeg
            posNeg = false;
        }
        else
        {
            //Else create a random event from Negative array
            GameObject.Instantiate(NegativeEvents[Random.Range(0, 3)], target.transform.position, Quaternion.identity, target.transform.parent);
            GameObject.Instantiate(Prefabs[0], target.transform.position, Quaternion.identity, target.transform.parent);
            //Switch posNeg
            posNeg = true;
        }

       
    }


}
