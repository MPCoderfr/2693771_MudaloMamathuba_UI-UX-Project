using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PopulateOverTime : MonoBehaviour
{
    public GameObject ItemToAppear1, ItemToAppear2, ItemToAppear3, ItemToAppear4;
    public float appearTime = 4f;
    void Start()
    {
        StartCoroutine(PopulateShop());
        ItemToAppear1.SetActive(false);
        ItemToAppear2.SetActive(false);
        ItemToAppear3.SetActive(false);
        ItemToAppear4.SetActive(false);
    }

    // Update is called once per frame
    IEnumerator PopulateShop()
    {
        yield return new WaitForSeconds(appearTime);
        ItemToAppear1.SetActive(true);
        yield return new WaitForSeconds(appearTime);
        ItemToAppear2.SetActive(true);
        yield return new WaitForSeconds(appearTime);
        ItemToAppear3.SetActive(true);
        yield return new WaitForSeconds(appearTime);
        ItemToAppear4.SetActive(true);

    }
}
