using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EC58", Offset = "0x59EC58")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EC58", Offset = "0x59EC58")]
	public class ActivateGameObject : FsmStateAction
	{
		[Token(Token = "0x4004A47")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5CAC", Offset = "0x5D5CAC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A48")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5CE4", Offset = "0x5D5CE4")]
		public FsmGameObject gameObject2;

		[Token(Token = "0x4004A49")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5D1C", Offset = "0x5D5D1C")]
		[RequiredField]
		public FsmBool activate;

		[Token(Token = "0x4004A4A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5D68", Offset = "0x5D5D68")]
		public FsmBool recursive;

		[Token(Token = "0x4004A4B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5DA0", Offset = "0x5D5DA0")]
		public bool resetOnExit;

		[Token(Token = "0x4004A4C")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5DD8", Offset = "0x5D5DD8")]
		public bool everyFrame;

		[Token(Token = "0x4004A4D")]
		[FieldOffset(Offset = "0x78")]
		public FsmGameObject[] gameObjectArray;

		[Token(Token = "0x4004A4E")]
		[FieldOffset(Offset = "0x80")]
		public FsmBool spawnSpecificIndexOnly;

		[Token(Token = "0x4004A4F")]
		[FieldOffset(Offset = "0x88")]
		public FsmInt specificIndex;

		[Token(Token = "0x4004A50")]
		[FieldOffset(Offset = "0x90")]
		public FsmBool spawnMultipleRandomObjects;

		[Token(Token = "0x4004A51")]
		[FieldOffset(Offset = "0x98")]
		public FsmInt numberOfMultipleObjectsToSpawn;

		[Token(Token = "0x4004A52")]
		[FieldOffset(Offset = "0xA0")]
		private List<GameObject> _activatedGameObject;

		[Token(Token = "0x6005F55")]
		[Address(RVA = "0xD58BC4", Offset = "0xD58BC4", VA = "0xD58BC4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F56")]
		[Address(RVA = "0xD58C08", Offset = "0xD58C08", VA = "0xD58C08", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F57")]
		[Address(RVA = "0xD59140", Offset = "0xD59140", VA = "0xD59140", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005F58")]
		[Address(RVA = "0xD59144", Offset = "0xD59144", VA = "0xD59144", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005F59")]
		[Address(RVA = "0xD58C44", Offset = "0xD58C44", VA = "0xD58C44")]
		private void DoActivateGameObject()
		{
		}

		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0xD5926C", Offset = "0xD5926C", VA = "0xD5926C")]
		private void ActiveGameObject(GameObject activatedGameObject)
		{
		}

		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0xD59354", Offset = "0xD59354", VA = "0xD59354")]
		public void SetActiveRecursively(GameObject go, bool state)
		{
		}

		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0xD59620", Offset = "0xD59620", VA = "0xD59620")]
		public ActivateGameObject()
		{
		}

		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0xD59698", Offset = "0xD59698", VA = "0xD59698")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C080", Offset = "0x62C080")]
		private void _003COnExit_003Eb__15_0(GameObject go)
		{
		}

		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0xD596DC", Offset = "0xD596DC", VA = "0xD596DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C090", Offset = "0x62C090")]
		private void _003COnExit_003Eb__15_1(GameObject go)
		{
		}
	}
}
