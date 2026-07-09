using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F83")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D5D8", Offset = "0x59D5D8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D5D8", Offset = "0x59D5D8")]
	public class SwipeGestureEvent : FsmStateAction
	{
		[Token(Token = "0x4004931")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1C84", Offset = "0x5D1C84")]
		public FsmFloat minSwipeDistance;

		[Token(Token = "0x4004932")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1CBC", Offset = "0x5D1CBC")]
		public FsmEvent swipeLeftEvent;

		[Token(Token = "0x4004933")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1CF4", Offset = "0x5D1CF4")]
		public FsmEvent swipeRightEvent;

		[Token(Token = "0x4004934")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1D2C", Offset = "0x5D1D2C")]
		public FsmEvent swipeUpEvent;

		[Token(Token = "0x4004935")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1D64", Offset = "0x5D1D64")]
		public FsmEvent swipeDownEvent;

		[Token(Token = "0x4004936")]
		[FieldOffset(Offset = "0x78")]
		private float screenDiagonalSize;

		[Token(Token = "0x4004937")]
		[FieldOffset(Offset = "0x7C")]
		private float minSwipeDistancePixels;

		[Token(Token = "0x4004938")]
		[FieldOffset(Offset = "0x80")]
		private bool touchStarted;

		[Token(Token = "0x4004939")]
		[FieldOffset(Offset = "0x84")]
		private Vector2 touchStartPos;

		[Token(Token = "0x6005E76")]
		[Address(RVA = "0xB49C18", Offset = "0xB49C18", VA = "0xB49C18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E77")]
		[Address(RVA = "0xB49C50", Offset = "0xB49C50", VA = "0xB49C50", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E78")]
		[Address(RVA = "0xB49CE4", Offset = "0xB49CE4", VA = "0xB49CE4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E79")]
		[Address(RVA = "0xB49DB8", Offset = "0xB49DB8", VA = "0xB49DB8")]
		private void TestForSwipeGesture(Vector2 touchPosition)
		{
		}

		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0xB49F34", Offset = "0xB49F34", VA = "0xB49F34")]
		public SwipeGestureEvent()
		{
		}
	}
}
