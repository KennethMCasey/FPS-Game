using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    int x = 0;
    public GameObject spawnItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        if (x % 20 == 0 && this.gameObject.tag == "TargetPositive" && spawner.targetPositiveCOunt < 100)
        {
            Instantiate(spawnItem, new Vector3((Random.value * 100 - 50), (Random.value * 100 - 50), (Random.value * 100 - 50)), Quaternion.identity);
            spawner.targetPositiveCOunt++;
        }

       else if (x % 20 == 0 && this.gameObject.tag == "TargetNegative" && spawner.targetNegativeCount < 200)
        {
            Instantiate(spawnItem, new Vector3((Random.value * 100 - 50), (Random.value * 100 - 50), (Random.value * 100 - 50)), Quaternion.identity);
            spawner.targetNegativeCount++;
        }

        else if (x % 20 == 0 && this.gameObject.tag == "TargetBonus" && spawner.targetBonusCount < 100)
        {
            Instantiate(spawnItem, new Vector3((Random.value * 100 - 50), (Random.value * 100 - 50), (Random.value * 100 - 50)), Quaternion.identity);
            spawner.targetBonusCount++;
        }

        else if (x % 20 == 0 && this.gameObject.tag == "TargetExtraLife" && spawner.targetExtraLife < 100)
        {
            Instantiate(spawnItem, new Vector3((Random.value * 100 - 50), (Random.value * 100 - 50), (Random.value * 100 - 50)), Quaternion.identity);
            spawner.targetExtraLife++;
        }
    }
}
