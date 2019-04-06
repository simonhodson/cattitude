using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OtherObjects {
    public class SpawnedItemMovement : MonoBehaviour {

        private float speed = 3.0f;

        // Use this for initialization
        void Start() {

            speed *= Time.deltaTime;

        }

        // Update is called once per frame
        void Update() {

            transform.Translate(Vector3.up * speed);

        }

    }
}
