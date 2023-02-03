using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<Sprite> backgrounds;
    [SerializeField] Image background;

    private static GameManager instance;
    private int index = 1;
    private bool changeScene = false;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (changeScene)
        {
            changeScene = false;
            background.sprite = backgrounds[index];
            index += 1;
        }
    }
    public void NextImage(int index = 0)
    {
        changeScene = true;
        if (index != 0)
        {
            this.index = index;
        }
    }
    
}
