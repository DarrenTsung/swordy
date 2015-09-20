using DT;
using System.Collections;
﻿using UnityEngine;

public class SwordyPlayerController : MonoBehaviour {
	// PRAGMA MARK - INTERNAL
	protected SwordyPlayer _player;
	
	protected virtual void Awake() {
		_player = this.GetRequiredComponent<SwordyPlayer>();
	}
}
