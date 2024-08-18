using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Scene_Manager : MonoBehaviour
{
    [SerializeField] GameObject popupPanel;

    private void Start() 
    {
        popupPanel.SetActive(false);
    }

    public void ShowPopUp()
    {
        popupPanel.SetActive(true);
        Debug.Log("Popup Active " + popupPanel.activeInHierarchy);
    }

    public void HidePopUp()
    {
        popupPanel.SetActive(false);
        Debug.Log("Popup Active " + popupPanel.activeInHierarchy);
    }
}
