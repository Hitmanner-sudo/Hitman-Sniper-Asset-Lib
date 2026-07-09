using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9B74", Offset = "0x5A9B74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9B74", Offset = "0x5A9B74")]
	public class TweenFloat : TweenVariableBase<FsmFloat>
	{
		[Token(Token = "0x60068D5")]
		[Address(RVA = "0xCAEAD8", Offset = "0xCAEAD8", VA = "0xCAEAD8", Slot = "65")]
		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		[Token(Token = "0x60068D6")]
		[Address(RVA = "0xCAEBAC", Offset = "0xCAEBAC", VA = "0xCAEBAC", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068D7")]
		[Address(RVA = "0xCAECB8", Offset = "0xCAECB8", VA = "0xCAECB8")]
		public TweenFloat()
		{
		}
	}
}
