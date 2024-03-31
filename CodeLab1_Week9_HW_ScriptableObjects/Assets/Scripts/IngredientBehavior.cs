using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientBehavior : MonoBehaviour
{

    public GameManager gm;
    public LocationScriptableObject pantry;
    public SpriteRenderer mySprite;
    public PolygonCollider2D myCollider;
    public bool wasClicked = false;
    
    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        myCollider = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.currentLocation == pantry && wasClicked == false)
        {
            mySprite.enabled = true;
            myCollider.enabled = true;
        }
        else
        {
            mySprite.enabled = false;
            myCollider.enabled = false;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mySprite.enabled = false;
            gm.inventory.Add(gameObject.tag);
            gm.inventoryUI.text += gameObject.tag + " ";
            wasClicked = true;
        }
    }
}
