using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class ColorPuzzle : MonoBehaviour
{
    [SerializeField] List<bool> correctLights;
    [SerializeField] InputController input;
    private List<Light2D> lights;
    void Awake()
    {
        foreach(Transform child in transform)
        {
            lights.Add(child.gameObject.GetComponent<Light2D>());
        }
    }
    void Update()
    {
        if (CheckLights())
        {
            input.PuzzleDone();
        }
    }
    public bool CheckLights()
    {
        var valid = true;
        for (int i = 0; i <= correctLights.Count-1; i++)
        {
            if (lights[i].enabled != correctLights[i])
            {
                valid = false;
            }
        }
        return valid;
    }
}
