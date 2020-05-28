using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    private static GameManager _Instance;

    public static GameManager Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = new GameManager();


            }
            return _Instance;

        }

    }

    public void LoadScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

}