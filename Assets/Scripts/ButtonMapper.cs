using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonMapper : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public string Scene1;
    public string Scene2;
    public string Scene3;

    private void Start()
    { 
     button1.onClick.AddListener(OnButtonClick1);
        button2.onClick.AddListener(OnButtonClick2);
        button3.onClick.AddListener(OnButtonClick3);
    }

   
    private void OnButtonClick1()
    {
        SceneManager.LoadScene(Scene1);
    }

    private void OnButtonClick2()
    {
        SceneManager.LoadScene(Scene2);
    }


    private void OnButtonClick3()
    {
        SceneManager.LoadScene(Scene3);
    }
}
