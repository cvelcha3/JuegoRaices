using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPuzzle : MonoBehaviour
{
    [SerializeField] InputController input;
    [SerializeField] float delay = 1f;
    [SerializeField] List<ObjectToFind> findObjects;
    public bool isDone = false;

    public void CheckObjects()
    {
        if (isDone) return;
        var valid = true;
        foreach(ObjectToFind go in findObjects)
        {
            if (go.isActiveAndEnabled) valid = false;
        }
        if (valid) StartCoroutine(DonePuzzle());
    }
    IEnumerator DonePuzzle()
    {
        isDone = true;
        yield return new WaitForSeconds(delay);
        input.PuzzleDone();
        gameObject.SetActive(false);
    }

}
