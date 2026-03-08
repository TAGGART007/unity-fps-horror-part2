using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class panelscript : MonoBehaviour {

    public GameObject Menupanel;
    public GameObject Helppanel;
    public GameObject Controlpanel;
    public GameObject Objectivepanel;
    public GameObject Exitpanel;

    public void Playbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void Helpbutton()
    {
        Menupanel.SetActive(false);
        Helppanel.SetActive(true);
    }
    public void Backbutton()
    {
        Menupanel.SetActive(true);
        Helppanel.SetActive(false);
    }
    public void Objecivebutton()
    {
        Helppanel.SetActive(false);
        Objectivepanel.SetActive(true);
    }
    public void backbutton()
    {
        Helppanel.SetActive(true);
        Objectivepanel.SetActive(false);
    }
    public void Controlbutton()
    {
        Helppanel.SetActive(false);
        Controlpanel.SetActive(true);
    }
    public void Back1button()
    {
        Helppanel.SetActive(true);
        Controlpanel.SetActive(false);
    }
    public void Exitbutton()
    {
        Menupanel.SetActive(false);
        Exitpanel.SetActive(true);
    }
    public void YesButton()
    {
        Application.Quit();
    }
    public void Nobutton()
    {
        Exitpanel.SetActive(false);
        Menupanel.SetActive(true);
    }
    public void restartbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void exittomainmenubutton()
    {
        SceneManager.LoadScene(0);
    }
}
