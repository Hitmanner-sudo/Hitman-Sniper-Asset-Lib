using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A993C", Offset = "0x5A993C")]
	public abstract class TweenPropertyBase<T> : TweenActionBase where T : NamedVariable
	{
		[Token(Token = "0x40054E8")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FF1D4", Offset = "0x5FF1D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF1D4", Offset = "0x5FF1D4")]
		public TargetValueOptions fromOption;

		[Token(Token = "0x40054E9")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5FF234", Offset = "0x5FF234")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF234", Offset = "0x5FF234")]
		public T fromValue;

		[Token(Token = "0x40054EA")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF294", Offset = "0x5FF294")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FF294", Offset = "0x5FF294")]
		public TargetValueOptions toOption;

		[Token(Token = "0x40054EB")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF2F4", Offset = "0x5FF2F4")]
		[Attribute(Name = "HideIfAttribute", RVA = "0x5FF2F4", Offset = "0x5FF2F4")]
		public T toValue;

		[Token(Token = "0x40054EC")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FF354", Offset = "0x5FF354")]
		private object _003CStartValue_003Ek__BackingField;

		[Token(Token = "0x40054ED")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FF364", Offset = "0x5FF364")]
		private object _003CEndValue_003Ek__BackingField;

		[Token(Token = "0x17000C45")]
		public object StartValue
		{
			[Token(Token = "0x60068A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C140", Offset = "0x62C140")]
			get
			{
				return null;
			}
			[Token(Token = "0x60068A9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C150", Offset = "0x62C150")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000C46")]
		public object EndValue
		{
			[Token(Token = "0x60068AA")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C160", Offset = "0x62C160")]
			get
			{
				return null;
			}
			[Token(Token = "0x60068AB")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C170", Offset = "0x62C170")]
			protected set
			{
			}
		}

		[Token(Token = "0x60068A7")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068AC")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068AD")]
		protected virtual void InitTargets()
		{
		}

		[Token(Token = "0x60068AE")]
		protected virtual object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		[Token(Token = "0x60068AF")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068B0")]
		protected TweenPropertyBase()
		{
		}
	}
}
