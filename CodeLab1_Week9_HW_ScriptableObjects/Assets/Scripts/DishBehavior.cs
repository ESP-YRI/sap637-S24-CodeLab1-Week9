using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishBehavior : MonoBehaviour
{
    public GameManager gm;
    public LocationScriptableObject end;
    public SpriteRenderer mySprite;
    
    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.currentLocation == end)
        {
            mySprite.enabled = true;
        }
    }
}
