using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetChanger : MonoBehaviour
{
   [SerializeField] private Menu _menu;
   public Planet Earth;
   public Planet Jupiter;
   public Planet Moon;
   [SerializeField] private Rigidbody2D _playerRigidbody2D;
   [SerializeField] private Camera _camera;


   private void OnChoicePlanet(Planet somePlanet)
   {
      _playerRigidbody2D.gravityScale = somePlanet.Gravitation;
      _camera.backgroundColor = somePlanet.BackGroundColor;
      _menu.DisableMenu();
   }

   public void EarthButton()
   {
      OnChoicePlanet(Earth);
   }
   public void MoonButton()
   {
      OnChoicePlanet(Moon);
   }

   public void JupiterButton()
   {
      OnChoicePlanet(Jupiter);
   }
}
