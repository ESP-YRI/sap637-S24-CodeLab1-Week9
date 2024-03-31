using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI locationUI;
    public TextMeshProUGUI goalUI;
    public TextMeshProUGUI inventoryUI;
    public TextMeshProUGUI recipeUI;
    
    public List<string> inventory = new List<string>();
    
    public LocationScriptableObject currentLocation;
    public LocationScriptableObject recipes;

    public LocationScriptableObject soupLoc;
    public LocationScriptableObject omeletteLoc;
    public LocationScriptableObject pizzaLoc;
    public LocationScriptableObject theEnd;
    
    public RecipesScriptableObject soup;
    public RecipesScriptableObject omelette;
    public RecipesScriptableObject pizza;
    
    public Button buttonNorth;
    public Button buttonSouth;
    public Button buttonEast;
    public Button buttonWest;

    public Button recipeButton;
    public Button exitButton;
    public Button soupButton;
    public Button eggButton;
    public Button pizzaButton;
    public Button cookButton;

    public SpriteRenderer endDish;
    public Sprite soupSprite;
    public Sprite omeletteSprite;
    public Sprite pizzaSprite;
    
    private bool haveIngredient1 = false;
    private bool haveIngredient2 = false;
    private bool haveIngredient3 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        currentLocation.PrintLocation();
        currentLocation.UpdateCurrentLocation(this);
        inventoryUI.text = "Inventory: ";
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLocation == soupLoc)
        {
            recipeUI.text = soup.recipeName + " \n" + "\n"
                            + soup.ingredient1 + ", "
                            + soup.ingredient2 + ", "
                            + soup.ingredient3;

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] == soup.ingredient1)
                {
                    haveIngredient1 = true;
                }
                
                if (inventory[i] == soup.ingredient2)
                {
                    haveIngredient2 = true;
                }
                
                if (inventory[i] == soup.ingredient3)
                {
                    haveIngredient3 = true;
                }
            }

            if (haveIngredient1 == true && haveIngredient2 == true && haveIngredient3 == true)
            {
                cookButton.gameObject.SetActive(true);
                endDish.sprite = soupSprite;
            }
            else
            {
                recipeUI.text += " \n" + "\n" + "You are missing ingredients!";
            }
            
        }

        else if (currentLocation == omeletteLoc)
        {
            recipeUI.text = omelette.recipeName + " \n" + "\n"
                            + omelette.ingredient1 + ", "
                            + omelette.ingredient2 + ", "
                            + omelette.ingredient3;
            
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] == omelette.ingredient1)
                {
                    haveIngredient1 = true;
                }
                
                if (inventory[i] == omelette.ingredient2)
                {
                    haveIngredient2 = true;
                }
                
                if (inventory[i] == omelette.ingredient3)
                {
                    haveIngredient3 = true;
                }
            }

            if (haveIngredient1 == true && haveIngredient2 == true && haveIngredient3 == true)
            {
                cookButton.gameObject.SetActive(true);
                endDish.sprite = omeletteSprite;
            }
            else
            {
                recipeUI.text += " \n" + "\n" + "You are missing ingredients!";
            }
        }

        else if (currentLocation == pizzaLoc)
        {
            recipeUI.text = pizza.recipeName + " \n" + "\n"
                            + pizza.ingredient1 + ", " 
                            + pizza.ingredient2 + ", " 
                            + pizza.ingredient3; 
            
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] == pizza.ingredient1)
                {
                    haveIngredient1 = true;
                }
                
                if (inventory[i] == pizza.ingredient2)
                {
                    haveIngredient2 = true;
                }
                
                if (inventory[i] == pizza.ingredient3)
                {
                    haveIngredient3 = true;
                }
            }

            if (haveIngredient1 == true && haveIngredient2 == true && haveIngredient3 == true)
            {
                cookButton.gameObject.SetActive(true);
                endDish.sprite = pizzaSprite;
            }
            else
            {
                recipeUI.text += " \n" + "\n" + "You are missing ingredients!";
            }
        }
        else
        {
            recipeUI.text = "";
        }

        if (currentLocation == theEnd)
        {
            inventoryUI.color = Color.black;
            inventoryUI.text = "<b>Inventory: \nA delicious meal!</b>";
        }
    }

    public void MoveDirection(string dirChar)
    {
        switch (dirChar)
        {
            case "N":
                currentLocation = currentLocation.north;
                break;
            case "S":
                currentLocation = currentLocation.south;
                break;
            case "E":
                currentLocation = currentLocation.east;
                break;
            case "W":
                currentLocation = currentLocation.west;
                break;
            case "R":
                currentLocation = currentLocation.recipes;
                break;
            
            case "L":
                currentLocation = currentLocation.exit;
                break;
            
            case "U":
                currentLocation = currentLocation.soup;
                break;
            
            case "O":
                currentLocation = currentLocation.omelette;
                break;
            
            case "P":
                currentLocation = currentLocation.pizza;
                break;
            
            case "C":
                currentLocation = currentLocation.end;
                break;
        }

        currentLocation.UpdateCurrentLocation(this);
    }
}
