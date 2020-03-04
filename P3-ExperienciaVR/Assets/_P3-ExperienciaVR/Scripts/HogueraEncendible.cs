using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HogueraEncendible : MonoBehaviour
{
  public List<GameObject> ComponentesLlama;

  public bool IsLlamaEncendida;

  private void Start()
  {
    if (IsLlamaEncendida)
    {
      EncenderLlama();
    }
    else
    {
      ApagarLlama();
    }
  }

  //Se podrían hacer ambos en un Script polivalente
  public void EncenderLlama()
  {
    for(int i=0; i<ComponentesLlama.Count; i++)
    {
      ComponentesLlama[i].SetActive(true);
    }
    IsLlamaEncendida = true;
  }

  public void ApagarLlama()
  {
    for (int i = 0; i < ComponentesLlama.Count; i++)
    {
      ComponentesLlama[i].SetActive(false);
    }
    IsLlamaEncendida = false;
  }

  private void OnTriggerEnter(Collider other)
  {
    GameObject ObjetoAtravesado = other.gameObject;
    Llama LlamaObjeto = ObjetoAtravesado.GetComponent<Llama>();
    if (LlamaObjeto != null)
    {
      Invoke("EncenderLlama", 1);
    }
  }

}
