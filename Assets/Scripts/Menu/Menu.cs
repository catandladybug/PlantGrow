using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Toggle raining;
    public Toggle animal;
    public Toggle cold;
    public int sceneToLoad = 1;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        raining = GameObject.FindGameObjectWithTag("Raining").GetComponent<Toggle>();
        animal = GameObject.FindGameObjectWithTag("Animal").GetComponent<Toggle>();
        cold = GameObject.FindGameObjectWithTag("Cold").GetComponent<Toggle>();
    }
    public void Load()
    {
        SceneManager.LoadScene(sceneToLoad);
        if (sceneToLoad == 1)
            sceneToLoad = 0;
        else
            Destroy(this.gameObject);
    }
}
