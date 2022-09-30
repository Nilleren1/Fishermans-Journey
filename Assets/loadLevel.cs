using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;

    public bool useIntegerToLoadLevel = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collsionGameObject = collision.gameObject;


        if((collsionGameObject.name == "Avatar") && (Input.GetKey(KeyCode.E)))
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }


    }
}
