using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
{
    [SerializeField]
    int lvl;
    public void Start()
    {

    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(lvl);
    }


}
