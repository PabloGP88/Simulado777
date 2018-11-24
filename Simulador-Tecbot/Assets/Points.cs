using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;
using TMPro;

public class Points : MonoBehaviour {
    public int points;
    private TextMeshPro score;

    void Awake()
    {
    }
    public void AddPoints(int poinsToAdd)
    {
        points += poinsToAdd;
       
        
    }
}