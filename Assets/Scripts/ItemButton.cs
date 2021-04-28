using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public GameObject buttonOptions;
    public bool optionsIsActive  = false;
    private InventoryCantroller inventoryCantroller;
    private void Awake()
    {
        inventoryCantroller = gameObject.GetComponentInParent<InventoryCantroller>();
    }
    public void Start()
    {
        ShowItemOptions(false);
    }
    public void DisplayItemOptions()
    {
        inventoryCantroller.HideItemsOptions();
        if(!optionsIsActive)
        {
            ShowItemOptions(true);
        }
        else if (optionsIsActive)
        {
            ShowItemOptions(false);
        }
    }
    public void ShowItemOptions(bool state)
    {
        buttonOptions.SetActive(state);
        optionsIsActive = state;
    }

    public void EquipItem()
    {
        CharacteraManager.Instance.EquipItem(gameObject);
    }
}
