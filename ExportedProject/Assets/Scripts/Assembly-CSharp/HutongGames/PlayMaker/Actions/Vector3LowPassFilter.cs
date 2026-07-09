using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200127A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACF44", Offset = "0x5ACF44")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACF44", Offset = "0x5ACF44")]
	public class Vector3LowPassFilter : FsmStateAction
	{
		[Token(Token = "0x4005868")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B83C", Offset = "0x60B83C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B83C", Offset = "0x60B83C")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005869")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B89C", Offset = "0x60B89C")]
		public FsmFloat filteringFactor;

		[Token(Token = "0x400586A")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 filteredVector;

		[Token(Token = "0x6006BEE")]
		[Address(RVA = "0x13C862C", Offset = "0x13C862C", VA = "0x13C862C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BEF")]
		[Address(RVA = "0x13C8660", Offset = "0x13C8660", VA = "0x13C8660", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BF0")]
		[Address(RVA = "0x13C86C8", Offset = "0x13C86C8", VA = "0x13C86C8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BF1")]
		[Address(RVA = "0x13C8800", Offset = "0x13C8800", VA = "0x13C8800")]
		public Vector3LowPassFilter()
		{
		}
	}
}
