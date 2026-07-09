using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x2000A1A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5977B4", Offset = "0x5977B4")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000A1B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5977EC", Offset = "0x5977EC")]
		private sealed class _003Cget_Childs_003Ed__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003533")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003534")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4003535")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4003536")]
			[FieldOffset(Offset = "0x28")]
			public JSONArray _003C_003E4__this;

			[Token(Token = "0x4003537")]
			[FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000830")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x600402F")]
				[Address(RVA = "0xB298F8", Offset = "0xB298F8", VA = "0xB298F8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000831")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004031")]
				[Address(RVA = "0xB29940", Offset = "0xB29940", VA = "0xB29940", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600402B")]
			[Address(RVA = "0xB296DC", Offset = "0xB296DC", VA = "0xB296DC")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600402C")]
			[Address(RVA = "0xB29714", Offset = "0xB29714", VA = "0xB29714", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600402D")]
			[Address(RVA = "0xB29784", Offset = "0xB29784", VA = "0xB29784", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600402E")]
			[Address(RVA = "0xB29730", Offset = "0xB29730", VA = "0xB29730")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6004030")]
			[Address(RVA = "0xB29900", Offset = "0xB29900", VA = "0xB29900", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004032")]
			[Address(RVA = "0xB29948", Offset = "0xB29948", VA = "0xB29948", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6004033")]
			[Address(RVA = "0xB299F0", Offset = "0xB299F0", VA = "0xB299F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000A1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5977FC", Offset = "0x5977FC")]
		private sealed class _003CGetEnumerator_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003538")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003539")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400353A")]
			[FieldOffset(Offset = "0x20")]
			public JSONArray _003C_003E4__this;

			[Token(Token = "0x400353B")]
			[FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000832")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004038")]
				[Address(RVA = "0xB2968C", Offset = "0xB2968C", VA = "0xB2968C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000833")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600403A")]
				[Address(RVA = "0xB296D4", Offset = "0xB296D4", VA = "0xB296D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004034")]
			[Address(RVA = "0xB2947C", Offset = "0xB2947C", VA = "0xB2947C")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004035")]
			[Address(RVA = "0xB294A8", Offset = "0xB294A8", VA = "0xB294A8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004036")]
			[Address(RVA = "0xB29518", Offset = "0xB29518", VA = "0xB29518", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004037")]
			[Address(RVA = "0xB294C4", Offset = "0xB294C4", VA = "0xB294C4")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6004039")]
			[Address(RVA = "0xB29694", Offset = "0xB29694", VA = "0xB29694", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBCF4", Offset = "0x5BBCF4")]
		private object _003CValue_003Ek__BackingField;

		[Token(Token = "0x1700082B")]
		public override JSONNode Item
		{
			[Token(Token = "0x600401B")]
			[Address(RVA = "0x10CAB10", Offset = "0x10CAB10", VA = "0x10CAB10", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600401C")]
			[Address(RVA = "0x10CABF8", Offset = "0x10CABF8", VA = "0x10CABF8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700082C")]
		public override JSONNode Item
		{
			[Token(Token = "0x600401D")]
			[Address(RVA = "0x10CACB0", Offset = "0x10CACB0", VA = "0x10CACB0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600401E")]
			[Address(RVA = "0x10CAD10", Offset = "0x10CAD10", VA = "0x10CAD10", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700082D")]
		public override object Value
		{
			[Token(Token = "0x600401F")]
			[Address(RVA = "0x10CAD74", Offset = "0x10CAD74", VA = "0x10CAD74", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624F98", Offset = "0x624F98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004020")]
			[Address(RVA = "0x10CAD7C", Offset = "0x10CAD7C", VA = "0x10CAD7C", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624FA8", Offset = "0x624FA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700082E")]
		public override int Count
		{
			[Token(Token = "0x6004021")]
			[Address(RVA = "0x10CAD84", Offset = "0x10CAD84", VA = "0x10CAD84", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700082F")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6004025")]
			[Address(RVA = "0x10CAF60", Offset = "0x10CAF60", VA = "0x10CAF60", Slot = "17")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624FB8", Offset = "0x624FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004022")]
		[Address(RVA = "0x10CADD0", Offset = "0x10CADD0", VA = "0x10CADD0", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6004023")]
		[Address(RVA = "0x10CAE34", Offset = "0x10CAE34", VA = "0x10CAE34", Slot = "15")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6004024")]
		[Address(RVA = "0x10CAEF4", Offset = "0x10CAEF4", VA = "0x10CAEF4", Slot = "16")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6004026")]
		[Address(RVA = "0x10CAFCC", Offset = "0x10CAFCC", VA = "0x10CAFCC", Slot = "46")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x625018", Offset = "0x625018")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6004027")]
		[Address(RVA = "0x10CB038", Offset = "0x10CB038", VA = "0x10CB038", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004028")]
		[Address(RVA = "0x10CB264", Offset = "0x10CB264", VA = "0x10CB264", Slot = "18")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6004029")]
		[Address(RVA = "0x10CB55C", Offset = "0x10CB55C", VA = "0x10CB55C", Slot = "45")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600402A")]
		[Address(RVA = "0x10CB644", Offset = "0x10CB644", VA = "0x10CB644")]
		public JSONArray()
		{
		}
	}
}
