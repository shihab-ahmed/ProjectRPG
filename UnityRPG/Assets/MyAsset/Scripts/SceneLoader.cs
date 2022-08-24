using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButton(0))
        //{
        //    LoadNewScene(sceneName);
        //}
    }
    public void LoadNewScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
