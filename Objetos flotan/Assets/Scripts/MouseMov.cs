using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class MouseMov : MonoBehaviour
{
    private Vector3 mOffSet;
    private float mZCoord;
    
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffSet = gameObject.transform.position - GetMouseAsWorldPoint();
    
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffSet;
    }
}
