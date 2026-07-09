using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9950", Offset = "0x5A9950")]
	public abstract class TweenVariableBase<T> : TweenPropertyBase<T> where T : NamedVariable
	{
		[Token(Token = "0x40054EE")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FF374", Offset = "0x5FF374")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF374", Offset = "0x5FF374")]
		[RequiredField]
		public T variable;

		[Token(Token = "0x60068B1")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068B2")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068B3")]
		protected override void InitTargets()
		{
		}

		[Token(Token = "0x60068B4")]
		protected TweenVariableBase()
		{
		}
	}
}
