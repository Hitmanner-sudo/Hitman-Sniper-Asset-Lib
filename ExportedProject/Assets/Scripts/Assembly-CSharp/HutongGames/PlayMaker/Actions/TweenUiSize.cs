using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011DC")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A9EAC", Offset = "0x5A9EAC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9EAC", Offset = "0x5A9EAC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9EAC", Offset = "0x5A9EAC")]
	public class TweenUiSize : TweenComponentBase<RectTransform>
	{
		[Token(Token = "0x4005578")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60004C", Offset = "0x60004C")]
		public TweenDirection tweenDirection;

		[Token(Token = "0x4005579")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600084", Offset = "0x600084")]
		public FsmVector2 targetSize;

		[Token(Token = "0x400557A")]
		[FieldOffset(Offset = "0xD8")]
		private RectTransform rectTransform;

		[Token(Token = "0x400557B")]
		[FieldOffset(Offset = "0xE0")]
		private Vector2 fromSize;

		[Token(Token = "0x400557C")]
		[FieldOffset(Offset = "0xE8")]
		private Vector2 toSize;

		[Token(Token = "0x6006913")]
		[Address(RVA = "0x1574524", Offset = "0x1574524", VA = "0x1574524", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006914")]
		[Address(RVA = "0x157457C", Offset = "0x157457C", VA = "0x157457C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006915")]
		[Address(RVA = "0x1574630", Offset = "0x1574630", VA = "0x1574630", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x6006916")]
		[Address(RVA = "0x15746A4", Offset = "0x15746A4", VA = "0x15746A4")]
		public TweenUiSize()
		{
		}
	}
}
