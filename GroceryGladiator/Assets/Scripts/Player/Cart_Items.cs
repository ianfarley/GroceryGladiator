using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart_Items : MonoBehaviour
{
    [SerializeField] public List<GameObject> ingredients;
    void Start()
    {
        
        for (int i = 0; i < ingredients.Count; i++)
        {
            ingredients[i].SetActive(false);
        }
    }

    public static void UpdateCart(int indexNum)
    {

    }


}
