using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F89")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D7EC", Offset = "0x59D7EC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D7EC", Offset = "0x59D7EC")]
	public class Flicker : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004966")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D27D8", Offset = "0x5D27D8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004967")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D2824", Offset = "0x5D2824")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2824", Offset = "0x5D2824")]
		public FsmFloat frequency;

		[Token(Token = "0x4004968")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D2878", Offset = "0x5D2878")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2878", Offset = "0x5D2878")]
		public FsmFloat amountOn;

		[Token(Token = "0x4004969")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D28CC", Offset = "0x5D28CC")]
		public bool rendererOnly;

		[Token(Token = "0x400496A")]
		[FieldOffset(Offset = "0x81")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2904", Offset = "0x5D2904")]
		public bool realTime;

		[Token(Token = "0x400496B")]
		[FieldOffset(Offset = "0x84")]
		private float startTime;

		[Token(Token = "0x400496C")]
		[FieldOffset(Offset = "0x88")]
		private float timer;

		[Token(Token = "0x6005E89")]
		[Address(RVA = "0x958730", Offset = "0x958730", VA = "0x958730", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0x95877C", Offset = "0x95877C", VA = "0x95877C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0x9587A8", Offset = "0x9587A8", VA = "0x9587A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E8C")]
		[Address(RVA = "0x95894C", Offset = "0x95894C", VA = "0x95894C")]
		public Flicker()
		{
		}
	}
}
