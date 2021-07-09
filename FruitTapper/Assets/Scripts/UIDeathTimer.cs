using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDeathTimer : MonoBehaviour
{
    private Image bar;
    private float fill;

    void Start()
    {
        fill = 1f;
        bar = GetComponent<Image>();
    }

    void Update()
    {
        bar.fillAmount = DeathTimer.deathTime / 60f;
    }
}
