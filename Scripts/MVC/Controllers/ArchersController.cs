using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchersController : MonoBehaviour
{
    enum ArchersType { Red, Green, Orange}
    ArchersType currentType;
    [HideInInspector]public int archersCount;
    public List<Transform> ArchersPositions;
    public List<GameObject> ArchersPrefabs;
    public List<GameObject> Archers = new List<GameObject>();
    BankController bankController;
    public BankController BankController
    {
        set { bankController = value; }
    }

    public void AddArcher()
    {
        if(archersCount <= 2)
        {
            if (bankController.TryBuyArcher(archersCount))
            {
                GameObject archer = Instantiate(ArchersPrefabs[(int)currentType], ArchersPositions[archersCount].position, Quaternion.identity);
                Archers.Add(archer);
                currentType = ArchersType.Red;
                archersCount++;
            }
        }  
    }
    public void UpgradeArcher()
    {
        if (archersCount != 0)
        {
            if (bankController.TryUpdateArchers(archersCount, (int)currentType))
            {
                int newArcherType = (int)currentType;
                newArcherType++;
                currentType = (ArchersType)newArcherType;
                for (int i = 0; i < Archers.Count; i++)
                {
                    GameObject curArch = Archers[i];
                    Destroy(curArch);
                    
                }
                Archers.Clear();
                for (int i = 0; i < archersCount; i++)
                {
                    GameObject archer = Instantiate(ArchersPrefabs[(int)currentType], ArchersPositions[i].position, Quaternion.identity);
                    Archers.Add(archer);
                }
            }
        }
    }
}
