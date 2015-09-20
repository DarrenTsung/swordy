using DT;
using System.Collections;
﻿using UnityEngine;

public class SwordyPlayerMovementController : SwordyPlayerController {
	// PRAGMA MARK - INTERFACE
	
	// PRAGMA MARK - INTERNAL
	[SerializeField]
	protected float _movementSpeed = 5;
	[SerializeField, ReadOnly]
	protected Vector3 _velocity;
	
	protected void Start() {
		UnityEvents.V2 directionEvent = _player.HandleDirectionVector;
		directionEvent.AddListener((Vector2 direction) => { 
				_velocity = new Vector3(direction.x, 0.0f, direction.y).normalized * _movementSpeed;
			});
	}

	protected void FixedUpdate() {
		Vector3 newPosition = _player.MRigidbody.position + _velocity * Time.fixedDeltaTime;
		_player.MRigidbody.MovePosition(newPosition);
	}
}
