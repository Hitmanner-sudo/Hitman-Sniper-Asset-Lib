using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EBE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599AD0", Offset = "0x599AD0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599AD0", Offset = "0x599AD0")]
	public class RemoveMixingTransform : BaseAnimationAction
	{
		[Token(Token = "0x40045D9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C3108", Offset = "0x5C3108")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3108", Offset = "0x5C3108")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045DA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C319C", Offset = "0x5C319C")]
		[RequiredField]
		public FsmString animationName;

		[Token(Token = "0x40045DB")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C31E8", Offset = "0x5C31E8")]
		public FsmString transfrom;

		[Token(Token = "0x6005B1C")]
		[Address(RVA = "0x965C68", Offset = "0x965C68", VA = "0x965C68", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B1D")]
		[Address(RVA = "0x965CC0", Offset = "0x965CC0", VA = "0x965CC0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B1E")]
		[Address(RVA = "0x965CE8", Offset = "0x965CE8", VA = "0x965CE8")]
		private void DoRemoveMixingTransform()
		{
		}

		[Token(Token = "0x6005B1F")]
		[Address(RVA = "0x965E20", Offset = "0x965E20", VA = "0x965E20")]
		public RemoveMixingTransform()
		{
		}
	}
}
