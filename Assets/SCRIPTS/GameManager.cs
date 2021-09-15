using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	static public GameManager instanceGameManager;
	static public GameManager Instance { get { return instanceGameManager; } }

	private void Awake()
	{
		if (instanceGameManager != this && instanceGameManager != null)
			Destroy(this.gameObject);
		else
			instanceGameManager = this;
	}
	private void Start()
	{
		
	}

	private void Update()
	{
		
	}
}
