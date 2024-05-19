using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour
{
    [SerializeField]
    public Camera main_camera;
    [SerializeField]
    public GameObject newQuest;

    Vector3 Ray_start_position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
    public static bool rayWatcher;

    void Update()
    {
        // Сам луч
        Ray ray = main_camera.ScreenPointToRay(Ray_start_position);
        // Запись объекта, в который пришел луч, в переменную
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        rayWatcher = isDesk(hit);
        if (ShowQuest.isQuest1Open)
        {
            newQuest.SetActive(rayWatcher);
        }
    }

    private bool isDesk(RaycastHit hit)
    {
        if (hit.collider.gameObject.CompareTag("Desk") && ((hit.collider.gameObject.transform.position - gameObject.transform.position).magnitude <= 5f))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
