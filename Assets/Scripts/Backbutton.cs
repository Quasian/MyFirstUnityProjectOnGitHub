using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Backbutton : MonoBehaviour
{
    public Button backbutton;
    public string Master;




 
    void Start()
    {
        backbutton.onClick.AddListener(OnBackClick);
    }


    private void OnBackClick()
        {
        SceneManager.LoadScene(Master);
        }
    
    
}
