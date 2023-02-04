using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    [SerializeField] string letter = "";
    private WordPuzzle puzzle;
    private AudioSource sound;
    public bool valid = false;
    private void Start()
    {
        puzzle = transform.parent.GetComponent<WordPuzzle>();
        sound = gameObject.GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<DraggableLetter>() && collision.gameObject.name == letter)
        {
            valid = true;
            puzzle.CheckWords();
            sound.Play();
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
    private void OnCollisionExit2D(Collision2D collision)
    {
        valid = false;
    }
}
