using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TattooPuzle : MonoBehaviour
{
    [SerializeField] InputController input;
    [SerializeField] float delay = 1f;
    [SerializeField] Tilemap mask;
    [SerializeField] Tilemap mustCover;
    [SerializeField] int rangeTiles = 100;
    public bool isDone = false;

    public void CheckTiles()
    {
        if (isDone) return;
        var valid = true;
        for (int i = -rangeTiles; i < rangeTiles*2; i++)
        {
            for (int j = -rangeTiles; j < rangeTiles * 2; j++)
            {
                if(mustCover.GetTile(new Vector3Int(i, j, 0)))
                {
                    if (!mask.GetTile(new Vector3Int(i, j, 0))) valid = false;
                }
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
