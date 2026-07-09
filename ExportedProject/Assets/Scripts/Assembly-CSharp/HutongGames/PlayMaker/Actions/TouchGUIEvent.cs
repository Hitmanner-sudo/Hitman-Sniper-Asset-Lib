using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F85")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D678", Offset = "0x59D678")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D678", Offset = "0x59D678")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59D678", Offset = "0x59D678")]
	public class TouchGUIEvent : FsmStateAction
	{
		[Token(Token = "0x2000F86")]
		public enum OffsetOptions
		{
			[Token(Token = "0x400494F")]
			TopLeft = 0,
			[Token(Token = "0x4004950")]
			Center = 1,
			[Token(Token = "0x4004951")]
			TouchStart = 2
		}

		[Token(Token = "0x400493E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1E94", Offset = "0x5D1E94")]
		[RequiredField]
		[Attribute(Name = "ActionSection", RVA = "0x5D1E94", Offset = "0x5D1E94")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400493F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1F04", Offset = "0x5D1F04")]
		public FsmInt fingerId;

		[Token(Token = "0x4004940")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ActionSection", RVA = "0x5D1F3C", Offset = "0x5D1F3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1F3C", Offset = "0x5D1F3C")]
		public FsmEvent touchBegan;

		[Token(Token = "0x4004941")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1F9C", Offset = "0x5D1F9C")]
		public FsmEvent touchMoved;

		[Token(Token = "0x4004942")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1FD4", Offset = "0x5D1FD4")]
		public FsmEvent touchStationary;

		[Token(Token = "0x4004943")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D200C", Offset = "0x5D200C")]
		public FsmEvent touchEnded;

		[Token(Token = "0x4004944")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2044", Offset = "0x5D2044")]
		public FsmEvent touchCanceled;

		[Token(Token = "0x4004945")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D207C", Offset = "0x5D207C")]
		public FsmEvent notTouching;

		[Token(Token = "0x4004946")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D20B4", Offset = "0x5D20B4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D20B4", Offset = "0x5D20B4")]
		[Attribute(Name = "ActionSection", RVA = "0x5D20B4", Offset = "0x5D20B4")]
		public FsmInt storeFingerId;

		[Token(Token = "0x4004947")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2128", Offset = "0x5D2128")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2128", Offset = "0x5D2128")]
		public FsmVector3 storeHitPoint;

		[Token(Token = "0x4004948")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2178", Offset = "0x5D2178")]
		public FsmBool normalizeHitPoint;

		[Token(Token = "0x4004949")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D21B0", Offset = "0x5D21B0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D21B0", Offset = "0x5D21B0")]
		public FsmVector3 storeOffset;

		[Token(Token = "0x400494A")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2200", Offset = "0x5D2200")]
		public OffsetOptions relativeTo;

		[Token(Token = "0x400494B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2238", Offset = "0x5D2238")]
		public FsmBool normalizeOffset;

		[Token(Token = "0x400494C")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ActionSection", RVA = "0x5D2270", Offset = "0x5D2270")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2270", Offset = "0x5D2270")]
		public bool everyFrame;

		[Token(Token = "0x400494D")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 touchStartPos;

		[Token(Token = "0x6005E7E")]
		[Address(RVA = "0xAD6C98", Offset = "0xAD6C98", VA = "0xAD6C98", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E7F")]
		[Address(RVA = "0xAD6D44", Offset = "0xAD6D44", VA = "0xAD6D44", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E80")]
		[Address(RVA = "0xAD6D4C", Offset = "0xAD6D4C", VA = "0xAD6D4C")]
		public TouchGUIEvent()
		{
		}
	}
}
