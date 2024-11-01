using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    private List<Camera> cameraList;

    void Start()
    {
        cameraList = new List<Camera>(FindObjectsOfType<Camera>());

        if (cameraList.Count > 0)
        {
            SetActiveCamera(cameraList[0]);
        }
    }

    void Update()
    {
        for (int index = 0; index < cameraList.Count && index < 10; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                SetActiveCamera(cameraList[index]);
            }
        }
    }

    void SetActiveCamera(Camera newActiveCamera)
    {
        foreach (Camera cam in cameraList)
        {
            cam.gameObject.SetActive(false)
