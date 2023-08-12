using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{

    public GameObject Card1;
    public GameObject Card2;
    public GameObject EnemyArea;
    public GameObject PlayerArea;

    void Start()
    {

    }

    public void OnClick()
    {
        for (int i = 0; i < 5; i++)
        {

            GameObject playerCard = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);
            GameObject enemyCard = Instantiate(Card2, new Vector3(0, 0, 0), Quaternion.identity);
            enemyCard.transform.SetParent (EnemyArea.transform, false);
        }
    }
}
