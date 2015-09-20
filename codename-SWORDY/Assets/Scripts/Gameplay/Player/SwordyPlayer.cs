using DT;
using System.Collections;
﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SwordyPlayer : Player {
	// PRAGMA MARK - INTERACE
	public Rigidbody MRigidbody {
		get { return _rigidbody; }
	}
	
	public SwordyPlayerMovementController MovementController {
		get { return _movementController; }
	}
	
	// PRAGMA MARK - INTERNAL
	protected Rigidbody _rigidbody;
	protected SwordyPlayerMovementController _movementController;
	
	protected void Awake() {
		_rigidbody = this.GetRequiredComponent<Rigidbody>();
		_movementController = this.GetRequiredComponent<SwordyPlayerMovementController>();
	}
}
