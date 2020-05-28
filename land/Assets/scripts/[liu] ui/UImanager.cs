using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public List<string> contents;
    public UIpannel pannel;
    private int currentLine;
    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {

            showUI();
            loadText(contents[currentLine]);
        }
        if (Input.GetMouseButtonDown(0))
        {
            nextLine();
            if (currentLine >= contents.Count)
            {
                currentLine = contents.Count;
                init();
            }
            loadText(contents[currentLine]);
        }
    }

    void init()
	{
        hideUI();
        currentLine = 0;
        pannel.setContext("");
	}

    void showUI()
	{
        pannel.showDialog(true);
        pannel.showText(true);
	}

    void hideUI()
	{
        pannel.showText(false);
        pannel.showDialog(false);
	}

    void nextLine()
    {
        currentLine++;
    }

    void loadText(string value)
	{
        pannel.setContext(value);
	}
}
