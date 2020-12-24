using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
	public float walkingSpeed = 2;
	public float runningSpeed = 12;
	public float rotationSensitivity = 500;
}
