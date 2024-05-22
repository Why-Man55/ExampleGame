using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AcceptQuests : MonoBehaviour
{
    public static bool isQuest1Acrive = false;

    [SerializeField]
    private GameObject marker1;
    [SerializeField]
    private GameObject marker2;
    [SerializeField]
    private GameObject marker3;
    [SerializeField]
    private GameObject marker4;
    [SerializeField]
    private GameObject mainQuestMenu;
    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private GameObject enemy2;
    [SerializeField]
    private GameObject enemy3;
    [SerializeField]
    private GameObject enemy4;
    [SerializeField]
    private GameObject newQuest;
    [SerializeField]
    private TMP_Text questText;

    void Update()
    {
        if(isQuest1Acrive && Input.GetKeyDown(KeyCode.Return))
        {
            marker1.SetActive(true);
            marker2.SetActive(true);
            marker3.SetActive(true);
            marker4.SetActive(true);
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(true);
            Destroy(mainQuestMenu);
            Destroy(newQuest);
            ShowQuest.isQuest1Open = false;
            Destroy(gameObject);
            questText.text = "0/4 enemies eliminated";
        }
    }
}
