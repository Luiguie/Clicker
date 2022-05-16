using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Main : MonoBehaviour
{
    public static float coins, CperClick, CperSecond;
    public TextMeshProUGUI CointText;
    
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        CperClick = 1;
        CperSecond = 1;
        StartCoroutine(CPerSec());
    }

    // Update is called once per frame
    void Update()
    {
        CointText.text = Mathf.RoundToInt(coins).ToString();
    }

    public void MainClick(){
        coins+= CperClick;
    }

    IEnumerator CPerSec(){
        while(true){
            coins+=CperSecond/10;
            yield return new WaitForSeconds(0.1f);
        }
    }

    

}
