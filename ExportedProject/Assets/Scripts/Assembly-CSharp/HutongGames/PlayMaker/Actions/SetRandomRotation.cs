using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9338", Offset = "0x5A9338")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9338", Offset = "0x5A9338")]
	public class SetRandomRotation : FsmStateAction
	{
		[Token(Token = "0x4005454")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD0DC", Offset = "0x5FD0DC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005455")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD128", Offset = "0x5FD128")]
		public FsmBool x;

		[Token(Token = "0x4005456")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD174", Offset = "0x5FD174")]
		[RequiredField]
		public FsmBool y;

		[Token(Token = "0x4005457")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD1C0", Offset = "0x5FD1C0")]
		[RequiredField]
		public FsmBool z;

		[Token(Token = "0x6006827")]
		[Address(RVA = "0x1043C44", Offset = "0x1043C44", VA = "0x1043C44", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006828")]
		[Address(RVA = "0x1043C94", Offset = "0x1043C94", VA = "0x1043C94", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006829")]
		[Address(RVA = "0x1043CBC", Offset = "0x1043CBC", VA = "0x1043CBC")]
		private void DoRandomRotation()
		{
		}

		[Token(Token = "0x600682A")]
		[Address(RVA = "0x1043E30", Offset = "0x1043E30", VA = "0x1043E30")]
		public SetRandomRotation()
		{
		}
	}
}
