using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CerraduraLlaveConClave : MonoBehaviour
{
  public string Clave;

  public UnityEvent OnClaveCorrecta;
  public UnityEvent OnClaveIncorrecta;

  private void OnTriggerEnter(Collision collision)
  {
    GameObject ObjectoColisionado = collision.gameObject;
    if (ObjectoColisionado.GetComponent<LlaveConClave>())
    {
      if (ObjectoColisionado.GetComponent<LlaveConClave>().Clave == Clave) // Si la clave coincide
      {
        OnClaveCorrecta.Invoke();
      }
      else
      {
        OnClaveIncorrecta.Invoke();
      }

    }
  }
}
