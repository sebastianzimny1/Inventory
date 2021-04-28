using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacteraManager : MonoBehaviour
{
    private static CharacteraManager _instance;
    public SoundManager soundManager;
    public ColorChange colorChange;

    public Image shieldImage;
    public Image swordImage;
    public Image SwordBackground;
    public Image ShieldBackground;
    public TextMeshProUGUI textInfo;

    private float durationTime = 2;

    public static CharacteraManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<CharacteraManager>();
            }
            return _instance;
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        textInfo.gameObject.SetActive(false);
    }

    public void EquipItem(GameObject item)
    {
        ItemObject chosenItem = item.GetComponent<ItemObject>();
        switch (chosenItem.itemType)
        {
            case ItemType.sword:
                swordImage.sprite = chosenItem.itemSprite;
                colorChange.StartHighlight(SwordBackground);
                break;
            case ItemType.shield:
                shieldImage.sprite = chosenItem.itemSprite;
                colorChange.StartHighlight(ShieldBackground);
                break;
        }
        StartCoroutine(DisplayText(durationTime, chosenItem.itemName));
        soundManager.PlayRandomSound();

    }

    IEnumerator DisplayText(float duration, string text)
    {
        textInfo.text = "Equipped " + text;
        textInfo.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        textInfo.gameObject.SetActive(false);
    }
}
