using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200109F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3060", Offset = "0x5A3060")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3060", Offset = "0x5A3060")]
	public class IsSleeping2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004E71")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E75B8", Offset = "0x5E75B8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E75B8", Offset = "0x5E75B8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E72")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E764C", Offset = "0x5E764C")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004E73")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7684", Offset = "0x5E7684")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004E74")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E76BC", Offset = "0x5E76BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E76BC", Offset = "0x5E76BC")]
		public FsmBool store;

		[Token(Token = "0x4004E75")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E770C", Offset = "0x5E770C")]
		public bool everyFrame;

		[Token(Token = "0x6006340")]
		[Address(RVA = "0x10BF0B4", Offset = "0x10BF0B4", VA = "0x10BF0B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006341")]
		[Address(RVA = "0x10BF0C8", Offset = "0x10BF0C8", VA = "0x10BF0C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006342")]
		[Address(RVA = "0x10BF1E0", Offset = "0x10BF1E0", VA = "0x10BF1E0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006343")]
		[Address(RVA = "0x10BF104", Offset = "0x10BF104", VA = "0x10BF104")]
		private void DoIsSleeping()
		{
		}

		[Token(Token = "0x6006344")]
		[Address(RVA = "0x10BF1E4", Offset = "0x10BF1E4", VA = "0x10BF1E4")]
		public IsSleeping2d()
		{
		}
	}
}
