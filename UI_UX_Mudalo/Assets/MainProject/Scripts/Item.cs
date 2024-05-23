using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public int ID;
    public string ItemName;
    public string ItemType;
    public int Cost; 
    public Sprite Sprite;
}
