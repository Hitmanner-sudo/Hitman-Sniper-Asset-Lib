using System;
using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011DB")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A9DF4", Offset = "0x5A9DF4")]
	[AttributeAttribute(Name = "ActionTarget", RVA = "0x5A9DF4", Offset = "0x5A9DF4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A9DF4", Offset = "0x5A9DF4")]
	public class TweenUiPosition : TweenComponentBase<RectTransform>
	{
		[Token(Token = "0x400556D")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TitleAttribute", RVA = "0x5FFE44", Offset = "0x5FFE44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FFE44", Offset = "0x5FFE44")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5FFE44", Offset = "0x5FFE44")]
		public UiPositionOptions fromOption;

		[Token(Token = "0x400556E")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FFEC8", Offset = "0x5FFEC8")]
		public FsmGameObject fromTarget;

		[Token(Token = "0x400556F")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FFF00", Offset = "0x5FFF00")]
		public FsmVector3 fromPosition;

		[Token(Token = "0x4005570")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TitleAttribute", RVA = "0x5FFF38", Offset = "0x5FFF38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FFF38", Offset = "0x5FFF38")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5FFF38", Offset = "0x5FFF38")]
		public UiPositionOptions toOption;

		[Token(Token = "0x4005571")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FFFBC", Offset = "0x5FFFBC")]
		public FsmGameObject toTarget;

		[Token(Token = "0x4005572")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FFFF4", Offset = "0x5FFFF4")]
		public FsmVector3 toPosition;

		[NonSerialized]
		[Token(Token = "0x4005573")]
		[FieldOffset(Offset = "0xF8")]
		private RectTransform transform;

		[NonSerialized]
		[Token(Token = "0x4005574")]
		[FieldOffset(Offset = "0x100")]
		private Transform fromTransform;

		[NonSerialized]
		[Token(Token = "0x4005575")]
		[FieldOffset(Offset = "0x108")]
		private Transform toTransform;

		[Token(Token = "0x4005576")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60002C", Offset = "0x60002C")]
		private Vector3 _003CStartPosition_003Ek__BackingField;

		[Token(Token = "0x4005577")]
		[FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60003C", Offset = "0x60003C")]
		private Vector3 _003CEndPosition_003Ek__BackingField;

		[Token(Token = "0x17000C4F")]
		public Vector3 StartPosition
		{
			[Token(Token = "0x6006909")]
			[Address(RVA = "0x1574144", Offset = "0x1574144", VA = "0x1574144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C240", Offset = "0x62C240")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600690A")]
			[Address(RVA = "0x1574154", Offset = "0x1574154", VA = "0x1574154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C250", Offset = "0x62C250")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C50")]
		public Vector3 EndPosition
		{
			[Token(Token = "0x600690B")]
			[Address(RVA = "0x1574164", Offset = "0x1574164", VA = "0x1574164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C260", Offset = "0x62C260")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600690C")]
			[Address(RVA = "0x1574174", Offset = "0x1574174", VA = "0x1574174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C270", Offset = "0x62C270")]
			private set
			{
			}
		}

		[Token(Token = "0x600690D")]
		[Address(RVA = "0x1574184", Offset = "0x1574184", VA = "0x1574184", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600690E")]
		[Address(RVA = "0x15741E8", Offset = "0x15741E8", VA = "0x15741E8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600690F")]
		[Address(RVA = "0x157437C", Offset = "0x157437C", VA = "0x157437C")]
		private void InitStartPosition()
		{
		}

		[Token(Token = "0x6006910")]
		[Address(RVA = "0x15743DC", Offset = "0x15743DC", VA = "0x15743DC")]
		private void InitEndPosition()
		{
		}

		[Token(Token = "0x6006911")]
		[Address(RVA = "0x1574440", Offset = "0x1574440", VA = "0x1574440", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x6006912")]
		[Address(RVA = "0x15744D8", Offset = "0x15744D8", VA = "0x15744D8")]
		public TweenUiPosition()
		{
		}
	}
}
