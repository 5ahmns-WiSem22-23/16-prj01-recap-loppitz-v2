
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private float timeLeft = 60;
    [SerializeField]
    private Text timeText;

  
    void Update()
    {
        TimeDisplay(timeLeft);
        if (timeLeft > 1)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("YouLost");
        }
    }

    void TimeDisplay(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeLeft / 60);
        float seconds = Mathf.FloorToInt(timeLeft % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
