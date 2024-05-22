using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQuest : MonoBehaviour
{
    [SerializeField]
    private GameObject questMarker;
    [SerializeField]
    public GameObject quest1Menu;
    [SerializeField]
    private Behaviour movingScript;

    private bool buttonState;
    public static bool isQuest1Open = true;
    public static bool activateStatus = true;
    
    void Update()
    {
        AcceptQuests.isQuest1Acrive = !activateStatus;
        buttonState = CameraRay.rayWatcher;
        if (buttonState && Input.GetKeyDown(KeyCode.E) && isQuest1Open)
        {
            destrMrk();
            quest1Menu.SetActive(activateStatus);
            movingScript.enabled = !activateStatus;
            activateStatus = !activateStatus;
        }
        if (isQuest1Open == false)
        {
            destrMrk();
            movingScript.enabled = true;
        }
    }

    private void destrMrk()
    {
        Destroy(questMarker);
    }
}
