using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace EntryPoint
{
    public class FadeIn : MonoBehaviour
    {

        public Image panel;

        private int nextScene;

        void Start()
        {
            //Eventually add Getter for scene loader flexibility
            nextScene = 1;
            panel = GetComponent<Image>();
            StartCoroutine(Fade());
            StartCoroutine(EndScene());
        }

        void Update()
        {

        }


        IEnumerator Fade()
        {
            for (float f = 1f; f >= 0; f -= 0.1f)
            {
                Color c = panel.color;
                c.a = f;
                panel.color = c;

                yield return new WaitForSeconds(0.1f);
            }

        }

        IEnumerator EndScene()
        {
            yield return new WaitForSeconds(5f);
            TitleEnd(nextScene);
        }

        void TitleEnd(int value)
        {
            SceneManager.LoadScene(value);
        }

    }
}
