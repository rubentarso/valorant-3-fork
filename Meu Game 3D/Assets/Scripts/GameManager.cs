using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, MsgVitoria;
    public int Restantes;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Restantes = FindObjectsOfType<Moeda>().Length;
        hud.text = $"Moedas Restantes: {Restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        Restantes = Restantes - valor;
        hud.text = $"Moedas Restantes: {Restantes}";
        
        if (Restantes <= 0)
        {
            //ganhou o jogo
            MsgVitoria.text = "Parabéns!";
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
