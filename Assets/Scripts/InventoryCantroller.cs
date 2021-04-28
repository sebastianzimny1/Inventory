using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCantroller : MonoBehaviour
{
    public void HideItemsOptions()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<ItemButton>().ShowItemOptions(false);
        }
    }
}
