using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaController : MonoBehaviour
{
    private GachaData gachaData;
    [SerializeField] private Vector2 spawnPos;
    private GachaSystem gachaSystem;
    private Dictionary<string, GameObject> gachaObj = new Dictionary<string, GameObject>();
    void Start()
    {
        gachaData = GetComponent<GachaData>();
        gachaSystem = new GachaSystem();
        for (int i = 0; i < 5; i++)
            gachaObj.Add(gachaData.rarityNames[i], gachaData.Cards[i]);
        StartCoroutine(SpawnGachaItems(20));
    }
    private IEnumerator SpawnGachaItems(int itemCount)
    {      
        for (int i = 0; i < itemCount / 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                string item = gachaSystem.GetRandomItem(gachaData.rates, gachaData.rarityNames);
                if (gachaObj.TryGetValue(item, out GameObject Card))
                {
                    Instantiate(Card, new Vector3(spawnPos.x * j, spawnPos.y * i), Quaternion.identity);
                }
                yield return new WaitForSeconds(0.1f);
            }
        }       
    }
}
