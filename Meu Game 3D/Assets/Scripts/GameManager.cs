using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, MsgVitoria;
    public int Restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);

        Restantes = FindObjectsOfType<Moeda>().Length;
        hud.text = $"Moedas Restantes: {Restantes}";
    }

    public void SubtrairMoedas(int valor)
    {

        Restantes = Restantes - valor;
        hud.text = $"Moedas Restantes: {Restantes}";
        source.PlayOneShot(clipMoeda);

        if (Restantes <= 0)
        {
            //ganhou o jogo
            MsgVitoria.text = "Parabéns!";
            source.Stop();
             source.PlayOneShot(clipVitoria);
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
