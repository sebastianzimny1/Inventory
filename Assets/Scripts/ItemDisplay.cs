using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    private ItemObject itemObject;
    private Image itemSprite;

    public void Awake()
    {
        itemSprite = GetComponent<Image>();
        itemObject = GetComponent<ItemObject>();
    }

    public void Start()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        itemSprite.sprite = itemObject.itemSprite;
    }
}
