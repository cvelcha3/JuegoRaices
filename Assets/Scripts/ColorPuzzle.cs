using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class ColorPuzzle : MonoBehaviour
{
    [SerializeField] List<bool> correctLights;
    [SerializeField] InputController input;
    [SerializeField] float delay= 1f;
    [SerializeField] List<Light2D> lights = new List<Light2D>();
    public bool isDone = false;
    public void CheckLights()
    {
        var valid = true;
        for (int i = 0; i <= correctLights.Count-1; i++)
        {
            if (lights[i].enabled != correctLights[i])
            {
                valid = false;
            }
        }
        if (valid) StartCoroutine(DonePuzzle());
    }
    IEnumerator DonePuzzle()
    {
        isDone = true;
        yield return new WaitForSeconds(delay);
        input.PuzzleDone();
        gameObject.SetActive(false);
    }
}
