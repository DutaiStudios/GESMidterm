using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    public Transform currspawn;
    public GameObject shark;
    int spawntimer;
    public int spawnset;
    public int random;
    public int difficulty;

    public bool easy;
    public bool medium;
    public bool hard;
    public bool supahhard;
    public bool jaws;
    public bool OHLAWDHECOMIN;

    public Transform sppn1;
    public Transform sppn2;
    public Transform sppn3;
    public Transform sppn4;
    public Transform sppn5;
    public Transform sppn6;
    public Transform sppn7;
    public Transform sppn8;
    public Transform sppn9;
    public Transform sppn10;
    public Transform sppn11;
    public Transform sppn12;
    public Transform sppn13;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawntimer++;
        difficulty++;

        difficultycheck();
        WaveManager();


    }

    void WaveManager()
    {
        if (easy == true)
        {
            if (spawntimer >= 200)
            {
                spawnpick();
                Instantiate(shark, currspawn);
                spawntimer = 0;
            }

        }

        if (medium == true)
        {
            if (spawntimer >= 150)
            {
                spawnpick();
                Instantiate(shark, currspawn);
                spawntimer = 0;
            }

        }

        if (hard == true)
        {
            if (spawntimer >= 100)
            {
                spawnpick();
                Instantiate(shark, currspawn);
                spawntimer = 0;
            }

        }

        if (supahhard == true)
        {
            if (spawntimer >= 75)
            {
                spawnpick();
                Instantiate(shark, currspawn);
                spawntimer = 0;
            }

        }

        if (OHLAWDHECOMIN == true)
        {
            if (spawntimer >= 50)
            {
                spawnpick();
                Instantiate(shark, currspawn);
                spawntimer = 0;
            }

        }
    }
    void difficultycheck()
    {

        if (difficulty <= 1000)
        {
            easy = true;

        }

        if (difficulty >= 1000)
        {
            easy = false;
            medium = true;
        }

        if (difficulty >= 2500)
        {
            medium = false;
            hard = true;
        }

        if (difficulty >= 5000)
        {
            hard= false;
            supahhard = true;
        }

        if (difficulty >= 8000)
        {
            supahhard = false;
            OHLAWDHECOMIN = true;
        }
    }
    void spawnpick()
    {
        random = Random.Range(0, 14);

        if (random == 1)
        {
            currspawn = sppn1;
        }

        if (random == 2)
        {
            currspawn = sppn2;
        }

        if (random == 3)
        {
            currspawn = sppn3;
        }

        if (random == 4)
        {
            currspawn = sppn4;
        }

        if (random == 5)
        {
            currspawn = sppn5;
        }

        if (random == 6)
        {
            currspawn = sppn6;
        }

        if (random == 7)
        {
            currspawn = sppn7;
        }

        if (random == 8)
        {
            currspawn = sppn8;
        }

        if (random == 9)
        {
            currspawn = sppn9;
        }

        if (random == 10)
        {
            currspawn = sppn10;
        }

        if (random == 11)
        {
            currspawn = sppn11;
        }

        if (random == 12)
        {
            currspawn = sppn12;
        }

        if (random == 13)
        {
            currspawn = sppn13;
        }
    }
}
