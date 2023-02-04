using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    [SerializeField] string letter = "";
    private WordPuzzle puzzle;
    public bool valid = false;
    private void Start()
    {
        puzzle = transform.parent.GetComponent<WordPuzzle>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<DraggableLetter>() && collision.gameObject.name == letter)
        {
            valid = true;
            puzzle.CheckWords();
        }
        else {
            valid = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<DraggableLetter>() && collision.gameObject.name == letter)
        {
            valid = true;
            puzzle.CheckWords();
        }
        else
        {
            valid = false;
        }
    }
}
