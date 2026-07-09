using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F8A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D83C", Offset = "0x59D83C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D83C", Offset = "0x59D83C")]
	public class ParticleSystemPlay : ComponentAction<ParticleSystem>
	{
		[Token(Token = "0x400496D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D293C", Offset = "0x5D293C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5D293C", Offset = "0x5D293C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400496E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D29D0", Offset = "0x5D29D0")]
		public FsmBool withChildren;

		[Token(Token = "0x400496F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2A08", Offset = "0x5D2A08")]
		public FsmBool cacheChildren;

		[Token(Token = "0x4004970")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2A40", Offset = "0x5D2A40")]
		public FsmBool stopOnExit;

		[Token(Token = "0x4004971")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2A78", Offset = "0x5D2A78")]
		public FsmBool destroyOnFinish;

		[Token(Token = "0x4004972")]
		[FieldOffset(Offset = "0x90")]
		private GameObject go;

		[Token(Token = "0x4004973")]
		[FieldOffset(Offset = "0x98")]
		private ParticleSystem[] childParticleSystems;

		[Token(Token = "0x6005E8D")]
		[Address(RVA = "0x8F59F0", Offset = "0x8F59F0", VA = "0x8F59F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E8E")]
		[Address(RVA = "0x8F5A00", Offset = "0x8F5A00", VA = "0x8F5A00", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6005E8F")]
		[Address(RVA = "0x8F5AC4", Offset = "0x8F5AC4", VA = "0x8F5AC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E90")]
		[Address(RVA = "0x8F5C90", Offset = "0x8F5C90", VA = "0x8F5C90", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005E91")]
		[Address(RVA = "0x8F5DE4", Offset = "0x8F5DE4", VA = "0x8F5DE4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E92")]
		[Address(RVA = "0x8F5B10", Offset = "0x8F5B10", VA = "0x8F5B10")]
		private void DoParticleSystemPlay()
		{
		}

		[Token(Token = "0x6005E93")]
		[Address(RVA = "0x8F5F70", Offset = "0x8F5F70", VA = "0x8F5F70")]
		public ParticleSystemPlay()
		{
		}
	}
}
