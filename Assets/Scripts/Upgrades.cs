using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrades : MonoBehaviour
{
    public float[] prices;
    public TextMeshProUGUI[] pricesText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpMartelos(){
        if(Main.coins>prices[0]){
            Main.coins-=prices[0];
            prices[0]*=1.1f;
            pricesText[0].text = Mathf.RoundToInt(prices[0]).ToString();
            Main.CperClick+=1;
        }
    }
    public void UpAssistente(){
        if(Main.coins>prices[1]){
            Main.coins-=prices[1];
            prices[1]*=1.1f;
            pricesText[1].text = Mathf.RoundToInt(prices[1]).ToString();
            Main.CperSecond+=1;
        }
    }
}
