using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Fire : MonoBehaviour
{
    private Light2D lighting;
    private ColorPuzzle puzzle;
    private void Start()
    {
        lighting = GetComponent<Light2D>();
        puzzle = transform.parent.GetComponent<ColorPuzzle>();
    }
    void OnMouseOver()
    {
        if (Input.GetButtonDown("Fire1") && !puzzle.isDone){
            lighting.enabled = !lighting.enabled;
            puzzle.CheckLights();
        }
    }
}
