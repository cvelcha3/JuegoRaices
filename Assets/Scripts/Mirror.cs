using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    private WordPuzzle puzzle;
    private SpriteRenderer sprite;
    private bool bad = true;
    [SerializeField] Sprite goodSpr;
    [SerializeField] Sprite badSprt;
    [SerializeField] float interval = 3f;
    private void Start()
    {
        puzzle = transform.parent.GetComponent<WordPuzzle>();
        sprite = GetComponent<SpriteRenderer>();
        StartCoroutine(Change());
    }
    IEnumerator Change()
    {
        yield return new WaitForSeconds(interval);
        if (!puzzle.isDone && !bad)
        {
            sprite.sprite = badSprt;
            bad = true;
        }
        else if (bad)
        {
            sprite.sprite = goodSpr;
            bad = false;
        }
        StartCoroutine(Change());
    }

}
