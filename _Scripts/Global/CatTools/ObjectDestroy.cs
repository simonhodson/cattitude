using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global
{
    public class ObjectDestroy : MonoBehaviour
    {

        // Use this for initialization
        void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
