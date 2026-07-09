using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A42AC", Offset = "0x5A42AC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A42AC", Offset = "0x5A42AC")]
	public class QuaternionLowPassFilter : QuaternionBaseAction
	{
		[Token(Token = "0x4004F72")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EBC70", Offset = "0x5EBC70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBC70", Offset = "0x5EBC70")]
		public FsmQuaternion quaternionVariable;

		[Token(Token = "0x4004F73")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBCD0", Offset = "0x5EBCD0")]
		public FsmFloat filteringFactor;

		[Token(Token = "0x4004F74")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion filteredQuaternion;

		[Token(Token = "0x600644D")]
		[Address(RVA = "0xB3D704", Offset = "0xB3D704", VA = "0xB3D704", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600644E")]
		[Address(RVA = "0xB3D744", Offset = "0xB3D744", VA = "0xB3D744", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600644F")]
		[Address(RVA = "0xB3D7A8", Offset = "0xB3D7A8", VA = "0xB3D7A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006450")]
		[Address(RVA = "0xB3D93C", Offset = "0xB3D93C", VA = "0xB3D93C", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006451")]
		[Address(RVA = "0xB3D950", Offset = "0xB3D950", VA = "0xB3D950", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006452")]
		[Address(RVA = "0xB3D7B8", Offset = "0xB3D7B8", VA = "0xB3D7B8")]
		private void DoQuatLowPassFilter()
		{
		}

		[Token(Token = "0x6006453")]
		[Address(RVA = "0xB3D964", Offset = "0xB3D964", VA = "0xB3D964")]
		public QuaternionLowPassFilter()
		{
		}
	}
}
