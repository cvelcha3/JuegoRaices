using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    private WordPuzzle puzzle;
    private SpriteRenderer sprite;
    private bool bad = false;
    [SerializeField] Sprite goodSpr;
    [SerializeField] Sprite badSprt;
    [SerializeField] float interval = 3f;
    private void Start()
    {
        puzzle = transform.parent.GetComponent<WordPuzzle>();
        sprite = GetComponent<SpriteRenderer>();

    }
    private void Update()
    {
        if (puzzle.isDone)
        {
            sprite.sprite = goodSpr;
        }
    }

}
