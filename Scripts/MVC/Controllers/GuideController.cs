using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideController
{
    GameObject guide;
    GameObject gameMenu;
    Transform guideBook;
    List<Transform> pages;
    int CurrentPage;
    public GuideController(GameObject _guide, Transform _guideBook, GameObject _gameMenu)
    {
        guide = _guide;
        guideBook = _guideBook;
        gameMenu = _gameMenu;
        pages = new List<Transform>();
        for (int i = 0; i < guideBook.childCount; i++)
        {
            Transform page = guideBook.GetChild(i);
            page.gameObject.SetActive(false);
            pages.Add(page);
        }
    }

    public void OpenGuide()
    {
        pages[CurrentPage].gameObject.SetActive(true);
        gameMenu.SetActive(false);
        guide.SetActive(true);
    }
    public void CloseGuide()
    {
        gameMenu.SetActive(true);
        guide.SetActive(false);
    }
    public void NextPage()
    {
        pages[CurrentPage].gameObject.SetActive(false);
        CurrentPage++;
        if (CurrentPage > pages.Count - 1) CurrentPage = 0;
        pages[CurrentPage].gameObject.SetActive(true);
    }
    public void PrevPage()
    {
        pages[CurrentPage].gameObject.SetActive(false);
        CurrentPage--;
        if (CurrentPage < 0) CurrentPage = pages.Count - 1;
        pages[CurrentPage].gameObject.SetActive(true);       
    }
}
