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

    [SerializeField] GameObject SnapGuess;
    [SerializeField] GameObject Snapnpose;
    [SerializeField] GameObject Snapncopy;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowGuess()
    {
        Instructions.SetActive(true);
        HideMenu();
        SnapGuess.SetActive(true);
    }

    public void ShowPose()
    {
        Instructions.SetActive(true);
        HideMenu();
        Snapnpose.SetActive(true);
    }

    public void ShowCopy()
    {
        Instructions.SetActive(true);
        HideMenu();
        Snapncopy.SetActive(true);
    }

    public void GoBack()
    {
        HideInstructions();
        ShowMenu();
    }

    public void HideInstructions()
    {
        Instructions.SetActive(false);
        SnapGuess.SetActive(false);
        Snapnpose.SetActive(false);
        Snapncopy.SetActive(false);
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