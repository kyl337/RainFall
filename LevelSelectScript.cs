using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
