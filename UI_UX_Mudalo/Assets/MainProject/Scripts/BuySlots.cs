using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySlots : MonoBehaviour
{
    public Transform bagWindow;
    public GameObject backpackSlotsPrefab;

    public Transform chestWindow;
    public GameObject chestWindowPrefab;

    public WalletScript walletScript;
    public int slotCost = 10;

    public void BuyBagSlot()
    {
        if (bagWindow.childCount < 9)
        {
            Instantiate(backpackSlotsPrefab, bagWindow);
            walletScript.moneyCounter -= slotCost;
            walletScript.ConvertToText();
        }

    }

    public void AddChestSlot()
    {
        Instantiate(chestWindowPrefab, chestWindow);
        walletScript.moneyCounter -= slotCost;
        walletScript.ConvertToText();
    }
}
