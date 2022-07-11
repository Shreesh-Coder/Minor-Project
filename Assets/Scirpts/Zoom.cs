using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    Vector3 touchStart;
    public float zoomOutMin = 1;
    public float zoomOutMax = 8;
    public Camera mainCamera;
    // Update is called once per frame
    void Update()
    {
        
     /*   if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("hellow");
            touchStart = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mainCamera.transform.position.z * -1));
            Debug.Log(touchStart);
        }*/
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * 0.01f);
        }
       /* else if (Input.GetMouseButton(0))
        {
            Debug.Log("wrold");
            Vector3 direction = touchStart - mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mainCamera.transform.position.z * -1)); ;
            Debug.Log(direction.magnitude);
            Camera.main.transform.position += direction;
        }*/
        zoom(Input.GetAxisRaw("Mouse ScrollWheel"));
    }

    void zoom(float increment)
    {
      //  Debug.Log(increment);
        mainCamera.orthographicSize = Mathf.Clamp(mainCamera.orthographicSize - increment, zoomOutMin, zoomOutMax);
        mainCamera.orthographic = true;
      //  Debug.Log(mainCamera.orthographicSize);
    }
}