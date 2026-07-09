using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010AF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3584", Offset = "0x5A3584")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3584", Offset = "0x5A3584")]
	public class SetVelocity2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004EE7")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E9574", Offset = "0x5E9574")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9574", Offset = "0x5E9574")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004EE8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9608", Offset = "0x5E9608")]
		public FsmVector2 vector;

		[Token(Token = "0x4004EE9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9640", Offset = "0x5E9640")]
		public FsmFloat x;

		[Token(Token = "0x4004EEA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9678", Offset = "0x5E9678")]
		public FsmFloat y;

		[Token(Token = "0x4004EEB")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E96B0", Offset = "0x5E96B0")]
		public Space space;

		[Token(Token = "0x4004EEC")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E96E8", Offset = "0x5E96E8")]
		public bool everyFrame;

		[Token(Token = "0x600638D")]
		[Address(RVA = "0x83CB00", Offset = "0x83CB00", VA = "0x83CB00", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600638E")]
		[Address(RVA = "0x83CBA0", Offset = "0x83CBA0", VA = "0x83CBA0", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x600638F")]
		[Address(RVA = "0x83CBC0", Offset = "0x83CBC0", VA = "0x83CBC0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006390")]
		[Address(RVA = "0x83CDD0", Offset = "0x83CDD0", VA = "0x83CDD0", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006391")]
		[Address(RVA = "0x83CBFC", Offset = "0x83CBFC", VA = "0x83CBFC")]
		private void DoSetVelocity()
		{
		}

		[Token(Token = "0x6006392")]
		[Address(RVA = "0x83CE0C", Offset = "0x83CE0C", VA = "0x83CE0C")]
		public SetVelocity2d()
		{
		}
	}
}
