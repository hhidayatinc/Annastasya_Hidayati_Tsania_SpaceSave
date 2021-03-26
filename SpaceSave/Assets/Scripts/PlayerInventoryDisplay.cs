using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
   public Image[] heartPlaceholders;
 	public Sprite iconFullHeart;
 	public Sprite iconEmptyHeart;
 	public void OnChangeHeartTotal(int asteroidTotal)
 	{
 		for (int i = 0; i < heartPlaceholders.Length; ++i)
 			{
 				if (i < asteroidTotal)
 					heartPlaceholders[i].sprite = iconEmptyHeart;
 				else
 					heartPlaceholders[i].sprite = iconFullHeart;
 			}
 	}
}
