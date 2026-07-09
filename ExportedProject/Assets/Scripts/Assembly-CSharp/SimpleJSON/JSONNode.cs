using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x2000A15")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x59773C", Offset = "0x59773C")]
	public abstract class JSONNode
	{
		[Token(Token = "0x2000A16")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597774", Offset = "0x597774")]
		private sealed class _003Cget_Childs_003Ed__18 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003524")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003525")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4003526")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x17000827")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6004006")]
				[Address(RVA = "0xB2A064", Offset = "0xB2A064", VA = "0xB2A064", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000828")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004008")]
				[Address(RVA = "0xB2A0AC", Offset = "0xB2A0AC", VA = "0xB2A0AC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004003")]
			[Address(RVA = "0xB2A010", Offset = "0xB2A010", VA = "0xB2A010")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004004")]
			[Address(RVA = "0xB2A048", Offset = "0xB2A048", VA = "0xB2A048", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004005")]
			[Address(RVA = "0xB2A04C", Offset = "0xB2A04C", VA = "0xB2A04C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004007")]
			[Address(RVA = "0xB2A06C", Offset = "0xB2A06C", VA = "0xB2A06C", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004009")]
			[Address(RVA = "0xB2A0B4", Offset = "0xB2A0B4", VA = "0xB2A0B4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600400A")]
			[Address(RVA = "0xB2A148", Offset = "0xB2A148", VA = "0xB2A148", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000A17")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597784", Offset = "0x597784")]
		private sealed class _003Cget_DeepChilds_003Ed__20 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003527")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003528")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x4003529")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400352A")]
			[FieldOffset(Offset = "0x28")]
			public JSONNode _003C_003E4__this;

			[Token(Token = "0x400352B")]
			[FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> _003C_003E7__wrap1;

			[Token(Token = "0x400352C")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> _003C_003E7__wrap2;

			[Token(Token = "0x17000829")]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSimpleJSON_002EJSONNode_003E_002ECurrent
			{
				[Token(Token = "0x6004010")]
				[Address(RVA = "0xB2A7C4", Offset = "0xB2A7C4", VA = "0xB2A7C4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700082A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004012")]
				[Address(RVA = "0xB2A80C", Offset = "0xB2A80C", VA = "0xB2A80C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600400B")]
			[Address(RVA = "0xB2A14C", Offset = "0xB2A14C", VA = "0xB2A14C")]
			[DebuggerHidden]
			public _003Cget_DeepChilds_003Ed__20(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600400C")]
			[Address(RVA = "0xB2A184", Offset = "0xB2A184", VA = "0xB2A184", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600400D")]
			[Address(RVA = "0xB2A38C", Offset = "0xB2A38C", VA = "0xB2A38C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600400E")]
			[Address(RVA = "0xB2A2D0", Offset = "0xB2A2D0", VA = "0xB2A2D0")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600400F")]
			[Address(RVA = "0xB2A214", Offset = "0xB2A214", VA = "0xB2A214")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6004011")]
			[Address(RVA = "0xB2A7CC", Offset = "0xB2A7CC", VA = "0xB2A7CC", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004013")]
			[Address(RVA = "0xB2A814", Offset = "0xB2A814", VA = "0xB2A814", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6004014")]
			[Address(RVA = "0xB2A8BC", Offset = "0xB2A8BC", VA = "0xB2A8BC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000A18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597794", Offset = "0x597794")]
		private sealed class _003C_003Ec__24<T> where T : new()
		{
			[Token(Token = "0x400352D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__24<T> _003C_003E9;

			[Token(Token = "0x400352E")]
			[FieldOffset(Offset = "0x0")]
			public static Func<MemberInfo, bool> _003C_003E9__24_0;

			[Token(Token = "0x6004016")]
			public _003C_003Ec__24()
			{
			}

			[Token(Token = "0x6004017")]
			internal bool _003CSerialize_003Eb__24_0(MemberInfo prop)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000A19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5977A4", Offset = "0x5977A4")]
		private sealed class _003C_003Ec__25<T> where T : new()
		{
			[Token(Token = "0x400352F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__25<T> _003C_003E9;

			[Token(Token = "0x4003530")]
			[FieldOffset(Offset = "0x0")]
			public static Func<MemberInfo, bool> _003C_003E9__25_0;

			[Token(Token = "0x6004019")]
			public _003C_003Ec__25()
			{
			}

			[Token(Token = "0x600401A")]
			internal bool _003CDeserialize_003Eb__25_0(MemberInfo prop)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003523")]
		private const BindingFlags SERIALIZATION_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		[Token(Token = "0x1700080F")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6003FBA")]
			[Address(RVA = "0x10CF83C", Offset = "0x10CF83C", VA = "0x10CF83C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FBB")]
			[Address(RVA = "0x10CF844", Offset = "0x10CF844", VA = "0x10CF844", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000810")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6003FBC")]
			[Address(RVA = "0x10CF848", Offset = "0x10CF848", VA = "0x10CF848", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FBD")]
			[Address(RVA = "0x10CF850", Offset = "0x10CF850", VA = "0x10CF850", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000811")]
		public virtual object Value
		{
			[Token(Token = "0x6003FBE")]
			[Address(RVA = "0x10CF854", Offset = "0x10CF854", VA = "0x10CF854", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FBF")]
			[Address(RVA = "0x10CF898", Offset = "0x10CF898", VA = "0x10CF898", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000812")]
		public virtual int Count
		{
			[Token(Token = "0x6003FC0")]
			[Address(RVA = "0x10CF89C", Offset = "0x10CF89C", VA = "0x10CF89C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000813")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6003FC6")]
			[Address(RVA = "0x10CF928", Offset = "0x10CF928", VA = "0x10CF928", Slot = "17")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624DF8", Offset = "0x624DF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000814")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6003FC7")]
			[Address(RVA = "0x10CF984", Offset = "0x10CF984", VA = "0x10CF984")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624E58", Offset = "0x624E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000815")]
		public virtual bool IsLong
		{
			[Token(Token = "0x6003FCD")]
			[Address(RVA = "0x10CFA78", Offset = "0x10CFA78", VA = "0x10CFA78", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000816")]
		public virtual bool IsInt
		{
			[Token(Token = "0x6003FCE")]
			[Address(RVA = "0x10CFAC4", Offset = "0x10CFAC4", VA = "0x10CFAC4", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000817")]
		public virtual bool IsFloat
		{
			[Token(Token = "0x6003FCF")]
			[Address(RVA = "0x10CFB10", Offset = "0x10CFB10", VA = "0x10CFB10", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000818")]
		public virtual bool IsDouble
		{
			[Token(Token = "0x6003FD0")]
			[Address(RVA = "0x10CFBB4", Offset = "0x10CFBB4", VA = "0x10CFBB4", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000819")]
		public virtual bool IsBool
		{
			[Token(Token = "0x6003FD1")]
			[Address(RVA = "0x10CFC5C", Offset = "0x10CFC5C", VA = "0x10CFC5C", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700081A")]
		public virtual bool IsString
		{
			[Token(Token = "0x6003FD2")]
			[Address(RVA = "0x10CFD04", Offset = "0x10CFD04", VA = "0x10CFD04", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700081B")]
		public virtual bool IsArray
		{
			[Token(Token = "0x6003FD3")]
			[Address(RVA = "0x10CFD44", Offset = "0x10CFD44", VA = "0x10CFD44", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700081C")]
		public virtual long AsLong
		{
			[Token(Token = "0x6003FD4")]
			[Address(RVA = "0x10CFDC0", Offset = "0x10CFDC0", VA = "0x10CFDC0", Slot = "26")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6003FD5")]
			[Address(RVA = "0x10CFE14", Offset = "0x10CFE14", VA = "0x10CFE14", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x1700081D")]
		public virtual int AsInt
		{
			[Token(Token = "0x6003FD6")]
			[Address(RVA = "0x10CFE88", Offset = "0x10CFE88", VA = "0x10CFE88", Slot = "28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003FD7")]
			[Address(RVA = "0x10CFEDC", Offset = "0x10CFEDC", VA = "0x10CFEDC", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700081E")]
		public virtual ulong AsULong
		{
			[Token(Token = "0x6003FD8")]
			[Address(RVA = "0x10CFF50", Offset = "0x10CFF50", VA = "0x10CFF50", Slot = "30")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6003FD9")]
			[Address(RVA = "0x10CFFA4", Offset = "0x10CFFA4", VA = "0x10CFFA4", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x1700081F")]
		public virtual uint AsUInt
		{
			[Token(Token = "0x6003FDA")]
			[Address(RVA = "0x10D0018", Offset = "0x10D0018", VA = "0x10D0018", Slot = "32")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6003FDB")]
			[Address(RVA = "0x10D006C", Offset = "0x10D006C", VA = "0x10D006C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000820")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6003FDC")]
			[Address(RVA = "0x10D00E0", Offset = "0x10D00E0", VA = "0x10D00E0", Slot = "34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6003FDD")]
			[Address(RVA = "0x10D0138", Offset = "0x10D0138", VA = "0x10D0138", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x17000821")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6003FDE")]
			[Address(RVA = "0x10D01AC", Offset = "0x10D01AC", VA = "0x10D01AC", Slot = "36")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6003FDF")]
			[Address(RVA = "0x10D0260", Offset = "0x10D0260", VA = "0x10D0260", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x17000822")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6003FE0")]
			[Address(RVA = "0x10D02D4", Offset = "0x10D02D4", VA = "0x10D02D4", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003FE1")]
			[Address(RVA = "0x10D03BC", Offset = "0x10D03BC", VA = "0x10D03BC", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000823")]
		public virtual string AsString
		{
			[Token(Token = "0x6003FE2")]
			[Address(RVA = "0x10D0430", Offset = "0x10D0430", VA = "0x10D0430", Slot = "40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FE3")]
			[Address(RVA = "0x10D04C4", Offset = "0x10D04C4", VA = "0x10D04C4", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x17000824")]
		public virtual Dictionary<string, object> AsDictionary
		{
			[Token(Token = "0x6003FE4")]
			[Address(RVA = "0x10D04D0", Offset = "0x10D04D0", VA = "0x10D04D0", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000825")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6003FE5")]
			[Address(RVA = "0x10D05B4", Offset = "0x10D05B4", VA = "0x10D05B4", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000826")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6003FE6")]
			[Address(RVA = "0x10D0630", Offset = "0x10D0630", VA = "0x10D0630", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x10CF838", Offset = "0x10CF838", VA = "0x10CF838", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x10CF8A4", Offset = "0x10CF8A4", VA = "0x10CF8A4", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x10CF908", Offset = "0x10CF908", VA = "0x10CF908", Slot = "13")]
		public virtual string KeyAt(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x10CF910", Offset = "0x10CF910", VA = "0x10CF910", Slot = "14")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x10CF918", Offset = "0x10CF918", VA = "0x10CF918", Slot = "15")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x10CF920", Offset = "0x10CF920", VA = "0x10CF920", Slot = "16")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x10CF9F0", Offset = "0x10CF9F0", VA = "0x10CF9F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x10CFA34", Offset = "0x10CFA34", VA = "0x10CFA34", Slot = "18")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6003FCA")]
		public static JSONNode Serialize<T>(T obj) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6003FCB")]
		public static T Deserialize<T>(JSONNode node) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6003FCC")]
		private static void SetMemberValue<T, K>(K info, T result, string name, JSONNode attribute)
		{
		}

		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x10CEA0C", Offset = "0x10CEA0C", VA = "0x10CEA0C")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x10C28A4", Offset = "0x10C28A4", VA = "0x10C28A4")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x10D06AC", Offset = "0x10D06AC", VA = "0x10D06AC")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x10D0714", Offset = "0x10D0714", VA = "0x10D0714")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x10D077C", Offset = "0x10D077C", VA = "0x10D077C")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x10D07E4", Offset = "0x10D07E4", VA = "0x10D07E4")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x10D084C", Offset = "0x10D084C", VA = "0x10D084C")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x10CEC40", Offset = "0x10CEC40", VA = "0x10CEC40")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x10C2548", Offset = "0x10C2548", VA = "0x10C2548")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6003FF0")]
		[Address(RVA = "0x10D08B4", Offset = "0x10D08B4", VA = "0x10D08B4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x10CF070", Offset = "0x10CF070", VA = "0x10CF070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0x10CD104", Offset = "0x10CD104", VA = "0x10CD104")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6003FF3")]
		[Address(RVA = "0x10CA4D8", Offset = "0x10CA4D8", VA = "0x10CA4D8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x10D08C0", Offset = "0x10D08C0", VA = "0x10D08C0", Slot = "45")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x10D08C4", Offset = "0x10D08C4", VA = "0x10D08C4")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x10D0940", Offset = "0x10D0940", VA = "0x10D0940")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0x10D0994", Offset = "0x10D0994", VA = "0x10D0994")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x10D09E8", Offset = "0x10D09E8", VA = "0x10D09E8")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x10D0A3C", Offset = "0x10D0A3C", VA = "0x10D0A3C")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x10D0BB8", Offset = "0x10D0BB8", VA = "0x10D0BB8")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x10D0D90", Offset = "0x10D0D90", VA = "0x10D0D90")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x10D1154", Offset = "0x10D1154", VA = "0x10D1154")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x10D11A8", Offset = "0x10D11A8", VA = "0x10D11A8")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x10D11FC", Offset = "0x10D11FC", VA = "0x10D11FC")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x10D1250", Offset = "0x10D1250", VA = "0x10D1250")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6004000")]
		[Address(RVA = "0x10D13B0", Offset = "0x10D13B0", VA = "0x10D13B0")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6004001")]
		[Address(RVA = "0x10D1424", Offset = "0x10D1424", VA = "0x10D1424")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6004002")]
		[Address(RVA = "0x10CB6BC", Offset = "0x10CB6BC", VA = "0x10CB6BC")]
		protected JSONNode()
		{
		}
	}
}
