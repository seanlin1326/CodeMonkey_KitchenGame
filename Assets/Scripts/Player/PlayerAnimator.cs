using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KitchenProject
{
    public class PlayerAnimator : MonoBehaviour
    {
        private const string IsWalking_AnimatorParameter = "IsWalking";

        [SerializeField] private Player player;
        private Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }
        private void Update()
        {
            animator.SetBool(IsWalking_AnimatorParameter, player.IsWalking()); 
        }

    }
}