using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    public string GetRandomItem(float[] rates, string[] rarityNames)
    {
        float totalRate = 0f;
        foreach (var rate in rates)
        {
            totalRate += rate;
        }

        float randomPoint = UnityEngine.Random.Range(0f, totalRate);

        float cumulative = 0f;
        for (int i = 0; i < rates.Length; i++)
        {
            cumulative += rates[i];
            if (randomPoint < cumulative)
            {
                return rarityNames[i];
            }
        }

        return "Unknown";
    }
}
