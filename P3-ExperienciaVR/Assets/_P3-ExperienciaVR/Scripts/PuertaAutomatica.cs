using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaAutomatica : MonoBehaviour
{
  public Animator animator;

  private void Awake()
  {
    animator = GetComponent<Animator>();
  }

  public void Abrir()
  {
    animator.SetTrigger("Abriendose");
  }

  public void Cerrar()
  {
    animator.SetTrigger("Cerrandose");
  }
}
