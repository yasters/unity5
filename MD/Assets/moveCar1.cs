﻿using UnityEngine;
using System.Collections;

public class moveCar1 : MonoBehaviour {

	private Vector3 m_pos;
	// Use this for initialization
	void Start() {
		m_pos = transform.localPosition;  // 形状位置を保持
	}

	// Update is called once per frame
	void Update() {
		transform.localPosition = m_pos;  // 形状位置を更新
		m_pos.x += 0.3f;
	}
}
