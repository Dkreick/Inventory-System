﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Item"))]
public class Item : ScriptableObject
{
	[SerializeField] string id;
    [SerializeField] int damage;
    [SerializeField] Sprite image;
}