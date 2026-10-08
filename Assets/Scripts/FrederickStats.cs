using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrederickStats : MonoBehaviour
{
    [Header("Frederick Base Stats")]
    public string FrederickName = "Frederick";
    public int MaxHealth = 200;
    public int MeleeAttack = 40;
    public int RangedAttack = 0;
    public int RangedAttackCount = 0;
    public int DamageMultiplier = 1;
    public int DefenseIgnorePercent = 0;
    public int CriticalHitChance = 1;
    public int CriticalHitMultiplier = 50;
    public int Defense = 15;
    public int DamageReductionPercent = 10;
    public int Speed = 50;

    [Header("Frederick Current Stats")]
    public int CurrentHealth = 200;


    [Header("Frederick Level Up Stats")]
    public int HealthIncreasePerLevel = 10;

    [Header("Frederick Weapon Level Up Stats")]
    public int MeleeAttackIncreasePerLevel = 10;
    public int RangedAttackIncreasePerLevel = 0;

    [Header("Frederick Event Flags")]
    public bool IsActiveCharacter = false;
    public bool IsArmGone = false;
    public bool HasAmulet = false;
}
