using System;
using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D4")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A9C14", Offset = "0x5A9C14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A9C14", Offset = "0x5A9C14")]
	public class TweenPosition : TweenComponentBase<Transform>
	{
		[Token(Token = "0x400553D")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF76C", Offset = "0x5FF76C")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5FF76C", Offset = "0x5FF76C")]
		[AttributeAttribute(Name = "TitleAttribute", RVA = "0x5FF76C", Offset = "0x5FF76C")]
		public PositionOptions fromOption;

		[Token(Token = "0x400553E")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF7F0", Offset = "0x5FF7F0")]
		public FsmGameObject fromTarget;

		[Token(Token = "0x400553F")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF828", Offset = "0x5FF828")]
		public FsmVector3 fromPosition;

		[Token(Token = "0x4005540")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF860", Offset = "0x5FF860")]
		[AttributeAttribute(Name = "TitleAttribute", RVA = "0x5FF860", Offset = "0x5FF860")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5FF860", Offset = "0x5FF860")]
		public PositionOptions toOption;

		[Token(Token = "0x4005541")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF8E4", Offset = "0x5FF8E4")]
		public FsmGameObject toTarget;

		[Token(Token = "0x4005542")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF91C", Offset = "0x5FF91C")]
		public FsmVector3 toPosition;

		[NonSerialized]
		[Token(Token = "0x4005543")]
		[FieldOffset(Offset = "0xF8")]
		private Transform transform;

		[NonSerialized]
		[Token(Token = "0x4005544")]
		[FieldOffset(Offset = "0x100")]
		private Transform fromTransform;

		[NonSerialized]
		[Token(Token = "0x4005545")]
		[FieldOffset(Offset = "0x108")]
		private Transform toTransform;

		[Token(Token = "0x4005546")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FF954", Offset = "0x5FF954")]
		private Vector3 _003CStartPosition_003Ek__BackingField;

		[Token(Token = "0x4005547")]
		[FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FF964", Offset = "0x5FF964")]
		private Vector3 _003CEndPosition_003Ek__BackingField;

		[Token(Token = "0x17000C49")]
		public Vector3 StartPosition
		{
			[Token(Token = "0x60068DB")]
			[Address(RVA = "0x1571D20", Offset = "0x1571D20", VA = "0x1571D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C180", Offset = "0x62C180")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60068DC")]
			[Address(RVA = "0x1571D30", Offset = "0x1571D30", VA = "0x1571D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C190", Offset = "0x62C190")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C4A")]
		public Vector3 EndPosition
		{
			[Token(Token = "0x60068DD")]
			[Address(RVA = "0x1571D40", Offset = "0x1571D40", VA = "0x1571D40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C1A0", Offset = "0x62C1A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60068DE")]
			[Address(RVA = "0x1571D50", Offset = "0x1571D50", VA = "0x1571D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C1B0", Offset = "0x62C1B0")]
			private set
			{
			}
		}

		[Token(Token = "0x60068DF")]
		[Address(RVA = "0x1571D60", Offset = "0x1571D60", VA = "0x1571D60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068E0")]
		[Address(RVA = "0x1571DC4", Offset = "0x1571DC4", VA = "0x1571DC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068E1")]
		[Address(RVA = "0x1571F58", Offset = "0x1571F58", VA = "0x1571F58")]
		private void InitStartPosition()
		{
		}

		[Token(Token = "0x60068E2")]
		[Address(RVA = "0x1571FB8", Offset = "0x1571FB8", VA = "0x1571FB8")]
		private void InitEndPosition()
		{
		}

		[Token(Token = "0x60068E3")]
		[Address(RVA = "0x157201C", Offset = "0x157201C", VA = "0x157201C", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068E4")]
		[Address(RVA = "0x15720B4", Offset = "0x15720B4", VA = "0x15720B4")]
		public TweenPosition()
		{
		}
	}
}
