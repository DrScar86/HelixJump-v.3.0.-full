using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Platform CurrentPlatform;
    public Game Game;
    public MeshRenderer MeshRenderer;
    public Material DissolveMaterial;
    public float TimeStart;
    public ParticleSystem PaintSplash;

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void Die()
    {
        PaintSplash.Play();
        MeshRenderer.material = DissolveMaterial;
        IsPlayerDie = true;
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

    public bool IsPlayerDie { get; private set; }

    private void FixedUpdate()
    {
        if (IsPlayerDie)
        {
            TimeStart += Time.deltaTime;
            
            DissolveMaterial.SetFloat("_DissolveAmount", TimeStart);
        }
        else
        {
            DissolveMaterial.SetFloat("_DissolveAmount", -1f);
        }
    }
}