using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu

    (
        fileName = "New Location",
        menuName = "New Location",
        order = 1
    )
]

public class LocationScriptableObject : ScriptableObject
{
    public string locationName;
    public string locationGoal;
    
    public LocationScriptableObject north;
    public LocationScriptableObject east;
    public LocationScriptableObject south;
    public LocationScriptableObject west;
    
    public LocationScriptableObject recipes;
    public LocationScriptableObject exit;
    
    public LocationScriptableObject soup;
    public LocationScriptableObject omelette;
    public LocationScriptableObject pizza;

    public LocationScriptableObject end;
    
    public bool isKitchen;
    public bool isPantry;

    public void PrintLocation()
    {
        string printstr = "\nLocation: " + locationName + "\nGoal: " + locationGoal;
        Debug.Log(printstr);
    }
    
    public void UpdateCurrentLocation(GameManager gm)
    {
        gm.locationUI.text = locationName;
        gm.goalUI.text = locationGoal;

        if (north == null)
        {
            gm.buttonNorth.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonNorth.gameObject.SetActive(true);
            north.south = this;
        }

        if (south == null)
        {
            gm.buttonSouth.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonSouth.gameObject.SetActive(true);
            south.north = this;
        }

        if (east == null)
        {
            gm.buttonEast.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonEast.gameObject.SetActive(true);
            east.west = this;
        }

        if (west == null)
        {
            gm.buttonWest.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonWest.gameObject.SetActive(true);
            west.east = this;
        }

        if (recipes == null)
        {
            gm.recipeButton.gameObject.SetActive(false);
        }
        else
        {
            gm.recipeButton.gameObject.SetActive(true);
        }
        
        if (exit == null)
        {
            gm.exitButton.gameObject.SetActive(false);
        }
        else
        {
            gm.exitButton.gameObject.SetActive(true);
        }
        
        if (soup == null)
        {
            gm.soupButton.gameObject.SetActive(false);
        }
        else
        {
            gm.soupButton.gameObject.SetActive(true);
        }
        
        if (omelette == null)
        {
            gm.eggButton.gameObject.SetActive(false);
        }
        else
        {
            gm.eggButton.gameObject.SetActive(true);
        }
        
        if (pizza == null)
        {
            gm.pizzaButton.gameObject.SetActive(false);
        }
        else
        {
            gm.pizzaButton.gameObject.SetActive(true);
        }
        
        if (end == null)
        {
            gm.cookButton.gameObject.SetActive(false);
        }
    }
}
