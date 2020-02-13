using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Place this script on an object that needs to override the fade options
/// Override the fade objects per object
/// </summary>
public class FadeToMe : MonoBehaviour
{
    void Start()
    {
        this.transform.Translate(-Vector3.one); // Obligatoire pour avoir l'effet de Fade ( pas logique )
        FadeObstructionsManager.Instance.RegisterShouldBeVisible(this.gameObject);
    }

}