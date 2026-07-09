using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010DA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A443C", Offset = "0x5A443C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A443C", Offset = "0x5A443C")]
	public class RectOverlaps : FsmStateAction
	{
		[Token(Token = "0x4004F8F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC4AC", Offset = "0x5EC4AC")]
		public FsmRect rect1;

		[Token(Token = "0x4004F90")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC4F8", Offset = "0x5EC4F8")]
		[RequiredField]
		public FsmRect rect2;

		[Token(Token = "0x4004F91")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC544", Offset = "0x5EC544")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004F92")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC57C", Offset = "0x5EC57C")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004F93")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC5B4", Offset = "0x5EC5B4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC5B4", Offset = "0x5EC5B4")]
		public FsmBool storeResult;

		[Token(Token = "0x4004F94")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC604", Offset = "0x5EC604")]
		public bool everyFrame;

		[Token(Token = "0x600646C")]
		[Address(RVA = "0xB440F8", Offset = "0xB440F8", VA = "0xB440F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600646D")]
		[Address(RVA = "0xB44194", Offset = "0xB44194", VA = "0xB44194", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600646E")]
		[Address(RVA = "0xB4427C", Offset = "0xB4427C", VA = "0xB4427C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600646F")]
		[Address(RVA = "0xB441D0", Offset = "0xB441D0", VA = "0xB441D0")]
		private void DoRectOverlap()
		{
		}

		[Token(Token = "0x6006470")]
		[Address(RVA = "0xB44280", Offset = "0xB44280", VA = "0xB44280")]
		public static bool Intersect(Rect a, Rect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6006471")]
		[Address(RVA = "0xB44370", Offset = "0xB44370", VA = "0xB44370")]
		public static void FlipNegative(ref Rect r)
		{
		}

		[Token(Token = "0x6006472")]
		[Address(RVA = "0xB44444", Offset = "0xB44444", VA = "0xB44444")]
		public RectOverlaps()
		{
		}
	}
}
