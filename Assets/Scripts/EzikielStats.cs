using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EzikielStats : MonoBehaviour
{
    [Header("Ezikiel Base Stats")]
    public string EzikielName = "Ezikiel";
    public int MaxHealth = 130;
    public int MeleeAttack = 30;
    public int RangedAttack = 30;
    public int RangedAttackCount = 1;
    public int DamageMultiplier = 1;
    public int DefenseIgnorePercent = 0;
    public int CriticalHitChance = 7;
    public int CriticalHitMultiplier = 60;
    public int Defense = 7;
    public int DamageReductionPercent = 0;
    public int Speed = 90;

    [Header("Ezikiel Current Stats")]
    public int CurrentHealth = 130;


    [Header("Ezikiel Level Up Stats")]
    public int HealthIncreasePerLevel = 10;

    [Header("Ezikiel Weapon Level Up Stats")]
    public int MeleeAttackIncreasePerLevel = 5;
    public int RangedAttackIncreasePerLevel = 5;

    [Header("Ezikiel Event Flags")]
    public bool IsArmGone = false;
    public bool HasAmulet = false;
}
