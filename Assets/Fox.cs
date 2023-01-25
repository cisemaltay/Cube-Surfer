using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private Animator _animator;
    private GameManager _gameManager;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _gameManager = FindObjectOfType<GameManager>();
    }
    
    public void OnGameFail()
    {
        _animator.SetInteger("State", 2);
    }

    public void OnGameWin()
    {
        _animator.SetInteger("State", 1);
    }

    public void OnGameStart()
    {
        _animator.speed = 1;
        _animator.SetInteger("State", 1);
    }

    public void StandUp()
    {
        _animator.Play("Walking");
        _animator.SetInteger("State", 0);
        _animator.speed = 0;
    }


    private void OnEnable()
    {
        _gameManager.onGameStart += OnGameStart;
        _gameManager.onGameFail += OnGameFail;
        _gameManager.onGameWin += OnGameWin;
    }

    private void OnDisable()
    {
        _gameManager.onGameStart -= OnGameStart;
        _gameManager.onGameFail -= OnGameFail;
        _gameManager.onGameWin -= OnGameWin;
    }
}
