using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Settings;
    Animator anim;
    public GameObject ShowButton;
    public GameObject InfoMenu;
    public GameObject FakeInfoMenu;

    public GameObject[] Info;
    public GameObject[] ButForw;
    public GameObject[] ButBack;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void Show()
    {
        anim.Play("Show");
        ShowButton.SetActive(false);
    }
    public void Hide()
    {
        anim.Play("Hide");
        ShowButton.SetActive(true);
    }

    IEnumerator ShowInfoMenu()
    {
        yield return new WaitForSeconds(0.5f);
        InfoMenu.SetActive(true);
        FakeInfoMenu.SetActive(false);
    }
    IEnumerator HideInfoMenu()
    {
        yield return new WaitForSeconds(0.5f);
        InfoMenu.SetActive(false);
        FakeInfoMenu.SetActive(true);
        anim.Play("ShowInfo3");
    }
    public void Show1()
    {
        anim.Play("Show1");
        ShowButton.SetActive(false);
        StartCoroutine(ShowInfoMenu());
    }
    public void Hide1()
    {
        anim.Play("Hide1");
        ShowButton.SetActive(true);
        StartCoroutine(HideInfoMenu());
    }

    public void LoadPlane()
    {
        SceneManager.LoadScene("Floor");
    }
    public void LoadImage()
    {
        SceneManager.LoadScene("Umage");
    }
    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }

    ////////////свайп-инфа//////////////////
    
    public void nextInfo2()
    {
        anim.Play("ShowInfo2");
        ButForw[0].SetActive(false);
        ButForw[1].SetActive(true);
        ButBack[0].SetActive(true);
    }
    public void nextInfo3()
    {
        anim.Play("ShowInfo3");
        ButForw[1].SetActive(false);
        ButBack[0].SetActive(false);
        ButForw[2].SetActive(true);
        ButBack[1].SetActive(true);
    }
    public void nextInfo4()
    {
        anim.Play("ShowInfo4");
        ButForw[2].SetActive(false);
        ButBack[1].SetActive(false);
        ButBack[2].SetActive(true);
    }
    public void backInfo3()
    {
        anim.Play("BackInfo3");
        ButForw[2].SetActive(true);
        ButBack[1].SetActive(true);
        ButBack[2].SetActive(false);
    }
    public void backInfo2()
    {
        anim.Play("BackInfo2");
        ButForw[2].SetActive(false);
        ButBack[1].SetActive(false);
        ButForw[1].SetActive(true);
        ButBack[0].SetActive(true);
    }
    public void backInfo1()
    {
        anim.Play("BackInfo1");
        ButForw[1].SetActive(false);
        ButBack[0].SetActive(false);
        ButForw[0].SetActive(true);
    }
    /////////////определение-картинки///////////////////
    public void ShowStartGame()
    {
        anim.Play("ShowStartGame");
    }
    public void HideStartGame()
    {
        anim.Play("HideStartGame");
    }
    public void ShowSettings1()
    {
        anim.Play("ShowSettings1");
    }
    public void HideSettings1()
    {
        anim.Play("HideSettings1");
    }
    public void ShowSettings2()
    {
        anim.Play("ShowSettings2");
    }
    public void HideSettings2()
    {
        anim.Play("HideSettings2");
    }
}
