using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    sword,
    shield
}

public class ItemObject : MonoBehaviour
{
    public ItemType itemType;
    public Sprite itemSprite;
    public string itemName;
}
