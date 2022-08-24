using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{
    public string sceneName;
    public SceneLoader sceneLoader;

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            Debug.Log("Enter");
            sceneLoader.LoadNewScene(sceneName);
        }
    }
}
