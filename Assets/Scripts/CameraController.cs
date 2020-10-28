﻿using UnityEngine;


namespace Labirint2
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - _player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = _player.transform.position + _offset;
        }
    }

}