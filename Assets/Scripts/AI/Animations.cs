using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Animations : MonoBehaviour
{
    public bool raining;
    public bool animal;
    public bool cold;
    public GameObject snow;
    public GameObject rain;
    public GameObject seed;
    public GameObject plant;
    public GameObject animall;
    public GameObject bigPlant;
    public GameObject cloud;
    public GameObject coldd;
    public Menu menu;
    public GameObject reset;

    public void Start()
    {
        menu = FindAnyObjectByType<Menu>();
        raining = menu.raining.isOn;
        animal = menu.animal.isOn;
        cold = menu.cold.isOn;
        Invoke("Reset", 3f);
        Begin();
    }

    public void Begin()
    {
        if (animal)
        {
            animall.SetActive(true);

            if (raining)
            {
                cloud.SetActive(true);

                if (cold)
                {
                    snow.SetActive(true);
                    coldd.SetActive(true);
                }
                else
                {
                    rain.SetActive(true);
                }
            }
            else
            {
                if(cold)
                {
                    coldd.SetActive(true);
                }
            }
        }
        else
        {
            if(raining)
            {
                cloud.SetActive(true);

                if (cold)
                {
                    snow.SetActive(true);
                    seed.SetActive(true);
                    coldd.SetActive(true);
                }
                else
                {
                    rain.SetActive(true);
                    bigPlant.SetActive(true);
                }
            }
            else
            {
                if (cold)
                {
                    seed.SetActive(true);
                    coldd.SetActive(true);
                }
                else
                {
                    plant.SetActive(true);
                }
            }
        }
    }

    void Reset()
    {
        reset.SetActive(true);
        reset.GetComponent<Button>().onClick.AddListener(menu.Load);
    }
}
