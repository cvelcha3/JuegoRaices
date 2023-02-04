using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToFind : MonoBehaviour
{
    private FindPuzzle puzzle;
    private void Start()
    {
        puzzle = transform.parent.parent.GetComponent<FindPuzzle>();
    }
    void OnMouseOver()
    {
        if (Input.GetButtonDown("Fire1") && !puzzle.isDone)
        {
            gameObject.SetActive(false);
            puzzle.CheckObjects();
        }
    }
}
