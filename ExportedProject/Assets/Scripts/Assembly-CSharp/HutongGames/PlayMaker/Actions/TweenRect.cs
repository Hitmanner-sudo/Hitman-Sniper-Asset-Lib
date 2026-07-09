using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9D04", Offset = "0x5A9D04")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9D04", Offset = "0x5A9D04")]
	public class TweenRect : TweenVariableBase<FsmRect>
	{
		[Token(Token = "0x60068EC")]
		[Address(RVA = "0x1572970", Offset = "0x1572970", VA = "0x1572970", Slot = "65")]
		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		[Token(Token = "0x60068ED")]
		[Address(RVA = "0x1572B04", Offset = "0x1572B04", VA = "0x1572B04", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068EE")]
		[Address(RVA = "0x1572C7C", Offset = "0x1572C7C", VA = "0x1572C7C")]
		public TweenRect()
		{
		}
	}
}
