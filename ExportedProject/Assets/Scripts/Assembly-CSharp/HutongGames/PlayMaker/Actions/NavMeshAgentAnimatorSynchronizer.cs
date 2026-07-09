using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EF1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59AA20", Offset = "0x59AA20")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59AA20", Offset = "0x59AA20")]
	public class NavMeshAgentAnimatorSynchronizer : FsmStateAction
	{
		[Token(Token = "0x40046B8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C7C6C", Offset = "0x5C7C6C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7C6C", Offset = "0x5C7C6C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C7C6C", Offset = "0x5C7C6C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40046B9")]
		[FieldOffset(Offset = "0x58")]
		private Animator _animator;

		[Token(Token = "0x40046BA")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent _agent;

		[Token(Token = "0x40046BB")]
		[FieldOffset(Offset = "0x68")]
		private Transform _trans;

		[Token(Token = "0x6005C10")]
		[Address(RVA = "0xC57C9C", Offset = "0xC57C9C", VA = "0xC57C9C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C11")]
		[Address(RVA = "0xC57CA4", Offset = "0xC57CA4", VA = "0xC57CA4", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005C12")]
		[Address(RVA = "0xC57CC4", Offset = "0xC57CC4", VA = "0xC57CC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C13")]
		[Address(RVA = "0xC57E00", Offset = "0xC57E00", VA = "0xC57E00", Slot = "59")]
		public override void DoAnimatorMove()
		{
		}

		[Token(Token = "0x6005C14")]
		[Address(RVA = "0xC57E98", Offset = "0xC57E98", VA = "0xC57E98")]
		public NavMeshAgentAnimatorSynchronizer()
		{
		}
	}
}
