using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// OPTIONS placeholder for structure

namespace EntryPoint
{
    public class PlayerOptions : MonoBehaviour
    {
        private float _startSpeed = 2f;
        private int _scoreThreshold = 5000;


        public float StartSpeed
        {
            get {return _startSpeed; }
            set { _startSpeed = value;}
        }

        public int ScoreThreshold
        {
            get { return _scoreThreshold;}
            set { _scoreThreshold = value;}
        }

    }
}
