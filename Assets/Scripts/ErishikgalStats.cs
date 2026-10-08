using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ErishikgalStats : MonoBehaviour
{
    [Header("Erishikgal Base Stats")]
    public string ErishikgalName = "Erishikgal";
    public int MaxHealth = 150;
    public int MeleeAttack = 25;
    public int RangedAttack = 4;
    public int RangedAttackCount = 6;
    public int DamageMultiplier = 1;
    public int DefenseIgnorePercent = 5;
    public int CriticalHitChance = 10;
    public int CriticalHitMultiplier = 75;
    public int Defense = 10;
    public int DamageReductionPercent = 5;
    public int Speed = 95;

    [Header("Erishikgal Current Stats")]
    public int CurrentHealth = 150;


    [Header("Erishikgal Level Up Stats")]
    public int HealthIncreasePerLevel = 15;

    [Header("Erishikgal Weapon Level Up Stats")]
    public int MeleeAttackIncreasePerLevel = 5;
    public int RangedAttackIncreasePerLevel = 2;

    [Header("Erishikgal Event Flags")]
    public bool IsArmGone = false;
    public bool HasAmulet = false;
}
