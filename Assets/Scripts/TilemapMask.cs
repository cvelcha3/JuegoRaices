using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapMask : MonoBehaviour
{
    [SerializeField] GameObject maskPrefab;
    [SerializeField] float gridScale = 0.3f;
    [SerializeField] Vector2 offset;
    private Tilemap myTilemap;
    private TattooPuzle puzzle;
    private void Start()
    {
        myTilemap = gameObject.GetComponent<Tilemap>();
        puzzle = transform.parent.parent.gameObject.GetComponent<TattooPuzle>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Tile tile = new Tile();
            Vector3Int cellPos = myTilemap.WorldToCell(pos);
            Debug.Log(cellPos);
            if (myTilemap.GetTile(cellPos) == null)
            {
                Instantiate(maskPrefab, new Vector3(cellPos.x * gridScale + offset.x, cellPos.y * gridScale+offset.y, 0), new Quaternion(), transform);
                myTilemap.SetTile(cellPos, tile);
                puzzle.CheckTiles();
            }
        }
    }
}
