using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour {

    public Text recipeName;
    public Text recipeDescription;
    public Text ingred1;
    public Text ingred2;
    public Text ingred3;
    public Recipe[] recipeList;
    public Inventory invent;

    private void Start()
    {
        recipeList = new Recipe[20]
        {
            new Recipe("Зелье восстановления здоровья",21,"Синюю бузину растереть в ступке, листья огнецвета отделить от стебля и мелко порвать, друздь отварить до получения концентрированного экстракта.",3,2,12,1,6,1),
            new Recipe("Зелье брони",22,"Вскипитити воду. Пашол а.",1,3,2,3,3,3),
            new Recipe("Зелье ускроения",23,"Вскипитити воду. Пашол х.",1,3,2,3,3,3),
            new Recipe("Зелье невидимости",24,"Вскипитити воду. Пашол р.",1,3,2,3,3,3),
            new Recipe("Зелье невесомости",25,"Вскипитити воду. Пашол е.",1,3,2,3,3,3),
            new Recipe("Зелье уменьшения",26,"Вскипитити воду. Пашол н.",1,3,2,3,3,3),
            new Recipe("Зелье очищения",27,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Огуречное зелье",28,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Квестовое",29,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Квестовое",30,"Вскипитити воду. Пашол.",1,3,2,3,3,3),
            new Recipe("Зелье замедления",31,"Отделить шкурку от шляпки моромуха и растереть в порошок, из стебля могильника выжать сок, друздь отварить до получения концентрированного экстракта.",7,2,2,1,6,1),
            new Recipe("Зелье уменьшения",32,"Отделить шкурку от шляпки моромуха и растереть в порошок. Лепестки огнецвета высушить, растереть в порошоки добавит в раствор. Стебли звуздопроудника мелко нарезать и варить до получения студенистой массы.",7,2,6,2,5,1),
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
        recipeName.text = recipeList[id].name;
        recipeDescription.text = recipeList[id].description;
        ingred1.text = invent.inventoryList[recipeList[id].ingred1 - 1].inventoryName + " x " + recipeList[id].ingred1Count;
        ingred2.text = invent.inventoryList[recipeList[id].ingred2 - 1].inventoryName + " x " + recipeList[id].ingred2Count;
        ingred3.text = invent.inventoryList[recipeList[id].ingred3 - 1].inventoryName + " x " + recipeList[id].ingred3Count;
    }

}
