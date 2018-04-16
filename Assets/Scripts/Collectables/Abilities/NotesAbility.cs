﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Collectables.Abilities {
    class NotesAbility : MonoBehaviour {
        private bool abilityActive;


        private void OnCollisionEnter2D(Collision2D collision) {
            if (abilityActive)
            {
                if (collision.collider.tag == "Enemy")
                {
                    Destroy(collision.collider.gameObject);
                }
            }
        }

        public IEnumerator ActivateAbility(float time){
            abilityActive = true;
            yield return new WaitForSeconds(time);
            abilityActive = false;
        }

        public bool AbilityActive{
            get {
                return abilityActive;
            }

            set {
                abilityActive = value;
            }
        }
    }
}