using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "ErishikgalStats", menuName = "ScriptableObjects/ErishikgalStats", order = 1)]
public class ErishikgalStats : ScriptableObject
{
    [Header("Erishikgal Base Stats")]
    public int MaxHealth = 150;
    public int MeleeAttack = 25;
    public int RangedAttack = 4;
    public int RangedAttackCount = 6;
    public int DamageMultiplier = 1;
    public int DefenseIgnorePercent = 5;
    public int CriticalHitChance = 10;
    public int CriticalHitMultiplier = 75;
    public int Defense = 10;
    public int DamageReguctionPercent = 5;
    public int Speed = 95;

    [Header("Erishikgal Currwnt Stats")]
    public int CurrentHealth;


    [Header("Erishikgal Level Up Stats")]
    public int HealthIncreasePerLevel = 15;
    public int damageIncreasePerLevel = 5;

    [Header("Erishikgal Weapon Level Up Stats")]
    public int MeleeAttackIncreasePerLevel = 5;
    public int RangedAttackIncreasePerLevel = 2;

    [Header("Erishikgal Event Flags")]
    public bool IsArmGone = false;
    public bool HasAmulet = false;
}
