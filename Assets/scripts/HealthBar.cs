using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microlight.MicroBar;

public class HealthBar : MonoBehaviour
{

[SerializeField] MicroBar health_Bar;
const float Max_Hp = 100f;
    float _hp = Max_Hp;
    float HP
    {
        get => _hp;
        set
        {
            _hp = Mathf.Clamp(value, 0f, Max_Hp);
            health_Bar.UpdateBar(_hp);
        }
    }

    void Start()
    {
        health_Bar.Initialize(Max_Hp);
    }

   
    public void damage()
    {
        _hp -= 20f;
    }

    public void heal()
    {
        _hp += 20f;
    }
}
