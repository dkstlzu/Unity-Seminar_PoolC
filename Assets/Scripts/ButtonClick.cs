using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Text text;
    public Scrollbar scrollbar;

    public void ChangeText()
    {
        Debug.Log("Change");
        text.text = "Button Clicked";
    }
}
