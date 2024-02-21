using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject Instructions;

    public Button snapnguess;
    public Button snapnpose;
    public Button snapncopy;
    public Button goback;
    public Button play;

    public void Start()
    {
        snapnguess.onClick.AddListener(ShowGuess);

        snapnpose.onClick.AddListener(ShowPose);

        snapncopy.onClick.AddListener(ShowCopy);

        goback.onClick.AddListener(GoBack);
        play.onClick.AddListener(Play);

    }

    public void Play()
    {
        SceneManager.LoadScene("CamTest 1");
    }

    public void ShowGuess()
    {
        Instructions.SetActive(true);
        HideMenu();

        GameObject instructionsWindow = GameObject.Find("Snap n Guess");
        instructionsWindow.SetActive(true);
    }

    public void ShowPose()
    {
        Instructions.SetActive(true);
        HideMenu();

        GameObject instructionsWindow = GameObject.Find("Snap n Pose");
        instructionsWindow.SetActive(true);
    }

    public void ShowCopy()
    {
        Instructions.SetActive(true);
        HideMenu();

        GameObject instructionsWindow = GameObject.Find("Snap n Copy");
        instructionsWindow.SetActive(true);
    }

    public void GoBack()
    {
        HideInstructions();
        ShowMenu();
    }

    public void HideInstructions()
    {
        Instructions.SetActive(false);
        HideMenu();
    }


    public void HideMenu()
    {
        mainMenu.SetActive(false);
    }

    public void ShowMenu()
    {
        mainMenu.SetActive(true);
    }
}