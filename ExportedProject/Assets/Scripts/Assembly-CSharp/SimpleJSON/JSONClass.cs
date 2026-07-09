using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x2000A1D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x59780C", Offset = "0x59780C")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000A1E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597844", Offset = "0x597844")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x400353D")]
			[FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x600404D")]
			[Address(RVA = "0xB299F4", Offset = "0xB299F4", VA = "0xB299F4")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600404E")]
			[Address(RVA = "0xB299FC", Offset = "0xB299FC", VA = "0xB299FC")]
			internal bool _003CRemove_003Eb__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000A1F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597854", Offset = "0x597854")]
		private sealed class _003Cget_Childs_003Ed__15 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400353E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400353F")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4003540")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4003541")]
			[FieldOffset(Offset = "0x28")]
			public JSONClass _003C_003E4__this;

			[Token(Token = "0x4003542")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000838")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6004053")]
				[Address(RVA = "0xB29F14", Offset = "0xB29F14", VA = "0xB29F14", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000839")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004055")]
				[Address(RVA = "0xB29F5C", Offset = "0xB29F5C", VA = "0xB29F5C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600404F")]
			[Address(RVA = "0xB29CE4", Offset = "0xB29CE4", VA = "0xB29CE4")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__15(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004050")]
			[Address(RVA = "0xB29D1C", Offset = "0xB29D1C", VA = "0xB29D1C", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004051")]
			[Address(RVA = "0xB29D8C", Offset = "0xB29D8C", VA = "0xB29D8C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004052")]
			[Address(RVA = "0xB29D38", Offset = "0xB29D38", VA = "0xB29D38")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6004054")]
			[Address(RVA = "0xB29F1C", Offset = "0xB29F1C", VA = "0xB29F1C", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004056")]
			[Address(RVA = "0xB29F64", Offset = "0xB29F64", VA = "0xB29F64", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6004057")]
			[Address(RVA = "0xB2A00C", Offset = "0xB2A00C", VA = "0xB2A00C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000A20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597864", Offset = "0x597864")]
		private sealed class _003CGetEnumerator_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003543")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003544")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003545")]
			[FieldOffset(Offset = "0x20")]
			public JSONClass _003C_003E4__this;

			[Token(Token = "0x4003546")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x1700083A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600405C")]
				[Address(RVA = "0xB29C94", Offset = "0xB29C94", VA = "0xB29C94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700083B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600405E")]
				[Address(RVA = "0xB29CDC", Offset = "0xB29CDC", VA = "0xB29CDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004058")]
			[Address(RVA = "0xB29A50", Offset = "0xB29A50", VA = "0xB29A50")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__16(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004059")]
			[Address(RVA = "0xB29A7C", Offset = "0xB29A7C", VA = "0xB29A7C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600405A")]
			[Address(RVA = "0xB29AEC", Offset = "0xB29AEC", VA = "0xB29AEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600405B")]
			[Address(RVA = "0xB29A98", Offset = "0xB29A98", VA = "0xB29A98")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600405D")]
			[Address(RVA = "0xB29C9C", Offset = "0xB29C9C", VA = "0xB29C9C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400353C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000834")]
		public override JSONNode Item
		{
			[Token(Token = "0x600403B")]
			[Address(RVA = "0x10CB6C4", Offset = "0x10CB6C4", VA = "0x10CB6C4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600403C")]
			[Address(RVA = "0x10CB7CC", Offset = "0x10CB7CC", VA = "0x10CB7CC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000835")]
		public override JSONNode Item
		{
			[Token(Token = "0x600403D")]
			[Address(RVA = "0x10CB89C", Offset = "0x10CB89C", VA = "0x10CB89C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600403E")]
			[Address(RVA = "0x10CB948", Offset = "0x10CB948", VA = "0x10CB948", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000836")]
		public override int Count
		{
			[Token(Token = "0x6004040")]
			[Address(RVA = "0x10CBAD0", Offset = "0x10CBAD0", VA = "0x10CBAD0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000837")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6004045")]
			[Address(RVA = "0x10CBFF4", Offset = "0x10CBFF4", VA = "0x10CBFF4", Slot = "17")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x625138", Offset = "0x625138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600403F")]
		[Address(RVA = "0x10CBA28", Offset = "0x10CBA28", VA = "0x10CBA28", Slot = "13")]
		public override string KeyAt(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6004041")]
		[Address(RVA = "0x10CBB24", Offset = "0x10CBB24", VA = "0x10CBB24", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6004042")]
		[Address(RVA = "0x10CBC70", Offset = "0x10CBC70", VA = "0x10CBC70", Slot = "14")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6004043")]
		[Address(RVA = "0x10CBD40", Offset = "0x10CBD40", VA = "0x10CBD40", Slot = "15")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6004044")]
		[Address(RVA = "0x10CBE28", Offset = "0x10CBE28", VA = "0x10CBE28", Slot = "16")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6004046")]
		[Address(RVA = "0x10CC060", Offset = "0x10CC060", VA = "0x10CC060", Slot = "46")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x625198", Offset = "0x625198")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6004047")]
		[Address(RVA = "0x10C353C", Offset = "0x10C353C", VA = "0x10C353C")]
		public static JSONClass FromDictionary(object dictionnary)
		{
			return null;
		}

		[Token(Token = "0x6004048")]
		[Address(RVA = "0x10CC3CC", Offset = "0x10CC3CC", VA = "0x10CC3CC")]
		public Dictionary<string, object> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x6004049")]
		[Address(RVA = "0x10CCDFC", Offset = "0x10CCDFC", VA = "0x10CCDFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600404A")]
		[Address(RVA = "0x10CD350", Offset = "0x10CD350", VA = "0x10CD350", Slot = "18")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600404B")]
		[Address(RVA = "0x10CD724", Offset = "0x10CD724", VA = "0x10CD724", Slot = "45")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600404C")]
		[Address(RVA = "0x10CC0CC", Offset = "0x10CC0CC", VA = "0x10CC0CC")]
		public JSONClass()
		{
		}
	}
}
