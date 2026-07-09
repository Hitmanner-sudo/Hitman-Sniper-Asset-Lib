using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9BC4", Offset = "0x5A9BC4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9BC4", Offset = "0x5A9BC4")]
	public class TweenInt : TweenVariableBase<FsmInt>
	{
		[Token(Token = "0x60068D8")]
		[Address(RVA = "0xCB02AC", Offset = "0xCB02AC", VA = "0xCB02AC", Slot = "65")]
		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		[Token(Token = "0x60068D9")]
		[Address(RVA = "0xCB0370", Offset = "0xCB0370", VA = "0xCB0370", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068DA")]
		[Address(RVA = "0xCB04A0", Offset = "0xCB04A0", VA = "0xCB04A0")]
		public TweenInt()
		{
		}
	}
}
