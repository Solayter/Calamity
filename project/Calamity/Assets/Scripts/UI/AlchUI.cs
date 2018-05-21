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

    public Text notifText;
    public GameObject notif;

    private int choosenID;
    private bool choosen = false;
    private void Start()
    {
       
        recipeList = new Recipe[20]
        {
            new Recipe("Зелье восстановления здоровья",21,"Синюю бузину растереть в ступке, листья огнецвета отделить от стебля и мелко порвать, друздь отварить до получения концентрированного экстракта.",3,2,12,1,6,1),//ингридиент1, его кол-во, ингридиент2, его кол-во, ингридиент3, его кол-во.
            new Recipe("Зелье брони",22,".",4,3,5,3,6,3),
            new Recipe("Зелье ускроения",23,".",1,3,2,3,3,3),
            new Recipe("Зелье невидимости",24,".",1,3,2,3,3,3),
            new Recipe("Зелье невесомости",25,".",1,3,2,3,3,3),
            new Recipe("Зелье уменьшения",26,".",1,3,2,3,3,3),
            new Recipe("Зелье очищения",27,".",1,3,2,3,3,3),
            new Recipe("Огуречное зелье",28,".",1,3,2,3,3,3),
            new Recipe("Квестовое",29,".",1,3,2,3,3,3),
            new Recipe("Квестовое",30,".",1,3,2,3,3,3),
            new Recipe("Зелье замедления",31,"Отделить шкурку от шляпки моромуха и растереть в порошок, из стебля могильника выжать сок, друздь отварить до получения концентрированного экстракта.",7,2,2,1,6,1),
            new Recipe("Зелье уменьшения",32,"Отделить шкурку от шляпки моромуха и растереть в порошок. Лепестки огнецвета высушить, растереть в порошоки добавит в раствор. Стебли звуздопроудника мелко нарезать и варить до получения студенистой массы.",7,2,6,2,5,1),
            new Recipe("Зелье сна",33,".",1,3,2,3,3,3),
            new Recipe("Зелье страха",34,".",1,3,2,3,3,3),
            new Recipe("Зелье приманки",35,".",1,3,2,3,3,3),
            new Recipe("Вонючее зелье",36,".",1,3,2,3,3,3),
            new Recipe("Деревянное зелье",37,".",1,3,2,3,3,3),
            new Recipe("Зелье взрыва",38,".",1,3,2,3,3,3),
            new Recipe("Овощное зелье",39,".",1,3,2,3,3,3),
            new Recipe("Загадочное зелье",40,".",1,3,2,3,3,3),
            };
    }

    

    public void Button(int id)
    {
        recipeScroll.SetActive(true);
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
        if((invent.inventoryList[40].amount != 0)&&
            (choosen)&&
            ((invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount != 0)|| 
            (invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount != 0)|| 
            (invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount != 0)))
            btnCraft.SetActive(true);
        else
            btnCraft.SetActive(false);
        ingred1.text = invent.inventoryList[recipeList[choosenID].ingred1 - 1].inventoryName + " x " + recipeList[choosenID].ingred1Count + "/" + invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount;
        ingred2.text = invent.inventoryList[recipeList[choosenID].ingred2 - 1].inventoryName + " x " + recipeList[choosenID].ingred2Count + "/" + invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount;
        ingred3.text = invent.inventoryList[recipeList[choosenID].ingred3 - 1].inventoryName + " x " + recipeList[choosenID].ingred3Count + "/" + invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount;

    }
    public void Craft()
    {
        if( (recipeList[choosenID].ingred1Count <= invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount)&&
            (recipeList[choosenID].ingred2Count <= invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount)&&
            (recipeList[choosenID].ingred3Count <= invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount)  )
        {
            invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount -= recipeList[choosenID].ingred1Count;//Крафт удался
            invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount -= recipeList[choosenID].ingred2Count;
            invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount -= recipeList[choosenID].ingred3Count;
            invent.inventoryList[40].amount--;
            invent.inventoryList[recipeList[choosenID].item - 1].find = true;
            invent.inventoryList[recipeList[choosenID].item - 1].amount++;
            Notification(invent.inventoryList[recipeList[choosenID].item - 1]);
        }
        else 
        {
            invent.inventoryList[recipeList[choosenID].ingred1 - 1].amount = 0;//Не удался
            invent.inventoryList[recipeList[choosenID].ingred2 - 1].amount = 0;//Получаем жижу
            invent.inventoryList[recipeList[choosenID].ingred3 - 1].amount = 0;
            invent.inventoryList[40].amount--;
            invent.inventoryList[47].find = true;
            invent.inventoryList[47].amount++;
            Notification(invent.inventoryList[47]);
        }
        
    }
    public void Notification(Item item)
    {
        notifText.text = "Получен предмет: " + item.inventoryName + " x 1";
        notif.GetComponent<Animation>().PlayQueued("appear", QueueMode.PlayNow);
    }
    
}


