using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject winScreen;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(score >= 280)
        {
            winScreen.SetActive(true);
            WaitForScene();
        }
        scoreText.text = "Score: " + score;
    }

    public void WaitForScene()
    {
        Invoke("LoadScene", 3);
    }
    void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
