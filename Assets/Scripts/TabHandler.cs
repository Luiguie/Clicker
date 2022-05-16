using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabHandler : MonoBehaviour
{
    public GameObject[] tabs;
    public void tabClick(int tabNumber){
        switch(tabNumber){
            case 0:
            tabs[0].SetActive(true);
            tabs[1].SetActive(false);
            break;
            case 1:
            tabs[1].SetActive(true);
            break;
        }
    }
}
