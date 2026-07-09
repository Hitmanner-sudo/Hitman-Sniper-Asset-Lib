using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001086")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2824", Offset = "0x5A2824")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2824", Offset = "0x5A2824")]
	public class SetVelocity : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DBB")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E445C", Offset = "0x5E445C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E445C", Offset = "0x5E445C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DBC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E44F0", Offset = "0x5E44F0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E44F0", Offset = "0x5E44F0")]
		public FsmVector3 vector;

		[Token(Token = "0x4004DBD")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4540", Offset = "0x5E4540")]
		public FsmFloat x;

		[Token(Token = "0x4004DBE")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4578", Offset = "0x5E4578")]
		public FsmFloat y;

		[Token(Token = "0x4004DBF")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E45B0", Offset = "0x5E45B0")]
		public FsmFloat z;

		[Token(Token = "0x4004DC0")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E45E8", Offset = "0x5E45E8")]
		public Space space;

		[Token(Token = "0x4004DC1")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4620", Offset = "0x5E4620")]
		public bool everyFrame;

		[Token(Token = "0x60062AC")]
		[Address(RVA = "0x83C740", Offset = "0x83C740", VA = "0x83C740", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062AD")]
		[Address(RVA = "0x83C804", Offset = "0x83C804", VA = "0x83C804", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60062AE")]
		[Address(RVA = "0x83C824", Offset = "0x83C824", VA = "0x83C824", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062AF")]
		[Address(RVA = "0x83CA78", Offset = "0x83CA78", VA = "0x83CA78", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60062B0")]
		[Address(RVA = "0x83C860", Offset = "0x83C860", VA = "0x83C860")]
		private void DoSetVelocity()
		{
		}

		[Token(Token = "0x60062B1")]
		[Address(RVA = "0x83CAB4", Offset = "0x83CAB4", VA = "0x83CAB4")]
		public SetVelocity()
		{
		}
	}
}
