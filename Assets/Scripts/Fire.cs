using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Fire : MonoBehaviour
{
    private Light2D lighting;
    private ColorPuzzle puzzle;
    private SpriteRenderer spriteFire;
    private bool spriteDimming = false;
    private void Start()
    {
        spriteFire = GetComponent<SpriteRenderer>();
        lighting = GetComponent<Light2D>();
        puzzle = transform.parent.GetComponent<ColorPuzzle>();
        spriteFire.color = lighting.color;
    }
    void OnMouseOver()
    {
        if (Input.GetButtonDown("Fire1") && !puzzle.isDone)
        {
            lighting.enabled = !lighting.enabled;
            puzzle.CheckLights();
            spriteDimming = !spriteDimming;
            if (spriteDimming)
            {
                spriteFire.color = new Color(lighting.color.r, lighting.color.g, lighting.color.b, 0.10f);
            }
            else
            {
                spriteFire.color = new Color(lighting.color.r, lighting.color.g, lighting.color.b, 0.75f);
            }
        }
    }
}
