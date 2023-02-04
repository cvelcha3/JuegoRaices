using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmalList : MonoBehaviour
{
    [SerializeField] GameObject bigList;
    void OnMouseOver()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            bigList.SetActive(!bigList.activeSelf);
        }
    }
}
