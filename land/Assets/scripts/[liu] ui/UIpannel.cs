using UnityEngine;
using UnityEngine.UI;

public class UIpannel : MonoBehaviour
{
    public Image dialog;
    public Text contentText;

    public void showDialog(bool value)
    {
        dialog.enabled = value;
    }

    public void setContext(string value)
    {
        contentText.text = value;
    }

    public void showText(bool value)
    {
        contentText.enabled = value;
    }
}
