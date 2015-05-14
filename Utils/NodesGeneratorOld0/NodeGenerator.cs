using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;

namespace NodeGenerator
{

	class text_consts
	{
		public class string_repl
		{
			public string_repl(string from,string to)
			{
				this.from=from;
				this.to=to;
			}

			public string from;
			public string to;
		}

        public static readonly string abstract_visitor_class_name = "AbstractVisitor";
        public static readonly string abstract_visitor_file_name = abstract_visitor_class_name + ".cs";

		public static readonly string space=" ";
		public static readonly string semicolon=";";
		public static readonly string namespace_keyword="namespace";
		public static readonly string open_figure="{";
		public static readonly string close_figure="}";
		public static readonly string class_keyword="class";
		public static readonly string underline="_";
		public static readonly string public_keyword="public";
		public static readonly string open_par="(";
		public static readonly string close_par=")";
		public static readonly string comma=",";
		public static readonly string assign="=";
		public static readonly string this_keyword="this";
		public static readonly string dot=".";
		public static readonly string create_word="create_";
		public static readonly string static_keyword="static";
		public static readonly string return_keyword="return";
		public static readonly string new_keyword="new";
		public static readonly string void_keyword="void";
		public static readonly string visitor_interface_name="IVisitor";
		public static readonly string visitor_name="visitor";
		public static readonly string virtual_keyword="virtual";
		public static readonly string visit_method_name="visit";
		public static readonly string tab="\t";
		public static readonly string tab2="\t\t";
		public static readonly string nr="\r\n";
		public static readonly string interface_keyword="interface";
		public static readonly string colon=":";
		public static readonly string override_keyword="override";
        //ssyy
        public static readonly string tab3 = "\t\t\t";

        public static readonly string using_system = "using System;";
        public static readonly string using_system_io = "using System.IO;";

        public static readonly string base_tree_node_name = "syntax_tree_node";

        public static readonly string source_context_name = "source_context";
        public static readonly string source_context_class_name = "SourceContext";
        public static readonly string file_position_class_name = "file_position";
        public static readonly string begin_position_name = "begin_position";
        public static readonly string end_position_name = "end_position";
        public static readonly string column_num_name = "column_num";
        public static readonly string line_num_name = "line_num";
        public static readonly string count_name = "Count";
        public static readonly string BinaryWriter_classname = "BinaryWriter";
        public static readonly string BinaryReader_classname = "BinaryReader";
        public static readonly string nodes_construct_method = "_construct_node";
        public static readonly string nodes_read_method = "_read_node";

        public static readonly string as_keyword = "as";
        public static readonly string switch_keyword_name = "switch";
        public static readonly string case_keyword_name = "case";
        public static readonly string break_keyword_name = "break";
        public static readonly string if_keyword_name = "if";
        public static readonly string else_keyword_name = "else";
        public static readonly string equal_keyword_name = "==";
        public static readonly string not_equal_keyword_name = "!=";
        public static readonly string null_keyword_name = "null";
        public static readonly string cpp_null_keyword_name = "NULL";
        public static readonly string for_keyword_name = "for";
        public static readonly string less_keyword_name = "<";
        public static readonly string greater_keyword_name = ">";
        public static readonly string increment_keyword_name = "++";
        public static readonly string open_qbracket = "[";
        public static readonly string close_qbracket = "]";

        public static readonly string i0_keyword_name = "0";
        public static readonly string i1_keyword_name = "1";
        public static readonly string im1_keyword_name = "-1";

        public static readonly string temp_beg = "ssyy_beg";
        public static readonly string temp_end = "ssyy_end";
        public static readonly string cycle_i_name = "ssyy_i";
        public static readonly string cycle_j_name = "ssyy_j";
        public static readonly string temp_count_name = "ssyy_count";
        public static readonly string temp_node_name = "ssyy_tmp";
        public static readonly string param_number_name = "node_class_number";
        public static readonly string writer_name = "bw";
        public static readonly string reader_name = "br";
        public static readonly string write_proc_name = "Write";
        public static readonly string add_proc_name = "Add";
        public static readonly string write_prefix = "write_";
        public static readonly string read_prefix = "read_";

        public static readonly string string_type_name = "string";
        public static readonly string int16_type_name = "Int16";
        public static readonly string int32_type_name = "Int32";
        public static readonly string int64_type_name = "Int64";
        public static readonly string uint64_type_name = "UInt64";
        public static readonly string bool_type_name = "bool";
        public static readonly string char_type_name = "char";
        public static readonly string uchar_type_name = "unsigned char";
        public static readonly string double_type_name = "double";
        public static readonly string byte_type_name = "byte";

        public static readonly string int16_type_name_cpp = "short";
        public static readonly string int32_type_name_cpp = "int";
        public static readonly string int64_type_name_cpp = "long";
        public static readonly string uint64_type_name_cpp = "unsigned long";

        public static readonly string read_byte_name = "ReadByte";
        public static readonly string read_int16_name = "ReadInt16";
        public static readonly string read_int32_name = "ReadInt32";
        public static readonly string read_int64_name = "ReadInt64";
        public static readonly string read_uint64_name = "ReadUInt64";
        public static readonly string read_string_name = "ReadString";
        public static readonly string read_bool_name = "ReadBoolean";
        public static readonly string read_double_name = "ReadDouble";
        public static readonly string read_char_name = "ReadChar";

        public static readonly string cstring_type_name = "char*";
        public static readonly string star = "*";
        public static readonly string arrow = "->";
        public static readonly string plus = "+";
        public static readonly string address = "&";
        public static readonly string colon2 = "::";

        public static readonly string length_property_name = "Length";
        public static readonly string CPP_reader_classname = "Reader";
        public static readonly string ostream_classname = "ostream";
        public static readonly string ostream_name = "*os";

        public static readonly string cpp_short_name = "short";
        public static readonly string GetChar_proc_name = "GetChar";
        public static readonly string GetByte_proc_name = "GetByte";
        public static readonly string GetShort_proc_name = "GetShort";
        public static readonly string GetInt_proc_name = "GetInt";
        public static readonly string GetString_proc_name = "GetString";
        public static readonly string vector_name = "vector";
        public static readonly string push_back_name = "push_back";
        public static readonly string type_cast_name = "static_cast";

        public static readonly string cross_platform_prefix = "CP";
        public static readonly string visualizator_name = "TreePainter";
        public static readonly string space_offset = "nspace";
        public static readonly string base_space_count = "2";
        public static readonly string inc_space = " += " + base_space_count;
        public static readonly string dec_space = " -= " + base_space_count;
        public static readonly string print_spaces_name = "PrintSpaces";
        public static readonly string stream_out = "<<";
        public static readonly string inverted_comma2 = "\"";
        public static readonly string print_node_proc = "print_node";
        public static readonly string endline_name = "endl";
        public static readonly string count_string = "\" Count=\"";
        public static readonly string size_proc_name = "size";

        public static readonly string delete_keyword = "delete";
        public static readonly string tilde = "~";
        public static readonly string vector_classname = "vector";
        public static readonly string iterator_name = "iterator";
        public static readonly string begin_seq = "begin";
        public static readonly string end_seq = "end";
        //\ssyy

		public static readonly string prop_template=
@"		///<summary>
		///help_context
		///</summary>
		public property_type property_name
		{
			get
			{
				return field_name;
			}
			set
			{
				field_name=value;
			}
		}
";

		public static readonly string field_template=
@"		protected field_type field_name;";

		
		public static readonly string field_with_new_template=
@"		protected field_type field_name=new field_type();";

		public static readonly string simple_constructor_template=
@"		public class_name()
		{

		}
";

		public static string change_word(string where,string from,string to)
		{
			Regex rg=new Regex(from);
			return rg.Replace(where,to);
		}

		public static string change_word(string where,string_repl sr)
		{
			return change_word(where,sr.from,sr.to);
		}

		public static string change_words(string where,params string_repl[] sr_arr)
		{
			foreach(string_repl sr in sr_arr)
			{
				where=change_word(where,sr);
			}
			return where;
		}

		public static string create_property(string property_type,string property_name,string field_name,string help_context)
		{
			return change_words(prop_template,new string_repl("property_type",property_type),
				new string_repl("property_name",property_name),new string_repl("field_name",field_name),
				new string_repl("help_context",help_context));
		}

		public static string create_field(string field_type,string field_name)
		{
			return change_words(field_template,new string_repl("field_type",field_type),
				new string_repl("field_name",field_name));
		}

		public static string create_field_with_new(string field_type,string field_name)
		{
			return change_words(field_with_new_template,new string_repl("field_type",field_type),
				new string_repl("field_name",field_name));
		}

		public static string create_simple_constructor(string class_name)
		{
			return change_words(simple_constructor_template,new string_repl("class_name",class_name));
		}

	}

	[Serializable]
	public class HelpContext
	{

		private string _help_context="";

		public string help_context
		{
			get
			{
				return _help_context;
			}
			set
			{
				_help_context=value;
			}
		}

	}

	[Serializable]
	public class HelpStorage
	{
		private Hashtable ht=new Hashtable();

		public void add_context(object ob,HelpContext hc)
		{
			ht.Add(ob,hc);
		}

		public HelpContext get_help_context(object key)
		{
			object o=ht[key];
			if (o==null)
			{
				HelpContext hc=new HelpContext();
				ht.Add(key,hc);
				return hc;
			}
			return (o as HelpContext);
		}

		public static HelpStorage deserialize(string file_name)
		{
			HelpStorage hc;
			BinaryFormatter formatter=new BinaryFormatter();
			FileStream fs;
			if (!File.Exists(file_name))
			{
				fs=File.Create(file_name);
				
				hc=new HelpStorage();

				formatter.Serialize(fs,hc);

				fs.Flush();
				fs.Close();

				return hc;
			}
			fs=File.Open(file_name,FileMode.Open);
			hc=(HelpStorage)formatter.Deserialize(fs);
			fs.Close();
			return hc;
		}

		public void serialize(string file_name)
		{
			FileStream fs=File.Create(file_name);
			BinaryFormatter formatter=new BinaryFormatter();
			formatter.Serialize(fs,this);
			fs.Flush();
			fs.Close();
		}

	}

	[Serializable]
	public class node_field_info
	{
		private string _field_name;
		private node_info _field_type;

		public string field_name
		{
			get
			{
				return _field_name;
			}
			set
			{
				_field_name=value;
			}
		}

		public node_info field_type
		{
			get
			{
				return _field_type;
			}
			set
			{
				_field_type=value;
			}
		}

		public override string ToString()
		{
			return (field_type.node_name+text_consts.space+field_name+text_consts.semicolon);
		}

		public string property_name
		{
			get
			{
				return field_name;
			}
		}

		public string field_code_name
		{
			get
			{
				return (text_consts.underline+field_name);
			}
		}

		public virtual string field_type_name
		{
			get
			{
				return field_type.node_name;
			}
		}

		public void generate_code_property(StreamWriter sw,node_info ni,HelpStorage hst)
		{
			string prop=text_consts.create_property(field_type_name,property_name,field_code_name,
				hst.get_help_context(ni.node_name+"."+field_name).help_context);
			//sw.WriteLine();
			sw.WriteLine(prop);
			//sw.WriteLine();
		}

		public void generate_field_code(StreamWriter sw)
		{
			//sw.WriteLine();
			extended_simple_element ese=this as extended_simple_element;
			bool created=false;
			if (ese!=null)
			{
				if (ese.create_var)
				{
					sw.WriteLine(text_consts.create_field_with_new(field_type_name,field_code_name));
					created=true;
				}
			}
			if (!created)
			{
				sw.WriteLine(text_consts.create_field(field_type_name,field_code_name));
			}
			//sw.WriteLine();
		}

        //ssyy
        public void generate_cpp_field_code(StreamWriter sw, List<string> destructor_code)
        {
            //sw.WriteLine();
            extended_simple_element ese = this as extended_simple_element;
            string f_name;
            if (ese != null)
            {
                if (field_type_name == text_consts.string_type_name)
                {
                    f_name = text_consts.cstring_type_name;
                }
                else
                {
                    if (field_type_name == text_consts.int32_type_name)
                    {
                        f_name = text_consts.int32_type_name_cpp;
                    }
                    else
                    {
                        if (field_type_name == text_consts.int16_type_name)
                        {
                            f_name = text_consts.int16_type_name_cpp;
                        }
                        else
                        {
                            if (field_type_name == text_consts.int64_type_name)
                            {
                                f_name = text_consts.int64_type_name_cpp;
                            }
                            else
                            {
                                if (field_type_name == text_consts.uint64_type_name)
                                {
                                    f_name = text_consts.uint64_type_name_cpp;
                                }
                                else
                                {
                                    if (field_type_name == text_consts.source_context_class_name)
                                    {
                                        f_name = text_consts.source_context_class_name + text_consts.star;
                                    }
                                    else
                                    {
                                        f_name = field_type_name.Replace("List", "vector");
                                        f_name = f_name.Replace(">", "*>*");
                                        if (f_name.Length > 7 && f_name.Substring(0, 7) == "vector<")
                                        {
                                            string type_name = f_name.Substring(0, f_name.Length - 1);
                                            //if (��� != NULL)
                                            //{
                                            //  for (vector<T*>::iterator ssyy_j = ���->begin(); ssyy_j != ���->end(); ssyy_j++)
                                            //  {
                                            //      delete *ssyy_j;
                                            //  }
                                            //  delete ���;
                                            //}
                                            destructor_code.Add(text_consts.tab2 + text_consts.if_keyword_name + text_consts.space +
                                                text_consts.open_par + property_name + text_consts.space +
                                                text_consts.not_equal_keyword_name + text_consts.space +
                                                text_consts.cpp_null_keyword_name + text_consts.close_par);
                                            destructor_code.Add(text_consts.tab2 + text_consts.open_figure);
                                            destructor_code.Add(text_consts.tab2 + text_consts.tab + text_consts.for_keyword_name +
                                                text_consts.space + text_consts.open_par + type_name + text_consts.colon2 +
                                                text_consts.iterator_name + text_consts.space + text_consts.cycle_j_name +
                                                text_consts.space + text_consts.assign + text_consts.space + property_name +
                                                text_consts.arrow + text_consts.begin_seq + text_consts.open_par +
                                                text_consts.close_par + text_consts.semicolon + text_consts.space +
                                                text_consts.cycle_j_name + text_consts.space + text_consts.not_equal_keyword_name +
                                                text_consts.space + property_name + text_consts.arrow + text_consts.end_seq +
                                                text_consts.open_par + text_consts.close_par + text_consts.semicolon +
                                                text_consts.space + text_consts.cycle_j_name + text_consts.increment_keyword_name +
                                                text_consts.close_par);
                                            destructor_code.Add(text_consts.tab2 + text_consts.tab + text_consts.open_figure);
                                            destructor_code.Add(text_consts.tab3 + text_consts.tab + text_consts.delete_keyword +
                                                text_consts.space + text_consts.star + text_consts.cycle_j_name +
                                                text_consts.semicolon);
                                            destructor_code.Add(text_consts.tab2 + text_consts.tab + text_consts.close_figure);
                                            destructor_code.Add(text_consts.tab2 + text_consts.tab + text_consts.delete_keyword +
                                                text_consts.space + property_name + text_consts.semicolon);
                                            destructor_code.Add(text_consts.tab2 + text_consts.close_figure);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (this is simple_element)
                {
                    f_name = field_type_name;
                }
                else
                {
                    f_name = field_type_name + '*';
                    destructor_code.Add(text_consts.tab3 + text_consts.delete_keyword +
                        text_consts.space + property_name + text_consts.semicolon);
                }
            }
            sw.WriteLine(text_consts.tab2 + f_name + text_consts.space + property_name + text_consts.semicolon);
            //sw.WriteLine();
        }
        //\ssyy

	}
    //miks 31.05.10
    [Serializable]
    public class method_info 
    {
        public string method_text { get; set; }
        public method_info(string text)
        {
            method_text = text;
        }
        public method_info()
        {
            method_text = "";
        }
        public string method_header
        {
            get
            {
                var p = method_text.IndexOf(Environment.NewLine);
                if (p == -1)
                    return method_text;
                else return method_text.Substring(0, p);
            }
        }

        public void generate_code(StreamWriter sw, node_info ni, HelpStorage hst)
        {
            string txt = "public "+method_text;
            var ss = txt.Split(new string[]{Environment.NewLine}, StringSplitOptions.None);
            txt = string.Join(Environment.NewLine + text_consts.tab + text_consts.tab, ss);
            sw.WriteLine(text_consts.tab + text_consts.tab + txt);
//            sw.WriteLine();
        }

        public override string ToString()
        {
            return method_header;
        }

    }

	[Serializable]
	public class simple_element:node_field_info
	{
		private string _field_type_name;

		public string val_field_type_name
		{
			get
			{
				return _field_type_name;
			}
			set
			{
				_field_type_name=value;
			}
		}

		public override string ToString()
		{
			return (this.field_type_name+text_consts.space+this.field_name);
		}

		public override string field_type_name
		{
			get
			{
				return val_field_type_name;
			}
		}

	}

	[Serializable]
	public class extended_simple_element:simple_element
	{
		private bool _delete_var=false;
		private bool _create_var=false;

		public bool delete_var
		{
			get
			{
				return _delete_var;
			}
			set
			{
				_delete_var=value;
			}
		}

		public bool create_var
		{
			get
			{
				return _create_var;
			}
			set
			{
				_create_var=value;
			}
		}
	}

	[Serializable]
	public class node_info: IComparable
	{
		private string _node_name;
        private ArrayList _subnodes = new ArrayList();
        public ArrayList _methods = new ArrayList();
        private node_info _base_class;

        public int CompareTo(object ni)
        {
            return _node_name.CompareTo(((node_info)ni)._node_name);
        }

        public method_info[] methods
        {
            get
            {
                return ((method_info[])_methods.ToArray(typeof(method_info)));;
            }
        }
        
        public node_field_info[] subnodes
		{
			get
			{
				return ((node_field_info[])_subnodes.ToArray(typeof(node_field_info)));
			}
		}

		public node_info base_class
		{
			get
			{
				return _base_class;
			}
			set
			{
				_base_class=value;
			}
		}

		public string node_name
		{
			get
			{
				return _node_name;
			}
			set
			{
				_node_name=value;
			}
		}

		public string creator_name
		{
			get
			{
				return text_consts.create_word+node_name;
			}
		}

		public void set_subnodes(ICollection new_subnodes)
		{
			_subnodes.Clear();
			_subnodes.AddRange(new_subnodes);
		}

        public void set_methods(ICollection new_methods)
        {
            //if (_methods == null)
            //    _methods = new ArrayList();

            _methods.Clear();
            _methods.AddRange(new_methods);
        }
        
        public void add_subnode(node_field_info nfi)
		{
			_subnodes.Add(nfi);
		}

        public void add_method(method_info nfi)
        {
            _methods.Add(nfi);
        }
        
        public override string ToString()
		{
			return node_name;
		}

		public void generate_simple_constructor_code(StreamWriter sw)
		{
			sw.WriteLine();
			sw.WriteLine(@"		///<summary>");
			sw.WriteLine(@"		///����������� ��� ����������.");
			sw.WriteLine(@"		///</summary>");
			sw.WriteLine(text_consts.create_simple_constructor(node_name));
			//sw.WriteLine();
		}

        private string subnode_variable(int i)
        {
            return (((node_field_info)_subnodes[i]).field_type_name + text_consts.space +
                    ((node_field_info)_subnodes[i]).field_code_name);
        }

        private string NodeToString(node_field_info subnode)
        {
            return subnode.field_type_name + text_consts.space + subnode.field_code_name;
        }

        public List<node_field_info> collect_subnodes(bool WithBaseClasses = false)
        {
            var ni = this;
            var l = new List<node_field_info>();
            var ll = new List<node_field_info>(ni.subnodes);
            l.InsertRange(0, ll);
            if (WithBaseClasses)
                while (ni.base_class != null)
                {
                    ni = ni.base_class;
                    if (ni.node_name.Equals("syntax_tree_node") || ni.node_name.Equals("declaration"))
                        break;
                    ll.Clear();
                    ll.AddRange(ni.subnodes);
                    if (ll.Count>0)
                        l.InsertRange(0, ll);
                } 
            return l;
        }

        public int CountNodesInBaseClasses()
        {
            int c = 0;
            var ni = this;
            while (ni.base_class != null)
            {
                ni = ni.base_class;
                if (ni.node_name.Equals("syntax_tree_node") || ni.node_name.Equals("declaration"))
                    break;
                c += ni.subnodes.Count();
            }
            return c;
        }

		public void generate_big_constructor_code(StreamWriter sw, bool WithSC, bool WithBaseClasses = false)
		{
			//sw.WriteLine();

            var nodes = collect_subnodes(WithBaseClasses);
            var s = string.Join(text_consts.comma, nodes.Select(n => NodeToString(n)));

            if (WithBaseClasses && CountNodesInBaseClasses() == 0)
                return;

            sw.WriteLine(@"		///<summary>");
            sw.WriteLine(@"		///����������� � �����������.");
            sw.WriteLine(@"		///</summary>");
            sw.Write(text_consts.tab + text_consts.tab + text_consts.public_keyword + text_consts.space + node_name +
                text_consts.open_par);

            sw.Write(s);
            /*for (int i = 0; i < _subnodes.Count - 1; i++)
			{
				sw.Write(subnode_variable(i)+text_consts.comma);
			}
			if (_subnodes.Count>0)
			{
				sw.Write(subnode_variable(_subnodes.Count-1));
			}*/
            if (WithSC)
            {
                if (_subnodes.Count>0 || CountNodesInBaseClasses()>0)
                    sw.Write(text_consts.comma);
                sw.Write("SourceContext sc");
            }

			sw.WriteLine(text_consts.close_par);
			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.open_figure);

			foreach(node_field_info nfi in nodes)
			{
				sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.tab+text_consts.this_keyword+
					text_consts.dot+nfi.field_code_name+text_consts.assign+
					nfi.field_code_name+text_consts.semicolon);
			}
            if (WithSC)
            {
                sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.tab+"source_context = sc;");
            }

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.close_figure);

			//sw.WriteLine();
		}

		public void generate_creator_method(StreamWriter sw)
		{
			//sw.WriteLine();

			sw.Write(text_consts.tab+text_consts.tab+text_consts.public_keyword+text_consts.space+
				text_consts.static_keyword+text_consts.space+
				node_name+text_consts.space+creator_name+text_consts.open_par);

			for(int i=0;i<_subnodes.Count-1;i++)
			{
				sw.Write(subnode_variable(i)+text_consts.comma);
			}
			if (_subnodes.Count>0)
			{
				sw.Write(subnode_variable(_subnodes.Count-1));
			}

			sw.WriteLine(text_consts.close_par);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.open_figure);

			sw.Write(text_consts.tab+text_consts.tab+text_consts.tab+text_consts.return_keyword+
				text_consts.space+text_consts.new_keyword+text_consts.space+
				node_name+text_consts.open_par);

			for(int i=0;i<_subnodes.Count-1;i++)
			{
				sw.Write(((node_field_info)_subnodes[i]).field_code_name+text_consts.comma);
			}
			if (_subnodes.Count>0)
			{
				sw.Write(((node_field_info)_subnodes[_subnodes.Count-1]).field_code_name);
			}

			sw.WriteLine(text_consts.close_par+text_consts.semicolon);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.close_figure);

			//sw.WriteLine();
		}

		public void generate_visitor_node(StreamWriter sw)
		{
			//sw.WriteLine();
			sw.WriteLine(@"		///<summary>");
			sw.WriteLine(@"		///����� ��� ������ ������ �����������");
			sw.WriteLine(@"		///</summary>");
			sw.WriteLine(@"		///<param name=""visitor"">������-����������.</param>");
			sw.WriteLine(@"		///<returns>Return value is void</returns>");
			string pol_type="";
			if (base_class!=null)
			{
				pol_type=text_consts.override_keyword;
			}
			else
			{
				pol_type=text_consts.virtual_keyword;
			}
			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.public_keyword+text_consts.space+
				pol_type+text_consts.space+
				text_consts.void_keyword+text_consts.space+text_consts.visit_method_name+text_consts.open_par+
				text_consts.visitor_interface_name+text_consts.space+text_consts.visitor_name+text_consts.close_par);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.open_figure);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.tab+text_consts.visitor_name+
				text_consts.dot+text_consts.visit_method_name+
				text_consts.open_par+text_consts.this_keyword+text_consts.close_par+text_consts.semicolon);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.close_figure);

			//sw.WriteLine();
		}

        public void generate_visitor_node_cpp(StreamWriter sw)
        {
            sw.WriteLine();
            sw.WriteLine(@"		///<summary>");
            sw.WriteLine(@"		///����� ��� ������ ������ �����������");
            sw.WriteLine(@"		///</summary>");
            sw.WriteLine(@"		///<param name=""visitor"">������-����������.</param>");
            sw.WriteLine(@"		///<returns>Return value is void</returns>");
            string pol_type = "";
            if (base_class == null)
            {
                pol_type = text_consts.virtual_keyword + text_consts.space;
            }
            sw.WriteLine(text_consts.tab + text_consts.tab + pol_type +
                text_consts.void_keyword + text_consts.space + text_consts.visit_method_name + text_consts.open_par +
                text_consts.abstract_visitor_class_name + text_consts.star + text_consts.space + text_consts.visitor_name + text_consts.close_par);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.open_figure);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.tab + text_consts.visitor_name +
                text_consts.arrow + text_consts.visit_method_name +
                text_consts.open_par + text_consts.this_keyword + text_consts.close_par + text_consts.semicolon);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.close_figure);

            sw.WriteLine();
        }

        public void genrate_summury_comment_for_interface_method(StreamWriter sw)
		{
			sw.WriteLine(@"		///<summary>");

			sw.WriteLine(@"		///Method to visit "+this.node_name+".");

			sw.WriteLine(@"		///</summary>");

			sw.WriteLine(@"		///<param name="""+text_consts.underline+node_name+@""">"+"Node to visit"+@"</param>");

			sw.WriteLine(@"		///<returns> Return value is void </returns>");
		}

		public void generate_visit_method_for_interface(StreamWriter sw)
		{
			//sw.WriteLine();

			genrate_summury_comment_for_interface_method(sw);
			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.void_keyword+text_consts.space+
				text_consts.visit_method_name+text_consts.open_par+
				node_name+text_consts.space+text_consts.underline+node_name+text_consts.close_par+text_consts.semicolon);

			//sw.WriteLine();
		}

        public void generate_visit_method_cpp(StreamWriter sw)
        {
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.virtual_keyword + text_consts.space + text_consts.void_keyword + text_consts.space +
                text_consts.visit_method_name + text_consts.open_par +
                node_name + text_consts.star + text_consts.space + node_name + text_consts.close_par +
                text_consts.open_figure + text_consts.close_figure);
        }

        public void generate_visit_method_for_abstract_visitor(StreamWriter sw)
        {
            sw.WriteLine();

            //genrate_summury_comment_for_interface_method(sw);
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.public_keyword + text_consts.space+ text_consts.virtual_keyword + text_consts.space + text_consts.void_keyword + text_consts.space +
                text_consts.visit_method_name + text_consts.open_par +
                node_name + text_consts.space + text_consts.underline + node_name + text_consts.close_par);
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.open_figure);
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.close_figure);

            //sw.WriteLine();
        }

        
        public void generate_visit_method(StreamWriter sw)
		{
			sw.WriteLine();

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.public_keyword+
				text_consts.space+text_consts.void_keyword+text_consts.space+text_consts.visit_method_name+
				text_consts.open_par+node_name+text_consts.space+text_consts.underline+node_name+text_consts.close_par);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.open_figure);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.tab);

			sw.WriteLine(text_consts.tab+text_consts.tab+text_consts.close_figure);

			sw.WriteLine();
		}

        public void generate_painter(StreamWriter sw_h, StreamWriter sw_cpp)
        {
            //����� ��������� visit ��� ������� ���� ����

            //void visit(���_���� *_���_����);

            //void Painter::visit(���_���� *_���_����)
            //{
            //  PrintSpaces();
            //  *os<<���_����<<endl;
            //  nspace += 2;
            //  write_���_����(_���_����);
            //  nspace -= 2;
            //}
            sw_h.WriteLine(text_consts.tab + text_consts.tab +
                text_consts.void_keyword + text_consts.space +
                text_consts.visit_method_name +
                text_consts.open_par + node_name + text_consts.space +
                text_consts.star + text_consts.underline + node_name + text_consts.close_par + text_consts.semicolon);

            sw_cpp.WriteLine(text_consts.tab +
                text_consts.void_keyword + text_consts.space +
                text_consts.visualizator_name + text_consts.colon2 +
                text_consts.visit_method_name +
                text_consts.open_par + node_name + text_consts.space +
                text_consts.star + text_consts.underline + node_name + text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.print_spaces_name +
                text_consts.open_par + text_consts.close_par + text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.ostream_name +
                text_consts.stream_out + text_consts.inverted_comma2 + node_name +
                text_consts.inverted_comma2 + text_consts.stream_out +
                text_consts.endline_name + text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.space_offset + text_consts.inc_space +
                text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.write_prefix + node_name +
                text_consts.open_par +
                text_consts.underline + node_name +
                text_consts.close_par + text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.space_offset + text_consts.dec_space +
                text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);

            //--------
            //����� ��������� write ��� ������� ���� ����
            sw_h.WriteLine(text_consts.tab + text_consts.tab +
                text_consts.void_keyword + text_consts.space +
                text_consts.write_prefix + node_name +
                text_consts.open_par + node_name + text_consts.space +
                text_consts.star + text_consts.underline + node_name + text_consts.close_par + text_consts.semicolon);

            sw_cpp.WriteLine(text_consts.tab +
                text_consts.void_keyword + text_consts.space +
                text_consts.visualizator_name + text_consts.colon2 +
                text_consts.write_prefix + node_name +
                text_consts.open_par + node_name + text_consts.space +
                text_consts.star + text_consts.underline + node_name + text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);
            if (node_name != text_consts.base_tree_node_name)
            {
                //if (base_class != null) //(ssyy) ��� ������ ���� ������������ syntax_tree_node
                {
                    //����� ����� ������������ ����� ������
                    //write_<���_����_������>(_<���_����>);
                    sw_cpp.WriteLine(text_consts.tab2 + text_consts.write_prefix + base_class.node_name +
                        text_consts.open_par + text_consts.underline +
                        node_name + text_consts.close_par + text_consts.semicolon);
                }

                //����� ���� �������
                foreach (node_field_info nfi in _subnodes)
                {
                    simple_element se = nfi as simple_element;

                    //���� ���� �� �������� ����� ������
                    if (se != null)
                    {
                        //�������� ��� ���� ����
                        string tname = se.val_field_type_name;//.ToLower();
                        if (tname.Length > 4 && tname.Substring(0, 5) == "List<")
                        {
                            //�����:
                            //if (<��������_visit>-><���_����> != null)
                            //{
                            //  PrintSpaces();
                            //  *os<<���_����<<" Count="<<_��������_visit->���_����->size()<<endl;
                            //  for(int ssyy_i = 0; ssyy_i < ��������_visit->���_����->size(); ssyy_i++)
                            //  {
                            //      PrintSpaces();
                            //      *os<<"["<<i<<"]"<<endl;
                            //      print_node((*(��������_visit->���_����))[i]);
                            //  }
                            //}
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.if_keyword_name + text_consts.space +
                                text_consts.open_par + text_consts.underline + node_name +
                                text_consts.arrow + nfi.field_name + text_consts.space +
                                text_consts.not_equal_keyword_name + text_consts.space + text_consts.cpp_null_keyword_name +
                                text_consts.close_par);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.print_spaces_name +
                                text_consts.open_par + text_consts.close_par + text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.ostream_name + text_consts.stream_out +
                                text_consts.inverted_comma2 + nfi.field_name + text_consts.inverted_comma2 +
                                text_consts.stream_out + text_consts.count_string + text_consts.stream_out +
                                text_consts.underline + node_name + text_consts.arrow + nfi.field_name + text_consts.arrow +
                                text_consts.size_proc_name + text_consts.open_par + text_consts.close_par +
                                text_consts.stream_out + text_consts.endline_name + text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.for_keyword_name +
                                text_consts.open_par + text_consts.int32_type_name_cpp +
                                text_consts.space + text_consts.cycle_i_name +
                                text_consts.space + text_consts.assign +
                                text_consts.space + text_consts.i0_keyword_name +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.space +
                                text_consts.less_keyword_name + text_consts.space +
                                text_consts.underline + node_name +
                                text_consts.arrow + nfi.field_name +
                                text_consts.arrow + text_consts.size_proc_name + text_consts.open_par + text_consts.close_par +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.increment_keyword_name +
                                text_consts.close_par);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.open_figure);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.print_spaces_name +
                                text_consts.open_par + text_consts.close_par + text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.ostream_name +
                                text_consts.stream_out + text_consts.inverted_comma2 + text_consts.open_qbracket +
                                text_consts.inverted_comma2 + text_consts.stream_out + text_consts.cycle_i_name +
                                text_consts.stream_out + text_consts.inverted_comma2 + text_consts.close_qbracket +
                                text_consts.inverted_comma2 + text_consts.stream_out + text_consts.endline_name +
                                text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.print_node_proc +
                                text_consts.open_par + text_consts.open_par + text_consts.star +
                                text_consts.open_par +
                                text_consts.underline + node_name + text_consts.arrow + nfi.field_name +
                                text_consts.close_par +
                                text_consts.close_par +
                                text_consts.open_qbracket + text_consts.cycle_i_name + text_consts.close_qbracket +
                                text_consts.close_par + text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.close_figure);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
                        }
                        else
                            if (tname == text_consts.string_type_name) //� ���������, � ��� ��� ������ null
                            {
                                //if (<��������>-><���_����> != null)
                                //{
                                //  PrintSpaces();
                                //  *os<<"���_����="<<<��������>-><���_����><<endl;
                                //}
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.if_keyword_name + text_consts.space +
                                    text_consts.open_par + text_consts.underline + node_name +
                                    text_consts.arrow + nfi.field_name + text_consts.space +
                                    text_consts.not_equal_keyword_name + text_consts.space + text_consts.cpp_null_keyword_name +
                                    text_consts.close_par);
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                                sw_cpp.WriteLine(text_consts.tab3 + text_consts.print_spaces_name +
                                    text_consts.open_par + text_consts.close_par + text_consts.semicolon);
                                sw_cpp.WriteLine(text_consts.tab3 + text_consts.ostream_name +
                                    text_consts.stream_out + text_consts.inverted_comma2 + nfi.field_name +
                                    text_consts.equal_keyword_name + text_consts.inverted_comma2 +
                                    text_consts.stream_out + text_consts.underline + node_name +
                                    text_consts.arrow + nfi.field_name + text_consts.stream_out +
                                    text_consts.endline_name + text_consts.semicolon);
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
                            }
                                else
                                    {
                                        //�����:
                                        //  PrintSpaces();
                                        //  *os<<"���_����="<<<��������>-><���_����><<endl;
                                        sw_cpp.WriteLine(text_consts.tab2 + text_consts.print_spaces_name +
                                            text_consts.open_par + text_consts.close_par + text_consts.semicolon);
                                        sw_cpp.WriteLine(text_consts.tab2 + text_consts.ostream_name +
                                            text_consts.stream_out + text_consts.inverted_comma2 + nfi.field_name +
                                            text_consts.equal_keyword_name + text_consts.inverted_comma2 +
                                            text_consts.stream_out + text_consts.underline + node_name +
                                            text_consts.arrow + nfi.field_name + text_consts.stream_out +
                                            text_consts.endline_name + text_consts.semicolon);
                                    }
                    }
                    else
                    {
                        //�����:
                        //print_node(<��������_visit>-><���_����>);
                        sw_cpp.WriteLine(text_consts.tab2 + text_consts.print_spaces_name +
                            text_consts.open_par + text_consts.close_par + text_consts.semicolon);
                        sw_cpp.WriteLine(text_consts.tab2 + text_consts.ostream_name +
                            text_consts.stream_out + text_consts.inverted_comma2 + nfi.field_name +
                            text_consts.inverted_comma2 +
                            text_consts.stream_out +
                            text_consts.inverted_comma2 + text_consts.colon + text_consts.inverted_comma2 +
                            text_consts.stream_out +
                            text_consts.endline_name +
                            text_consts.semicolon);
                        sw_cpp.WriteLine(text_consts.tab2 + text_consts.print_node_proc +
                            text_consts.open_par + text_consts.underline + node_name +
                            text_consts.arrow + nfi.field_name + text_consts.close_par +
                            text_consts.semicolon);
                    }
                }
            }
            sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);

            sw_cpp.WriteLine();
        }



        //ssyy
        //number - ����� ���� � ����� ������
        public void generate_pcu_writer(StreamWriter sw, int number, bool cross_platform)
        {
            //�����
            //public void visit(<���_����> _<���_����>)
            //{
            //  sw.Write((Int16)<�����_����_����>);
            //  write_<��� ����>(_<��� ����>);
            //}

            sw.WriteLine();

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.public_keyword +
                text_consts.space + text_consts.void_keyword + text_consts.space + text_consts.visit_method_name +
                text_consts.open_par + node_name + text_consts.space + text_consts.underline + node_name + text_consts.close_par);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.open_figure);

            sw.WriteLine(text_consts.tab3 + text_consts.writer_name + text_consts.dot +
                text_consts.write_proc_name + text_consts.open_par +
                text_consts.open_par +
                text_consts.int16_type_name + text_consts.close_par +
                number.ToString() + text_consts.close_par +
                text_consts.semicolon);

            sw.WriteLine(text_consts.tab3 + text_consts.write_prefix + node_name +
                text_consts.open_par + text_consts.underline + node_name +
                text_consts.close_par + text_consts.semicolon);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.close_figure);

            sw.WriteLine();

            //����� ��������� write ��� ������� ���� ����

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.public_keyword +
                text_consts.space + text_consts.void_keyword + text_consts.space +
                text_consts.write_prefix + node_name +
                text_consts.open_par + node_name + text_consts.space +
                text_consts.underline + node_name + text_consts.close_par);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.open_figure);

            if (node_name == text_consts.base_tree_node_name)
            {
                //�����
                //if (_<���_����>.SourceContext == null)
                //{
                //  sw.Write((byte)0);
                //}
                //else
                //{
                //  sw.Write((byte)1);
                //  if (_<���_����>.SourceContext.begin_position == null)
                //  {
                //      sw.Write((byte)0);
                //  }
                //  else
                //  {
                //      sw.Write((byte)1);
                //      sw.Write(_<���_����>.SourceContext.begin_position.line_num);
                //      sw.Write(_<���_����>.SourceContext.begin_position.column_num);
                //  }
                //  if (_<���_����>.SourceContext.end_position == null)
                //  {
                //      sw.Write((byte)0);
                //  }
                //  else
                //  {
                //      sw.Write((byte)1);
                //      sw.Write(_<���_����>.SourceContext.end_position.line_num);
                //      sw.Write(_<���_����>.SourceContext.end_position.column_num);
                //  }
                //}
                sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.underline + node_name +
                    text_consts.dot + text_consts.source_context_name + text_consts.space +
                    text_consts.equal_keyword_name + text_consts.space + text_consts.null_keyword_name +
                    text_consts.close_par);
                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.open_par + text_consts.byte_type_name +
                    text_consts.close_par + text_consts.i0_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.open_par + text_consts.byte_type_name +
                    text_consts.close_par + text_consts.i1_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.underline + node_name +
                    text_consts.dot + text_consts.source_context_name +
                    text_consts.dot + text_consts.begin_position_name + text_consts.space +
                    text_consts.equal_keyword_name + text_consts.space + text_consts.null_keyword_name +
                    text_consts.close_par);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.open_par + text_consts.byte_type_name +
                    text_consts.close_par + text_consts.i0_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.else_keyword_name);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.open_par + text_consts.byte_type_name +
                    text_consts.close_par + text_consts.i1_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab2 + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.underline + node_name +
                    text_consts.dot + text_consts.source_context_name +
                    text_consts.dot + text_consts.begin_position_name + text_consts.dot + 
                    text_consts.line_num_name + text_consts.close_par +
                    text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab2 + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.underline + node_name +
                    text_consts.dot + text_consts.source_context_name +
                    text_consts.dot + text_consts.begin_position_name + text_consts.dot + 
                    text_consts.column_num_name + text_consts.close_par +
                    text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.underline + node_name +
                    text_consts.dot + text_consts.source_context_name +
                    text_consts.dot + text_consts.end_position_name + text_consts.space +
                    text_consts.equal_keyword_name + text_consts.space + text_consts.null_keyword_name +
                    text_consts.close_par);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.open_par + text_consts.byte_type_name +
                    text_consts.close_par + text_consts.i0_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.else_keyword_name);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.open_par + text_consts.byte_type_name +
                    text_consts.close_par + text_consts.i1_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab2 + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.underline + node_name +
                    text_consts.dot + text_consts.source_context_name +
                    text_consts.dot + text_consts.end_position_name + text_consts.dot + 
                    text_consts.line_num_name + text_consts.close_par +
                    text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab2 + text_consts.writer_name + text_consts.dot +
                    text_consts.write_proc_name + text_consts.open_par +
                    text_consts.underline + node_name +
                    text_consts.dot + text_consts.source_context_name +
                    text_consts.dot + text_consts.end_position_name + text_consts.dot + 
                    text_consts.column_num_name + text_consts.close_par +
                    text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
            }
            else
            {
                //if (base_class != null) //(ssyy) ��� ������ ���� ������������ syntax_tree_node
                {
                    //����� ����� ������������ ����� ������
                    //write_<���_����_������>(_<���_����>);
                    sw.WriteLine(text_consts.tab3 + text_consts.write_prefix + base_class.node_name +
                        text_consts.open_par + text_consts.underline +
                        node_name + text_consts.close_par + text_consts.semicolon);
                }
                
                //����� ���� �������
                foreach (node_field_info nfi in _subnodes)
                {
                    simple_element se = nfi as simple_element;

                    //���� ���� �� �������� ����� ������
                    if (se != null)
                    {
                        //�������� ��� ���� ����
                        string tname = se.val_field_type_name;//.ToLower();
                        if (tname.Length > 4 && tname.Substring(0, 5) == "List<")
                        {
                            //�����:
                            //if (<��������_visit>.<���_����> == null)
                            //{
                            //  sw.Write((byte)0);
                            //}
                            //else
                            //{
                            //  sw.Write((byte)1);
                            //  sw.Write(<��������_visit>.<���_����>.Count);
                            //  for(int ssyy_i = 0; ssyy_i < <��������_visit>.<���_����>.Count; ssyy_i++)
                            //  {
                            //      if (<��������_visit>.<���_����>[ssyy_i] == null)
                            //      {
                            //          sw.Write((byte)0);
                            //      }
                            //      else
                            //      {
                            //          sw.Write((byte)1);
                            //          <��������_visit>.���_����[ssyy_i].visit(this);
                            //      }
                            //  }
                            //}
                            sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name + text_consts.space +
                                text_consts.open_par + text_consts.underline + node_name +
                                text_consts.dot + nfi.field_name + text_consts.space +
                                text_consts.equal_keyword_name + text_consts.space + text_consts.null_keyword_name +
                                text_consts.close_par);
                            sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                text_consts.write_proc_name + text_consts.open_par +
                                text_consts.open_par + text_consts.byte_type_name +
                                text_consts.close_par + text_consts.i0_keyword_name +
                                text_consts.close_par + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
                            sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                text_consts.write_proc_name + text_consts.open_par +
                                text_consts.open_par + text_consts.byte_type_name +
                                text_consts.close_par + text_consts.i1_keyword_name +
                                text_consts.close_par + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                text_consts.write_proc_name + text_consts.open_par +
                                text_consts.underline + node_name +
                                text_consts.dot + nfi.field_name +
                                text_consts.dot + text_consts.count_name +
                                text_consts.close_par + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.for_keyword_name +
                                text_consts.open_par + text_consts.int32_type_name +
                                text_consts.space + text_consts.cycle_i_name +
                                text_consts.space + text_consts.assign +
                                text_consts.space + text_consts.i0_keyword_name +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.space +
                                text_consts.less_keyword_name + text_consts.space +
                                text_consts.underline + node_name +
                                text_consts.dot + nfi.field_name +
                                text_consts.dot + text_consts.count_name +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.increment_keyword_name +
                                text_consts.close_par);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + 
                                text_consts.if_keyword_name + text_consts.space +
                                text_consts.open_par + text_consts.underline + node_name +
                                text_consts.dot + nfi.field_name + text_consts.open_qbracket +
                                text_consts.cycle_i_name + text_consts.close_qbracket +
                                text_consts.space +
                                text_consts.equal_keyword_name + text_consts.space + text_consts.null_keyword_name +
                                text_consts.close_par);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.open_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.tab +
                                text_consts.writer_name + text_consts.dot +
                                text_consts.write_proc_name + text_consts.open_par +
                                text_consts.open_par + text_consts.byte_type_name +
                                text_consts.close_par + text_consts.i0_keyword_name +
                                text_consts.close_par + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.close_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.else_keyword_name);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.open_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.tab +
                                text_consts.writer_name + text_consts.dot +
                                text_consts.write_proc_name + text_consts.open_par +
                                text_consts.open_par + text_consts.byte_type_name +
                                text_consts.close_par + text_consts.i1_keyword_name +
                                text_consts.close_par + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.tab +
                                text_consts.underline + node_name
                                + text_consts.dot + nfi.field_name +
                                text_consts.open_qbracket + text_consts.cycle_i_name +
                                text_consts.close_qbracket + text_consts.dot +
                                text_consts.visit_method_name +
                                text_consts.open_par + text_consts.this_keyword +
                                text_consts.close_par + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.tab + text_consts.close_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                        }
                        else
                            if (tname == text_consts.string_type_name) //� ���������, � ��� ��� ������ null
                            {
                                //if (<��������>.<���_����> == null)
                                //{
                                //  sw.Write((byte)0);
                                //}
                                //else
                                //{
                                //  sw.Write((byte)1);
                                //  sw.Write(<��������>.<���_����>); //��� .NET
                                //}

                                //��� ������������������:
                                //  sw.Write(<��������>.<���_����>.Length + 1);
                                //  for(int ssyy_i = 0; i < <��������>.<���_����>.Length; i++)
                                //  {
                                //      sw.Write(<��������>.<���_����>[ssyy_i]);
                                //  }
                                //  sw.Write((byte)0); //��������� ������
                                sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name + text_consts.space +
                                    text_consts.open_par + text_consts.underline + node_name +
                                    text_consts.dot + nfi.field_name + text_consts.space +
                                    text_consts.equal_keyword_name + text_consts.space + text_consts.null_keyword_name +
                                    text_consts.close_par);
                                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                    text_consts.write_proc_name + text_consts.open_par +
                                    text_consts.open_par + text_consts.byte_type_name +
                                    text_consts.close_par + text_consts.i0_keyword_name +
                                    text_consts.close_par + text_consts.semicolon);
                                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                                sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
                                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                    text_consts.write_proc_name + text_consts.open_par +
                                    text_consts.open_par + text_consts.byte_type_name +
                                    text_consts.close_par + text_consts.i1_keyword_name +
                                    text_consts.close_par + text_consts.semicolon);
                                if (!cross_platform)
                                {
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab +
                                        text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.underline + node_name + text_consts.dot +
                                        se.field_name + text_consts.close_par +
                                        text_consts.semicolon);
                                }
                                else
                                {
                                    //����� ��� ������������ ������ � C-������, �.�. � char*
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab +
                                        text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.underline + node_name + text_consts.dot +
                                        se.field_name + text_consts.dot + text_consts.length_property_name +
                                        text_consts.space + text_consts.plus + text_consts.space +
                                        text_consts.i1_keyword_name + text_consts.close_par +
                                        text_consts.semicolon);
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.for_keyword_name +
                                        text_consts.open_par + text_consts.int32_type_name +
                                        text_consts.space + text_consts.cycle_i_name +
                                        text_consts.space + text_consts.assign +
                                        text_consts.space + text_consts.i0_keyword_name +
                                        text_consts.semicolon + text_consts.space +
                                        text_consts.cycle_i_name + text_consts.space +
                                        text_consts.less_keyword_name + text_consts.space + text_consts.underline + node_name +
                                        text_consts.dot + nfi.field_name +
                                        text_consts.dot + text_consts.length_property_name +
                                        text_consts.semicolon + text_consts.space +
                                        text_consts.cycle_i_name + text_consts.increment_keyword_name +
                                        text_consts.close_par);
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab2 +
                                        text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.underline + node_name + text_consts.dot + nfi.field_name +
                                        text_consts.open_qbracket + text_consts.cycle_i_name +
                                        text_consts.close_qbracket + text_consts.close_par +
                                        text_consts.semicolon);
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.open_par + text_consts.byte_type_name +
                                        text_consts.close_par + text_consts.i0_keyword_name +
                                        text_consts.close_par + text_consts.semicolon);
                                }
                                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                            }
                            else
                                if (tname == text_consts.bool_type_name && cross_platform)
                                {
                                    //if (_<��������>.<���_����>)
                                    //{
                                    //  sw.Write((byte)1);
                                    //}
                                    //else
                                    //{
                                    //  sw.Write((byte)0);
                                    //}
                                    sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name +
                                        text_consts.space + text_consts.open_par +
                                        text_consts.underline + node_name +
                                        text_consts.dot + se.field_name + text_consts.close_par);
                                    sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.open_par + text_consts.byte_type_name +
                                        text_consts.close_par + text_consts.i1_keyword_name +
                                        text_consts.close_par + text_consts.semicolon);
                                    sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                                    sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                                    sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.open_par + text_consts.byte_type_name +
                                        text_consts.close_par + text_consts.i0_keyword_name +
                                        text_consts.close_par + text_consts.semicolon);
                                    sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                                }
                                else
                                if (tname == text_consts.int32_type_name ||
                                    tname == text_consts.int64_type_name ||
                                    tname == text_consts.uint64_type_name ||
                                    tname == text_consts.double_type_name ||
                                    tname == text_consts.bool_type_name ||
                                    tname == text_consts.char_type_name)
                                {
                                    //�����: sw.Write(<��������>.<���_����>);
                                    sw.WriteLine(text_consts.tab3 + text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.underline + node_name + text_consts.dot +
                                        se.field_name + text_consts.close_par +
                                        text_consts.semicolon);
                                }
                                else
                                {
                                    sw.WriteLine(text_consts.tab3 + text_consts.writer_name + text_consts.dot +
                                        text_consts.write_proc_name + text_consts.open_par +
                                        text_consts.open_par + text_consts.byte_type_name +
                                        text_consts.close_par + text_consts.underline +
                                        node_name + text_consts.dot + se.field_name +
                                        text_consts.close_par + text_consts.semicolon);
                                }
                    }
                    else
                    {
                        //�����:
                        //if (<��������_visit>.<���_����> == null)
                        //{
                        //  sw.Write((byte)0);
                        //}
                        //else
                        //{
                        //  sw.Write((byte)1);
                        //  <��������_visit>.<���_����>.visit(this);
                        //}
                        sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name + text_consts.space +
                            text_consts.open_par + text_consts.underline + node_name +
                            text_consts.dot + nfi.field_name + text_consts.space +
                            text_consts.equal_keyword_name + text_consts.space + text_consts.null_keyword_name +
                            text_consts.close_par);
                        sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                        sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                            text_consts.write_proc_name + text_consts.open_par +
                            text_consts.open_par + text_consts.byte_type_name +
                            text_consts.close_par + text_consts.i0_keyword_name +
                            text_consts.close_par + text_consts.semicolon);
                        sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                        sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
                        sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                        sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.writer_name + text_consts.dot +
                            text_consts.write_proc_name + text_consts.open_par +
                            text_consts.open_par + text_consts.byte_type_name +
                            text_consts.close_par + text_consts.i1_keyword_name +
                            text_consts.close_par + text_consts.semicolon);
                        sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.underline + node_name
                            + text_consts.dot + nfi.field_name + text_consts.dot +
                            text_consts.visit_method_name +
                            text_consts.open_par + text_consts.this_keyword +
                            text_consts.close_par + text_consts.semicolon);
                        sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                    }
                }
            }
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.close_figure);

            sw.WriteLine();
        }

        public void generate_stream_reader_cpp(StreamWriter sw_h, StreamWriter sw_cpp, string pcu_reader_name)
        {
            //�����
            //void visit(<���_����> *_<���_����>)
            //{
            //  read_<��� ����>(_<��� ����>);
            //}

            sw_h.WriteLine();

            sw_h.WriteLine(text_consts.tab + text_consts.tab +
                text_consts.void_keyword + text_consts.space + text_consts.visit_method_name +
                text_consts.open_par + node_name + text_consts.space + text_consts.star +
                text_consts.underline + node_name + text_consts.close_par);

            sw_h.WriteLine(text_consts.tab + text_consts.tab + text_consts.open_figure);

            sw_h.WriteLine(text_consts.tab3 + text_consts.read_prefix + node_name +
                text_consts.open_par + text_consts.underline + node_name +
                text_consts.close_par + text_consts.semicolon);

            sw_h.WriteLine(text_consts.tab + text_consts.tab + text_consts.close_figure);

            //����� ��������� ������ ������� ����
            sw_h.WriteLine(text_consts.tab + text_consts.tab +
                text_consts.void_keyword + text_consts.space +
                text_consts.read_prefix + node_name +
                text_consts.open_par + node_name + text_consts.space + text_consts.star +
                text_consts.underline + node_name + text_consts.close_par +
                text_consts.semicolon);

            sw_cpp.WriteLine();

            sw_cpp.WriteLine(text_consts.tab +
                text_consts.void_keyword + text_consts.space +
                pcu_reader_name + text_consts.colon2 +
                text_consts.read_prefix + node_name +
                text_consts.open_par + node_name + text_consts.space + text_consts.star +
                text_consts.underline + node_name + text_consts.close_par);

            sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);

            //����� ��������� ������ ����� ��� ������� ���� ����

            if (node_name == text_consts.base_tree_node_name)
            {
                //�����
                //if (br.GetChar() == 0)
                //{
                //  _<���_����>->source_context = NULL;
                //}
                //else
                //{
                //  SourceContext *ssyy_beg = NULL;
                //  SourceContext *ssyy_end = NULL;
                //  if (br.GetChar() == 1)
                //  {
                //      ssyy_beg = new SourceContext(br.GetInt(), br.GetInt(), 0, 0);
                //  }
                //  if (br.GetChar() == 1)
                //  {
                //      ssyy_end = new SourceContext(0, 0, br.GetInt(), br.GetInt());
                //  }
                //  _<���_����>->source_context = new SourceContext(ssyy_beg, ssyy_end);  
                //}
                sw_cpp.WriteLine(text_consts.tab2 + text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.GetChar_proc_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.space + text_consts.equal_keyword_name +
                    text_consts.space + text_consts.i0_keyword_name +
                    text_consts.close_par);
                sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.underline + 
                    node_name + text_consts.arrow + text_consts.source_context_name +
                    text_consts.space + text_consts.assign + text_consts.space +
                    text_consts.cpp_null_keyword_name + text_consts.semicolon);
                sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
                sw_cpp.WriteLine(text_consts.tab2 + text_consts.else_keyword_name);
                sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                sw_cpp.WriteLine(text_consts.tab3 +
                    text_consts.source_context_class_name + text_consts.space +
                    text_consts.star +
                    text_consts.temp_beg + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.cpp_null_keyword_name +
                    text_consts.semicolon);
                sw_cpp.WriteLine(text_consts.tab3 +
                    text_consts.source_context_class_name + text_consts.space +
                    text_consts.star +
                    text_consts.temp_end + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.cpp_null_keyword_name +
                    text_consts.semicolon);
                sw_cpp.WriteLine(text_consts.tab3 +
                    text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.GetChar_proc_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.space + text_consts.equal_keyword_name +
                    text_consts.space + text_consts.i1_keyword_name +
                    text_consts.close_par);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.open_figure);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.temp_beg + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.new_keyword +
                    text_consts.space + text_consts.source_context_class_name +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.GetInt_proc_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.comma + text_consts.space +
                    text_consts.reader_name +
                    text_consts.dot + text_consts.GetInt_proc_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.comma + text_consts.space + text_consts.i0_keyword_name +
                    text_consts.comma + text_consts.space + text_consts.i0_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.close_figure);
                sw_cpp.WriteLine(text_consts.tab3 +
                    text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.GetChar_proc_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.space + text_consts.equal_keyword_name +
                    text_consts.space + text_consts.i1_keyword_name +
                    text_consts.close_par);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.open_figure);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.temp_end + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.new_keyword +
                    text_consts.space + text_consts.source_context_class_name +
                    text_consts.open_par +
                    text_consts.i0_keyword_name +
                    text_consts.comma + text_consts.space + text_consts.i0_keyword_name +
                    text_consts.comma + text_consts.space + text_consts.reader_name +
                    text_consts.dot + text_consts.GetInt_proc_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.comma + text_consts.space +
                    text_consts.reader_name +
                    text_consts.dot + text_consts.GetInt_proc_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.close_par + text_consts.semicolon);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.close_figure);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.underline + 
                    node_name + text_consts.arrow + text_consts.source_context_name +
                    text_consts.space + text_consts.assign + text_consts.space +
                    text_consts.new_keyword + text_consts.space +
                    text_consts.source_context_class_name + text_consts.open_par +
                    text_consts.temp_beg + text_consts.comma +
                    text_consts.space + text_consts.temp_end +
                    text_consts.close_par + text_consts.semicolon);
                sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
            }
            else
            {
                //if (base_class != null) //(ssyy) ��� ������ ���� ������������ tree_node
                {
                    //����� ����� �������������� ����� ������
                    //read_<���_����_������>(_<���_����>);
                    sw_cpp.WriteLine(text_consts.tab2 + text_consts.read_prefix + base_class.node_name +
                        text_consts.open_par + text_consts.underline +
                        node_name + text_consts.close_par + text_consts.semicolon);
                }

                //����� ���� �������
                foreach (node_field_info nfi in _subnodes)
                {
                    simple_element se = nfi as simple_element;

                    string write_proc_string = "";

                    //���� ���� �� �������� ����� ������
                    if (se != null)
                    {
                        //�������� ��� ���� ����
                        string tname = se.val_field_type_name;//.ToLower();
                        if (tname.Length > 5 && tname.Substring(0, 5) == "List<")
                        {
                            //�����:
                            //if (br.GetChar() == 0)
                            //{
                            //  <��������_visit>-><���_����> = NULL;
                            //}
                            //else
                            //{
                            //  <��������_visit>-><���_����> = new vector<��������_List*>();
                            //  int ssyy_count = br.GetInt();
                            //  for(int ssyy_i = 0; ssyy_i < ssyy_count; ssyy_i++)
                            //  {
                            //      <��������_visit>-><���_����>.push_back(static_cast<��������_List*>(read_node()));
                            //  }
                            //}
                            string list_param = tname.Substring(5, tname.Length - 6);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.if_keyword_name + text_consts.space +
                                text_consts.open_par + text_consts.reader_name +
                                text_consts.dot + text_consts.GetChar_proc_name +
                                text_consts.open_par + text_consts.close_par +
                                text_consts.space + text_consts.equal_keyword_name +
                                text_consts.space + text_consts.i0_keyword_name +
                                text_consts.close_par);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.tab + text_consts.underline + 
                                node_name + text_consts.arrow + nfi.field_name +
                                text_consts.space + text_consts.assign + text_consts.space +
                                text_consts.cpp_null_keyword_name + text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.else_keyword_name);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.underline + 
                                node_name + text_consts.arrow + nfi.field_name +
                                text_consts.space + text_consts.assign + text_consts.space +
                                text_consts.new_keyword + text_consts.space +
                                text_consts.vector_name + text_consts.less_keyword_name +
                                list_param + text_consts.star + text_consts.greater_keyword_name +
                                text_consts.open_par + text_consts.close_par +
                                text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 +
                                text_consts.int32_type_name_cpp + text_consts.space +
                                text_consts.temp_count_name + text_consts.space +
                                text_consts.assign + text_consts.space +
                                text_consts.reader_name + text_consts.dot +
                                text_consts.GetInt_proc_name + text_consts.open_par +
                                text_consts.close_par + text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.for_keyword_name +
                                text_consts.open_par + text_consts.int32_type_name_cpp +
                                text_consts.space + text_consts.cycle_i_name +
                                text_consts.space + text_consts.assign +
                                text_consts.space + text_consts.i0_keyword_name +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.space +
                                text_consts.less_keyword_name + text_consts.space +
                                text_consts.temp_count_name +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.increment_keyword_name +
                                text_consts.close_par);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.open_figure);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.underline + 
                                node_name + text_consts.arrow + nfi.field_name +
                                text_consts.arrow + text_consts.push_back_name +
                                text_consts.open_par +
                                text_consts.type_cast_name + text_consts.less_keyword_name +
                                list_param + text_consts.star + text_consts.greater_keyword_name +
                                text_consts.open_par +
                                text_consts.nodes_read_method +
                                text_consts.open_par + text_consts.close_par +
                                text_consts.close_par + text_consts.close_par +
                                text_consts.semicolon);
                            sw_cpp.WriteLine(text_consts.tab3 + text_consts.close_figure);
                            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
                        }
                        else
                        {
                            if (tname == text_consts.string_type_name)
                            {
                                //if (br.GetChar() == 0)
                                //{
                                //  <��������_visit>-><���_����> = NULL;
                                //}
                                //else
                                //{
                                //  <��������_visit>-><���_����> = br.GetString();
                                //}
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.if_keyword_name +
                                    text_consts.space + text_consts.open_par +
                                    text_consts.reader_name + text_consts.dot +
                                    text_consts.GetChar_proc_name + text_consts.open_par +
                                    text_consts.close_par + text_consts.space +
                                    text_consts.equal_keyword_name + text_consts.space +
                                    text_consts.i0_keyword_name + text_consts.close_par);
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                                sw_cpp.WriteLine(text_consts.tab3 +
                                    text_consts.underline + node_name +
                                    text_consts.arrow + nfi.field_name + text_consts.space +
                                    text_consts.assign + text_consts.space + text_consts.cpp_null_keyword_name +
                                    text_consts.semicolon);
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.else_keyword_name);
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
                                sw_cpp.WriteLine(text_consts.tab3 +
                                    text_consts.underline + node_name +
                                    text_consts.arrow + nfi.field_name + text_consts.space +
                                    text_consts.assign + text_consts.space +
                                    text_consts.reader_name + text_consts.dot +
                                    text_consts.GetString_proc_name + text_consts.open_par +
                                    text_consts.close_par +
                                    text_consts.semicolon);
                                sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
                            }
                            //������� ���� - �������������� ������ �������:
                            else
                            {
                                if (tname == text_consts.int32_type_name)
                                {
                                    write_proc_string = text_consts.read_int32_name;
                                }
                                else
                                    if (tname == text_consts.int64_type_name)
                                    {
                                        write_proc_string = text_consts.read_int64_name;
                                    }
                                    else
                                        if (tname == text_consts.uint64_type_name)
                                        {
                                            write_proc_string = text_consts.read_uint64_name;
                                        }
                                        else
                                            if (tname == text_consts.double_type_name)
                                            {
                                                write_proc_string = text_consts.read_double_name;
                                            }
                                            else
                                                if (tname == text_consts.bool_type_name)
                                                {
                                                    write_proc_string = text_consts.read_bool_name;
                                                }
                                                else
                                                    if (tname == text_consts.char_type_name)
                                                    {
                                                        write_proc_string = text_consts.read_char_name;
                                                    }
                                if (write_proc_string != "")
                                {
                                    //br.Read...(&<��������_visit>-><���_����>);
                                    sw_cpp.WriteLine(text_consts.tab2 + text_consts.reader_name +
                                    text_consts.dot + write_proc_string +
                                    text_consts.open_par + text_consts.address +
                                    text_consts.underline +
                                    node_name + text_consts.arrow + nfi.field_name +
                                    text_consts.close_par + text_consts.semicolon);
                                }
                                else
                                {
                                    //<��������_visit>-><���_����> = (<���_����>)br.GetByte();
                                    sw_cpp.WriteLine(text_consts.tab2 + text_consts.underline +
                                    node_name + text_consts.arrow + nfi.field_name +
                                    text_consts.space + text_consts.assign +
                                    text_consts.space +
                                    text_consts.open_par + nfi.field_type_name + text_consts.close_par +
                                    text_consts.reader_name +
                                    text_consts.dot + text_consts.GetByte_proc_name +
                                    text_consts.open_par + text_consts.close_par +
                                    text_consts.semicolon);
                                }
                            }
                        }
                    }
                    else
                    {
                        //�����:
                        //<��������_visit>-><���_����> = static_cast<���_����*>(read_node());
                        sw_cpp.WriteLine(text_consts.tab2 + text_consts.underline + 
                        node_name + text_consts.arrow + nfi.field_name +
                        text_consts.space + text_consts.assign +
                        text_consts.space +
                        text_consts.type_cast_name + text_consts.less_keyword_name +
                        nfi.field_type_name + text_consts.star +
                        text_consts.greater_keyword_name +
                        text_consts.open_par +
                        text_consts.nodes_read_method +
                        text_consts.open_par + text_consts.close_par +
                        text_consts.close_par +
                        text_consts.semicolon);
                    }
                }
            }
            sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);

            sw_cpp.WriteLine();
        }

        //----------------------------------------------------------------------------

        public void generate_pcu_reader(StreamWriter sw)
        {
            //�����
            //public void visit(<���_����> _<���_����>)
            //{
            //  read_<��� ����>(_<��� ����>);
            //}

            sw.WriteLine();

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.public_keyword +
                text_consts.space + text_consts.void_keyword + text_consts.space + text_consts.visit_method_name +
                text_consts.open_par + node_name + text_consts.space + text_consts.underline + node_name + text_consts.close_par);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.open_figure);

            sw.WriteLine(text_consts.tab3 + text_consts.read_prefix + node_name +
                text_consts.open_par + text_consts.underline + node_name +
                text_consts.close_par + text_consts.semicolon);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.close_figure);

            
            //����� ��������� ������ ������� ����
            sw.WriteLine();

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.public_keyword +
                text_consts.space + text_consts.void_keyword + text_consts.space +
                text_consts.read_prefix + node_name +
                text_consts.open_par + node_name + text_consts.space +
                text_consts.underline + node_name + text_consts.close_par);

            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.open_figure);

            //����� ��������� ������ ����� ��� ������� ���� ����

            if (node_name == text_consts.base_tree_node_name)
            {
                //�����
                //if (br.ReadByte() == 0)
                //{
                //  _<���_����>.source_context = null;
                //}
                //else
                //{
                //  SourceContext ssyy_beg = null;
                //  SourceContext ssyy_end = null;
                //  if (br.ReadByte() == 1)
                //  {
                //      ssyy_beg = new SourceContext(br.ReadInt32(), br.ReadInt32(), 0, 0);
                //  }
                //  if (br.ReadByte() == 1)
                //  {
                //      ssyy_end = new SourceContext(0, 0, br.ReadInt32(), br.ReadInt32());
                //  }
                //  _<���_����>.source_context = new SourceContext(ssyy_beg, ssyy_end);  
                //}
                sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.read_byte_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.space + text_consts.equal_keyword_name +
                    text_consts.space + text_consts.i0_keyword_name +
                    text_consts.close_par);
                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.underline + 
                    node_name + text_consts.dot + text_consts.source_context_name +
                    text_consts.space + text_consts.assign + text_consts.space +
                    text_consts.null_keyword_name + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.source_context_class_name + text_consts.space +
                    text_consts.temp_beg + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.null_keyword_name +
                    text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.source_context_class_name + text_consts.space +
                    text_consts.temp_end + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.null_keyword_name +
                    text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.read_byte_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.space + text_consts.equal_keyword_name +
                    text_consts.space + text_consts.i1_keyword_name +
                    text_consts.close_par);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab2 +
                    text_consts.temp_beg + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.new_keyword +
                    text_consts.space + text_consts.source_context_class_name +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.read_int32_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.comma + text_consts.space +
                    text_consts.reader_name +
                    text_consts.dot + text_consts.read_int32_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.comma + text_consts.space + text_consts.i0_keyword_name +
                    text_consts.comma + text_consts.space + text_consts.i0_keyword_name +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.if_keyword_name + text_consts.space +
                    text_consts.open_par + text_consts.reader_name +
                    text_consts.dot + text_consts.read_byte_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.space + text_consts.equal_keyword_name +
                    text_consts.space + text_consts.i1_keyword_name +
                    text_consts.close_par);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab2 +
                    text_consts.temp_end + text_consts.space + text_consts.assign +
                    text_consts.space + text_consts.new_keyword +
                    text_consts.space + text_consts.source_context_class_name +
                    text_consts.open_par +
                    text_consts.i0_keyword_name +
                    text_consts.comma + text_consts.space + text_consts.i0_keyword_name +
                    text_consts.comma + text_consts.space + text_consts.reader_name +
                    text_consts.dot + text_consts.read_int32_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.comma + text_consts.space +
                    text_consts.reader_name +
                    text_consts.dot + text_consts.read_int32_name +
                    text_consts.open_par + text_consts.close_par +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.underline + 
                    node_name + text_consts.dot + text_consts.source_context_name +
                    text_consts.space + text_consts.assign + text_consts.space +
                    text_consts.new_keyword + text_consts.space +
                    text_consts.source_context_class_name + text_consts.open_par +
                    text_consts.temp_beg + text_consts.comma +
                    text_consts.space + text_consts.temp_end +
                    text_consts.close_par + text_consts.semicolon);
                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
            }
            else
            {
                //if (base_class != null) //(ssyy) ��� ������ ���� ������������ tree_node
                {
                    //����� ����� �������������� ����� ������
                    //read_<���_����_������>(_<���_����>);
                    sw.WriteLine(text_consts.tab3 + text_consts.read_prefix + base_class.node_name +
                        text_consts.open_par + text_consts.underline +
                        node_name + text_consts.close_par + text_consts.semicolon);
                }

                //����� ���� �������
                foreach (node_field_info nfi in _subnodes)
                {
                    simple_element se = nfi as simple_element;

                    string write_proc_string = "";

                    //���� ���� �� �������� ����� ������
                    if (se != null)
                    {
                        //�������� ��� ���� ����
                        string tname = se.val_field_type_name;//.ToLower();
                        if (tname.Length > 5 && tname.Substring(0, 5) == "List<")
                        {
                            //�����:
                            //if (br.ReadByte() == 0)
                            //{
                            //  <��������_visit>.<���_����> = null;
                            //}
                            //else
                            //{
                            //  <��������_visit>.<���_����> = new <���_����>();
                            //  Int32 ssyy_count = br.ReadInt32();
                            //  for(int ssyy_i = 0; ssyy_i < ssyy_count; ssyy_i++)
                            //  {
                            //      <��������_visit>.<���_����>.Add(read_node() as <��������_List>);
                            //  }
                            //}
                            sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name + text_consts.space +
                                text_consts.open_par + text_consts.reader_name +
                                text_consts.dot + text_consts.read_byte_name +
                                text_consts.open_par + text_consts.close_par +
                                text_consts.space + text_consts.equal_keyword_name +
                                text_consts.space + text_consts.i0_keyword_name +
                                text_consts.close_par);
                            sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.underline + 
                                node_name + text_consts.dot + nfi.field_name +
                                text_consts.space + text_consts.assign + text_consts.space +
                                text_consts.null_keyword_name + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
                            sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.underline + 
                                node_name + text_consts.dot + nfi.field_name +
                                text_consts.space + text_consts.assign + text_consts.space +
                                text_consts.new_keyword + text_consts.space +
                                tname + text_consts.open_par + text_consts.close_par +
                                text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab +
                                text_consts.int32_type_name + text_consts.space +
                                text_consts.temp_count_name + text_consts.space +
                                text_consts.assign + text_consts.space +
                                text_consts.reader_name + text_consts.dot +
                                text_consts.read_int32_name + text_consts.open_par +
                                text_consts.close_par + text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.for_keyword_name +
                                text_consts.open_par + text_consts.int32_type_name +
                                text_consts.space + text_consts.cycle_i_name +
                                text_consts.space + text_consts.assign +
                                text_consts.space + text_consts.i0_keyword_name +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.space +
                                text_consts.less_keyword_name + text_consts.space +
                                text_consts.temp_count_name +
                                text_consts.semicolon + text_consts.space +
                                text_consts.cycle_i_name + text_consts.increment_keyword_name +
                                text_consts.close_par);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.open_figure);
                            string list_param = tname.Substring(5, tname.Length - 6);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab2 + text_consts.underline + 
                                node_name + text_consts.dot + nfi.field_name +
                                text_consts.dot + text_consts.add_proc_name +
                                text_consts.open_par + text_consts.nodes_read_method +
                                text_consts.open_par + text_consts.close_par +
                                text_consts.space + text_consts.as_keyword +
                                text_consts.space + list_param + text_consts.close_par+
                                text_consts.semicolon);
                            sw.WriteLine(text_consts.tab3 + text_consts.tab + text_consts.close_figure);
                            sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                        }
                        else
                        {
                            if (tname == text_consts.string_type_name)
                            {
                                //if (br.ReadByte() == 0)
                                //{
                                //  <��������_visit>.<���_����> = null;
                                //}
                                //else
                                //{
                                //  <��������_visit>.<���_����> = br.ReadString();
                                //}
                                sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name +
                                    text_consts.space + text_consts.open_par +
                                    text_consts.reader_name + text_consts.dot +
                                    text_consts.read_byte_name + text_consts.open_par +
                                    text_consts.close_par + text_consts.space +
                                    text_consts.equal_keyword_name + text_consts.space +
                                    text_consts.i0_keyword_name + text_consts.close_par);
                                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                                sw.WriteLine(text_consts.tab3 + text_consts.tab +
                                    text_consts.underline + node_name +
                                    text_consts.dot + nfi.field_name + text_consts.space +
                                    text_consts.assign + text_consts.space + text_consts.null_keyword_name +
                                    text_consts.semicolon);
                                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                                sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
                                sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
                                sw.WriteLine(text_consts.tab3 + text_consts.tab +
                                    text_consts.underline + node_name +
                                    text_consts.dot + nfi.field_name + text_consts.space +
                                    text_consts.assign + text_consts.space +
                                    text_consts.reader_name + text_consts.dot +
                                    text_consts.read_string_name + text_consts.open_par +
                                    text_consts.close_par +
                                    text_consts.semicolon);
                                sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
                            }
                            //������� ���� - �������������� ������ �������:
                            else
                            {
                                if (tname == text_consts.int32_type_name)
                                {
                                    write_proc_string = text_consts.read_int32_name;
                                }
                                else
                                    if (tname == text_consts.int64_type_name)
                                    {
                                        write_proc_string = text_consts.read_int64_name;
                                    }
                                    else
                                        if (tname == text_consts.uint64_type_name)
                                        {
                                            write_proc_string = text_consts.read_uint64_name;
                                        }
                                        else
                                            if (tname == text_consts.double_type_name)
                                            {
                                                write_proc_string = text_consts.read_double_name;
                                            }
                                            else
                                                if (tname == text_consts.bool_type_name)
                                                {
                                                    write_proc_string = text_consts.read_bool_name;
                                                }
                                                else
                                                    if (tname == text_consts.char_type_name)
                                                    {
                                                        write_proc_string = text_consts.read_char_name;
                                                    }
                                if (write_proc_string != "")
                                {
                                    //<��������_visit>.<���_����> = br.Read...();
                                    sw.WriteLine(text_consts.tab3 + text_consts.underline +
                                    node_name + text_consts.dot + nfi.field_name +
                                    text_consts.space + text_consts.assign +
                                    text_consts.space + text_consts.reader_name +
                                    text_consts.dot + write_proc_string +
                                    text_consts.open_par + text_consts.close_par +
                                    text_consts.semicolon);
                                }
                                else
                                {
                                    //<��������_visit>.<���_����> = (<���_����>)br.ReadByte();
                                    sw.WriteLine(text_consts.tab3 + text_consts.underline +
                                    node_name + text_consts.dot + nfi.field_name +
                                    text_consts.space + text_consts.assign +
                                    text_consts.space +
                                    text_consts.open_par + nfi.field_type_name + text_consts.close_par +
                                    text_consts.reader_name +
                                    text_consts.dot + text_consts.read_byte_name +
                                    text_consts.open_par + text_consts.close_par +
                                    text_consts.semicolon);
                                }
                            }
                        }
                    }
                    else
                    {
                        //�����:
                        //<��������_visit>.<���_����> = read_node() as <���_����>;
                        sw.WriteLine(text_consts.tab3 + text_consts.underline + 
                        node_name + text_consts.dot + nfi.field_name +
                        text_consts.space + text_consts.assign +
                        text_consts.space + text_consts.nodes_read_method +
                        text_consts.open_par + text_consts.close_par +
                        text_consts.space + text_consts.as_keyword +
                        text_consts.space + nfi.field_type_name +
                        text_consts.semicolon);
                    }
                }
            }
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.close_figure);

            sw.WriteLine();
        }
        
        //\ssyy

        //ssyy
        public void generate_cpp_code(StreamWriter sw_h, StreamWriter sw_cpp, HelpStorage hst)
        {
            sw_h.WriteLine();

            string temp = "";
            if (hst.get_help_context(this.node_name) != null)
            {
                sw_h.WriteLine(@"	///<summary>");
                sw_h.WriteLine(@"	///" + hst.get_help_context(this.node_name).help_context);
                sw_h.WriteLine(@"	///</summary>");
                if (base_class != null)
                {
                    temp = text_consts.space + text_consts.colon + text_consts.space
                        + text_consts.public_keyword + text_consts.space + base_class.node_name;
                }

                sw_h.WriteLine(text_consts.tab + text_consts.class_keyword + text_consts.space +
                    node_name + temp);
                sw_h.WriteLine(text_consts.tab + text_consts.open_figure);
                sw_h.WriteLine(text_consts.tab + text_consts.public_keyword + text_consts.colon);

                List<string> destructor_code = new List<string>();

                foreach (node_field_info nfi in _subnodes)
                {
                    nfi.generate_cpp_field_code(sw_h, destructor_code);
                }

                if (destructor_code.Count > 0)
                {
                    sw_h.WriteLine();
                    sw_h.WriteLine(text_consts.tab2 + text_consts.tilde + node_name +
                        text_consts.open_par + text_consts.close_par + text_consts.semicolon);
                    sw_cpp.WriteLine();
                    sw_cpp.WriteLine(text_consts.tab + node_name + text_consts.colon2 +
                        text_consts.tilde + node_name +
                        text_consts.open_par + text_consts.close_par);
                    sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);
                    foreach (string s in destructor_code)
                    {
                        sw_cpp.WriteLine(s);
                    }
                    sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);
                }

                generate_visitor_node_cpp(sw_h);

                sw_h.WriteLine(text_consts.tab + text_consts.close_figure + text_consts.semicolon);
                sw_h.WriteLine();
            }
        }

        public void generate_cpp_predef_code(StreamWriter sw)
        {
            sw.WriteLine(text_consts.tab + text_consts.class_keyword + text_consts.space +
                node_name + text_consts.semicolon);
        }
        //\ssyy

		public void generate_code(StreamWriter sw,HelpStorage hst)
		{
			//sw.WriteLine();

			string temp="";
			if (hst.get_help_context(this.node_name)!=null)
			{
                sw.WriteLine(@"	///<summary>");
				sw.WriteLine(@"	///"+hst.get_help_context(this.node_name).help_context);
				sw.WriteLine(@"	///</summary>");
			}
			sw.WriteLine("	[Serializable]");
			if (base_class!=null)
			{
				temp=text_consts.space+text_consts.colon+text_consts.space+base_class.node_name;
			}

			sw.WriteLine(text_consts.tab+text_consts.public_keyword+text_consts.space+text_consts.class_keyword+text_consts.space+
				node_name+temp);
			sw.WriteLine(text_consts.tab+text_consts.open_figure);
			//sw.WriteLine();

			generate_simple_constructor_code(sw);

			//sw.WriteLine();

			if (_subnodes.Count>0)
			{
				generate_big_constructor_code(sw, false);
				sw.WriteLine();
                generate_big_constructor_code(sw, true);
            }

            if (CountNodesInBaseClasses() > 0)
            {
                sw.WriteLine();
                generate_big_constructor_code(sw, false, true);
                sw.WriteLine();
                generate_big_constructor_code(sw, true, true);
            }

            sw.WriteLine();
            foreach (node_field_info nfi in _subnodes)
			{
				nfi.generate_field_code(sw);
			}

            if (_subnodes.Count > 0)
                sw.WriteLine();

			foreach(node_field_info nfi in _subnodes)
			{
				nfi.generate_code_property(sw,this,hst);
			}

            if (_subnodes.Count>0)
                sw.WriteLine();

            foreach (method_info mi in _methods)
            {
                mi.generate_code(sw, this, hst);
            }

            if (_methods.Count > 0)
                sw.WriteLine();

            generate_visitor_node(sw);

			sw.WriteLine();
			sw.WriteLine(text_consts.tab+text_consts.close_figure);
			sw.WriteLine();

			sw.WriteLine();
		}
		public void generate_to_text(StreamWriter sw,HelpStorage hst)
		{
			if (this.base_class!=null)
				sw.WriteLine(this.node_name+"->"+this.base_class.node_name);
			else
				sw.WriteLine(this.node_name);

			foreach(node_field_info nfi in _subnodes)
			{
				sw.WriteLine(text_consts.tab+nfi.field_type_name+" "+nfi.field_name);
			}
			/*
			string resize_part=
				text_consts.tab2+"if ("+this.node_name+"_size<="+this.node_name+"_count)"+text_consts.nr+
				text_consts.tab2+"{"+text_consts.nr+
				text_consts.tab2+this.node_name+"_size*=2;"+text_consts.nr+
				text_consts.tab2+this.node_name+"[] "+this.node_name+"_arrayold="+this.node_name+"_array;"+text_consts.nr+
				text_consts.tab2+this.node_name+"_array=new "+this.node_name+"["+this.node_name+"_size];"+text_consts.nr+
				text_consts.tab2+this.node_name+"_arrayold.CopyTo("+this.node_name+"_array,0);"+text_consts.nr+
				text_consts.tab2+"for (int i="+this.node_name+"_count;i<"+this.node_name+"_size;i++) "+this.node_name+"_array[i]=new "+this.node_name+"();"+text_consts.nr+
				text_consts.tab2+"}";
			
			sw.WriteLine(text_consts.tab2+this.node_name+"_count++"+text_consts.semicolon);
			sw.WriteLine(resize_part);
			
			string elem=this.node_name+"_array["+this.node_name+"_count-1]";
			
			string reset_elem="";
			for(int i=0;i<_subnodes.Count;i++)
			{
				if (!(_subnodes[i] is simple_element))
					reset_elem+=text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+"=null;"+text_consts.nr;
				if (_subnodes[i] is extended_simple_element)
					if (((extended_simple_element)_subnodes[i]).field_type_name.IndexOf("ArrayList")>=0)
						reset_elem+=text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+".Clear();"+text_consts.nr;
			}

			if(reset_elem!="")
			{
				sw.WriteLine(reset_elem);
			}
			
			sw.WriteLine(text_consts.tab2+"return "+elem+";");
			
			sw.WriteLine(text_consts.tab+text_consts.close_figure);

			sw.WriteLine();
			
			if (_subnodes.Count>0)
			{
				//tn(...)
				sw.Write(text_consts.tab+text_consts.public_keyword+text_consts.space+
					text_consts.space+
					node_name+text_consts.space+text_consts.new_keyword+text_consts.underline+this.node_name+text_consts.open_par);
				for(int i=0;i<_subnodes.Count-1;i++)
					sw.Write(subnode_variable(i)+text_consts.comma);
				if (_subnodes.Count>0)
					sw.Write(subnode_variable(_subnodes.Count-1));
				sw.WriteLine(text_consts.close_par);

				sw.WriteLine(text_consts.tab+text_consts.open_figure);
			
				sw.WriteLine(text_consts.tab2+this.node_name+"_count++"+text_consts.semicolon);
				sw.WriteLine(resize_part);
				
				reset_elem="";
				for(int i=0;i<_subnodes.Count;i++)
				{
					if (_subnodes[i] is extended_simple_element)
						if (((extended_simple_element)_subnodes[i]).field_type_name.IndexOf("ArrayList")>=0)
							reset_elem+=text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+".Clear();"+text_consts.nr;
				}

				if(reset_elem!="")
				{
					sw.WriteLine(reset_elem);
					
				}

				for(int i=0;i<_subnodes.Count;i++)
					sw.WriteLine(text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+"="+((node_field_info)_subnodes[i]).field_code_name+text_consts.semicolon);
			

				sw.WriteLine(text_consts.tab2+"return "+elem+";");

				sw.WriteLine(text_consts.tab+text_consts.close_figure);
			}

			*/
			sw.WriteLine();
			
		}
		public void generate_fabric_method(StreamWriter sw)
		{
			sw.WriteLine(text_consts.tab+this.node_name+"[] "+this.node_name+"_array"+text_consts.semicolon);
			sw.WriteLine(text_consts.tab+"int "+this.node_name+"_size=0,"+this.node_name+"_count=0"+text_consts.semicolon);
			sw.WriteLine();
			
			//tn()
			sw.WriteLine(text_consts.tab+text_consts.public_keyword+text_consts.space+this.node_name+
				text_consts.space+text_consts.new_keyword+text_consts.underline+this.node_name+text_consts.open_par+text_consts.close_par);
			sw.WriteLine(text_consts.tab+text_consts.open_figure);
			
			string resize_part=
				text_consts.tab2+"if ("+this.node_name+"_size<="+this.node_name+"_count)"+text_consts.nr+
				text_consts.tab2+"{"+text_consts.nr+
				text_consts.tab2+this.node_name+"_size*=2;"+text_consts.nr+
				text_consts.tab2+this.node_name+"[] "+this.node_name+"_arrayold="+this.node_name+"_array;"+text_consts.nr+
				text_consts.tab2+this.node_name+"_array=new "+this.node_name+"["+this.node_name+"_size];"+text_consts.nr+
				text_consts.tab2+this.node_name+"_arrayold.CopyTo("+this.node_name+"_array,0);"+text_consts.nr+
				text_consts.tab2+"for (int i="+this.node_name+"_count;i<"+this.node_name+"_size;i++) "+this.node_name+"_array[i]=new "+this.node_name+"();"+text_consts.nr+
				text_consts.tab2+"}";
			
			sw.WriteLine(text_consts.tab2+this.node_name+"_count++"+text_consts.semicolon);
			sw.WriteLine(resize_part);
			
			string elem=this.node_name+"_array["+this.node_name+"_count-1]";
			
			string reset_elem="";
			for(int i=0;i<_subnodes.Count;i++)
			{
				if (!(_subnodes[i] is simple_element))
					reset_elem+=text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+"=null;"+text_consts.nr;
				if (_subnodes[i] is extended_simple_element)
					if (((extended_simple_element)_subnodes[i]).field_type_name.IndexOf("ArrayList")>=0)
						reset_elem+=text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+".Clear();"+text_consts.nr;
			}

			if(reset_elem!="")
			{
				sw.WriteLine(reset_elem);
			}
			
			sw.WriteLine(text_consts.tab2+"return "+elem+";");
			
			sw.WriteLine(text_consts.tab+text_consts.close_figure);

			sw.WriteLine();
			
			if (_subnodes.Count>0)
			{
				//tn(...)
				sw.Write(text_consts.tab+text_consts.public_keyword+text_consts.space+
					text_consts.space+
					node_name+text_consts.space+text_consts.new_keyword+text_consts.underline+this.node_name+text_consts.open_par);
				for(int i=0;i<_subnodes.Count-1;i++)
					sw.Write(subnode_variable(i)+text_consts.comma);
				if (_subnodes.Count>0)
					sw.Write(subnode_variable(_subnodes.Count-1));
				sw.WriteLine(text_consts.close_par);

				sw.WriteLine(text_consts.tab+text_consts.open_figure);
			
				sw.WriteLine(text_consts.tab2+this.node_name+"_count++"+text_consts.semicolon);
				sw.WriteLine(resize_part);
				
				reset_elem="";
				for(int i=0;i<_subnodes.Count;i++)
				{
						if (_subnodes[i] is extended_simple_element)
						if (((extended_simple_element)_subnodes[i]).field_type_name.IndexOf("ArrayList")>=0)
							reset_elem+=text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+".Clear();"+text_consts.nr;
				}

				if(reset_elem!="")
				{
					sw.WriteLine(reset_elem);
					
				}

				for(int i=0;i<_subnodes.Count;i++)
					sw.WriteLine(text_consts.tab2+elem+"."+((node_field_info)_subnodes[i]).field_name+"="+((node_field_info)_subnodes[i]).field_code_name+text_consts.semicolon);
			

				sw.WriteLine(text_consts.tab2+"return "+elem+";");

				sw.WriteLine(text_consts.tab+text_consts.close_figure);
			}

			sw.WriteLine();sw.WriteLine();
			
		}
		public void generate_fabric_create_part(StreamWriter sw)
		{
			sw.WriteLine(text_consts.tab2+this.node_name+"_size=start_size"+text_consts.semicolon);
			sw.WriteLine(text_consts.tab2+this.node_name+"_array=new "+this.node_name+"["+this.node_name+"_size];");
			sw.WriteLine(text_consts.tab2+"for (int i=0;i<"+this.node_name+"_size;i++) "+this.node_name+"_array[i]=new "+this.node_name+"();");
			sw.WriteLine();
		}
		public void generate_fabric_reset_part(StreamWriter sw)
		{
			
			sw.WriteLine(text_consts.tab2+this.node_name+"_count=0"+text_consts.semicolon);
			
		}

	}

	[Serializable]
	public class NodeGenerator
	{
		private ArrayList nodes=new ArrayList();
        private ArrayList unsorted_nodes = null;
		private string _file_name;
		private string _namespace_name;
		private string _factory_name;
		private string _visitor_interface_file_name;
        private string _pcu_writer_name;
        private string _pcu_writer_file_name;
        private string _pcu_reader_name;
        private string _pcu_reader_file_name;
        private string _pcu_reader_file_name_h;

        public void SortNodes()
        {
            unsorted_nodes = (ArrayList)nodes.Clone();
            nodes.Sort();
        }

        public void UnsortNodes()
        {
            if (unsorted_nodes != null)
                nodes = unsorted_nodes;
        }

        public string pcu_reader_file_name_h
        {
            get { return _pcu_reader_file_name_h; }
            set { _pcu_reader_file_name_h = value; }
        }
        private string _pcu_reader_file_name_cpp;

        public string pcu_reader_file_name_cpp
        {
            get { return _pcu_reader_file_name_cpp; }
            set { _pcu_reader_file_name_cpp = value; }
        }

		[NonSerialized]
		private HelpStorage hstr=new HelpStorage();

		public HelpStorage help_storage
		{
			get
			{
				return hstr;
			}
		}

		public void add_node(node_info ni)
		{
			nodes.Add(ni);
		}

		public ArrayList all_nodes
		{
			get
			{
				return nodes;
			}
			set
			{
				nodes.Clear();
				nodes.AddRange(value);
			}
		}

		public void set_nodes(ICollection tnodes)
		{
			nodes.Clear();
			nodes.AddRange(tnodes);
		}

		public string visitor_interface_file_name
		{
			get
			{
				return _visitor_interface_file_name;
			}
			set
			{
				_visitor_interface_file_name=value;
			}
		}

        public string pcu_writer_file_name
        {
            get
            {
                return _pcu_writer_file_name;
            }
            set
            {
                _pcu_writer_file_name = value;
            }
        }

        public string pcu_writer_name
        {
            get
            {
                return _pcu_writer_name;
            }
            set
            {
                _pcu_writer_name = value;
            }
        }

        public string pcu_reader_file_name
        {
            get
            {
                return _pcu_reader_file_name;
            }
            set
            {
                _pcu_reader_file_name = value;
            }
        }

        public string pcu_reader_name
        {
            get
            {
                return _pcu_reader_name;
            }
            set
            {
                _pcu_reader_name = value;
            }
        }

        public string factory_name
		{
			get
			{
				return _factory_name;
			}
			set
			{
				_factory_name=value;
			}
		}

		public string namespace_name
		{
			get
			{
				return _namespace_name;
			}
			set
			{
				_namespace_name=value;
			}
		}

		public string file_name
		{
			get
			{
				return _file_name;
			}
			set
			{
				_file_name=value;
			}
		}

		public void generate_pre_code(StreamWriter sw)
		{
			sw.WriteLine();

			sw.WriteLine(text_consts.namespace_keyword+text_consts.space+namespace_name);
			sw.WriteLine(text_consts.open_figure);
		}

        public void generate_post_code(StreamWriter sw)
		{
			sw.WriteLine();
			sw.WriteLine(text_consts.close_figure);
			sw.WriteLine();
		}

        public void generate_header_code(StreamWriter sw)
        {
            sw.WriteLine("/********************************************************************************************");
            sw.WriteLine("���� ���� ������ ����������");
            sw.WriteLine("PascalABC.NET: syntax tree generator  v1.5(�) ��������� �., ������ �.�., ������ �.�., 2007");
            sw.WriteLine();
            sw.WriteLine("������� �� �������������!");
            sw.WriteLine("*********************************************************************************************/");
            sw.WriteLine(text_consts.using_system);
            sw.WriteLine(text_consts.using_system_io);
        }

		public void generate_factory_class(StreamWriter sw)
		{
			sw.WriteLine();

			sw.WriteLine(text_consts.tab+text_consts.public_keyword+text_consts.space+text_consts.class_keyword+text_consts.space+factory_name);
			sw.WriteLine(text_consts.tab+text_consts.open_figure);

			sw.WriteLine();

			foreach(node_info ni in nodes)
			{
				ni.generate_creator_method(sw);
			}

			sw.WriteLine();

			sw.WriteLine(text_consts.tab+text_consts.close_figure);

			sw.WriteLine();
		}

		public void generate_visitor_interface_code()
		{
			StreamWriter sw=new StreamWriter(visitor_interface_file_name);
			generate_pre_code(sw);

			sw.WriteLine();

			sw.WriteLine(text_consts.tab+text_consts.public_keyword+text_consts.space+text_consts.interface_keyword+
				text_consts.space+
				text_consts.visitor_interface_name);

			sw.WriteLine(text_consts.tab+text_consts.open_figure);

			foreach(node_info ni in nodes)
			{
				ni.generate_visit_method_for_interface(sw);
			}

			sw.WriteLine(text_consts.tab+text_consts.close_figure);

			sw.WriteLine();

			generate_post_code(sw);

			sw.Flush();
			sw.Close();
		}

        public void generate_abstract_visitor_code()
        {
            StreamWriter sw = new StreamWriter(text_consts.abstract_visitor_file_name);
            generate_pre_code(sw);

            sw.WriteLine();

            sw.WriteLine(text_consts.tab + text_consts.public_keyword + text_consts.space + text_consts.class_keyword+
                text_consts.space +
                text_consts.abstract_visitor_class_name+ text_consts.colon+text_consts.space+text_consts.visitor_interface_name);

            sw.WriteLine(text_consts.tab + text_consts.open_figure);

            foreach (node_info ni in nodes)
            {
                ni.generate_visit_method_for_abstract_visitor(sw);
            }

            sw.WriteLine(text_consts.tab + text_consts.close_figure);

            sw.WriteLine();

            generate_post_code(sw);

            sw.Flush();
            sw.Close();
        }

        
        public void generate_visitor_template(string visitor_name,string visitor_template_file_name)
		{
			StreamWriter sw=new StreamWriter(visitor_template_file_name);
			generate_pre_code(sw);

			sw.WriteLine();

			sw.WriteLine(text_consts.tab+text_consts.class_keyword+text_consts.space+visitor_name+text_consts.space+
				text_consts.colon+text_consts.space+text_consts.visitor_interface_name);
			sw.WriteLine(text_consts.tab+text_consts.open_figure);
			
			foreach(node_info ni in nodes)
			{
				ni.generate_visit_method(sw);
			}

			sw.WriteLine(text_consts.tab+text_consts.close_figure);
			sw.WriteLine();

			generate_post_code(sw);

			sw.Flush();
			sw.Close();
		}

        public void generate_visitor_cpp(StreamWriter sw, string visitor_name)
        {
            sw.WriteLine();
            sw.WriteLine(text_consts.tab + text_consts.class_keyword + text_consts.space +
                visitor_name);
            sw.WriteLine(text_consts.tab + text_consts.open_figure);
            sw.WriteLine(text_consts.tab + text_consts.public_keyword + text_consts.colon);
            foreach (node_info ni in nodes)
            {
                ni.generate_visit_method_cpp(sw);
            }
            sw.WriteLine(text_consts.tab + text_consts.close_figure + text_consts.semicolon);
            sw.WriteLine();
        }
		
		public void generate_nodes_fabric(string fabric_name,string file_name)
		{
			StreamWriter sw=new StreamWriter(file_name);
			generate_pre_code(sw);

			sw.WriteLine();

			sw.WriteLine(text_consts.tab+text_consts.public_keyword+text_consts.space+text_consts.class_keyword+text_consts.space+fabric_name+text_consts.space);
			sw.WriteLine(text_consts.tab+text_consts.open_figure);
			
			foreach(node_info ni in nodes)
			{
				ni.generate_fabric_method(sw);
			}

			sw.WriteLine(text_consts.tab+text_consts.public_keyword+text_consts.space+fabric_name+"(int start_size)");
			sw.WriteLine(text_consts.tab+text_consts.open_figure);
			foreach(node_info ni in nodes)
			{
				ni.generate_fabric_create_part(sw);
			}
			sw.WriteLine(text_consts.tab+text_consts.close_figure);
			
			sw.WriteLine(text_consts.tab+text_consts.public_keyword+text_consts.space+"void reset()");
			sw.WriteLine(text_consts.tab+text_consts.open_figure);
			foreach(node_info ni in nodes)
			{
				ni.generate_fabric_reset_part(sw);
			}
			sw.WriteLine(text_consts.tab+text_consts.close_figure);

			sw.WriteLine(text_consts.tab+text_consts.close_figure);
			sw.WriteLine();

			generate_post_code(sw);

			sw.Flush();
			sw.Close();
		}

		public void generate_code()
		{
			StreamWriter sw=new StreamWriter(file_name);
			StreamWriter swt=new StreamWriter(file_name+".txt");

            sw.WriteLine();
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections;");
            sw.WriteLine("using System.Collections.Generic;");

            generate_pre_code(sw);

			foreach(node_info ni in nodes)
			{
				ni.generate_code(sw,this.help_storage);
			}
			foreach(node_info ni in nodes)
			{
				ni.generate_to_text(swt,this.help_storage);
			}

			//generate_factory_class(sw);

			generate_post_code(sw);

			generate_visitor_interface_code();

            generate_abstract_visitor_code();

			sw.Flush();
			sw.Close();
			swt.Flush();
			swt.Close();
		}

        public void generate_cpp_code()
        {
            int dot_pos = file_name.IndexOf('.');
            string name_of_file = file_name.Substring(0, dot_pos);
            StreamWriter sw_h = new StreamWriter(name_of_file + ".h");
            StreamWriter sw_cpp = new StreamWriter(name_of_file + ".cpp");

            sw_h.WriteLine();
            sw_h.WriteLine("#ifndef " + name_of_file.ToUpper() + "_H");
            sw_h.WriteLine("#define " + name_of_file.ToUpper() + "_H");
            sw_h.WriteLine();
            sw_h.WriteLine("#include \"TreeSubsidiary.h\"");
            sw_h.WriteLine("#include <vector>");
            sw_h.WriteLine("using namespace std;");

            sw_cpp.WriteLine("#include \"stdafx.h\"");
            sw_cpp.WriteLine("#include \"" + text_consts.visualizator_name + ".h" + "\"");

            generate_pre_code(sw_h);
            generate_pre_code(sw_cpp);

            foreach (node_info ni in nodes)
            {
                ni.generate_cpp_predef_code(sw_h);
            }

            generate_visitor_cpp(sw_h, text_consts.abstract_visitor_class_name);

            ArrayList tmp_nodes = new ArrayList(nodes);

            while (tmp_nodes.Count > 0)
            {
                int i = 0;
                while (i < tmp_nodes.Count)
                {
                    node_info ni = tmp_nodes[i] as node_info;
                    if (ni.base_class == null || !tmp_nodes.Contains(ni.base_class))
                    {
                        ni.generate_cpp_code(sw_h, sw_cpp, this.help_storage);
                        tmp_nodes.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            /*foreach (node_info ni in nodes)
            {
                ni.generate_cpp_code(sw, this.help_storage);
            }*/

            generate_post_code(sw_h);
            generate_post_code(sw_cpp);

            sw_h.WriteLine();
            sw_h.WriteLine("#endif");
            sw_h.WriteLine();

            sw_h.Flush();
            sw_h.Close();
            sw_cpp.Flush();
            sw_cpp.Close();
        }

        public void generate_pcu_writer_code(bool cross_platform)
        {
            string prefix = (cross_platform) ? "CP" : "";
            StreamWriter sw = new StreamWriter(prefix + pcu_writer_file_name);
            generate_header_code(sw);
            generate_pre_code(sw);

            sw.WriteLine();

            sw.WriteLine(text_consts.tab + text_consts.public_keyword + text_consts.space + text_consts.class_keyword +
                text_consts.space +
                prefix + pcu_writer_name + text_consts.colon +
                text_consts.visitor_interface_name);

            sw.WriteLine(text_consts.tab + text_consts.open_figure);

            sw.WriteLine();
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.public_keyword +
                text_consts.space + text_consts.BinaryWriter_classname +
                text_consts.space + text_consts.writer_name + text_consts.semicolon);
            sw.WriteLine();

            for (int i = 0; i < nodes.Count; i++)
            {
                ((node_info)nodes[i]).generate_pcu_writer(sw, i, cross_platform);
            }

            sw.WriteLine(text_consts.tab + text_consts.close_figure);

            sw.WriteLine();

            generate_post_code(sw);

            sw.Flush();
            sw.Close();
        }

        public void generate_vizualizator_cpp()
        {
            StreamWriter sw_h = new StreamWriter(text_consts.visualizator_name + ".h");
            StreamWriter sw_cpp = new StreamWriter(text_consts.visualizator_name + ".cpp");

            sw_h.WriteLine();
            sw_h.WriteLine("#ifndef " + text_consts.visualizator_name.ToUpper() + "_H");
            sw_h.WriteLine("#define " + text_consts.visualizator_name.ToUpper() + "_H");
            sw_h.WriteLine();
            sw_h.WriteLine("#include <vector>");
            sw_h.WriteLine("#include \"Tree.h\"");
            sw_h.WriteLine("using namespace std;");

            sw_cpp.WriteLine("#include \"stdafx.h\"");
            sw_cpp.WriteLine("#include \"" + text_consts.visualizator_name + ".h" + "\"");

            generate_pre_code(sw_h);
            generate_pre_code(sw_cpp);

            sw_h.WriteLine(text_consts.tab + text_consts.class_keyword +
                text_consts.space + text_consts.visualizator_name + text_consts.colon +
                text_consts.public_keyword + text_consts.space +
                text_consts.abstract_visitor_class_name);
            sw_h.WriteLine(text_consts.tab + text_consts.open_figure);
            sw_h.WriteLine(text_consts.tab + text_consts.public_keyword + text_consts.colon);
            sw_h.WriteLine(text_consts.tab2 + text_consts.int32_type_name_cpp +
                text_consts.space + text_consts.space_offset + text_consts.semicolon);
            sw_h.WriteLine(text_consts.tab + text_consts.tab +
                text_consts.ostream_classname +
                text_consts.space + text_consts.ostream_name + text_consts.semicolon);
            sw_h.WriteLine();

            //void PrintSpaces();

            //void TreePainter::PrintSpaces()
            //{
            //  for(int ssyy_i = 0; ssyy_i < nspace; ssyy_i++)
            //  {
            //      *os<<" ";
            //  }
            //}

            sw_h.WriteLine(text_consts.tab2 + text_consts.void_keyword +
                text_consts.space + text_consts.print_spaces_name +
                text_consts.open_par +
                text_consts.close_par + text_consts.semicolon);

            sw_cpp.WriteLine(text_consts.tab + text_consts.void_keyword +
                text_consts.space + text_consts.visualizator_name +
                text_consts.colon2 + text_consts.print_spaces_name +
                text_consts.open_par + text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.for_keyword_name +
                text_consts.open_par + text_consts.int32_type_name_cpp +
                text_consts.space + text_consts.cycle_i_name + text_consts.space +
                text_consts.assign + text_consts.space + text_consts.i0_keyword_name +
                text_consts.semicolon + text_consts.space + text_consts.cycle_i_name +
                text_consts.space + text_consts.less_keyword_name + text_consts.space +
                text_consts.space_offset + text_consts.semicolon +
                text_consts.space + text_consts.cycle_i_name + text_consts.increment_keyword_name +
                text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab3 + text_consts.ostream_name + text_consts.stream_out +
                text_consts.inverted_comma2 + text_consts.space + text_consts.inverted_comma2 +
                text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
            sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);

            //void print_node(tree_node *_tree_node);

            //void TreePainter::print_node(tree_node *_tree_node)
            //{
            //  if (_tree_node != null)
            //  {
            //      _tree_node->visit(this);
            //  }
            //}

            sw_h.WriteLine(text_consts.tab2 + text_consts.void_keyword +
                text_consts.space + text_consts.print_node_proc +
                text_consts.open_par + text_consts.base_tree_node_name +
                text_consts.space + text_consts.star + text_consts.underline +
                text_consts.base_tree_node_name +
                text_consts.close_par + text_consts.semicolon);

            sw_cpp.WriteLine();
            sw_cpp.WriteLine(text_consts.tab +
                text_consts.void_keyword + text_consts.space + 
                text_consts.visualizator_name + text_consts.colon2 +
                text_consts.print_node_proc +
                text_consts.open_par + text_consts.base_tree_node_name +
                text_consts.space + text_consts.star + text_consts.underline +
                text_consts.base_tree_node_name +
                text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab2 +
                text_consts.if_keyword_name + text_consts.open_par +
                text_consts.underline + text_consts.base_tree_node_name +
                text_consts.space + text_consts.not_equal_keyword_name +
                text_consts.space + text_consts.cpp_null_keyword_name +
                text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab3 + text_consts.underline +
                text_consts.base_tree_node_name + text_consts.arrow +
                text_consts.visit_method_name + text_consts.open_par +
                text_consts.this_keyword + text_consts.close_par +
                text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
            sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);

            for (int i = 0; i < nodes.Count; i++)
            {
                ((node_info)nodes[i]).generate_painter(sw_h, sw_cpp);
            }

            sw_h.WriteLine(text_consts.tab + text_consts.close_figure + text_consts.semicolon);
            sw_h.WriteLine();

            generate_post_code(sw_h);
            generate_post_code(sw_cpp);

            sw_h.WriteLine();
            sw_h.WriteLine("#endif");
            sw_h.WriteLine();

            sw_h.Flush();
            sw_h.Close();
            sw_cpp.Flush();
            sw_cpp.Close();
        }

        public void generate_stream_reader_cpp()
        {
            StreamWriter sw_h = new StreamWriter(pcu_reader_file_name_h);
            StreamWriter sw_cpp = new StreamWriter(pcu_reader_file_name_cpp);

            sw_h.WriteLine();
            sw_h.WriteLine("#ifndef " + pcu_reader_name.ToUpper() + "_H");
            sw_h.WriteLine("#define " + pcu_reader_name.ToUpper() + "_H");
            sw_h.WriteLine();
            sw_h.WriteLine("#include <vector>");
            sw_h.WriteLine("#include \"Tree.h\"");
            sw_h.WriteLine("#include \"Reader.h\"");
            sw_h.WriteLine("using namespace std;");

            sw_cpp.WriteLine("#include \"stdafx.h\"");
            sw_cpp.WriteLine("#include \"" + pcu_reader_file_name_h + "\"");

            generate_pre_code(sw_h);
            generate_pre_code(sw_cpp);

            sw_h.WriteLine(text_consts.tab + text_consts.class_keyword +
                text_consts.space + pcu_reader_name + text_consts.colon +
                text_consts.public_keyword + text_consts.space +
                text_consts.abstract_visitor_class_name);

            sw_h.WriteLine(text_consts.tab + text_consts.open_figure);
            sw_h.WriteLine(text_consts.tab + text_consts.public_keyword + text_consts.colon);
            sw_h.WriteLine(text_consts.tab + text_consts.tab +
                text_consts.CPP_reader_classname +
                text_consts.space + text_consts.reader_name + text_consts.semicolon);
            sw_h.WriteLine();

            //����� ����������� �����.

            //tree_node* construct_node(short node_class_number);
            
            //tree_node* SyntaxTreeReader::construct_node(short node_class_number)
            //{
            //  switch(node_class_number)
            //  {
            //      case <�����>:
            //          return new <����_������>();
            //      ...
            //  }
            //  return NULL;
            //}

            sw_h.WriteLine(text_consts.tab2 + text_consts.base_tree_node_name +
                text_consts.star +
                text_consts.space + text_consts.nodes_construct_method +
                text_consts.open_par + text_consts.cpp_short_name +
                text_consts.space + text_consts.param_number_name +
                text_consts.close_par + text_consts.semicolon);

            sw_cpp.WriteLine(text_consts.tab + text_consts.base_tree_node_name +
                text_consts.star + text_consts.space +
                pcu_reader_name + text_consts.colon2 +
                text_consts.nodes_construct_method +
                text_consts.open_par + text_consts.cpp_short_name +
                text_consts.space + text_consts.param_number_name +
                text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.switch_keyword_name +
                text_consts.open_par + text_consts.param_number_name +
                text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
            for (int i = 0; i < nodes.Count; i++)
            {
                sw_cpp.WriteLine(text_consts.tab3 +
                    text_consts.case_keyword_name + text_consts.space +
                    i.ToString() + text_consts.colon);
                sw_cpp.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.return_keyword + text_consts.space +
                    text_consts.new_keyword + text_consts.space +
                    ((node_info)nodes[i]).node_name + text_consts.open_par +
                    text_consts.close_par + text_consts.semicolon);
            }
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.return_keyword +
                text_consts.space + text_consts.cpp_null_keyword_name + text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);
            sw_cpp.WriteLine();

            //����� ��������� ������ ����

            //tree_node* read_node();

            //tree_node* SyntaxTreeReader::read_node()
            //{
            //  if (br.GetChar() == 1)
            //  {
            //      tree_node* ssyy_tmp = construct_node(br.GetShort());
            //      ssyy_tmp->visit(this);
            //      return ssyy_tmp;
            //  }
            //  else
            //  {
            //      return NULL;
            //  }
            //}

            sw_h.WriteLine(text_consts.tab2 + 
                text_consts.base_tree_node_name + text_consts.star + text_consts.space +
                text_consts.nodes_read_method + text_consts.open_par +
                text_consts.close_par + text_consts.semicolon);

            sw_cpp.WriteLine(text_consts.tab +
                text_consts.base_tree_node_name + text_consts.star + text_consts.space +
                pcu_reader_name + text_consts.colon2 +
                text_consts.nodes_read_method + text_consts.open_par +
                text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.if_keyword_name +
                text_consts.space + text_consts.open_par +
                text_consts.reader_name + text_consts.dot +
                text_consts.GetChar_proc_name + text_consts.open_par +
                text_consts.close_par + text_consts.space +
                text_consts.equal_keyword_name + text_consts.space +
                text_consts.i1_keyword_name + text_consts.close_par);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.tab +
                text_consts.base_tree_node_name + text_consts.space +
                text_consts.star +
                text_consts.temp_node_name + text_consts.space +
                text_consts.assign + text_consts.space +
                text_consts.nodes_construct_method + text_consts.open_par +
                text_consts.reader_name + text_consts.dot +
                text_consts.GetShort_proc_name + text_consts.open_par +
                text_consts.close_par + text_consts.close_par + text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.tab +
                text_consts.temp_node_name + text_consts.arrow +
                text_consts.visit_method_name + text_consts.open_par +
                text_consts.this_keyword + text_consts.close_par +
                text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.tab +
                text_consts.return_keyword + text_consts.space +
                text_consts.temp_node_name +
                text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.else_keyword_name);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.open_figure);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.tab +
                text_consts.return_keyword + text_consts.space +
                text_consts.cpp_null_keyword_name + text_consts.semicolon);
            sw_cpp.WriteLine(text_consts.tab2 + text_consts.close_figure);
            sw_cpp.WriteLine(text_consts.tab + text_consts.close_figure);
            sw_cpp.WriteLine();

            for (int i = 0; i < nodes.Count; i++)
            {
                ((node_info)nodes[i]).generate_stream_reader_cpp(sw_h, sw_cpp, pcu_reader_name);
            }

            sw_h.WriteLine(text_consts.tab + text_consts.close_figure + text_consts.semicolon);
            sw_h.WriteLine();

            generate_post_code(sw_h);
            generate_post_code(sw_cpp);

            sw_h.WriteLine();
            sw_h.WriteLine("#endif");
            sw_h.WriteLine();

            sw_h.Flush();
            sw_h.Close();
            sw_cpp.Flush();
            sw_cpp.Close();
        }

        public void generate_pcu_reader_code()
        {
            StreamWriter sw = new StreamWriter(pcu_reader_file_name);
            generate_header_code(sw);
            sw.WriteLine("using System.Collections.Generic;");
            generate_pre_code(sw);

            sw.WriteLine();

            sw.WriteLine(text_consts.tab + text_consts.public_keyword + text_consts.space + text_consts.class_keyword +
                text_consts.space +
                pcu_reader_name + text_consts.colon +
                text_consts.visitor_interface_name);

            sw.WriteLine(text_consts.tab + text_consts.open_figure);

            sw.WriteLine();
            sw.WriteLine(text_consts.tab + text_consts.tab + text_consts.public_keyword +
                text_consts.space + text_consts.BinaryReader_classname +
                text_consts.space + text_consts.reader_name + text_consts.semicolon);
            sw.WriteLine();

            //����� ����������� �����.
            //public tree_node construct_node(Int16 node_class_number)
            //{
            //  switch(node_class_number)
            //  {
            //      case <�����>:
            //          return new <����_������>();
            //      ...
            //  }
            //  return null;
            //}

            sw.WriteLine(text_consts.tab2 + text_consts.public_keyword +
                text_consts.space + text_consts.base_tree_node_name +
                text_consts.space + text_consts.nodes_construct_method +
                text_consts.open_par + text_consts.int16_type_name +
                text_consts.space + text_consts.param_number_name +
                text_consts.close_par);
            sw.WriteLine(text_consts.tab2 + text_consts.open_figure);
            sw.WriteLine(text_consts.tab3 + text_consts.switch_keyword_name +
                text_consts.open_par + text_consts.param_number_name +
                text_consts.close_par);
            sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
            for (int i = 0; i < nodes.Count; i++)
            {
                sw.WriteLine(text_consts.tab3 + text_consts.tab +
                    text_consts.case_keyword_name + text_consts.space +
                    i.ToString() + text_consts.colon);
                sw.WriteLine(text_consts.tab3 + text_consts.tab2 +
                    text_consts.return_keyword + text_consts.space +
                    text_consts.new_keyword + text_consts.space +
                    ((node_info)nodes[i]).node_name + text_consts.open_par +
                    text_consts.close_par + text_consts.semicolon);
            }
            sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
            sw.WriteLine(text_consts.tab3 + text_consts.return_keyword +
                text_consts.space + text_consts.null_keyword_name + text_consts.semicolon);
            sw.WriteLine(text_consts.tab2 + text_consts.close_figure);

            //����� ��������� ������ ����
            //public tree_node read_node()
            //{
            //  if (br.ReadByte() == 1)
            //  {
            //      tree_node ssyy_tmp = construct_node(br.ReadInt16());
            //      ssyy_tmp.visit(this);
            //      return ssyy_tmp;
            //  }
            //  else
            //  {
            //      return null;
            //  }
            //}

            sw.WriteLine(text_consts.tab2 + text_consts.public_keyword +
                text_consts.space +
                text_consts.base_tree_node_name + text_consts.space +
                text_consts.nodes_read_method + text_consts.open_par +
                text_consts.close_par);
            sw.WriteLine(text_consts.tab2 + text_consts.open_figure);
            sw.WriteLine(text_consts.tab3 + text_consts.if_keyword_name +
                text_consts.space + text_consts.open_par +
                text_consts.reader_name + text_consts.dot +
                text_consts.read_byte_name + text_consts.open_par +
                text_consts.close_par + text_consts.space +
                text_consts.equal_keyword_name + text_consts.space +
                text_consts.i1_keyword_name + text_consts.close_par);
            sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
            sw.WriteLine(text_consts.tab3 + text_consts.tab +
                text_consts.base_tree_node_name + text_consts.space +
                text_consts.temp_node_name + text_consts.space +
                text_consts.assign + text_consts.space +
                text_consts.nodes_construct_method + text_consts.open_par +
                text_consts.reader_name + text_consts.dot +
                text_consts.read_int16_name + text_consts.open_par +
                text_consts.close_par + text_consts.close_par + text_consts.semicolon);
            sw.WriteLine(text_consts.tab3 + text_consts.tab +
                text_consts.temp_node_name + text_consts.dot +
                text_consts.visit_method_name + text_consts.open_par +
                text_consts.this_keyword + text_consts.close_par +
                text_consts.semicolon);
            sw.WriteLine(text_consts.tab3 + text_consts.tab +
                text_consts.return_keyword + text_consts.space +
                text_consts.temp_node_name +
                text_consts.semicolon);
            sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
            sw.WriteLine(text_consts.tab3 + text_consts.else_keyword_name);
            sw.WriteLine(text_consts.tab3 + text_consts.open_figure);
            sw.WriteLine(text_consts.tab3 + text_consts.tab +
                text_consts.return_keyword + text_consts.space +
                text_consts.null_keyword_name + text_consts.semicolon);
            sw.WriteLine(text_consts.tab3 + text_consts.close_figure);
            sw.WriteLine(text_consts.tab2 + text_consts.close_figure);

            for (int i = 0; i < nodes.Count; i++)
            {
                ((node_info)nodes[i]).generate_pcu_reader(sw);
            }

            sw.WriteLine(text_consts.tab + text_consts.close_figure);

            sw.WriteLine();

            generate_post_code(sw);

            sw.Flush();
            sw.Close();
        }



		public void serialize(string file_name)
		{
			Stream str=File.Open(file_name,FileMode.Create);

			BinaryFormatter formatter=new BinaryFormatter();

			formatter.Serialize(str,this);

			str.Flush();
			str.Close();

			string fn2=Path.ChangeExtension(file_name,".hcnt");
			hstr.serialize(fn2);
		}

		public static NodeGenerator deserialize(string file_name)
		{
			Stream str=File.Open(file_name,FileMode.Open);
			
			BinaryFormatter formatter=new BinaryFormatter();

			object o=formatter.Deserialize(str);

			NodeGenerator ng=(o as NodeGenerator);

			//str.Flush();
			str.Close();

			string fn2=Path.ChangeExtension(file_name,".hcnt");
			
			HelpStorage hc=HelpStorage.deserialize(fn2);

			ng.hstr=hc;

			return ng;
		}

	}

}