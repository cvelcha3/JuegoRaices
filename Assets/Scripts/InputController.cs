using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] float nextImageCooldown = 3.0f;
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
    IEnumerator NextScene() {
        puzzle = gameManager.NextImage();
        yield return new WaitForSeconds(nextImageCooldown);
        goToNextScene = true;
    }
    public void PuzzleDone()
    {
        puzzle = false;
    }
}
