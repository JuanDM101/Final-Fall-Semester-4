using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = false;

    public Button replayButton;

    // Start is called before the first frame update
    void Start()
    {
        replayButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        isGameActive = false;
        replayButton.gameObject.SetActive(true);
    }

    public void PressReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene.buildIndex);
    }

    
}
