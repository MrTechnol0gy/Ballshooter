using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelect : MonoBehaviour
{    
    public int level;
    public TMP_Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenScene()
    {
        SceneManager.LoadScene("lvl" + level.ToString());
    }
}
