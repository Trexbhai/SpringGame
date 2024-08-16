using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to create a scriptable object we inheret from scriptable object(not mono behaviour)
// Create asset menu enables it to be visible in the right click menu

[CreateAssetMenu(fileName = "New Player Data", menuName = "Data/ New Player")]
public class PlayerData : ScriptableObject 
{
    [field: SerializeField]
    public string DisplayName { get; private set; } = "Spring";

    [Header("Health")]
    [SerializeField] private int _maxHealth = 3;
    [SerializeField] private int _minHealth = 0;

    [Header("Move Speed")]
    [SerializeField] private float _runSpeed = 1.0f;

    [Header("Dash")]
    [SerializeField] private float _dashDistance = 5.0f;
    [SerializeField] private float _dashSpeed = 5.0f;
    [SerializeField] private float _dashCount = 1f;

    [Header("Jump")]
    [SerializeField] private float _jumpHeight = 1.0f;
    [SerializeField] private float _jumpSpeed = 1.0f;

    [Header("Gravity")]
    [SerializeField] private float _gravity = 10.0f;
    [SerializeField, Range(1f,3f)] private float fastFallModifier = 2.0f;

    [Header("Afforadance")]
    [SerializeField] private float _coyoteTime = 0.1f;
    [SerializeField] private float _jumpBuffer = 0.1f;
    [SerializeField] private float _fastFallBuffer = 2f;

    [Header("Momentum")]
    [SerializeField] private float _momentumFalloffTime = 0.3f;
    [SerializeField, Range(0f, 1f)] private float _airControlFactor = 0.3f;

    [Header("Speed Cap")]
    [SerializeField] private float _speedCap = 5.0f;

    public float MaxHealth => _maxHealth;
    public float MinHealth => _minHealth;
    public float RunSpeed => _runSpeed;
    public float DashSpeed => _dashSpeed;
    public float JumpHeight => _jumpHeight;
    public float JumpSpeed => _jumpSpeed;
    public float Gravity => _gravity;
    public float CoyoteTime => _coyoteTime;
    public float JumpBuffer => _jumpBuffer;
    public float FastFallBuffer => _fastFallBuffer;
    public float MomentumFalloffMultiplier => _momentumFalloffTime;
    public float AirControlFactor => _airControlFactor;
    public float SpeedCap => _speedCap;
}
