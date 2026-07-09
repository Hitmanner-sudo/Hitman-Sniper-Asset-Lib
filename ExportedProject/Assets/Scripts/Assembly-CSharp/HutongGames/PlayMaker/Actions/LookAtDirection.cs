using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011AA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9134", Offset = "0x5A9134")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9134", Offset = "0x5A9134")]
	public class LookAtDirection : ComponentAction<Transform>
	{
		[Token(Token = "0x4005425")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC734", Offset = "0x5FC734")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005426")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC780", Offset = "0x5FC780")]
		[RequiredField]
		public FsmVector3 targetDirection;

		[Token(Token = "0x4005427")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC7CC", Offset = "0x5FC7CC")]
		public FsmVector3 upVector;

		[Token(Token = "0x4005428")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC804", Offset = "0x5FC804")]
		public bool everyFrame;

		[Token(Token = "0x4005429")]
		[FieldOffset(Offset = "0x81")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC83C", Offset = "0x5FC83C")]
		public bool lateUpdate;

		[Token(Token = "0x60067FF")]
		[Address(RVA = "0x9DFD34", Offset = "0x9DFD34", VA = "0x9DFD34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006800")]
		[Address(RVA = "0x9DFDD4", Offset = "0x9DFDD4", VA = "0x9DFDD4", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006801")]
		[Address(RVA = "0x9DFDF8", Offset = "0x9DFDF8", VA = "0x9DFDF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006802")]
		[Address(RVA = "0x9DFF64", Offset = "0x9DFF64", VA = "0x9DFF64", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006803")]
		[Address(RVA = "0x9DFF74", Offset = "0x9DFF74", VA = "0x9DFF74", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006804")]
		[Address(RVA = "0x9DFE34", Offset = "0x9DFE34", VA = "0x9DFE34")]
		private void DoLookAtDirection()
		{
		}

		[Token(Token = "0x6006805")]
		[Address(RVA = "0x9DFF84", Offset = "0x9DFF84", VA = "0x9DFF84")]
		public LookAtDirection()
		{
		}
	}
}
