using System;
using System.Reflection;
using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200112C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A5C80", Offset = "0x5A5C80")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A5C80", Offset = "0x5A5C80")]
	public class CallMethod : FsmStateAction
	{
		[Token(Token = "0x400517C")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ObjectTypeAttribute", RVA = "0x5F375C", Offset = "0x5F375C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F375C", Offset = "0x5F375C")]
		public FsmObject behaviour;

		[Token(Token = "0x400517D")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F37E0", Offset = "0x5F37E0")]
		public FsmString methodName;

		[Token(Token = "0x400517E")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F3818", Offset = "0x5F3818")]
		public FsmVar[] parameters;

		[Token(Token = "0x400517F")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F3850", Offset = "0x5F3850")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5F3850", Offset = "0x5F3850")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5F3850", Offset = "0x5F3850")]
		public FsmVar storeResult;

		[Token(Token = "0x4005180")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F38C4", Offset = "0x5F38C4")]
		public bool everyFrame;

		[Token(Token = "0x4005181")]
		[FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F38FC", Offset = "0x5F38FC")]
		public bool manualUI;

		[Token(Token = "0x4005182")]
		[FieldOffset(Offset = "0x78")]
		private FsmObject cachedBehaviour;

		[Token(Token = "0x4005183")]
		[FieldOffset(Offset = "0x80")]
		private FsmString cachedMethodName;

		[Token(Token = "0x4005184")]
		[FieldOffset(Offset = "0x88")]
		private Type cachedType;

		[Token(Token = "0x4005185")]
		[FieldOffset(Offset = "0x90")]
		private MethodInfo cachedMethodInfo;

		[Token(Token = "0x4005186")]
		[FieldOffset(Offset = "0x98")]
		private ParameterInfo[] cachedParameterInfo;

		[Token(Token = "0x4005187")]
		[FieldOffset(Offset = "0xA0")]
		private object[] parametersArray;

		[Token(Token = "0x4005188")]
		[FieldOffset(Offset = "0xA8")]
		private string errorString;

		[Token(Token = "0x60065CF")]
		[Address(RVA = "0xAEF974", Offset = "0xAEF974", VA = "0xAEF974", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065D0")]
		[Address(RVA = "0xAEF984", Offset = "0xAEF984", VA = "0xAEF984", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065D1")]
		[Address(RVA = "0xAEFD68", Offset = "0xAEFD68", VA = "0xAEFD68", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065D2")]
		[Address(RVA = "0xAEFA08", Offset = "0xAEFA08", VA = "0xAEFA08")]
		private void DoMethodCall()
		{
		}

		[Token(Token = "0x60065D3")]
		[Address(RVA = "0xAEFD6C", Offset = "0xAEFD6C", VA = "0xAEFD6C")]
		private bool NeedToUpdateCache()
		{
			return default(bool);
		}

		[Token(Token = "0x60065D4")]
		[Address(RVA = "0xAF0204", Offset = "0xAF0204", VA = "0xAF0204")]
		private void ClearCache()
		{
		}

		[Token(Token = "0x60065D5")]
		[Address(RVA = "0xAEFEB0", Offset = "0xAEFEB0", VA = "0xAEFEB0")]
		private bool DoCache()
		{
			return default(bool);
		}

		[Token(Token = "0x60065D6")]
		[Address(RVA = "0xAF0218", Offset = "0xAF0218", VA = "0xAF0218", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60065D7")]
		[Address(RVA = "0xAF07B8", Offset = "0xAF07B8", VA = "0xAF07B8")]
		public CallMethod()
		{
		}
	}
}
