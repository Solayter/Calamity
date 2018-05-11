using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchUI : MonoBehaviour
{

    public Text recipeName;
    public Text recipeDescription;
    public Text ingred1;
    public Text ingred2;
    public Text ingred3;
    public Recipe[] recipeList;
    public Inventory invent;
    public GameObject recipeScroll;
    public GameObject btnCraft;
    private int choosenID;
    private bool choosen = false;
    private void Start()
    {
        recipeList = new Recipe[20]
        {
            new Recipe("Зелье восстановления здоровья",21,"Вскипитити воду. Пашол н.",1,1,2,1,3,1),//ингридиент1, его кол-во, ингридиент2, его кол-во, ингридиент3, его кол-во.
            new Recipe("Зелье брони",22,"Вскипитити воду. Пашол а.",4,3,5,3,6,3),
            new Recipe("Зелье ускроения",23,"Вскипитити воду. Пашол х.",1,3,2,3,3,3),
            new Recipe("Зелье невидимости",24,"Вскипитити воду. Пашол р.",1,3,2,3,3,3),
            new Recipe("Зелье невесомости",25,"Вскипитити воду. Пашол е.",1,3,2,3,3,3),
            new Recipe("Зелье уменьшения",26,"Вскипитити воду. Пашол н.",1,3,2,3,3,3),
            new Recipe("Зелье очищения",27,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Огуречное зелье",28,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Квестовое",29,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Квестовое",30,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Зелье замедления",31,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Зелье уменьшения",32,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Зелье сна",33,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Зелье страха",34,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Зелье приманки",35,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Вонючее зелье",36,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Деревянное зелье",37,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Зелье взрыва",38,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Овощное зелье",39,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Загадочное зелье",40,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            };
    }

    

    public void Button(int id)
    {
        choosen = true;
        recipeName.text = recipeList[id].name;
        recipeDescription.text = recipeList[id].description;
        ingred1.text = invent.inventoryList[recipeList[id].ingred1 - 1].inventoryName + " x " + recipeList[id].ingred1Count + "/" + invent.inventoryList[recipeList[id].ingred1 - 1].amount;
        ingred2.text = invent.inventoryList[recipeList[id].ingred2 - 1].inventoryName + " x " + recipeList[id].ingred2Count + "/" + invent.inventoryList[recipeList[id].ingred2 - 1].amount;
        ingred3.text = invent.inventoryList[recipeList[id].ingred3 - 1].inventoryName + " x " + recipeList[id].ingred3Count + "/" + invent.inventoryList[recipeList[id].ingred3 - 1].amount;
        choosenID = id;
    }

    public void Update()
    {
        if((invent.inventoryList[40].amount == 0)&(!choosen))
            btnCraft.SetActive(false);
        else
            btnCraft.SetActive(true);

        if ((invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount == 0) &
            (invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount == 0) &
            (invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount == 0))
            btnCraft.SetActive(false);
        else
            btnCraft.SetActive(true);
    }
    public void Craft()
    {
        if( (recipeList[choosenID].ingred1Count <= invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount)&
            (recipeList[choosenID].ingred2Count <= invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount)&
            (recipeList[choosenID].ingred3Count <= invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount)  )
        {
            invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount -= recipeList[choosenID].ingred1Count;//Крафт удался
            invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount -= recipeList[choosenID].ingred2Count;
            invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount -= recipeList[choosenID].ingred3Count;
            invent.inventoryList[40].amount--;
            invent.inventoryList[recipeList[choosenID].item - 1].find = true;
            invent.inventoryList[recipeList[choosenID].item - 1].amount++;
        }
        else 
        {
            invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount = 0;//Не удался
            invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount = 0;//Получаем жижу
            invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount = 0;
            invent.inventoryList[40].amount--;
            invent.inventoryList[47].find = true;
            invent.inventoryList[47].amount++;
        }
        ingred1.text = invent.inventoryList[recipeList[choosenID].ingred1 - 1].inventoryName + " x " + recipeList[choosenID].ingred1Count + "/" + invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount;
        ingred2.text = invent.inventoryList[recipeList[choosenID].ingred2 - 1].inventoryName + " x " + recipeList[choosenID].ingred2Count + "/" + invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount;
        ingred3.text = invent.inventoryList[recipeList[choosenID].ingred3 - 1].inventoryName + " x " + recipeList[choosenID].ingred3Count + "/" + invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount;

    }
}


