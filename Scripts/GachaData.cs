using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaData : MonoBehaviour
{
    public float[] rates = { 0.12f, 5f, 16f, 26f, 52f };
    public string[] rarityNames = { "Legend", "Unique", "Epic", "Rare", "Normal" };
    public List<GameObject> Cards;
}
