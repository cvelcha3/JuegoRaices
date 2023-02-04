using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableLetter : MonoBehaviour
{
    Vector3 mousePositionRn;
    Vector3 getMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDown()
    {
        mousePositionRn = gameObject.transform.position - getMousePosition();
    }
    private void OnMouseDrag()
    {
        transform.position = getMousePosition() + mousePositionRn;
    }
}
