using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001065")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1E80", Offset = "0x5A1E80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1E80", Offset = "0x5A1E80")]
	public class Vector2RandomValue : FsmStateAction
	{
		[Token(Token = "0x2001066")]
		public enum Option
		{
			[Token(Token = "0x4004CF8")]
			Circle = 0,
			[Token(Token = "0x4004CF9")]
			Rectangle = 1,
			[Token(Token = "0x4004CFA")]
			InArc = 2,
			[Token(Token = "0x4004CFB")]
			AtAngles = 3
		}

		[Token(Token = "0x4004CEE")]
		[FieldOffset(Offset = "0x0")]
		private static bool showPreview;

		[Token(Token = "0x4004CEF")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0DAC", Offset = "0x5E0DAC")]
		[Attribute(Name = "PreviewFieldAttribute", RVA = "0x5E0DAC", Offset = "0x5E0DAC")]
		public Option shape;

		[Token(Token = "0x4004CF0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0E0C", Offset = "0x5E0E0C")]
		public FsmFloat minLength;

		[Token(Token = "0x4004CF1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0E44", Offset = "0x5E0E44")]
		public FsmFloat maxLength;

		[Token(Token = "0x4004CF2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0E7C", Offset = "0x5E0E7C")]
		public FsmFloat floatParam1;

		[Token(Token = "0x4004CF3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0EB4", Offset = "0x5E0EB4")]
		public FsmFloat floatParam2;

		[Token(Token = "0x4004CF4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0EEC", Offset = "0x5E0EEC")]
		public FsmFloat yScale;

		[Token(Token = "0x4004CF5")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0F24", Offset = "0x5E0F24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0F24", Offset = "0x5E0F24")]
		public FsmVector2 storeResult;

		[Token(Token = "0x4004CF6")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 v2;

		[Token(Token = "0x60061FA")]
		[Address(RVA = "0x13C6E34", Offset = "0x13C6E34", VA = "0x13C6E34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061FB")]
		[Address(RVA = "0x13C6E94", Offset = "0x13C6E94", VA = "0x13C6E94", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061FC")]
		[Address(RVA = "0x13C6ED0", Offset = "0x13C6ED0", VA = "0x13C6ED0")]
		private void DoRandomVector2()
		{
		}

		[Token(Token = "0x60061FD")]
		[Address(RVA = "0x13C71E8", Offset = "0x13C71E8", VA = "0x13C71E8")]
		public Vector2RandomValue()
		{
		}
	}
}
