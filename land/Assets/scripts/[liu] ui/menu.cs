using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menu : MonoBehaviour
{

    private Button localgameB;
    private Button teachingModeB;
    private Button exit;
    private Button informationB;
    // Start is called before the first frame update
    void Start()
    {
        localgameB = transform.Find("localgame").GetComponent<Button>();
        localgameB.onClick.AddListener(localStart);
        teachingModeB = transform.Find("teaching mode").GetComponent<Button>();
        teachingModeB.onClick.AddListener(teachStart);
        exit = transform.Find("exit").GetComponent<Button>();
        exit.onClick.AddListener(exitApplication);
        informationB = transform.Find("information").GetComponent<Button>();
        informationB.onClick.AddListener(informationStart);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void localStart()
	{
        GameManager.Instance.LoadScene("localGame");
	}
    private void teachStart()
    {
        GameManager.Instance.LoadScene("teachingMode");
    }
    private void informationStart()
	{
        GameManager.Instance.LoadScene("information");
	}
    private void exitApplication()
	{
        Application.Quit();
        print("quit game");
	}
}
