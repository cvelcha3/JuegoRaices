using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] float nextImageCooldown = 3.0f;
    [SerializeField] float puzleDelay = 0.2f;
    private GameManager gameManager;
    private bool goToNextScene = true;
    private bool puzzle = false;
    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }
    private void Update()
    {
        if (goToNextScene && !puzzle && Input.GetButton("Fire1")) {
            goToNextScene = false;
            StartCoroutine(NextScene());
        };
    }
    IEnumerator NextScene(bool delay = false) {
        if (delay) yield return new WaitForSeconds(puzleDelay);
        puzzle = gameManager.NextImage();
        yield return new WaitForSeconds(nextImageCooldown);
        goToNextScene = true;
    }
    public void PuzzleDone()
    {
        StartCoroutine(NextScene(true));
    }
}
