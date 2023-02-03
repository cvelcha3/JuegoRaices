using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] float nextImageCooldown = 10.0f;
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
            StartCoroutine(NextScene());
        };
    }
    IEnumerator NextScene(bool puzzle = false) {
        gameManager.NextImage();
        goToNextScene = false;
        if (!puzzle)
        {
            this.puzzle = false;
            yield return new WaitForSeconds(nextImageCooldown);
            goToNextScene = true;
        }
        else
        {
            this.puzzle = true;
        }
    }
}
