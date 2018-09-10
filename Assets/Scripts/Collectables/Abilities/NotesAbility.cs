using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Collectables.Abilities {
    class NotesAbility : MonoBehaviour {
        private bool abilityActive;
        private SpriteRenderer myRenderer;

        private void Start()
        {
            myRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            if (abilityActive)
            {
                myRenderer.enabled = !myRenderer.enabled;
            }
            else
                myRenderer.enabled = true;
        }

        private void OnCollisionEnter2D(Collision2D collision) {
            if (abilityActive)
            {
                if (collision.collider.tag == "Enemy")
                {
                    collision.collider.gameObject.SendMessage("Die");
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
