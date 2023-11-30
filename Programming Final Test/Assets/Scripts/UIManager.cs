using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    Button startButton;
    Button resetButton;
    
    [SerializeField] BallController ball; 
    // Start is called before the first frame update
    void Start()
    {
        GameStart();

    }

    void GameStart()
    {
        startButton = transform.Find("MainMenuPanelMenu").Find("Button").GetComponent<Button>();
        startButton.onClick.AddListener(LoadScene);
        startButton = transform.Find("MainMenuPanelMenu").Find("Button").GetComponent<Button>();
    }

    void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void GameOver()
    {
        if(ball.ReturnGameOverStatus() == true)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    private void Reset()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
