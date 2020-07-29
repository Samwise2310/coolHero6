using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheesyJokes : MonoBehaviour
{

    // Declaring Variabals
        // Bakery
    public GameObject bakery;
        // Ball
    public GameObject ball;
        // Bar
    public GameObject bar;
        // Bike
    public GameObject bike;
        // Bombing
    public GameObject bombing;
        // Construction
    public GameObject construction;
        // ExWife
    public GameObject exWife;
        // Fish
    public GameObject fish;
        // Gouda
    public GameObject gouda;
        // In Tents
    public GameObject inTents;
        // Kid Napping
    public GameObject kidNapping;
        // Numbers
    public GameObject numbers;
        // Peanuts
    public GameObject peanuts;
        // Small
    public GameObject small;
        // stairs
    public GameObject stairs;

        // timer
    float timer = 0;





    void Start()
    {
        bakery.SetActive(false); //
        ball.SetActive(false); //
        bar.SetActive(false); //
        bike.SetActive(false); //
        bombing.SetActive(false); //
        construction.SetActive(false); //
        exWife.SetActive(false); //
        fish.SetActive(false); //
        gouda.SetActive(false); //
        inTents.SetActive(false); //
        kidNapping.SetActive(false); //
        numbers.SetActive(false); //
        peanuts.SetActive(false); //
        small.SetActive(false); //
        stairs.SetActive(false); //

        Invoke("Bakery", 2f);
    }


    void Bakery()
    {
        bakery.SetActive(true);
        Invoke("BakeryOff", 5f);
    }

    void BakeryOff()
    {
        bakery.SetActive(false);
        Invoke("Stairs", 3f);
    }

    void Stairs()
    {
        stairs.SetActive(true);
        Invoke("StairsOff", 5f);
    }

    void StairsOff()
    {
        stairs.SetActive(false);
        Invoke("Construction", 3f);
    }

    void Construction()
    {
        construction.SetActive(true);
        Invoke("ConstructionOff", 5f);
    }

    void ConstructionOff()
    {
        construction.SetActive(false);
        Invoke("Fish", 3f);
    }

    void Fish()
    {
        fish.SetActive(true);
        Invoke("FishOff", 5f);
    }

    void FishOff()
    {
        fish.SetActive(false);
        Invoke("Kidnapping", 3f);
    }

    void Kidnapping()
    {
        kidNapping.SetActive(true);
        Invoke("KidnappingOff", 5f);
    }

    void KidnappingOff()
    {
        kidNapping.SetActive(false);
        Invoke("Peanuts", 3f);
    }

    void Peanuts()
    {
        peanuts.SetActive(true);
        Invoke("PeanutsOff", 5f);
    }

    void PeanutsOff()
    {
        peanuts.SetActive(false);
        Invoke("Bar", 3f);
    }

    void Bar()
    {
        bar.SetActive(true);
        Invoke("BarOff", 5f);
    }

    void BarOff()
    {
        bar.SetActive(false);
        Invoke("InTents", 3f);
    }

    void InTents()
    {
        inTents.SetActive(true);
        Invoke("InTentsOff", 5f);
    }

    void InTentsOff()
    {
        inTents.SetActive(false);
        Invoke("Gouda", 3f);
    }

    void Gouda()
    {
        gouda.SetActive(true);
        Invoke("GoudaOff", 5f);
    }

    void GoudaOff()
    {
        gouda.SetActive(false);
        Invoke("Small", 3f);
    }

    void Small()
    {
        small.SetActive(true);
        Invoke("SmallOff", 5f);
    }

    void SmallOff()
    {
        small.SetActive(false);
        Invoke("Ball", 3f);
    }

    void Ball()
    {
        ball.SetActive(true);
        Invoke("BallOff", 5f);
    }

    void BallOff()
    {
        ball.SetActive(false);
        Invoke("Bombing", 3f);
    }

    void Bombing()
    {
        bombing.SetActive(true);
        Invoke("BombingOff", 5f);
    }

    void BombingOff()
    {
        bombing.SetActive(false);
        Invoke("Numbers", 3f);
    }

    void Numbers()
    {
        numbers.SetActive(true);
        Invoke("NumbersOff", 5f);
    }

    void NumbersOff()
    {
        numbers.SetActive(false);
        Invoke("Bike", 3f);
    }

    void Bike()
    {
        bike.SetActive(true);
        Invoke("BikeOff", 5f);
    }

    void BikeOff()
    {
        bike.SetActive(false);
        Invoke("ExWife", 3f);
    }

    void ExWife()
    {
        exWife.SetActive(true);
        Invoke("ExWifeOff", 5f);
    }

    void ExWifeOff()
    {
        exWife.SetActive(false);
    }

}
