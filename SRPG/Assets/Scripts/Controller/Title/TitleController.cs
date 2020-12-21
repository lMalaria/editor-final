using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TitleController : MonoBehaviour {

    enum CanvasType
    {

    }


    enum PanelType
    {
        LoadPanel = 0,
        OptionPanel,
        Count
    }

    PanelType panelType;

    public Panel[] panels;

    public void PressButton()
    {
        switch(EventSystem.current.currentSelectedGameObject.name)
        {
            case "Start Button":
                StartNewGame();
                break;
            case "Load Button":
                SeeLoadPanel();
                break;
            case "Option Button":
                SelectOption();
                break;
            case "Exit Button":
                ExitGame();
                break;
        }
    }

    void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    void SeeLoadPanel()
    {

        panels[(int)PanelType.LoadPanel].enabled = true;
    }

    void LoadGame()
    {

    }

    void SelectOption()
    {

    }

    void ExitGame()
    {

    }
}
