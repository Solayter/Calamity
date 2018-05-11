using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
    public int item;
    public string name;
    public string description;

    public int ingred1;
    public int ingred1Count;

    public int ingred2;
    public int ingred2Count;

    public int ingred3;
    public int ingred3Count;

    public Recipe(string name, int item, string description,
                  int ingred1, int ingred1Count,
                  int ingred2, int ingred2Count,
                  int ingred3, int ingred3Count)
    {
        this.name = name;
        this.item = item;
        this.description = description;

        this.ingred1 = ingred1;
        this.ingred1Count = ingred1Count;

        this.ingred2 = ingred2;
        this.ingred2Count = ingred2Count;

        this.ingred3 = ingred3;
        this.ingred3Count = ingred3Count;
    }
}

