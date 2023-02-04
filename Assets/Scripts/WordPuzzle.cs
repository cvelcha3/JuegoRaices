using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordPuzzle : MonoBehaviour
{
    [SerializeField] InputController input;
    [SerializeField] float delay = 1f;
    [SerializeField] List<Position> positions;
    public bool isDone = false;

    public void CheckWords()
    {
        if (isDone) return;
        var valid = true;
        foreach(Position position in positions)
        {
            if (!position.valid) valid = false;
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
