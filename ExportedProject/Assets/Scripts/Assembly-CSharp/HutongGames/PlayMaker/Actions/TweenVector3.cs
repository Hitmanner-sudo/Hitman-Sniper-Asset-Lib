using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011DE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9FB4", Offset = "0x5A9FB4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9FB4", Offset = "0x5A9FB4")]
	public class TweenVector3 : TweenVariableBase<FsmVector3>
	{
		[Token(Token = "0x600691A")]
		[Address(RVA = "0x1574930", Offset = "0x1574930", VA = "0x1574930", Slot = "65")]
		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		[Token(Token = "0x600691B")]
		[Address(RVA = "0x1574A14", Offset = "0x1574A14", VA = "0x1574A14", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x600691C")]
		[Address(RVA = "0x1574B54", Offset = "0x1574B54", VA = "0x1574B54")]
		public TweenVector3()
		{
		}
	}
}
