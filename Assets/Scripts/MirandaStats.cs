using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirandaStats : MonoBehaviour
{
    [Header("Miranda Base Stats")]
    public string MirandaName = "Miranda";
    public int MaxHealth = 90;
    public int MeleeAttack = 5;
    public int RangedAttack = 40;
    public int RangedAttackCount = 1;
    public int DamageMultiplier = 1;
    public int DefenseIgnorePercent = 10;
    public int CriticalHitChance = 15;
    public int CriticalHitMultiplier = 100;
    public int Defense = 5;
    public int DamageReductionPercent = 0;
    public int Speed = 110;

    [Header("Miranda Current Stats")]
    public int CurrentHealth = 90;


    [Header("Miranda Level Up Stats")]
    public int HealthIncreasePerLevel = 5;

    [Header("Miranda Weapon Level Up Stats")]
    public int MeleeAttackIncreasePerLevel = 1;
    public int RangedAttackIncreasePerLevel = 10;

    [Header("Miranda Event Flags")]
    public bool IsArmGone = false;
    public bool HasAmulet = false;
}
