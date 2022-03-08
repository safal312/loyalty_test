using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text text;
    public Slider slider;

    bool gameHasEnded = false;
    //public float restartDelay = 1f;

    private void Start()
    {
        slider.gameObject.SetActive(false);
        StartCoroutine(IntroAnim());
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            print("Game Over");
            StartCoroutine(Restart());
        }
    }

    IEnumerator IntroAnim()
    {
        text.text = "Man, shouldn't have had taco bell for lunch...";
        yield return new WaitForSeconds(2f);
        slider.gameObject.SetActive(true);
    }

    IEnumerator Restart()
    {
        text.text = "You shit your pants";
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //void Restart()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
