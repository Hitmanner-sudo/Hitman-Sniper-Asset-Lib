using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001276")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACE04", Offset = "0x5ACE04")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACE04", Offset = "0x5ACE04")]
	public class Vector3HighPassFilter : FsmStateAction
	{
		[Token(Token = "0x4005855")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B3A4", Offset = "0x60B3A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B3A4", Offset = "0x60B3A4")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005856")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B404", Offset = "0x60B404")]
		public FsmFloat filteringFactor;

		[Token(Token = "0x4005857")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 filteredVector;

		[Token(Token = "0x6006BDD")]
		[Address(RVA = "0x13C7F20", Offset = "0x13C7F20", VA = "0x13C7F20", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BDE")]
		[Address(RVA = "0x13C7F54", Offset = "0x13C7F54", VA = "0x13C7F54", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BDF")]
		[Address(RVA = "0x13C7FBC", Offset = "0x13C7FBC", VA = "0x13C7FBC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BE0")]
		[Address(RVA = "0x13C8144", Offset = "0x13C8144", VA = "0x13C8144")]
		public Vector3HighPassFilter()
		{
		}
	}
}
