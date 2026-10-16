using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy01Stats : MonoBehaviour
{
    [Header("Enemy01 Base Stats")]
    public string EnemyName = "Zombie";
    public int MaxHealth = 150;
    public int MeleeAttack = 25;
    public int RangedAttack = 0;
    public int RangedAttackCount = 0;
    public int DamageMultiplier = 1;
    public int DefenseIgnorePercent = 0;
    public int CriticalHitChance = 1;
    public int CriticalHitMultiplier = 75;
    public int Defense = 10;
    public int DamageReductionPercent = 0;
    public int Speed = 60;

    [Header("Enemy01 Current Stats")]
    public int CurrentHealth = 150;


    [Header("Enemy01 Level Up Stats")]
    public int HealthIncreasePerLevel = 15;
    public int MeleeAttackIncreasePerLevel = 5;
    public int RangedAttackIncreasePerLevel = 0;
}