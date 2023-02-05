using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashbackPuzzle : MonoBehaviour
{
    [SerializeField] InputController input;
    [SerializeField] float delay = 1f;
    [SerializeField] float delayFlash = 5f;
    [SerializeField] List<ObjectToFind> findObjects;
    [SerializeField] Image image;
    [SerializeField] Sprite black;
    [SerializeField] Sprite badImage;
    public bool isDone = false;

    public void CheckObjects()
    {
        if (isDone) return;
        var valid = true;
        if (valid) StartCoroutine(DonePuzzle());
    }
    IEnumerator DonePuzzle()
    {
        isDone = true;
        yield return new WaitForSeconds(delay);
        input.PuzzleDone();
        gameObject.SetActive(false);
    }
    void Start()
    {
        Invoke("Timer", delayFlash);
        Invoke("ChangeBlack", delayFlash / 3);
        Invoke("ChangeBad", delayFlash*2 / 3);
        Invoke("ChangeBlack", delayFlash);
    }
    private void Timer()
    {
        StartCoroutine(DonePuzzle());
    }
    private void ChangeBlack()
    {
        image.sprite = black;
    }
    private void ChangeBad()
    {
        image.sprite = badImage;
    }
}
