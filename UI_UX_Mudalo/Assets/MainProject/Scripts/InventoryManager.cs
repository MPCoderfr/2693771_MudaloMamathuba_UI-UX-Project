using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //The array stores the bag slots so that the system knows what slots specifically to place items into
    //The InventoryItemPrefab variable tells you which game object you are instantiating into the slots
    public InventorySlots[] inventorySlots;
    public GameObject inventoryItemPrefab;

    //Find the first empty slot and run the SpawnItem function
    public void AddItem(Item item)
    {
        //For loop counts the number of slots in the bag, how many are open and then finds the first open slot and assigns a value to it.
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlots slot = inventorySlots[i];
            DraggableItem itemInSlot = slot.GetComponentInChildren<DraggableItem>();
            //When it finds a free slot, it will run the Spawnitem funcion to instantiate an object in the first one.
            if (itemInSlot == null)
            {
                SpawnItem(item, slot); 
                return; 
            }
        }
    }


    //Instantiates items
    public void SpawnItem(Item item, InventorySlots slot)
    {
        GameObject newItemGO = Instantiate(inventoryItemPrefab, slot.transform);
        DraggableItem inventoryItem = newItemGO.GetComponent<DraggableItem>();
        inventoryItem.InitialiseItem(item);    
    }
}
