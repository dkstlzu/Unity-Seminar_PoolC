using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevCommand : MonoBehaviour
{
    public Text text;
    
    private const string DefaultText = "Press \"Tab\" to use Dev Commands.";
    private const string WrongCommandText = "You typed wrong command.";
    private Coroutine WrongCommandCoroutine;
    private bool DevCommandLineOn = false;

    [SerializeField] private GameObject DevUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            text.text = "";

            if (WrongCommandCoroutine != null) StopCoroutine(WrongCommandCoroutine);

            DevCommandLineOn = true;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            ExecuteCommand(text.text);
            DevCommandLineOn = false;
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            text.text = text.text.Remove(text.text.Length-1, 1);
        } else if (DevCommandLineOn)
        {
            foreach (var character in Input.inputString)
            {
                text.text += character;
            }
        }
    }

    void ExecuteCommand(string commandText)
    {
        bool SomethingWrong = false;
        string[] texts = commandText.ToLower().Split();

        IEnumerator textIterator = texts.GetEnumerator();
        if (!textIterator.MoveNext()) {WrongCommandCoroutine = StartCoroutine(WrongCommand()); return;};

        string tempStr;
        switch(textIterator.Current)
        {
            case "dev":
            if (!textIterator.MoveNext()) {SomethingWrong = true; break;};

            if (textIterator.Current.Equals("on")) DevTestingOn();
            else if (textIterator.Current.Equals("off")) DevTestingOff();
            else SomethingWrong = true;
            break;


            case "playsound":
            if (!textIterator.MoveNext()) {SomethingWrong = true; break;}
            string soundName = textIterator.Current as string;

            
            break;


            case "event":
            if (!textIterator.MoveNext()) {SomethingWrong = true; break;}

            tempStr = textIterator.Current as string;
            if (tempStr.Equals("invoke"))
            {
                if (!textIterator.MoveNext()) {SomethingWrong = true; break;}

                tempStr = textIterator.Current as string;

            }
            break;

            case "startroom":
            if (!textIterator.MoveNext()) {SomethingWrong = true; break;}

            tempStr = textIterator.Current as string;
            break;
            default: SomethingWrong = true;
            break;
        }

        if (SomethingWrong)
        {
            WrongCommandCoroutine = StartCoroutine(WrongCommand());
        } else
        {
            text.text = DefaultText;
        }
    }

    IEnumerator WrongCommand()
    {
        text.text = WrongCommandText;
        yield return new WaitForSeconds(2f);
        text.text = DefaultText;
        WrongCommandCoroutine = null;
    }

    private void DevTestingOn()
    {
        DevUI.SetActive(true);
    }

    private void DevTestingOff()
    {
        DevUI.SetActive(false);
    }
}
