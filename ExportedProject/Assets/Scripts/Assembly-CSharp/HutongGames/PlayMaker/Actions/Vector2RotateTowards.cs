using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001269")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC9F4", Offset = "0x5AC9F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC9F4", Offset = "0x5AC9F4")]
	public class Vector2RotateTowards : FsmStateAction
	{
		[Token(Token = "0x4005822")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A5A8", Offset = "0x60A5A8")]
		public FsmVector2 currentDirection;

		[Token(Token = "0x4005823")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A5F4", Offset = "0x60A5F4")]
		public FsmVector2 targetDirection;

		[Token(Token = "0x4005824")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A640", Offset = "0x60A640")]
		[RequiredField]
		public FsmFloat rotateSpeed;

		[Token(Token = "0x4005825")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 current;

		[Token(Token = "0x4005826")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 target;

		[Token(Token = "0x6006BA0")]
		[Address(RVA = "0x13C71F0", Offset = "0x13C71F0", VA = "0x13C71F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BA1")]
		[Address(RVA = "0x13C7298", Offset = "0x13C7298", VA = "0x13C7298", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BA2")]
		[Address(RVA = "0x13C72D4", Offset = "0x13C72D4", VA = "0x13C72D4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BA3")]
		[Address(RVA = "0x13C73A4", Offset = "0x13C73A4", VA = "0x13C73A4")]
		public Vector2RotateTowards()
		{
		}
	}
}
