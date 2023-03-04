using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlacedObject : MonoBehaviour
{
    //������������ ������
    public GameObject Tower;
    public GameObject Transformator;
    public GameObject PowerTransformator;
    public GameObject Stolb;

    //������ �� �������� � ������� ��������� ������
    public GameObject AR;
    public void SetTower()
    {
        AR.GetComponent<PlaceOnPlane>().placedPrefab = Tower;
    }

    public void SetTransfomator()
    {
        AR.GetComponent<PlaceOnPlane>().placedPrefab = Transformator;
    }
    public void SetPowerTransfomator()
    {
        AR.GetComponent<PlaceOnPlane>().placedPrefab = PowerTransformator;
    }
    public void SetStolb()
    {
        AR.GetComponent<PlaceOnPlane>().placedPrefab = Stolb;
    }
}
