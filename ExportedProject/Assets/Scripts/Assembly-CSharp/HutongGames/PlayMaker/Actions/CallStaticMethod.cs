using System;
using System.Reflection;
using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200112D")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A5CD0", Offset = "0x5A5CD0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A5CD0", Offset = "0x5A5CD0")]
	public class CallStaticMethod : FsmStateAction
	{
		[Token(Token = "0x4005189")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F3934", Offset = "0x5F3934")]
		public FsmString className;

		[Token(Token = "0x400518A")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F396C", Offset = "0x5F396C")]
		public FsmString methodName;

		[Token(Token = "0x400518B")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F39A4", Offset = "0x5F39A4")]
		public FsmVar[] parameters;

		[Token(Token = "0x400518C")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5F39DC", Offset = "0x5F39DC")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5F39DC", Offset = "0x5F39DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F39DC", Offset = "0x5F39DC")]
		public FsmVar storeResult;

		[Token(Token = "0x400518D")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F3A50", Offset = "0x5F3A50")]
		public bool everyFrame;

		[Token(Token = "0x400518E")]
		[FieldOffset(Offset = "0x78")]
		private Type cachedType;

		[Token(Token = "0x400518F")]
		[FieldOffset(Offset = "0x80")]
		private string cachedClassName;

		[Token(Token = "0x4005190")]
		[FieldOffset(Offset = "0x88")]
		private string cachedMethodName;

		[Token(Token = "0x4005191")]
		[FieldOffset(Offset = "0x90")]
		private MethodInfo cachedMethodInfo;

		[Token(Token = "0x4005192")]
		[FieldOffset(Offset = "0x98")]
		private ParameterInfo[] cachedParameterInfo;

		[Token(Token = "0x4005193")]
		[FieldOffset(Offset = "0xA0")]
		private object[] parametersArray;

		[Token(Token = "0x4005194")]
		[FieldOffset(Offset = "0xA8")]
		private string errorString;

		[Token(Token = "0x60065D8")]
		[Address(RVA = "0xAF07C0", Offset = "0xAF07C0", VA = "0xAF07C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065D9")]
		[Address(RVA = "0xAF0A64", Offset = "0xAF0A64", VA = "0xAF0A64", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065DA")]
		[Address(RVA = "0xAF0844", Offset = "0xAF0844", VA = "0xAF0844")]
		private void DoMethodCall()
		{
		}

		[Token(Token = "0x60065DB")]
		[Address(RVA = "0xAF0A68", Offset = "0xAF0A68", VA = "0xAF0A68")]
		private bool DoCache()
		{
			return default(bool);
		}

		[Token(Token = "0x60065DC")]
		[Address(RVA = "0xAF0E84", Offset = "0xAF0E84", VA = "0xAF0E84", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60065DD")]
		[Address(RVA = "0xAF1434", Offset = "0xAF1434", VA = "0xAF1434")]
		public CallStaticMethod()
		{
		}
	}
}
