using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }


          private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            var ActiveScene = SceneManager.GetActiveScene();

             if(ActiveScene.name == "SampleScene")
             {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
             }
             if(ActiveScene.name == "Dungeon1")
             {
                  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
             }

        }
     }


}