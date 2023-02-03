using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<Sprite> backgrounds;
    [SerializeField] List<int> puzzleIndex;
    [SerializeField] Image background;

    private static GameManager instance;
    private int index = 0;
    private int thisPuzzle = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(instance == null)
        {
            instance = this;
            background.sprite = backgrounds[index];
            index += 1;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool NextImage(int index = 0)
    {
        if (index != 0)
        {
            this.index = index;
        }
        background.sprite = backgrounds[this.index];
        if(this.index == puzzleIndex[thisPuzzle])
        {
            thisPuzzle += 1;
            this.index += 1;
            return true;
        }
        this.index += 1;
        return false;
    }
    
}
