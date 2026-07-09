using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E65")]
	public class Node : IEnumerable<Node>, IEnumerable
	{
		[Token(Token = "0x40043EA")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, Node> _childs;

		[Token(Token = "0x40043EB")]
		[FieldOffset(Offset = "0x18")]
		private NodeAttribute _attribute;

		[Token(Token = "0x40043EC")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFCD4", Offset = "0x5BFCD4")]
		private Node _003CParent_003Ek__BackingField;

		[Token(Token = "0x40043ED")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFCE4", Offset = "0x5BFCE4")]
		private IMeasurable _003CMeasure_003Ek__BackingField;

		[Token(Token = "0x17000BEB")]
		public Node Parent
		{
			[Token(Token = "0x600589D")]
			[Address(RVA = "0xC5D42C", Offset = "0xC5D42C", VA = "0xC5D42C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BB28", Offset = "0x62BB28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600589E")]
			[Address(RVA = "0xC5D434", Offset = "0xC5D434", VA = "0xC5D434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BB38", Offset = "0x62BB38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000BEC")]
		public IMeasurable Measure
		{
			[Token(Token = "0x600589F")]
			[Address(RVA = "0xC5D43C", Offset = "0xC5D43C", VA = "0xC5D43C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BB48", Offset = "0x62BB48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0xC5D444", Offset = "0xC5D444", VA = "0xC5D444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BB58", Offset = "0x62BB58")]
			set
			{
			}
		}

		[Token(Token = "0x17000BED")]
		public string Value
		{
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0xC5D44C", Offset = "0xC5D44C", VA = "0xC5D44C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BEE")]
		public string Id
		{
			[Token(Token = "0x60058A2")]
			[Address(RVA = "0xC5D454", Offset = "0xC5D454", VA = "0xC5D454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BEF")]
		public Schema Schema
		{
			[Token(Token = "0x60058A3")]
			[Address(RVA = "0xC5D45C", Offset = "0xC5D45C", VA = "0xC5D45C")]
			get
			{
				return default(Schema);
			}
		}

		[Token(Token = "0x17000BF0")]
		public int GameCreationTimeInSeconds
		{
			[Token(Token = "0x60058A4")]
			[Address(RVA = "0xC5D464", Offset = "0xC5D464", VA = "0xC5D464")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60058A5")]
			[Address(RVA = "0xC5D46C", Offset = "0xC5D46C", VA = "0xC5D46C")]
			set
			{
			}
		}

		[Token(Token = "0x17000BF1")]
		public bool isLeaf
		{
			[Token(Token = "0x60058A6")]
			[Address(RVA = "0xC5D474", Offset = "0xC5D474", VA = "0xC5D474")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BF2")]
		public int Count
		{
			[Token(Token = "0x60058AC")]
			[Address(RVA = "0xC5D750", Offset = "0xC5D750", VA = "0xC5D750")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60058A7")]
		[Address(RVA = "0xC5D484", Offset = "0xC5D484", VA = "0xC5D484")]
		public Node(NodeAttribute l_attribute)
		{
		}

		[Token(Token = "0x60058A8")]
		[Address(RVA = "0xC5D51C", Offset = "0xC5D51C", VA = "0xC5D51C")]
		public Node GetChild(NodeAttribute l_key)
		{
			return null;
		}

		[Token(Token = "0x60058A9")]
		[Address(RVA = "0xC5D5B8", Offset = "0xC5D5B8", VA = "0xC5D5B8")]
		public Node Add(Node l_item)
		{
			return null;
		}

		[Token(Token = "0x60058AA")]
		[Address(RVA = "0xC5D694", Offset = "0xC5D694", VA = "0xC5D694")]
		public void AddMeasure(IMeasurable l_measure)
		{
		}

		[Token(Token = "0x60058AB")]
		[Address(RVA = "0xC5D69C", Offset = "0xC5D69C", VA = "0xC5D69C", Slot = "4")]
		public IEnumerator<Node> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60058AD")]
		[Address(RVA = "0xC5D7A4", Offset = "0xC5D7A4", VA = "0xC5D7A4")]
		public static Node BuildTree(string l_tree)
		{
			return null;
		}

		[Token(Token = "0x60058AE")]
		[Address(RVA = "0xC5DAE8", Offset = "0xC5DAE8", VA = "0xC5DAE8")]
		public static string BuildString(Node l_tree)
		{
			return null;
		}

		[Token(Token = "0x60058AF")]
		[Address(RVA = "0xC5DF34", Offset = "0xC5DF34", VA = "0xC5DF34")]
		public static void ActionAllNodes(Node l_node, Action<Node> l_func)
		{
		}

		[Token(Token = "0x60058B0")]
		[Address(RVA = "0xC5E1A0", Offset = "0xC5E1A0", VA = "0xC5E1A0")]
		public static void ActionParents(Node l_node, Action<Node> l_func)
		{
		}

		[Token(Token = "0x60058B1")]
		[Address(RVA = "0xC5E248", Offset = "0xC5E248", VA = "0xC5E248", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60058B2")]
		[Address(RVA = "0xC5DB8C", Offset = "0xC5DB8C", VA = "0xC5DB8C")]
		private static void BuildString(StringBuilder l_sb, Node l_node, int l_depth)
		{
		}

		[Token(Token = "0x60058B3")]
		[Address(RVA = "0xC5E1C0", Offset = "0xC5E1C0", VA = "0xC5E1C0")]
		private static void ActionParentNodes(Node l_node, Action<Node> l_func)
		{
		}
	}
}
