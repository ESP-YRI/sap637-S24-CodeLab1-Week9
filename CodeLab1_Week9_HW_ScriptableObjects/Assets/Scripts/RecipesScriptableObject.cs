using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu
    (
        fileName = "New Recipe",
        menuName = "New Recipe",
        order = 0
    )
]

public class RecipesScriptableObject : ScriptableObject
{
    public string recipeName;
    public string ingredient1;
    public string ingredient2;
    public string ingredient3;
    
}
