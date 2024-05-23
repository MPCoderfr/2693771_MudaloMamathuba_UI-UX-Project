using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [Header("Shop and Chest views")]
    public Animator animator;
    public Button shopButton;
    public Button chestButton;


    [Header("Item Purchases")]
    public InventoryManager invMan;
    public Item[] itemsToBuy;
    public TextMeshProUGUI notEnoughText;


    public WalletScript moneyChange;

    private void Start()
    {
        shopButton.onClick.AddListener(SwitchToShop);
        chestButton.onClick.AddListener(SwitchToChest);
        shopButton.interactable = false;

        notEnoughText.gameObject.SetActive(false);
    }
    public void SwitchToChest()
    {
        animator.SetBool("move", true);
        chestButton.interactable = false;
        shopButton.interactable = true;
    }

    public void SwitchToShop()
    {
        animator.SetBool("move", false);
        shopButton.interactable = false;
        chestButton.interactable= true;
    }



    public void ClickBuyItem(int ID)
    {

        if (moneyChange.moneyCounter - itemsToBuy[ID].Cost >= 0)
        {
            invMan.AddItem(itemsToBuy[ID]);
            moneyChange.moneyCounter -= itemsToBuy[ID].Cost;
            moneyChange.ConvertToText();
        }
        else if (moneyChange.moneyCounter - itemsToBuy[ID].Cost < 0)
        {
            notEnoughText.gameObject.SetActive(true);
            Invoke("DisplayNotEnough", 2f);
        }

    }

    public void DisplayNotEnough()
    {
        notEnoughText.gameObject.SetActive(false);
    }

    
}
