﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour {

    public static EffectManager Instance;

    public Transform EffectCanvas;


    public GameObject[] NegEffects;
    public GameObject[] PosEffects;
    public GameObject[] SuperPosEffects;

    private void Awake() {
        Instance = this;
    }

    public void PlayEffect(int effect, GameObject[] EffectType)
    {
        GameObject prefab = EffectType[effect];
        Instantiate(prefab);
    }

    public void PlayNegEffect()
    {
        GameObject prefab = NegEffects[Random.Range(0, NegEffects.Length)];
        Instantiate(prefab);
    }

    public void PlayPosEffect()
    {
        GameObject prefab = PosEffects[Random.Range(0, PosEffects.Length)];
        Instantiate(prefab);
    }

    public void PlaySuperPosEffect()
    {
        GameObject prefab = SuperPosEffects[Random.Range(0, SuperPosEffects.Length)];
        Instantiate(prefab);
    }

}
