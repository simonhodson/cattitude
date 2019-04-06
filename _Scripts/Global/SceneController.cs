using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Global
{
    public class SceneController : Singleton<SceneController>
    {
        void Start()
        {

        }

        //Load Main Game currently by name
        public void GameStart()
        {
            SceneManager.LoadScene("04_Game");
        }

        public void Options()
        {
            SceneManager.LoadScene("03_Options");
        }

        public void Quit()
        {
            Debug.Log("I am quitting");
            //SceneManager.LoadScene("12_ExitMenu");
            // Learn about quitting

        }

        public void MainMenu()
        {
            SceneManager.LoadScene("02_MainMenu");
        }

        public void Death()
        {
            SceneManager.LoadScene("11_GameOver");
        }

    }
}