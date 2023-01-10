
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}