// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g 2014-09-02 16:30:24

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;

using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime;
using Hashtable = System.Collections.Hashtable;

using Antlr.Runtime.Tree;
using ANTLR.Parser;

public partial class CalcETreeParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"Identifier", 
		"COMMENT", 
		"Literal", 
		"Letter", 
		"JavaIDDigit", 
		"IntegerLiteral", 
		"FloatingPointLiteral", 
		"CharacterLiteral", 
		"StringLiteral", 
		"BooleanLiteral", 
		"HexLiteral", 
		"OctalLiteral", 
		"DecimalLiteral", 
		"ElseIfStmt", 
		"ReturnType", 
		"Parameters", 
		"BlockName", 
		"ElseStmt", 
		"RateTypeParameter", 
		"InputParameters", 
		"OutputParameters", 
		"InvokeCondition", 
		"Dummy", 
		"RuleDummy", 
		"MetadataDummy", 
		"HexDigit", 
		"IntegerTypeSuffix", 
		"Exponent", 
		"FloatTypeSuffix", 
		"EscapeSequence", 
		"UnicodeEscape", 
		"OctalEscape", 
		"ENUM", 
		"ASSERT", 
		"WS", 
		"'{'", 
		"'}'", 
		"'metadata'", 
		"'return'", 
		"';'", 
		"'arguments'", 
		"'('", 
		"','", 
		"')'", 
		"'callBlock'", 
		"'['", 
		"']'", 
		"'invokeFormula'", 
		"'invokePricer'", 
		"'applyAdjustments'", 
		"'invokeIfExists'", 
		"'EXIT'", 
		"'OUTPUTCOMMENT'", 
		"'displayProperty'", 
		"'ifExists'", 
		"'endIfExists'", 
		"'forAll'", 
		"'endForAll'", 
		"'forAllValues'", 
		"'endForAllValues'", 
		"'PRICEPE'", 
		"'PRICEPECATEGORY'", 
		"'PRICEPC'", 
		"'PRICEPCCATEGORY'", 
		"'filter'", 
		"'if'", 
		"'then'", 
		"'endif'", 
		"'elseif'", 
		"'else'", 
		"'while'", 
		"'endWhile'", 
		"'invoke'", 
		"'multipleLookup'", 
		"'splitLookup'", 
		"'='", 
		"'OR'", 
		"'AND'", 
		"'IN'", 
		"'NOTIN'", 
		"'LE'", 
		"'GE'", 
		"'GT'", 
		"'LT'", 
		"'EQ'", 
		"'NE'", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'%'", 
		"'lookup'", 
		"'singleLookup'", 
		"'method'", 
		"'operandDisplayProperty'", 
		"'null'", 
		"'NOT'", 
		"'save'", 
		"'Variable'", 
		"'#'", 
		"'Constant'", 
		"'ObjectModel'", 
		"'varObjectModel'", 
		"'xPath'", 
		"'.'"
    };

    public const int FloatTypeSuffix = 32;
    public const int OctalLiteral = 15;
    public const int Dummy = 26;
    public const int ElseIfStmt = 17;
    public const int EOF = -1;
    public const int Identifier = 4;
    public const int RuleDummy = 27;
    public const int T__93 = 93;
    public const int T__94 = 94;
    public const int T__91 = 91;
    public const int T__92 = 92;
    public const int T__90 = 90;
    public const int COMMENT = 5;
    public const int T__99 = 99;
    public const int T__98 = 98;
    public const int T__97 = 97;
    public const int InvokeCondition = 25;
    public const int T__96 = 96;
    public const int T__95 = 95;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int IntegerTypeSuffix = 30;
    public const int ElseStmt = 21;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int ASSERT = 37;
    public const int T__87 = 87;
    public const int RateTypeParameter = 22;
    public const int T__86 = 86;
    public const int T__89 = 89;
    public const int T__88 = 88;
    public const int WS = 38;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int ReturnType = 18;
    public const int FloatingPointLiteral = 10;
    public const int JavaIDDigit = 8;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int EscapeSequence = 33;
    public const int T__73 = 73;
    public const int Letter = 7;
    public const int T__79 = 79;
    public const int BooleanLiteral = 13;
    public const int T__78 = 78;
    public const int T__77 = 77;
    public const int InputParameters = 23;
    public const int T__68 = 68;
    public const int MetadataDummy = 28;
    public const int T__69 = 69;
    public const int Parameters = 19;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int CharacterLiteral = 11;
    public const int Exponent = 31;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int HexDigit = 29;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Literal = 6;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__107 = 107;
    public const int T__108 = 108;
    public const int T__59 = 59;
    public const int T__103 = 103;
    public const int T__104 = 104;
    public const int T__105 = 105;
    public const int BlockName = 20;
    public const int T__106 = 106;
    public const int T__50 = 50;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int HexLiteral = 14;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int T__102 = 102;
    public const int T__101 = 101;
    public const int T__100 = 100;
    public const int DecimalLiteral = 16;
    public const int StringLiteral = 12;
    public const int ENUM = 36;
    public const int T__39 = 39;
    public const int UnicodeEscape = 34;
    public const int OutputParameters = 24;
    public const int IntegerLiteral = 9;
    public const int OctalEscape = 35;

    // delegates
    // delegators



        public CalcETreeParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public CalcETreeParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[175+1];
             
             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return CalcETreeParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g"; }
    }


    TypeCastImpl objTypeCast  = new   TypeCastImpl();

    public static int Counter = 0;

    public  List<string> doubleMethods=new List<string>()
    {"ABS","POWER","ROUND","ROUNDUP","ROUNDDOWN","ROUNDHALFDOWN","ROUNDNEAREST","BROUND","TRUNCATE","MAX","MIN","AVERAGE"
    ,"AGGREGATEBYVALUES","AGGREGATEBYENTITY","PV","PMT"
    ,"PPMT","NPV","NPER","IRR","IPMT","FV","SUM","PRORATE","CONVERTINTEGERTODOUBLE","CONVERTSTRINGTODOUBLE"};

    public static List<string> integerMethods=new List<string>(){"CEILING","MOD","FLOOR","DATEDIFFINYEARS","DATEDIFFINMONTHS","DATEDIFFINDAYS","DAYSINMONTH","DAY","MONTH","YEAR","TIMEDIFFINHOURS","COUNT","CONVERTSTRINGTOINTEGER","CONVERTDOUBLETOINTEGER","CONVERTBOOLEANTOINTEGER"};

    public static List<string> stringMethods=new List<string>(){"LOWER","UPPER","CONCATENATE","ISAVAILABLE","CONVERTBOOLEANTOSTRING","CONVERTINTEGERTOSTRING","CONVERTDOUBLETOSTRING","CONVERTDATETOSTRING","CONVERTTOSTRING"};

    public static List<string> dateMethods=new List<string>(){"FIRSTDAY","DATEADD","NUMERIC","GETDATE","TODAY","CONVERTSTRINGTODATE"};

    public static List<string> anyMethods = new List<string>() { "CREATENEW", "GETBYINDEX" };

    public static List<string> boolMethods=new List<string>(){"STARTSWITH","CONVERTSTRINGTOBOOLEAN","CONVERTINTEGERTOBOOLEAN"};

    public List<string> noneMethods=new List<string>(){"RESETDOMAIN","SET","CLEAR","RANK","SORT"};

    public List<string> arrayMethods = new List<string>(){"ADD","ADDALL","ADDBYINDEX","GET","REMOVE","REMOVEBYINDEX"};

    public static List<string> dualMethods = new List<string>() { "MAX", "MIN", "SUM", "MOD" };

    public static List<string> decimalMethods = new List<string>(){"ABS","ROUNDUP","ROUNDDOWN","ROUNDHALFDOWN","BROUND","ROUNDNEAREST"};

    public List<string> roundMethod = new List<string>(){"ROUND"};
    	
    public List<string> primitiveTypes = new List<string>(){"DATE","DOUBLE","STRING","TEXT","BOOLEAN","BOOL","DATETIME","INTEGER"};

    public List<string> DualParamMethods = new List<string>(){"ROUNDUP","ROUNDDOWN","ROUNDHALFDOWN","BROUND","ROUNDNEAREST","TRUNCATE","POWER","MOD"};

    public List<string> SingleParamMethods = new List<string>(){"ABS","CEILING","FLOOR"};

    internal bool  isValidate = true;


    public class block_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "block"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:70:1: block : '{' ( blockStatement )* '}' ;
    public CalcETreeParser.block_return block() // throws RecognitionException [1]
    {   
        CalcETreeParser.block_return retval = new CalcETreeParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal1 = null;
        IToken char_literal3 = null;
        CalcETreeParser.blockStatement_return blockStatement2 = default(CalcETreeParser.blockStatement_return);


        CommonTree char_literal1_tree=null;
        CommonTree char_literal3_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:71:3: ( '{' ( blockStatement )* '}' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:72:3: '{' ( blockStatement )* '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal1=(IToken)Match(input,39,FOLLOW_39_in_block86); if (state.failed) return retval;
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:72:8: ( blockStatement )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == COMMENT || (LA1_0 >= 41 && LA1_0 <= 43) || LA1_0 == 48 || (LA1_0 >= 51 && LA1_0 <= 53) || (LA1_0 >= 55 && LA1_0 <= 56) || LA1_0 == 58 || LA1_0 == 60 || LA1_0 == 62 || (LA1_0 >= 64 && LA1_0 <= 67) || LA1_0 == 69 || LA1_0 == 74 || (LA1_0 >= 76 && LA1_0 <= 78) || (LA1_0 >= 95 && LA1_0 <= 97) || (LA1_0 >= 101 && LA1_0 <= 102) || (LA1_0 >= 105 && LA1_0 <= 107)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: blockStatement
            			    {
            			    	PushFollow(FOLLOW_blockStatement_in_block89);
            			    	blockStatement2 = blockStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement2.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	char_literal3=(IToken)Match(input,40,FOLLOW_40_in_block92); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, block_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "block"

    public class blockStatement_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "blockStatement"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:75:1: blockStatement : statement ;
    public CalcETreeParser.blockStatement_return blockStatement() // throws RecognitionException [1]
    {   
        CalcETreeParser.blockStatement_return retval = new CalcETreeParser.blockStatement_return();
        retval.Start = input.LT(1);
        int blockStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.statement_return statement4 = default(CalcETreeParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:76:3: ( statement )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:77:3: statement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_statement_in_blockStatement108);
            	statement4 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement4.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, blockStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "blockStatement"

    public class statement_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:80:1: statement : ( 'metadata' ( identifier primary )* ( inputArguments )? ( blockReturnType )? -> ^( 'metadata' ( ^( Dummy identifier primary ) )* ( inputArguments )? ( blockReturnType )? ) | 'return' ( rhsEntities )? ';' -> ^( 'return' ( rhsEntities )? ) | statements | ';' );
    public CalcETreeParser.statement_return statement() // throws RecognitionException [1]
    {   
        CalcETreeParser.statement_return retval = new CalcETreeParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal5 = null;
        IToken string_literal10 = null;
        IToken char_literal12 = null;
        IToken char_literal14 = null;
        CalcETreeParser.identifier_return identifier6 = default(CalcETreeParser.identifier_return);

        CalcETreeParser.primary_return primary7 = default(CalcETreeParser.primary_return);

        CalcETreeParser.inputArguments_return inputArguments8 = default(CalcETreeParser.inputArguments_return);

        CalcETreeParser.blockReturnType_return blockReturnType9 = default(CalcETreeParser.blockReturnType_return);

        CalcETreeParser.rhsEntities_return rhsEntities11 = default(CalcETreeParser.rhsEntities_return);

        CalcETreeParser.statements_return statements13 = default(CalcETreeParser.statements_return);


        CommonTree string_literal5_tree=null;
        CommonTree string_literal10_tree=null;
        CommonTree char_literal12_tree=null;
        CommonTree char_literal14_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleSubtreeStream stream_primary = new RewriteRuleSubtreeStream(adaptor,"rule primary");
        RewriteRuleSubtreeStream stream_inputArguments = new RewriteRuleSubtreeStream(adaptor,"rule inputArguments");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        RewriteRuleSubtreeStream stream_rhsEntities = new RewriteRuleSubtreeStream(adaptor,"rule rhsEntities");
        RewriteRuleSubtreeStream stream_blockReturnType = new RewriteRuleSubtreeStream(adaptor,"rule blockReturnType");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:81:3: ( 'metadata' ( identifier primary )* ( inputArguments )? ( blockReturnType )? -> ^( 'metadata' ( ^( Dummy identifier primary ) )* ( inputArguments )? ( blockReturnType )? ) | 'return' ( rhsEntities )? ';' -> ^( 'return' ( rhsEntities )? ) | statements | ';' )
            int alt6 = 4;
            switch ( input.LA(1) ) 
            {
            case 41:
            	{
                alt6 = 1;
                }
                break;
            case 42:
            	{
                alt6 = 2;
                }
                break;
            case COMMENT:
            case 48:
            case 51:
            case 52:
            case 53:
            case 55:
            case 56:
            case 58:
            case 60:
            case 62:
            case 64:
            case 65:
            case 66:
            case 67:
            case 69:
            case 74:
            case 76:
            case 77:
            case 78:
            case 95:
            case 96:
            case 97:
            case 101:
            case 102:
            case 105:
            case 106:
            case 107:
            	{
                alt6 = 3;
                }
                break;
            case 43:
            	{
                alt6 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:82:3: 'metadata' ( identifier primary )* ( inputArguments )? ( blockReturnType )?
                    {
                    	string_literal5=(IToken)Match(input,41,FOLLOW_41_in_statement123); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_41.Add(string_literal5);

                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:82:14: ( identifier primary )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( (LA2_0 == Identifier) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:82:15: identifier primary
                    			    {
                    			    	PushFollow(FOLLOW_identifier_in_statement126);
                    			    	identifier6 = identifier();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_identifier.Add(identifier6.Tree);
                    			    	PushFollow(FOLLOW_primary_in_statement128);
                    			    	primary7 = primary();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_primary.Add(primary7.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:82:36: ( inputArguments )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 44) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: inputArguments
                    	        {
                    	        	PushFollow(FOLLOW_inputArguments_in_statement132);
                    	        	inputArguments8 = inputArguments();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_inputArguments.Add(inputArguments8.Tree);

                    	        }
                    	        break;

                    	}

                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:82:52: ( blockReturnType )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 45) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: blockReturnType
                    	        {
                    	        	PushFollow(FOLLOW_blockReturnType_in_statement135);
                    	        	blockReturnType9 = blockReturnType();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_blockReturnType.Add(blockReturnType9.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          inputArguments, identifier, 41, blockReturnType, primary
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 83:5: -> ^( 'metadata' ( ^( Dummy identifier primary ) )* ( inputArguments )? ( blockReturnType )? )
                    	{
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:84:7: ^( 'metadata' ( ^( Dummy identifier primary ) )* ( inputArguments )? ( blockReturnType )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_41.NextNode(), root_1);

                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:86:9: ( ^( Dummy identifier primary ) )*
                    	    while ( stream_identifier.HasNext() || stream_primary.HasNext() )
                    	    {
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:86:9: ^( Dummy identifier primary )
                    	        {
                    	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(Dummy, "Dummy"), root_2);

                    	        adaptor.AddChild(root_2, stream_identifier.NextTree());
                    	        adaptor.AddChild(root_2, stream_primary.NextTree());

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_identifier.Reset();
                    	    stream_primary.Reset();
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:87:9: ( inputArguments )?
                    	    if ( stream_inputArguments.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_inputArguments.NextTree());

                    	    }
                    	    stream_inputArguments.Reset();
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:87:25: ( blockReturnType )?
                    	    if ( stream_blockReturnType.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_blockReturnType.NextTree());

                    	    }
                    	    stream_blockReturnType.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:89:5: 'return' ( rhsEntities )? ';'
                    {
                    	string_literal10=(IToken)Match(input,42,FOLLOW_42_in_statement207); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_42.Add(string_literal10);

                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:89:14: ( rhsEntities )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == Literal || LA5_0 == 48 || (LA5_0 >= 64 && LA5_0 <= 67) || LA5_0 == 97 || LA5_0 == 99 || LA5_0 == 102 || (LA5_0 >= 104 && LA5_0 <= 107)) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: rhsEntities
                    	        {
                    	        	PushFollow(FOLLOW_rhsEntities_in_statement209);
                    	        	rhsEntities11 = rhsEntities();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_rhsEntities.Add(rhsEntities11.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal12=(IToken)Match(input,43,FOLLOW_43_in_statement212); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_43.Add(char_literal12);



                    	// AST REWRITE
                    	// elements:          rhsEntities, 42
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 90:5: -> ^( 'return' ( rhsEntities )? )
                    	{
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:91:7: ^( 'return' ( rhsEntities )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_42.NextNode(), root_1);

                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:91:18: ( rhsEntities )?
                    	    if ( stream_rhsEntities.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_rhsEntities.NextTree());

                    	    }
                    	    stream_rhsEntities.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:92:5: statements
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statements_in_statement237);
                    	statements13 = statements();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statements13.Tree);

                    }
                    break;
                case 4 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:93:5: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal14=(IToken)Match(input,43,FOLLOW_43_in_statement243); if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, statement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class inputArguments_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "inputArguments"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:96:1: inputArguments : 'arguments' '(' lhsEntities ( ',' lhsEntities )* ')' -> ^( 'arguments' lhsEntities ( lhsEntities )* ) ;
    public CalcETreeParser.inputArguments_return inputArguments() // throws RecognitionException [1]
    {   
        CalcETreeParser.inputArguments_return retval = new CalcETreeParser.inputArguments_return();
        retval.Start = input.LT(1);
        int inputArguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal15 = null;
        IToken char_literal16 = null;
        IToken char_literal18 = null;
        IToken char_literal20 = null;
        CalcETreeParser.lhsEntities_return lhsEntities17 = default(CalcETreeParser.lhsEntities_return);

        CalcETreeParser.lhsEntities_return lhsEntities19 = default(CalcETreeParser.lhsEntities_return);


        CommonTree string_literal15_tree=null;
        CommonTree char_literal16_tree=null;
        CommonTree char_literal18_tree=null;
        CommonTree char_literal20_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_lhsEntities = new RewriteRuleSubtreeStream(adaptor,"rule lhsEntities");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:97:3: ( 'arguments' '(' lhsEntities ( ',' lhsEntities )* ')' -> ^( 'arguments' lhsEntities ( lhsEntities )* ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:98:3: 'arguments' '(' lhsEntities ( ',' lhsEntities )* ')'
            {
            	string_literal15=(IToken)Match(input,44,FOLLOW_44_in_inputArguments259); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(string_literal15);

            	char_literal16=(IToken)Match(input,45,FOLLOW_45_in_inputArguments261); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal16);

            	PushFollow(FOLLOW_lhsEntities_in_inputArguments263);
            	lhsEntities17 = lhsEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_lhsEntities.Add(lhsEntities17.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:98:31: ( ',' lhsEntities )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 46) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:98:32: ',' lhsEntities
            			    {
            			    	char_literal18=(IToken)Match(input,46,FOLLOW_46_in_inputArguments266); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_46.Add(char_literal18);

            			    	PushFollow(FOLLOW_lhsEntities_in_inputArguments268);
            			    	lhsEntities19 = lhsEntities();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_lhsEntities.Add(lhsEntities19.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	char_literal20=(IToken)Match(input,47,FOLLOW_47_in_inputArguments272); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal20);



            	// AST REWRITE
            	// elements:          lhsEntities, lhsEntities, 44
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 99:5: -> ^( 'arguments' lhsEntities ( lhsEntities )* )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:100:7: ^( 'arguments' lhsEntities ( lhsEntities )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_44.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_lhsEntities.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:100:33: ( lhsEntities )*
            	    while ( stream_lhsEntities.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_lhsEntities.NextTree());

            	    }
            	    stream_lhsEntities.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, inputArguments_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "inputArguments"

    public class blockReturnType_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "blockReturnType"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:103:1: blockReturnType : '(' Identifier ')' ;
    public CalcETreeParser.blockReturnType_return blockReturnType() // throws RecognitionException [1]
    {   
        CalcETreeParser.blockReturnType_return retval = new CalcETreeParser.blockReturnType_return();
        retval.Start = input.LT(1);
        int blockReturnType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal21 = null;
        IToken Identifier22 = null;
        IToken char_literal23 = null;

        CommonTree char_literal21_tree=null;
        CommonTree Identifier22_tree=null;
        CommonTree char_literal23_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:104:3: ( '(' Identifier ')' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:104:5: '(' Identifier ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal21=(IToken)Match(input,45,FOLLOW_45_in_blockReturnType306); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal21_tree = (CommonTree)adaptor.Create(char_literal21);
            		adaptor.AddChild(root_0, char_literal21_tree);
            	}
            	Identifier22=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_blockReturnType308); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier22_tree = (CommonTree)adaptor.Create(Identifier22);
            		adaptor.AddChild(root_0, Identifier22_tree);
            	}
            	char_literal23=(IToken)Match(input,47,FOLLOW_47_in_blockReturnType310); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal23_tree = (CommonTree)adaptor.Create(char_literal23);
            		adaptor.AddChild(root_0, char_literal23_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, blockReturnType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "blockReturnType"

    public class statementsExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statementsExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:106:1: statementsExpression : ( statements )* ;
    public CalcETreeParser.statementsExpression_return statementsExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.statementsExpression_return retval = new CalcETreeParser.statementsExpression_return();
        retval.Start = input.LT(1);
        int statementsExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.statements_return statements24 = default(CalcETreeParser.statements_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:107:3: ( ( statements )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:108:3: ( statements )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:108:3: ( statements )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == COMMENT || LA8_0 == 48 || (LA8_0 >= 51 && LA8_0 <= 53) || (LA8_0 >= 55 && LA8_0 <= 56) || LA8_0 == 58 || LA8_0 == 60 || LA8_0 == 62 || (LA8_0 >= 64 && LA8_0 <= 67) || LA8_0 == 69 || LA8_0 == 74 || (LA8_0 >= 76 && LA8_0 <= 78) || (LA8_0 >= 95 && LA8_0 <= 97) || (LA8_0 >= 101 && LA8_0 <= 102) || (LA8_0 >= 105 && LA8_0 <= 107)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: statements
            			    {
            			    	PushFollow(FOLLOW_statements_in_statementsExpression329);
            			    	statements24 = statements();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statements24.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, statementsExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statementsExpression"

    public class statements_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statements"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:111:1: statements : expression ';' ;
    public CalcETreeParser.statements_return statements() // throws RecognitionException [1]
    {   
        CalcETreeParser.statements_return retval = new CalcETreeParser.statements_return();
        retval.Start = input.LT(1);
        int statements_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal26 = null;
        CalcETreeParser.expression_return expression25 = default(CalcETreeParser.expression_return);


        CommonTree char_literal26_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:112:3: ( expression ';' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:113:3: expression ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	if ( (state.backtracking==0) )
            	{
            	  Counter++;
            	}
            	PushFollow(FOLLOW_expression_in_statements349);
            	expression25 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression25.Tree);
            	char_literal26=(IToken)Match(input,43,FOLLOW_43_in_statements351); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal26_tree = (CommonTree)adaptor.Create(char_literal26);
            		adaptor.AddChild(root_0, char_literal26_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, statements_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statements"

    public class expression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:117:1: expression : ( assignExpression displayExpression -> displayExpression assignExpression | invokeExpression ( invokeConditionExpression )? displayExpression -> ^( invokeExpression displayExpression ( ^( InvokeCondition invokeConditionExpression ) )? ) | ifExpression | whileExpression | saveExpression displayExpression -> displayExpression saveExpression | forAll | ifExistsExpression | multipleLookupExpression displayExpression -> displayExpression multipleLookupExpression | splitLookupExpression displayExpression -> displayExpression splitLookupExpression | forAllValuesExpression | methodexpression displayExpression -> displayExpression methodexpression | callBlock displayExpression -> displayExpression callBlock | invokeFormula displayExpression -> displayExpression invokeFormula | outputConmmentsExpression displayExpression -> displayExpression outputConmmentsExpression | exitExpression displayExpression -> displayExpression exitExpression | priceExpression displayExpression -> displayExpression priceExpression | lookupExpression displayExpression -> displayExpression lookupExpression | invokePricer displayExpression -> displayExpression invokePricer | applyAdjustmanets displayExpression -> displayExpression applyAdjustmanets | COMMENT );
    public CalcETreeParser.expression_return expression() // throws RecognitionException [1]
    {   
        CalcETreeParser.expression_return retval = new CalcETreeParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken COMMENT61 = null;
        CalcETreeParser.assignExpression_return assignExpression27 = default(CalcETreeParser.assignExpression_return);

        CalcETreeParser.displayExpression_return displayExpression28 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.invokeExpression_return invokeExpression29 = default(CalcETreeParser.invokeExpression_return);

        CalcETreeParser.invokeConditionExpression_return invokeConditionExpression30 = default(CalcETreeParser.invokeConditionExpression_return);

        CalcETreeParser.displayExpression_return displayExpression31 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.ifExpression_return ifExpression32 = default(CalcETreeParser.ifExpression_return);

        CalcETreeParser.whileExpression_return whileExpression33 = default(CalcETreeParser.whileExpression_return);

        CalcETreeParser.saveExpression_return saveExpression34 = default(CalcETreeParser.saveExpression_return);

        CalcETreeParser.displayExpression_return displayExpression35 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.forAll_return forAll36 = default(CalcETreeParser.forAll_return);

        CalcETreeParser.ifExistsExpression_return ifExistsExpression37 = default(CalcETreeParser.ifExistsExpression_return);

        CalcETreeParser.multipleLookupExpression_return multipleLookupExpression38 = default(CalcETreeParser.multipleLookupExpression_return);

        CalcETreeParser.displayExpression_return displayExpression39 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.splitLookupExpression_return splitLookupExpression40 = default(CalcETreeParser.splitLookupExpression_return);

        CalcETreeParser.displayExpression_return displayExpression41 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.forAllValuesExpression_return forAllValuesExpression42 = default(CalcETreeParser.forAllValuesExpression_return);

        CalcETreeParser.methodexpression_return methodexpression43 = default(CalcETreeParser.methodexpression_return);

        CalcETreeParser.displayExpression_return displayExpression44 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.callBlock_return callBlock45 = default(CalcETreeParser.callBlock_return);

        CalcETreeParser.displayExpression_return displayExpression46 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.invokeFormula_return invokeFormula47 = default(CalcETreeParser.invokeFormula_return);

        CalcETreeParser.displayExpression_return displayExpression48 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.outputConmmentsExpression_return outputConmmentsExpression49 = default(CalcETreeParser.outputConmmentsExpression_return);

        CalcETreeParser.displayExpression_return displayExpression50 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.exitExpression_return exitExpression51 = default(CalcETreeParser.exitExpression_return);

        CalcETreeParser.displayExpression_return displayExpression52 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.priceExpression_return priceExpression53 = default(CalcETreeParser.priceExpression_return);

        CalcETreeParser.displayExpression_return displayExpression54 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.lookupExpression_return lookupExpression55 = default(CalcETreeParser.lookupExpression_return);

        CalcETreeParser.displayExpression_return displayExpression56 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.invokePricer_return invokePricer57 = default(CalcETreeParser.invokePricer_return);

        CalcETreeParser.displayExpression_return displayExpression58 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.applyAdjustmanets_return applyAdjustmanets59 = default(CalcETreeParser.applyAdjustmanets_return);

        CalcETreeParser.displayExpression_return displayExpression60 = default(CalcETreeParser.displayExpression_return);


        CommonTree COMMENT61_tree=null;
        RewriteRuleSubtreeStream stream_applyAdjustmanets = new RewriteRuleSubtreeStream(adaptor,"rule applyAdjustmanets");
        RewriteRuleSubtreeStream stream_lookupExpression = new RewriteRuleSubtreeStream(adaptor,"rule lookupExpression");
        RewriteRuleSubtreeStream stream_displayExpression = new RewriteRuleSubtreeStream(adaptor,"rule displayExpression");
        RewriteRuleSubtreeStream stream_assignExpression = new RewriteRuleSubtreeStream(adaptor,"rule assignExpression");
        RewriteRuleSubtreeStream stream_invokeConditionExpression = new RewriteRuleSubtreeStream(adaptor,"rule invokeConditionExpression");
        RewriteRuleSubtreeStream stream_methodexpression = new RewriteRuleSubtreeStream(adaptor,"rule methodexpression");
        RewriteRuleSubtreeStream stream_outputConmmentsExpression = new RewriteRuleSubtreeStream(adaptor,"rule outputConmmentsExpression");
        RewriteRuleSubtreeStream stream_invokeFormula = new RewriteRuleSubtreeStream(adaptor,"rule invokeFormula");
        RewriteRuleSubtreeStream stream_saveExpression = new RewriteRuleSubtreeStream(adaptor,"rule saveExpression");
        RewriteRuleSubtreeStream stream_splitLookupExpression = new RewriteRuleSubtreeStream(adaptor,"rule splitLookupExpression");
        RewriteRuleSubtreeStream stream_exitExpression = new RewriteRuleSubtreeStream(adaptor,"rule exitExpression");
        RewriteRuleSubtreeStream stream_invokeExpression = new RewriteRuleSubtreeStream(adaptor,"rule invokeExpression");
        RewriteRuleSubtreeStream stream_multipleLookupExpression = new RewriteRuleSubtreeStream(adaptor,"rule multipleLookupExpression");
        RewriteRuleSubtreeStream stream_callBlock = new RewriteRuleSubtreeStream(adaptor,"rule callBlock");
        RewriteRuleSubtreeStream stream_invokePricer = new RewriteRuleSubtreeStream(adaptor,"rule invokePricer");
        RewriteRuleSubtreeStream stream_priceExpression = new RewriteRuleSubtreeStream(adaptor,"rule priceExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:118:3: ( assignExpression displayExpression -> displayExpression assignExpression | invokeExpression ( invokeConditionExpression )? displayExpression -> ^( invokeExpression displayExpression ( ^( InvokeCondition invokeConditionExpression ) )? ) | ifExpression | whileExpression | saveExpression displayExpression -> displayExpression saveExpression | forAll | ifExistsExpression | multipleLookupExpression displayExpression -> displayExpression multipleLookupExpression | splitLookupExpression displayExpression -> displayExpression splitLookupExpression | forAllValuesExpression | methodexpression displayExpression -> displayExpression methodexpression | callBlock displayExpression -> displayExpression callBlock | invokeFormula displayExpression -> displayExpression invokeFormula | outputConmmentsExpression displayExpression -> displayExpression outputConmmentsExpression | exitExpression displayExpression -> displayExpression exitExpression | priceExpression displayExpression -> displayExpression priceExpression | lookupExpression displayExpression -> displayExpression lookupExpression | invokePricer displayExpression -> displayExpression invokePricer | applyAdjustmanets displayExpression -> displayExpression applyAdjustmanets | COMMENT )
            int alt10 = 20;
            switch ( input.LA(1) ) 
            {
            case 102:
            case 105:
            case 106:
            case 107:
            	{
                alt10 = 1;
                }
                break;
            case 76:
            	{
                alt10 = 2;
                }
                break;
            case 69:
            	{
                alt10 = 3;
                }
                break;
            case 74:
            	{
                alt10 = 4;
                }
                break;
            case 101:
            	{
                alt10 = 5;
                }
                break;
            case 60:
            	{
                alt10 = 6;
                }
                break;
            case 58:
            	{
                alt10 = 7;
                }
                break;
            case 77:
            	{
                alt10 = 8;
                }
                break;
            case 78:
            	{
                alt10 = 9;
                }
                break;
            case 62:
            	{
                alt10 = 10;
                }
                break;
            case 97:
            	{
                alt10 = 11;
                }
                break;
            case 48:
            	{
                alt10 = 12;
                }
                break;
            case 51:
            	{
                alt10 = 13;
                }
                break;
            case 56:
            	{
                alt10 = 14;
                }
                break;
            case 55:
            	{
                alt10 = 15;
                }
                break;
            case 64:
            case 65:
            case 66:
            case 67:
            	{
                alt10 = 16;
                }
                break;
            case 95:
            case 96:
            	{
                alt10 = 17;
                }
                break;
            case 52:
            	{
                alt10 = 18;
                }
                break;
            case 53:
            	{
                alt10 = 19;
                }
                break;
            case COMMENT:
            	{
                alt10 = 20;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:119:3: assignExpression displayExpression
                    {
                    	PushFollow(FOLLOW_assignExpression_in_expression366);
                    	assignExpression27 = assignExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_assignExpression.Add(assignExpression27.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression368);
                    	displayExpression28 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression28.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, assignExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 120:5: -> displayExpression assignExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_assignExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:121:5: invokeExpression ( invokeConditionExpression )? displayExpression
                    {
                    	PushFollow(FOLLOW_invokeExpression_in_expression384);
                    	invokeExpression29 = invokeExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_invokeExpression.Add(invokeExpression29.Tree);
                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:121:22: ( invokeConditionExpression )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( (LA9_0 == Literal || LA9_0 == 45 || LA9_0 == 48 || LA9_0 == 54 || (LA9_0 >= 64 && LA9_0 <= 67) || (LA9_0 >= 95 && LA9_0 <= 97) || (LA9_0 >= 99 && LA9_0 <= 100) || LA9_0 == 102 || (LA9_0 >= 104 && LA9_0 <= 107)) )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: invokeConditionExpression
                    	        {
                    	        	PushFollow(FOLLOW_invokeConditionExpression_in_expression386);
                    	        	invokeConditionExpression30 = invokeConditionExpression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_invokeConditionExpression.Add(invokeConditionExpression30.Tree);

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_displayExpression_in_expression389);
                    	displayExpression31 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression31.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, invokeConditionExpression, invokeExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 122:5: -> ^( invokeExpression displayExpression ( ^( InvokeCondition invokeConditionExpression ) )? )
                    	{
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:123:7: ^( invokeExpression displayExpression ( ^( InvokeCondition invokeConditionExpression ) )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_invokeExpression.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_displayExpression.NextTree());
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:125:9: ( ^( InvokeCondition invokeConditionExpression ) )?
                    	    if ( stream_invokeConditionExpression.HasNext() )
                    	    {
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:125:9: ^( InvokeCondition invokeConditionExpression )
                    	        {
                    	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(InvokeCondition, "InvokeCondition"), root_2);

                    	        adaptor.AddChild(root_2, stream_invokeConditionExpression.NextTree());

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_invokeConditionExpression.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:127:5: ifExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifExpression_in_expression445);
                    	ifExpression32 = ifExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifExpression32.Tree);

                    }
                    break;
                case 4 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:128:5: whileExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileExpression_in_expression451);
                    	whileExpression33 = whileExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileExpression33.Tree);

                    }
                    break;
                case 5 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:129:5: saveExpression displayExpression
                    {
                    	PushFollow(FOLLOW_saveExpression_in_expression457);
                    	saveExpression34 = saveExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_saveExpression.Add(saveExpression34.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression459);
                    	displayExpression35 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression35.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, saveExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 130:5: -> displayExpression saveExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_saveExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:131:5: forAll
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forAll_in_expression475);
                    	forAll36 = forAll();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forAll36.Tree);

                    }
                    break;
                case 7 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:132:5: ifExistsExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifExistsExpression_in_expression481);
                    	ifExistsExpression37 = ifExistsExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifExistsExpression37.Tree);

                    }
                    break;
                case 8 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:133:5: multipleLookupExpression displayExpression
                    {
                    	PushFollow(FOLLOW_multipleLookupExpression_in_expression487);
                    	multipleLookupExpression38 = multipleLookupExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_multipleLookupExpression.Add(multipleLookupExpression38.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression489);
                    	displayExpression39 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression39.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, multipleLookupExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 134:5: -> displayExpression multipleLookupExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_multipleLookupExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 9 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:135:5: splitLookupExpression displayExpression
                    {
                    	PushFollow(FOLLOW_splitLookupExpression_in_expression505);
                    	splitLookupExpression40 = splitLookupExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_splitLookupExpression.Add(splitLookupExpression40.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression507);
                    	displayExpression41 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression41.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, splitLookupExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 136:5: -> displayExpression splitLookupExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_splitLookupExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 10 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:137:5: forAllValuesExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forAllValuesExpression_in_expression523);
                    	forAllValuesExpression42 = forAllValuesExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forAllValuesExpression42.Tree);

                    }
                    break;
                case 11 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:138:5: methodexpression displayExpression
                    {
                    	PushFollow(FOLLOW_methodexpression_in_expression529);
                    	methodexpression43 = methodexpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_methodexpression.Add(methodexpression43.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression531);
                    	displayExpression44 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression44.Tree);


                    	// AST REWRITE
                    	// elements:          methodexpression, displayExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 139:5: -> displayExpression methodexpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_methodexpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 12 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:140:5: callBlock displayExpression
                    {
                    	PushFollow(FOLLOW_callBlock_in_expression547);
                    	callBlock45 = callBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_callBlock.Add(callBlock45.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression549);
                    	displayExpression46 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression46.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, callBlock
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 141:5: -> displayExpression callBlock
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_callBlock.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 13 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:142:5: invokeFormula displayExpression
                    {
                    	PushFollow(FOLLOW_invokeFormula_in_expression565);
                    	invokeFormula47 = invokeFormula();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_invokeFormula.Add(invokeFormula47.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression567);
                    	displayExpression48 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression48.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, invokeFormula
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 143:5: -> displayExpression invokeFormula
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_invokeFormula.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 14 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:144:5: outputConmmentsExpression displayExpression
                    {
                    	PushFollow(FOLLOW_outputConmmentsExpression_in_expression584);
                    	outputConmmentsExpression49 = outputConmmentsExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_outputConmmentsExpression.Add(outputConmmentsExpression49.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression586);
                    	displayExpression50 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression50.Tree);


                    	// AST REWRITE
                    	// elements:          outputConmmentsExpression, displayExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 145:5: -> displayExpression outputConmmentsExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_outputConmmentsExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 15 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:146:5: exitExpression displayExpression
                    {
                    	PushFollow(FOLLOW_exitExpression_in_expression602);
                    	exitExpression51 = exitExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exitExpression.Add(exitExpression51.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression604);
                    	displayExpression52 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression52.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, exitExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 147:5: -> displayExpression exitExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_exitExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 16 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:148:5: priceExpression displayExpression
                    {
                    	PushFollow(FOLLOW_priceExpression_in_expression620);
                    	priceExpression53 = priceExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_priceExpression.Add(priceExpression53.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression622);
                    	displayExpression54 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression54.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, priceExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 149:5: -> displayExpression priceExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_priceExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 17 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:150:5: lookupExpression displayExpression
                    {
                    	PushFollow(FOLLOW_lookupExpression_in_expression638);
                    	lookupExpression55 = lookupExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lookupExpression.Add(lookupExpression55.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression640);
                    	displayExpression56 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression56.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, lookupExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 151:5: -> displayExpression lookupExpression
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_lookupExpression.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 18 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:152:5: invokePricer displayExpression
                    {
                    	PushFollow(FOLLOW_invokePricer_in_expression656);
                    	invokePricer57 = invokePricer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_invokePricer.Add(invokePricer57.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression658);
                    	displayExpression58 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression58.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, invokePricer
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 153:5: -> displayExpression invokePricer
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_invokePricer.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 19 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:154:5: applyAdjustmanets displayExpression
                    {
                    	PushFollow(FOLLOW_applyAdjustmanets_in_expression674);
                    	applyAdjustmanets59 = applyAdjustmanets();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_applyAdjustmanets.Add(applyAdjustmanets59.Tree);
                    	PushFollow(FOLLOW_displayExpression_in_expression676);
                    	displayExpression60 = displayExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression60.Tree);


                    	// AST REWRITE
                    	// elements:          displayExpression, applyAdjustmanets
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 155:5: -> displayExpression applyAdjustmanets
                    	{
                    	    adaptor.AddChild(root_0, stream_displayExpression.NextTree());
                    	    adaptor.AddChild(root_0, stream_applyAdjustmanets.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 20 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:156:5: COMMENT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COMMENT61=(IToken)Match(input,COMMENT,FOLLOW_COMMENT_in_expression692); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMENT61_tree = (CommonTree)adaptor.Create(COMMENT61);
                    		adaptor.AddChild(root_0, COMMENT61_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, expression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class callBlock_return : ParserRuleReturnScope
    {
        public MetadataInfo callBlockInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "callBlock"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:159:1: callBlock returns [MetadataInfo callBlockInfo] : 'callBlock' identifier ( '[' )? identifier '(' ( parameters )? ')' (a= identifier )? ( ']' )? -> ^( 'callBlock' identifier ^( BlockName identifier ) ( ^( Parameters parameters ) )? ( ^( ReturnType identifier ) )? ) ;
    public CalcETreeParser.callBlock_return callBlock() // throws RecognitionException [1]
    {   
        CalcETreeParser.callBlock_return retval = new CalcETreeParser.callBlock_return();
        retval.Start = input.LT(1);
        int callBlock_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal62 = null;
        IToken char_literal64 = null;
        IToken char_literal66 = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        CalcETreeParser.identifier_return a = default(CalcETreeParser.identifier_return);

        CalcETreeParser.identifier_return identifier63 = default(CalcETreeParser.identifier_return);

        CalcETreeParser.identifier_return identifier65 = default(CalcETreeParser.identifier_return);

        CalcETreeParser.parameters_return parameters67 = default(CalcETreeParser.parameters_return);


        CommonTree string_literal62_tree=null;
        CommonTree char_literal64_tree=null;
        CommonTree char_literal66_tree=null;
        CommonTree char_literal68_tree=null;
        CommonTree char_literal69_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_parameters = new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        MetadataInfo metaData = new MetadataInfo() {datatype="none" };  
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:6: ( 'callBlock' identifier ( '[' )? identifier '(' ( parameters )? ')' (a= identifier )? ( ']' )? -> ^( 'callBlock' identifier ^( BlockName identifier ) ( ^( Parameters parameters ) )? ( ^( ReturnType identifier ) )? ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:7: 'callBlock' identifier ( '[' )? identifier '(' ( parameters )? ')' (a= identifier )? ( ']' )?
            {
            	string_literal62=(IToken)Match(input,48,FOLLOW_48_in_callBlock715); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(string_literal62);

            	PushFollow(FOLLOW_identifier_in_callBlock717);
            	identifier63 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier63.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:30: ( '[' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 49) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: '['
            	        {
            	        	char_literal64=(IToken)Match(input,49,FOLLOW_49_in_callBlock719); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_49.Add(char_literal64);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_identifier_in_callBlock722);
            	identifier65 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier65.Tree);
            	char_literal66=(IToken)Match(input,45,FOLLOW_45_in_callBlock724); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal66);

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:49: ( parameters )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == Literal || LA12_0 == 48 || (LA12_0 >= 64 && LA12_0 <= 67) || (LA12_0 >= 95 && LA12_0 <= 97) || LA12_0 == 99 || LA12_0 == 102 || (LA12_0 >= 104 && LA12_0 <= 107)) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: parameters
            	        {
            	        	PushFollow(FOLLOW_parameters_in_callBlock725);
            	        	parameters67 = parameters();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_parameters.Add(parameters67.Tree);

            	        }
            	        break;

            	}

            	char_literal68=(IToken)Match(input,47,FOLLOW_47_in_callBlock727); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal68);

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:64: (a= identifier )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == Identifier) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:66: a= identifier
            	        {
            	        	PushFollow(FOLLOW_identifier_in_callBlock736);
            	        	a = identifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_identifier.Add(a.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   metaData.datatype = ((a != null) ? a.identifierInfo : default(MetadataInfo)).value; 
            	        	}

            	        }
            	        break;

            	}

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:133: ( ']' )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 50) )
            	{
            	    int LA14_1 = input.LA(2);

            	    if ( (LA14_1 == 57) )
            	    {
            	        int LA14_3 = input.LA(3);

            	        if ( (LA14_3 == Literal) )
            	        {
            	            int LA14_5 = input.LA(4);

            	            if ( (synpred34_CalcETree()) )
            	            {
            	                alt14 = 1;
            	            }
            	        }
            	    }
            	    else if ( (LA14_1 == EOF || LA14_1 == Literal || LA14_1 == 43 || (LA14_1 >= 45 && LA14_1 <= 48) || LA14_1 == 50 || (LA14_1 >= 64 && LA14_1 <= 67) || (LA14_1 >= 80 && LA14_1 <= 97) || (LA14_1 >= 99 && LA14_1 <= 100) || LA14_1 == 102 || (LA14_1 >= 104 && LA14_1 <= 107)) )
            	    {
            	        alt14 = 1;
            	    }
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ']'
            	        {
            	        	char_literal69=(IToken)Match(input,50,FOLLOW_50_in_callBlock742); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_50.Add(char_literal69);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          identifier, identifier, 48, identifier, parameters
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 161:5: -> ^( 'callBlock' identifier ^( BlockName identifier ) ( ^( Parameters parameters ) )? ( ^( ReturnType identifier ) )? )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:161:8: ^( 'callBlock' identifier ^( BlockName identifier ) ( ^( Parameters parameters ) )? ( ^( ReturnType identifier ) )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_48.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:162:8: ^( BlockName identifier )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BlockName, "BlockName"), root_2);

            	    adaptor.AddChild(root_2, stream_identifier.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:163:8: ( ^( Parameters parameters ) )?
            	    if ( stream_parameters.HasNext() )
            	    {
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:163:8: ^( Parameters parameters )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(Parameters, "Parameters"), root_2);

            	        adaptor.AddChild(root_2, stream_parameters.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_parameters.Reset();
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:164:8: ( ^( ReturnType identifier ) )?
            	    if ( stream_identifier.HasNext() )
            	    {
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:164:8: ^( ReturnType identifier )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ReturnType, "ReturnType"), root_2);

            	        adaptor.AddChild(root_2, stream_identifier.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_identifier.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, callBlock_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "callBlock"

    public class invokeFormula_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "invokeFormula"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:166:1: invokeFormula : 'invokeFormula' identifier ( '(' parameters ')' )? -> ^( 'invokeFormula' identifier ( ^( Parameters parameters ) )? ) ;
    public CalcETreeParser.invokeFormula_return invokeFormula() // throws RecognitionException [1]
    {   
        CalcETreeParser.invokeFormula_return retval = new CalcETreeParser.invokeFormula_return();
        retval.Start = input.LT(1);
        int invokeFormula_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal70 = null;
        IToken char_literal72 = null;
        IToken char_literal74 = null;
        CalcETreeParser.identifier_return identifier71 = default(CalcETreeParser.identifier_return);

        CalcETreeParser.parameters_return parameters73 = default(CalcETreeParser.parameters_return);


        CommonTree string_literal70_tree=null;
        CommonTree char_literal72_tree=null;
        CommonTree char_literal74_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleSubtreeStream stream_parameters = new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:167:5: ( 'invokeFormula' identifier ( '(' parameters ')' )? -> ^( 'invokeFormula' identifier ( ^( Parameters parameters ) )? ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:167:6: 'invokeFormula' identifier ( '(' parameters ')' )?
            {
            	string_literal70=(IToken)Match(input,51,FOLLOW_51_in_invokeFormula810); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(string_literal70);

            	PushFollow(FOLLOW_identifier_in_invokeFormula812);
            	identifier71 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier71.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:167:33: ( '(' parameters ')' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 45) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:167:34: '(' parameters ')'
            	        {
            	        	char_literal72=(IToken)Match(input,45,FOLLOW_45_in_invokeFormula815); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal72);

            	        	PushFollow(FOLLOW_parameters_in_invokeFormula816);
            	        	parameters73 = parameters();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_parameters.Add(parameters73.Tree);
            	        	char_literal74=(IToken)Match(input,47,FOLLOW_47_in_invokeFormula817); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_47.Add(char_literal74);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          parameters, 51, identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 168:6: -> ^( 'invokeFormula' identifier ( ^( Parameters parameters ) )? )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:168:9: ^( 'invokeFormula' identifier ( ^( Parameters parameters ) )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_51.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:169:7: ( ^( Parameters parameters ) )?
            	    if ( stream_parameters.HasNext() )
            	    {
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:169:7: ^( Parameters parameters )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(Parameters, "Parameters"), root_2);

            	        adaptor.AddChild(root_2, stream_parameters.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_parameters.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, invokeFormula_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "invokeFormula"

    public class invokePricer_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "invokePricer"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:172:1: invokePricer : 'invokePricer' identifier -> ^( 'invokePricer' identifier ) ;
    public CalcETreeParser.invokePricer_return invokePricer() // throws RecognitionException [1]
    {   
        CalcETreeParser.invokePricer_return retval = new CalcETreeParser.invokePricer_return();
        retval.Start = input.LT(1);
        int invokePricer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal75 = null;
        CalcETreeParser.identifier_return identifier76 = default(CalcETreeParser.identifier_return);


        CommonTree string_literal75_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:173:3: ( 'invokePricer' identifier -> ^( 'invokePricer' identifier ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:173:4: 'invokePricer' identifier
            {
            	string_literal75=(IToken)Match(input,52,FOLLOW_52_in_invokePricer859); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(string_literal75);

            	PushFollow(FOLLOW_identifier_in_invokePricer861);
            	identifier76 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier76.Tree);


            	// AST REWRITE
            	// elements:          identifier, 52
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 174:6: -> ^( 'invokePricer' identifier )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:175:7: ^( 'invokePricer' identifier )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_52.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, invokePricer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "invokePricer"

    public class applyAdjustmanets_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "applyAdjustmanets"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:177:1: applyAdjustmanets : 'applyAdjustments' identifier ( ',' identifier )* -> ^( 'applyAdjustments' identifier ( identifier )* ) ;
    public CalcETreeParser.applyAdjustmanets_return applyAdjustmanets() // throws RecognitionException [1]
    {   
        CalcETreeParser.applyAdjustmanets_return retval = new CalcETreeParser.applyAdjustmanets_return();
        retval.Start = input.LT(1);
        int applyAdjustmanets_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal77 = null;
        IToken char_literal79 = null;
        CalcETreeParser.identifier_return identifier78 = default(CalcETreeParser.identifier_return);

        CalcETreeParser.identifier_return identifier80 = default(CalcETreeParser.identifier_return);


        CommonTree string_literal77_tree=null;
        CommonTree char_literal79_tree=null;
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:178:3: ( 'applyAdjustments' identifier ( ',' identifier )* -> ^( 'applyAdjustments' identifier ( identifier )* ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:178:5: 'applyAdjustments' identifier ( ',' identifier )*
            {
            	string_literal77=(IToken)Match(input,53,FOLLOW_53_in_applyAdjustmanets892); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(string_literal77);

            	PushFollow(FOLLOW_identifier_in_applyAdjustmanets894);
            	identifier78 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier78.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:178:35: ( ',' identifier )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == 46) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:178:36: ',' identifier
            			    {
            			    	char_literal79=(IToken)Match(input,46,FOLLOW_46_in_applyAdjustmanets897); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_46.Add(char_literal79);

            			    	PushFollow(FOLLOW_identifier_in_applyAdjustmanets899);
            			    	identifier80 = identifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_identifier.Add(identifier80.Tree);

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements



            	// AST REWRITE
            	// elements:          identifier, 53, identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 179:6: -> ^( 'applyAdjustments' identifier ( identifier )* )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:180:7: ^( 'applyAdjustments' identifier ( identifier )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_53.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:180:39: ( identifier )*
            	    while ( stream_identifier.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_identifier.NextTree());

            	    }
            	    stream_identifier.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, applyAdjustmanets_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "applyAdjustmanets"

    public class invokeConditionExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "invokeConditionExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:183:1: invokeConditionExpression : ( conditionalOrExpression | ifexistsEntity );
    public CalcETreeParser.invokeConditionExpression_return invokeConditionExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.invokeConditionExpression_return retval = new CalcETreeParser.invokeConditionExpression_return();
        retval.Start = input.LT(1);
        int invokeConditionExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.conditionalOrExpression_return conditionalOrExpression81 = default(CalcETreeParser.conditionalOrExpression_return);

        CalcETreeParser.ifexistsEntity_return ifexistsEntity82 = default(CalcETreeParser.ifexistsEntity_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:184:3: ( conditionalOrExpression | ifexistsEntity )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == Literal || LA17_0 == 45 || LA17_0 == 48 || (LA17_0 >= 64 && LA17_0 <= 67) || (LA17_0 >= 95 && LA17_0 <= 97) || (LA17_0 >= 99 && LA17_0 <= 100) || LA17_0 == 102 || (LA17_0 >= 104 && LA17_0 <= 107)) )
            {
                alt17 = 1;
            }
            else if ( (LA17_0 == 54) )
            {
                alt17 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:185:3: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_invokeConditionExpression944);
                    	conditionalOrExpression81 = conditionalOrExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression81.Tree);

                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:186:5: ifexistsEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifexistsEntity_in_invokeConditionExpression950);
                    	ifexistsEntity82 = ifexistsEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifexistsEntity82.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, invokeConditionExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "invokeConditionExpression"

    public class ifexistsEntity_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ifexistsEntity"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:189:1: ifexistsEntity : 'invokeIfExists' objectModelEntity -> ^( 'invokeIfExists' objectModelEntity ) ;
    public CalcETreeParser.ifexistsEntity_return ifexistsEntity() // throws RecognitionException [1]
    {   
        CalcETreeParser.ifexistsEntity_return retval = new CalcETreeParser.ifexistsEntity_return();
        retval.Start = input.LT(1);
        int ifexistsEntity_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal83 = null;
        CalcETreeParser.objectModelEntity_return objectModelEntity84 = default(CalcETreeParser.objectModelEntity_return);


        CommonTree string_literal83_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_objectModelEntity = new RewriteRuleSubtreeStream(adaptor,"rule objectModelEntity");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:190:3: ( 'invokeIfExists' objectModelEntity -> ^( 'invokeIfExists' objectModelEntity ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:191:3: 'invokeIfExists' objectModelEntity
            {
            	string_literal83=(IToken)Match(input,54,FOLLOW_54_in_ifexistsEntity965); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(string_literal83);

            	PushFollow(FOLLOW_objectModelEntity_in_ifexistsEntity967);
            	objectModelEntity84 = objectModelEntity();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_objectModelEntity.Add(objectModelEntity84.Tree);


            	// AST REWRITE
            	// elements:          54, objectModelEntity
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 192:7: -> ^( 'invokeIfExists' objectModelEntity )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:193:7: ^( 'invokeIfExists' objectModelEntity )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_54.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_objectModelEntity.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, ifexistsEntity_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ifexistsEntity"

    public class exitExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exitExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:196:1: exitExpression : 'EXIT' ;
    public CalcETreeParser.exitExpression_return exitExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.exitExpression_return retval = new CalcETreeParser.exitExpression_return();
        retval.Start = input.LT(1);
        int exitExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal85 = null;

        CommonTree string_literal85_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:197:3: ( 'EXIT' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:198:3: 'EXIT'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal85=(IToken)Match(input,55,FOLLOW_55_in_exitExpression1002); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal85_tree = (CommonTree)adaptor.Create(string_literal85);
            		adaptor.AddChild(root_0, string_literal85_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, exitExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "exitExpression"

    public class outputConmmentsExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "outputConmmentsExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:201:1: outputConmmentsExpression : 'OUTPUTCOMMENT' Literal ( '(' metadata ')' )? -> ^( 'OUTPUTCOMMENT' Literal ( metadata )? ) ;
    public CalcETreeParser.outputConmmentsExpression_return outputConmmentsExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.outputConmmentsExpression_return retval = new CalcETreeParser.outputConmmentsExpression_return();
        retval.Start = input.LT(1);
        int outputConmmentsExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal86 = null;
        IToken Literal87 = null;
        IToken char_literal88 = null;
        IToken char_literal90 = null;
        CalcETreeParser.metadata_return metadata89 = default(CalcETreeParser.metadata_return);


        CommonTree string_literal86_tree=null;
        CommonTree Literal87_tree=null;
        CommonTree char_literal88_tree=null;
        CommonTree char_literal90_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_Literal = new RewriteRuleTokenStream(adaptor,"token Literal");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_metadata = new RewriteRuleSubtreeStream(adaptor,"rule metadata");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:202:3: ( 'OUTPUTCOMMENT' Literal ( '(' metadata ')' )? -> ^( 'OUTPUTCOMMENT' Literal ( metadata )? ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:202:5: 'OUTPUTCOMMENT' Literal ( '(' metadata ')' )?
            {
            	string_literal86=(IToken)Match(input,56,FOLLOW_56_in_outputConmmentsExpression1015); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(string_literal86);

            	Literal87=(IToken)Match(input,Literal,FOLLOW_Literal_in_outputConmmentsExpression1017); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Literal.Add(Literal87);

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:202:29: ( '(' metadata ')' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 45) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:202:30: '(' metadata ')'
            	        {
            	        	char_literal88=(IToken)Match(input,45,FOLLOW_45_in_outputConmmentsExpression1020); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal88);

            	        	PushFollow(FOLLOW_metadata_in_outputConmmentsExpression1022);
            	        	metadata89 = metadata();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_metadata.Add(metadata89.Tree);
            	        	char_literal90=(IToken)Match(input,47,FOLLOW_47_in_outputConmmentsExpression1024); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_47.Add(char_literal90);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          metadata, Literal, 56
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 202:49: -> ^( 'OUTPUTCOMMENT' Literal ( metadata )? )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:202:52: ^( 'OUTPUTCOMMENT' Literal ( metadata )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_56.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_Literal.NextNode());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:202:78: ( metadata )?
            	    if ( stream_metadata.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_metadata.NextTree());

            	    }
            	    stream_metadata.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, outputConmmentsExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "outputConmmentsExpression"

    public class displayExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "displayExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:204:1: displayExpression : 'displayProperty' Literal -> ^( 'displayProperty' Literal ) ;
    public CalcETreeParser.displayExpression_return displayExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.displayExpression_return retval = new CalcETreeParser.displayExpression_return();
        retval.Start = input.LT(1);
        int displayExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal91 = null;
        IToken Literal92 = null;

        CommonTree string_literal91_tree=null;
        CommonTree Literal92_tree=null;
        RewriteRuleTokenStream stream_Literal = new RewriteRuleTokenStream(adaptor,"token Literal");
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:205:3: ( 'displayProperty' Literal -> ^( 'displayProperty' Literal ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:206:3: 'displayProperty' Literal
            {
            	string_literal91=(IToken)Match(input,57,FOLLOW_57_in_displayExpression1049); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_57.Add(string_literal91);

            	Literal92=(IToken)Match(input,Literal,FOLLOW_Literal_in_displayExpression1051); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Literal.Add(Literal92);



            	// AST REWRITE
            	// elements:          Literal, 57
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 207:5: -> ^( 'displayProperty' Literal )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:208:7: ^( 'displayProperty' Literal )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_57.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_Literal.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, displayExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "displayExpression"

    public class ifExistsExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ifExistsExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:211:1: ifExistsExpression : 'ifExists' objectModelEntity displayExpression '[' statementsExpression ']' 'endIfExists' -> ^( 'ifExists' displayExpression objectModelEntity ( statementsExpression )* 'endIfExists' ) ;
    public CalcETreeParser.ifExistsExpression_return ifExistsExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.ifExistsExpression_return retval = new CalcETreeParser.ifExistsExpression_return();
        retval.Start = input.LT(1);
        int ifExistsExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal93 = null;
        IToken char_literal96 = null;
        IToken char_literal98 = null;
        IToken string_literal99 = null;
        CalcETreeParser.objectModelEntity_return objectModelEntity94 = default(CalcETreeParser.objectModelEntity_return);

        CalcETreeParser.displayExpression_return displayExpression95 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.statementsExpression_return statementsExpression97 = default(CalcETreeParser.statementsExpression_return);


        CommonTree string_literal93_tree=null;
        CommonTree char_literal96_tree=null;
        CommonTree char_literal98_tree=null;
        CommonTree string_literal99_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_displayExpression = new RewriteRuleSubtreeStream(adaptor,"rule displayExpression");
        RewriteRuleSubtreeStream stream_statementsExpression = new RewriteRuleSubtreeStream(adaptor,"rule statementsExpression");
        RewriteRuleSubtreeStream stream_objectModelEntity = new RewriteRuleSubtreeStream(adaptor,"rule objectModelEntity");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:212:3: ( 'ifExists' objectModelEntity displayExpression '[' statementsExpression ']' 'endIfExists' -> ^( 'ifExists' displayExpression objectModelEntity ( statementsExpression )* 'endIfExists' ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:213:3: 'ifExists' objectModelEntity displayExpression '[' statementsExpression ']' 'endIfExists'
            {
            	string_literal93=(IToken)Match(input,58,FOLLOW_58_in_ifExistsExpression1084); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(string_literal93);

            	PushFollow(FOLLOW_objectModelEntity_in_ifExistsExpression1086);
            	objectModelEntity94 = objectModelEntity();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_objectModelEntity.Add(objectModelEntity94.Tree);
            	PushFollow(FOLLOW_displayExpression_in_ifExistsExpression1088);
            	displayExpression95 = displayExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression95.Tree);
            	char_literal96=(IToken)Match(input,49,FOLLOW_49_in_ifExistsExpression1090); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal96);

            	PushFollow(FOLLOW_statementsExpression_in_ifExistsExpression1092);
            	statementsExpression97 = statementsExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementsExpression.Add(statementsExpression97.Tree);
            	char_literal98=(IToken)Match(input,50,FOLLOW_50_in_ifExistsExpression1094); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal98);

            	string_literal99=(IToken)Match(input,59,FOLLOW_59_in_ifExistsExpression1096); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(string_literal99);



            	// AST REWRITE
            	// elements:          statementsExpression, 58, displayExpression, 59, objectModelEntity
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 214:5: -> ^( 'ifExists' displayExpression objectModelEntity ( statementsExpression )* 'endIfExists' )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:215:7: ^( 'ifExists' displayExpression objectModelEntity ( statementsExpression )* 'endIfExists' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_58.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_displayExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_objectModelEntity.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:215:56: ( statementsExpression )*
            	    while ( stream_statementsExpression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statementsExpression.NextTree());

            	    }
            	    stream_statementsExpression.Reset();
            	    adaptor.AddChild(root_1, stream_59.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, ifExistsExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ifExistsExpression"

    public class forAll_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forAll"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:220:1: forAll : 'forAll' lhsEntities displayExpression '[' statementsExpression ']' 'endForAll' -> ^( 'forAll' displayExpression lhsEntities ( statementsExpression )* 'endForAll' ) ;
    public CalcETreeParser.forAll_return forAll() // throws RecognitionException [1]
    {   
        CalcETreeParser.forAll_return retval = new CalcETreeParser.forAll_return();
        retval.Start = input.LT(1);
        int forAll_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal100 = null;
        IToken char_literal103 = null;
        IToken char_literal105 = null;
        IToken string_literal106 = null;
        CalcETreeParser.lhsEntities_return lhsEntities101 = default(CalcETreeParser.lhsEntities_return);

        CalcETreeParser.displayExpression_return displayExpression102 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.statementsExpression_return statementsExpression104 = default(CalcETreeParser.statementsExpression_return);


        CommonTree string_literal100_tree=null;
        CommonTree char_literal103_tree=null;
        CommonTree char_literal105_tree=null;
        CommonTree string_literal106_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_lhsEntities = new RewriteRuleSubtreeStream(adaptor,"rule lhsEntities");
        RewriteRuleSubtreeStream stream_displayExpression = new RewriteRuleSubtreeStream(adaptor,"rule displayExpression");
        RewriteRuleSubtreeStream stream_statementsExpression = new RewriteRuleSubtreeStream(adaptor,"rule statementsExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:221:3: ( 'forAll' lhsEntities displayExpression '[' statementsExpression ']' 'endForAll' -> ^( 'forAll' displayExpression lhsEntities ( statementsExpression )* 'endForAll' ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:222:3: 'forAll' lhsEntities displayExpression '[' statementsExpression ']' 'endForAll'
            {
            	string_literal100=(IToken)Match(input,60,FOLLOW_60_in_forAll1138); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(string_literal100);

            	PushFollow(FOLLOW_lhsEntities_in_forAll1140);
            	lhsEntities101 = lhsEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_lhsEntities.Add(lhsEntities101.Tree);
            	PushFollow(FOLLOW_displayExpression_in_forAll1142);
            	displayExpression102 = displayExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression102.Tree);
            	char_literal103=(IToken)Match(input,49,FOLLOW_49_in_forAll1144); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal103);

            	PushFollow(FOLLOW_statementsExpression_in_forAll1146);
            	statementsExpression104 = statementsExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementsExpression.Add(statementsExpression104.Tree);
            	char_literal105=(IToken)Match(input,50,FOLLOW_50_in_forAll1148); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal105);

            	string_literal106=(IToken)Match(input,61,FOLLOW_61_in_forAll1150); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_61.Add(string_literal106);



            	// AST REWRITE
            	// elements:          displayExpression, 60, 61, lhsEntities, statementsExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 223:5: -> ^( 'forAll' displayExpression lhsEntities ( statementsExpression )* 'endForAll' )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:224:7: ^( 'forAll' displayExpression lhsEntities ( statementsExpression )* 'endForAll' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_60.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_displayExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_lhsEntities.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:226:9: ( statementsExpression )*
            	    while ( stream_statementsExpression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statementsExpression.NextTree());

            	    }
            	    stream_statementsExpression.Reset();
            	    adaptor.AddChild(root_1, stream_61.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, forAll_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forAll"

    public class forAllValuesExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forAllValuesExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:229:1: forAllValuesExpression : 'forAllValues' lhsEntities displayExpression '[' statementsExpression ']' 'endForAllValues' -> ^( 'forAllValues' displayExpression lhsEntities statementsExpression ) 'endForAllValues' ;
    public CalcETreeParser.forAllValuesExpression_return forAllValuesExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.forAllValuesExpression_return retval = new CalcETreeParser.forAllValuesExpression_return();
        retval.Start = input.LT(1);
        int forAllValuesExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal107 = null;
        IToken char_literal110 = null;
        IToken char_literal112 = null;
        IToken string_literal113 = null;
        CalcETreeParser.lhsEntities_return lhsEntities108 = default(CalcETreeParser.lhsEntities_return);

        CalcETreeParser.displayExpression_return displayExpression109 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.statementsExpression_return statementsExpression111 = default(CalcETreeParser.statementsExpression_return);


        CommonTree string_literal107_tree=null;
        CommonTree char_literal110_tree=null;
        CommonTree char_literal112_tree=null;
        CommonTree string_literal113_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_62 = new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_lhsEntities = new RewriteRuleSubtreeStream(adaptor,"rule lhsEntities");
        RewriteRuleSubtreeStream stream_displayExpression = new RewriteRuleSubtreeStream(adaptor,"rule displayExpression");
        RewriteRuleSubtreeStream stream_statementsExpression = new RewriteRuleSubtreeStream(adaptor,"rule statementsExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:230:3: ( 'forAllValues' lhsEntities displayExpression '[' statementsExpression ']' 'endForAllValues' -> ^( 'forAllValues' displayExpression lhsEntities statementsExpression ) 'endForAllValues' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:231:3: 'forAllValues' lhsEntities displayExpression '[' statementsExpression ']' 'endForAllValues'
            {
            	string_literal107=(IToken)Match(input,62,FOLLOW_62_in_forAllValuesExpression1208); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_62.Add(string_literal107);

            	PushFollow(FOLLOW_lhsEntities_in_forAllValuesExpression1210);
            	lhsEntities108 = lhsEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_lhsEntities.Add(lhsEntities108.Tree);
            	PushFollow(FOLLOW_displayExpression_in_forAllValuesExpression1212);
            	displayExpression109 = displayExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression109.Tree);
            	char_literal110=(IToken)Match(input,49,FOLLOW_49_in_forAllValuesExpression1214); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal110);

            	PushFollow(FOLLOW_statementsExpression_in_forAllValuesExpression1216);
            	statementsExpression111 = statementsExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementsExpression.Add(statementsExpression111.Tree);
            	char_literal112=(IToken)Match(input,50,FOLLOW_50_in_forAllValuesExpression1218); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal112);

            	string_literal113=(IToken)Match(input,63,FOLLOW_63_in_forAllValuesExpression1220); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_63.Add(string_literal113);



            	// AST REWRITE
            	// elements:          lhsEntities, statementsExpression, 62, displayExpression, 63
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 232:5: -> ^( 'forAllValues' displayExpression lhsEntities statementsExpression ) 'endForAllValues'
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:233:7: ^( 'forAllValues' displayExpression lhsEntities statementsExpression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_62.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_displayExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_lhsEntities.NextTree());
            	    adaptor.AddChild(root_1, stream_statementsExpression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    adaptor.AddChild(root_0, stream_63.NextNode());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, forAllValuesExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forAllValuesExpression"

    public class priceExpression_return : ParserRuleReturnScope
    {
        public MetadataInfo priceExpressionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "priceExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:238:1: priceExpression returns [MetadataInfo priceExpressionInfo] : ( 'PRICEPE' primaryForMethod -> ^( 'PRICEPE' primaryForMethod ) | 'PRICEPECATEGORY' primaryForMethod -> ^( 'PRICEPECATEGORY' primaryForMethod ) | 'PRICEPC' primaryForMethod -> ^( 'PRICEPC' primaryForMethod ) | 'PRICEPCCATEGORY' primaryForMethod -> ^( 'PRICEPCCATEGORY' primaryForMethod ) );
    public CalcETreeParser.priceExpression_return priceExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.priceExpression_return retval = new CalcETreeParser.priceExpression_return();
        retval.Start = input.LT(1);
        int priceExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal114 = null;
        IToken string_literal116 = null;
        IToken string_literal118 = null;
        IToken string_literal120 = null;
        CalcETreeParser.primaryForMethod_return primaryForMethod115 = default(CalcETreeParser.primaryForMethod_return);

        CalcETreeParser.primaryForMethod_return primaryForMethod117 = default(CalcETreeParser.primaryForMethod_return);

        CalcETreeParser.primaryForMethod_return primaryForMethod119 = default(CalcETreeParser.primaryForMethod_return);

        CalcETreeParser.primaryForMethod_return primaryForMethod121 = default(CalcETreeParser.primaryForMethod_return);


        CommonTree string_literal114_tree=null;
        CommonTree string_literal116_tree=null;
        CommonTree string_literal118_tree=null;
        CommonTree string_literal120_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_primaryForMethod = new RewriteRuleSubtreeStream(adaptor,"rule primaryForMethod");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:239:3: ( 'PRICEPE' primaryForMethod -> ^( 'PRICEPE' primaryForMethod ) | 'PRICEPECATEGORY' primaryForMethod -> ^( 'PRICEPECATEGORY' primaryForMethod ) | 'PRICEPC' primaryForMethod -> ^( 'PRICEPC' primaryForMethod ) | 'PRICEPCCATEGORY' primaryForMethod -> ^( 'PRICEPCCATEGORY' primaryForMethod ) )
            int alt19 = 4;
            switch ( input.LA(1) ) 
            {
            case 64:
            	{
                alt19 = 1;
                }
                break;
            case 65:
            	{
                alt19 = 2;
                }
                break;
            case 66:
            	{
                alt19 = 3;
                }
                break;
            case 67:
            	{
                alt19 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:240:5: 'PRICEPE' primaryForMethod
                    {
                    	string_literal114=(IToken)Match(input,64,FOLLOW_64_in_priceExpression1272); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_64.Add(string_literal114);

                    	PushFollow(FOLLOW_primaryForMethod_in_priceExpression1274);
                    	primaryForMethod115 = primaryForMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_primaryForMethod.Add(primaryForMethod115.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.priceExpressionInfo =  ((primaryForMethod115 != null) ? primaryForMethod115.primaryForMethodInfo : default(MetadataInfo));retval.priceExpressionInfo.value="PRICEPE";retval.priceExpressionInfo.datatype = "price"; 
                    	}


                    	// AST REWRITE
                    	// elements:          primaryForMethod, 64
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 240:175: -> ^( 'PRICEPE' primaryForMethod )
                    	{
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:240:178: ^( 'PRICEPE' primaryForMethod )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_64.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_primaryForMethod.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:241:6: 'PRICEPECATEGORY' primaryForMethod
                    {
                    	string_literal116=(IToken)Match(input,65,FOLLOW_65_in_priceExpression1291); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_65.Add(string_literal116);

                    	PushFollow(FOLLOW_primaryForMethod_in_priceExpression1293);
                    	primaryForMethod117 = primaryForMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_primaryForMethod.Add(primaryForMethod117.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.priceExpressionInfo =  ((primaryForMethod117 != null) ? primaryForMethod117.primaryForMethodInfo : default(MetadataInfo));retval.priceExpressionInfo.value="PRICEPECATEGORY"; retval.priceExpressionInfo.datatype = "price";
                    	}


                    	// AST REWRITE
                    	// elements:          primaryForMethod, 65
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 241:192: -> ^( 'PRICEPECATEGORY' primaryForMethod )
                    	{
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:241:195: ^( 'PRICEPECATEGORY' primaryForMethod )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_65.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_primaryForMethod.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:242:6: 'PRICEPC' primaryForMethod
                    {
                    	string_literal118=(IToken)Match(input,66,FOLLOW_66_in_priceExpression1311); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_66.Add(string_literal118);

                    	PushFollow(FOLLOW_primaryForMethod_in_priceExpression1313);
                    	primaryForMethod119 = primaryForMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_primaryForMethod.Add(primaryForMethod119.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.priceExpressionInfo =  ((primaryForMethod119 != null) ? primaryForMethod119.primaryForMethodInfo : default(MetadataInfo));retval.priceExpressionInfo.value="PRICEPC"; retval.priceExpressionInfo.datatype = "price";
                    	}


                    	// AST REWRITE
                    	// elements:          66, primaryForMethod
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 242:176: -> ^( 'PRICEPC' primaryForMethod )
                    	{
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:242:179: ^( 'PRICEPC' primaryForMethod )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_66.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_primaryForMethod.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:243:6: 'PRICEPCCATEGORY' primaryForMethod
                    {
                    	string_literal120=(IToken)Match(input,67,FOLLOW_67_in_priceExpression1331); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_67.Add(string_literal120);

                    	PushFollow(FOLLOW_primaryForMethod_in_priceExpression1333);
                    	primaryForMethod121 = primaryForMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_primaryForMethod.Add(primaryForMethod121.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.priceExpressionInfo =  ((primaryForMethod121 != null) ? primaryForMethod121.primaryForMethodInfo : default(MetadataInfo));retval.priceExpressionInfo.value="PRICEPCCATEGORY"; retval.priceExpressionInfo.datatype = "price";
                    	}


                    	// AST REWRITE
                    	// elements:          67, primaryForMethod
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 243:192: -> ^( 'PRICEPCCATEGORY' primaryForMethod )
                    	{
                    	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:243:195: ^( 'PRICEPCCATEGORY' primaryForMethod )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_67.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_primaryForMethod.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, priceExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "priceExpression"

    public class assignExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:248:1: assignExpression : a= lhsEntities assignmentOperator (b= multiplicativeExpression | c= filterExpression ) ;
    public CalcETreeParser.assignExpression_return assignExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.assignExpression_return retval = new CalcETreeParser.assignExpression_return();
        retval.Start = input.LT(1);
        int assignExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.lhsEntities_return a = default(CalcETreeParser.lhsEntities_return);

        CalcETreeParser.multiplicativeExpression_return b = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.filterExpression_return c = default(CalcETreeParser.filterExpression_return);

        CalcETreeParser.assignmentOperator_return assignmentOperator122 = default(CalcETreeParser.assignmentOperator_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:249:3: (a= lhsEntities assignmentOperator (b= multiplicativeExpression | c= filterExpression ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:250:2: a= lhsEntities assignmentOperator (b= multiplicativeExpression | c= filterExpression )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_lhsEntities_in_assignExpression1365);
            	a = lhsEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignExpression1370);
            	assignmentOperator122 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assignmentOperator122.Tree, root_0);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:252:4: (b= multiplicativeExpression | c= filterExpression )
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == Literal || LA20_0 == 45 || LA20_0 == 48 || (LA20_0 >= 64 && LA20_0 <= 67) || (LA20_0 >= 95 && LA20_0 <= 97) || LA20_0 == 99 || LA20_0 == 102 || (LA20_0 >= 104 && LA20_0 <= 107)) )
            	{
            	    alt20 = 1;
            	}
            	else if ( (LA20_0 == 68) )
            	{
            	    alt20 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:252:5: b= multiplicativeExpression
            	        {
            	        	PushFollow(FOLLOW_multiplicativeExpression_in_assignExpression1382);
            	        	b = multiplicativeExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	     if(isValidate)
            	        	     {
            	        	     if(!((((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).ismultiple == ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).ismultiple) || ((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).ismultiple ))
            	        	       throw new DataMisMatchedException(){ ErrorCause="Cardinality mismatch, "+((assignmentOperator122 != null) ? input.ToString((IToken)(assignmentOperator122.Start),(IToken)(assignmentOperator122.Stop)) : null)+ "cannot be applied between "+((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).datatype+" and "+((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype };
            	        	     if(!(((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).datatype=="double"&&((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype=="integer")&&((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).datatype!=((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype && ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype != "lookup" && ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype != "price")
            	        	       throw new DataMisMatchedException(){ ErrorCause="Invalid datatype, "+((assignmentOperator122 != null) ? input.ToString((IToken)(assignmentOperator122.Start),(IToken)(assignmentOperator122.Stop)) : null)+ "cannot be applied between "+((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).datatype+" and "+ ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype};
            	        	       }
            	        	     
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:262:6: c= filterExpression
            	        {
            	        	PushFollow(FOLLOW_filterExpression_in_assignExpression1398);
            	        	c = filterExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, c.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	     if(isValidate)
            	        	     {
            	        	     if(((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).datatype!=((c != null) ? c.filterExpressionInfo : default(MetadataInfo)).datatype && ((c != null) ? c.filterExpressionInfo : default(MetadataInfo)).datatype !="lookup" && ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype != "price")
            	        	       throw new DataMisMatchedException(){ ErrorCause="Invalid datatype, "+((assignmentOperator122 != null) ? input.ToString((IToken)(assignmentOperator122.Start),(IToken)(assignmentOperator122.Stop)) : null)+ "cannot be applied between "+((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo)).datatype+" and "+((c != null) ? c.filterExpressionInfo : default(MetadataInfo)).datatype };
            	        	     }
            	        	     
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, assignExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "assignExpression"

    public class filterExpression_return : ParserRuleReturnScope
    {
        public MetadataInfo filterExpressionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "filterExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:274:1: filterExpression returns [MetadataInfo filterExpressionInfo] : 'filter' a= lhsEntities b= conditionalOrExpression -> ^( 'filter' lhsEntities conditionalOrExpression ) ;
    public CalcETreeParser.filterExpression_return filterExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.filterExpression_return retval = new CalcETreeParser.filterExpression_return();
        retval.Start = input.LT(1);
        int filterExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal123 = null;
        CalcETreeParser.lhsEntities_return a = default(CalcETreeParser.lhsEntities_return);

        CalcETreeParser.conditionalOrExpression_return b = default(CalcETreeParser.conditionalOrExpression_return);


        CommonTree string_literal123_tree=null;
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleSubtreeStream stream_lhsEntities = new RewriteRuleSubtreeStream(adaptor,"rule lhsEntities");
        RewriteRuleSubtreeStream stream_conditionalOrExpression = new RewriteRuleSubtreeStream(adaptor,"rule conditionalOrExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:275:2: ( 'filter' a= lhsEntities b= conditionalOrExpression -> ^( 'filter' lhsEntities conditionalOrExpression ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:275:3: 'filter' a= lhsEntities b= conditionalOrExpression
            {
            	string_literal123=(IToken)Match(input,68,FOLLOW_68_in_filterExpression1426); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_68.Add(string_literal123);

            	PushFollow(FOLLOW_lhsEntities_in_filterExpression1432);
            	a = lhsEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_lhsEntities.Add(a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.filterExpressionInfo = ((a != null) ? a.lhsEntitiesInfo : default(MetadataInfo));  
            	}
            	PushFollow(FOLLOW_conditionalOrExpression_in_filterExpression1439);
            	b = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_conditionalOrExpression.Add(b.Tree);


            	// AST REWRITE
            	// elements:          conditionalOrExpression, lhsEntities, 68
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 276:3: -> ^( 'filter' lhsEntities conditionalOrExpression )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:276:6: ^( 'filter' lhsEntities conditionalOrExpression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_68.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_lhsEntities.NextTree());
            	    adaptor.AddChild(root_1, stream_conditionalOrExpression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, filterExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "filterExpression"

    public class ifExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ifExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:278:1: ifExpression : 'if' conditionalOrExpression displayExpression 'then' statementsExpression ( elseIfExpression )* ( elseExpression )? 'endif' -> ^( 'if' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) ( ^( ElseIfStmt elseIfExpression ) )* ( ^( ElseStmt elseExpression ) )? 'endif' ) ;
    public CalcETreeParser.ifExpression_return ifExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.ifExpression_return retval = new CalcETreeParser.ifExpression_return();
        retval.Start = input.LT(1);
        int ifExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal124 = null;
        IToken string_literal127 = null;
        IToken string_literal131 = null;
        CalcETreeParser.conditionalOrExpression_return conditionalOrExpression125 = default(CalcETreeParser.conditionalOrExpression_return);

        CalcETreeParser.displayExpression_return displayExpression126 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.statementsExpression_return statementsExpression128 = default(CalcETreeParser.statementsExpression_return);

        CalcETreeParser.elseIfExpression_return elseIfExpression129 = default(CalcETreeParser.elseIfExpression_return);

        CalcETreeParser.elseExpression_return elseExpression130 = default(CalcETreeParser.elseExpression_return);


        CommonTree string_literal124_tree=null;
        CommonTree string_literal127_tree=null;
        CommonTree string_literal131_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_71 = new RewriteRuleTokenStream(adaptor,"token 71");
        RewriteRuleSubtreeStream stream_elseExpression = new RewriteRuleSubtreeStream(adaptor,"rule elseExpression");
        RewriteRuleSubtreeStream stream_displayExpression = new RewriteRuleSubtreeStream(adaptor,"rule displayExpression");
        RewriteRuleSubtreeStream stream_conditionalOrExpression = new RewriteRuleSubtreeStream(adaptor,"rule conditionalOrExpression");
        RewriteRuleSubtreeStream stream_statementsExpression = new RewriteRuleSubtreeStream(adaptor,"rule statementsExpression");
        RewriteRuleSubtreeStream stream_elseIfExpression = new RewriteRuleSubtreeStream(adaptor,"rule elseIfExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:279:3: ( 'if' conditionalOrExpression displayExpression 'then' statementsExpression ( elseIfExpression )* ( elseExpression )? 'endif' -> ^( 'if' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) ( ^( ElseIfStmt elseIfExpression ) )* ( ^( ElseStmt elseExpression ) )? 'endif' ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:280:3: 'if' conditionalOrExpression displayExpression 'then' statementsExpression ( elseIfExpression )* ( elseExpression )? 'endif'
            {
            	string_literal124=(IToken)Match(input,69,FOLLOW_69_in_ifExpression1464); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_69.Add(string_literal124);

            	PushFollow(FOLLOW_conditionalOrExpression_in_ifExpression1466);
            	conditionalOrExpression125 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_conditionalOrExpression.Add(conditionalOrExpression125.Tree);
            	PushFollow(FOLLOW_displayExpression_in_ifExpression1468);
            	displayExpression126 = displayExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression126.Tree);
            	string_literal127=(IToken)Match(input,70,FOLLOW_70_in_ifExpression1470); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_70.Add(string_literal127);

            	PushFollow(FOLLOW_statementsExpression_in_ifExpression1472);
            	statementsExpression128 = statementsExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementsExpression.Add(statementsExpression128.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:280:78: ( elseIfExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 72) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: elseIfExpression
            			    {
            			    	PushFollow(FOLLOW_elseIfExpression_in_ifExpression1474);
            			    	elseIfExpression129 = elseIfExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_elseIfExpression.Add(elseIfExpression129.Tree);

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:280:96: ( elseExpression )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == 73) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: elseExpression
            	        {
            	        	PushFollow(FOLLOW_elseExpression_in_ifExpression1477);
            	        	elseExpression130 = elseExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseExpression.Add(elseExpression130.Tree);

            	        }
            	        break;

            	}

            	string_literal131=(IToken)Match(input,71,FOLLOW_71_in_ifExpression1480); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_71.Add(string_literal131);



            	// AST REWRITE
            	// elements:          elseExpression, conditionalOrExpression, elseIfExpression, statementsExpression, 70, 69, displayExpression, 71
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 281:5: -> ^( 'if' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) ( ^( ElseIfStmt elseIfExpression ) )* ( ^( ElseStmt elseExpression ) )? 'endif' )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:282:7: ^( 'if' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) ( ^( ElseIfStmt elseIfExpression ) )* ( ^( ElseStmt elseExpression ) )? 'endif' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_69.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_displayExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_conditionalOrExpression.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:284:9: ^( 'then' statementsExpression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_70.NextNode(), root_2);

            	    adaptor.AddChild(root_2, stream_statementsExpression.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:285:9: ( ^( ElseIfStmt elseIfExpression ) )*
            	    while ( stream_elseIfExpression.HasNext() )
            	    {
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:286:11: ^( ElseIfStmt elseIfExpression )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ElseIfStmt, "ElseIfStmt"), root_2);

            	        adaptor.AddChild(root_2, stream_elseIfExpression.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_elseIfExpression.Reset();
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:286:44: ( ^( ElseStmt elseExpression ) )?
            	    if ( stream_elseExpression.HasNext() )
            	    {
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:287:11: ^( ElseStmt elseExpression )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ElseStmt, "ElseStmt"), root_2);

            	        adaptor.AddChild(root_2, stream_elseExpression.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_elseExpression.Reset();
            	    adaptor.AddChild(root_1, stream_71.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, ifExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ifExpression"

    public class elseIfExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elseIfExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:291:1: elseIfExpression : 'elseif' conditionalOrExpression displayExpression 'then' statementsExpression -> ^( 'elseif' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) ) ;
    public CalcETreeParser.elseIfExpression_return elseIfExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.elseIfExpression_return retval = new CalcETreeParser.elseIfExpression_return();
        retval.Start = input.LT(1);
        int elseIfExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal132 = null;
        IToken string_literal135 = null;
        CalcETreeParser.conditionalOrExpression_return conditionalOrExpression133 = default(CalcETreeParser.conditionalOrExpression_return);

        CalcETreeParser.displayExpression_return displayExpression134 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.statementsExpression_return statementsExpression136 = default(CalcETreeParser.statementsExpression_return);


        CommonTree string_literal132_tree=null;
        CommonTree string_literal135_tree=null;
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_displayExpression = new RewriteRuleSubtreeStream(adaptor,"rule displayExpression");
        RewriteRuleSubtreeStream stream_conditionalOrExpression = new RewriteRuleSubtreeStream(adaptor,"rule conditionalOrExpression");
        RewriteRuleSubtreeStream stream_statementsExpression = new RewriteRuleSubtreeStream(adaptor,"rule statementsExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:292:3: ( 'elseif' conditionalOrExpression displayExpression 'then' statementsExpression -> ^( 'elseif' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:293:3: 'elseif' conditionalOrExpression displayExpression 'then' statementsExpression
            {
            	string_literal132=(IToken)Match(input,72,FOLLOW_72_in_elseIfExpression1596); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_72.Add(string_literal132);

            	PushFollow(FOLLOW_conditionalOrExpression_in_elseIfExpression1598);
            	conditionalOrExpression133 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_conditionalOrExpression.Add(conditionalOrExpression133.Tree);
            	PushFollow(FOLLOW_displayExpression_in_elseIfExpression1600);
            	displayExpression134 = displayExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression134.Tree);
            	string_literal135=(IToken)Match(input,70,FOLLOW_70_in_elseIfExpression1602); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_70.Add(string_literal135);

            	PushFollow(FOLLOW_statementsExpression_in_elseIfExpression1604);
            	statementsExpression136 = statementsExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementsExpression.Add(statementsExpression136.Tree);


            	// AST REWRITE
            	// elements:          70, 72, statementsExpression, conditionalOrExpression, displayExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 294:5: -> ^( 'elseif' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:295:7: ^( 'elseif' displayExpression conditionalOrExpression ^( 'then' statementsExpression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_72.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_displayExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_conditionalOrExpression.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:297:9: ^( 'then' statementsExpression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_70.NextNode(), root_2);

            	    adaptor.AddChild(root_2, stream_statementsExpression.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, elseIfExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "elseIfExpression"

    public class elseExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elseExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:301:1: elseExpression : 'else' statementsExpression -> ^( 'else' statementsExpression ) ;
    public CalcETreeParser.elseExpression_return elseExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.elseExpression_return retval = new CalcETreeParser.elseExpression_return();
        retval.Start = input.LT(1);
        int elseExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal137 = null;
        CalcETreeParser.statementsExpression_return statementsExpression138 = default(CalcETreeParser.statementsExpression_return);


        CommonTree string_literal137_tree=null;
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_statementsExpression = new RewriteRuleSubtreeStream(adaptor,"rule statementsExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:302:3: ( 'else' statementsExpression -> ^( 'else' statementsExpression ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:303:3: 'else' statementsExpression
            {
            	string_literal137=(IToken)Match(input,73,FOLLOW_73_in_elseExpression1670); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_73.Add(string_literal137);

            	PushFollow(FOLLOW_statementsExpression_in_elseExpression1672);
            	statementsExpression138 = statementsExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementsExpression.Add(statementsExpression138.Tree);


            	// AST REWRITE
            	// elements:          statementsExpression, 73
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 304:5: -> ^( 'else' statementsExpression )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:305:7: ^( 'else' statementsExpression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_73.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_statementsExpression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, elseExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "elseExpression"

    public class whileExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "whileExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:308:1: whileExpression : 'while' conditionalOrExpression displayExpression '[' statementsExpression ']' 'endWhile' -> ^( 'while' displayExpression conditionalOrExpression '[' statementsExpression ']' 'endWhile' ) ;
    public CalcETreeParser.whileExpression_return whileExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.whileExpression_return retval = new CalcETreeParser.whileExpression_return();
        retval.Start = input.LT(1);
        int whileExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal139 = null;
        IToken char_literal142 = null;
        IToken char_literal144 = null;
        IToken string_literal145 = null;
        CalcETreeParser.conditionalOrExpression_return conditionalOrExpression140 = default(CalcETreeParser.conditionalOrExpression_return);

        CalcETreeParser.displayExpression_return displayExpression141 = default(CalcETreeParser.displayExpression_return);

        CalcETreeParser.statementsExpression_return statementsExpression143 = default(CalcETreeParser.statementsExpression_return);


        CommonTree string_literal139_tree=null;
        CommonTree char_literal142_tree=null;
        CommonTree char_literal144_tree=null;
        CommonTree string_literal145_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_displayExpression = new RewriteRuleSubtreeStream(adaptor,"rule displayExpression");
        RewriteRuleSubtreeStream stream_conditionalOrExpression = new RewriteRuleSubtreeStream(adaptor,"rule conditionalOrExpression");
        RewriteRuleSubtreeStream stream_statementsExpression = new RewriteRuleSubtreeStream(adaptor,"rule statementsExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:309:3: ( 'while' conditionalOrExpression displayExpression '[' statementsExpression ']' 'endWhile' -> ^( 'while' displayExpression conditionalOrExpression '[' statementsExpression ']' 'endWhile' ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:310:3: 'while' conditionalOrExpression displayExpression '[' statementsExpression ']' 'endWhile'
            {
            	string_literal139=(IToken)Match(input,74,FOLLOW_74_in_whileExpression1705); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_74.Add(string_literal139);

            	PushFollow(FOLLOW_conditionalOrExpression_in_whileExpression1707);
            	conditionalOrExpression140 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_conditionalOrExpression.Add(conditionalOrExpression140.Tree);
            	PushFollow(FOLLOW_displayExpression_in_whileExpression1709);
            	displayExpression141 = displayExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_displayExpression.Add(displayExpression141.Tree);
            	char_literal142=(IToken)Match(input,49,FOLLOW_49_in_whileExpression1711); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal142);

            	PushFollow(FOLLOW_statementsExpression_in_whileExpression1713);
            	statementsExpression143 = statementsExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementsExpression.Add(statementsExpression143.Tree);
            	char_literal144=(IToken)Match(input,50,FOLLOW_50_in_whileExpression1715); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal144);

            	string_literal145=(IToken)Match(input,75,FOLLOW_75_in_whileExpression1717); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_75.Add(string_literal145);



            	// AST REWRITE
            	// elements:          50, displayExpression, statementsExpression, conditionalOrExpression, 75, 49, 74
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 311:5: -> ^( 'while' displayExpression conditionalOrExpression '[' statementsExpression ']' 'endWhile' )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:312:7: ^( 'while' displayExpression conditionalOrExpression '[' statementsExpression ']' 'endWhile' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_74.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_displayExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_conditionalOrExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_49.NextNode());
            	    adaptor.AddChild(root_1, stream_statementsExpression.NextTree());
            	    adaptor.AddChild(root_1, stream_50.NextNode());
            	    adaptor.AddChild(root_1, stream_75.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 27, whileExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "whileExpression"

    public class invokeExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "invokeExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:315:1: invokeExpression : 'invoke' primaryForMethod ;
    public CalcETreeParser.invokeExpression_return invokeExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.invokeExpression_return retval = new CalcETreeParser.invokeExpression_return();
        retval.Start = input.LT(1);
        int invokeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal146 = null;
        CalcETreeParser.primaryForMethod_return primaryForMethod147 = default(CalcETreeParser.primaryForMethod_return);


        CommonTree string_literal146_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:316:3: ( 'invoke' primaryForMethod )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:317:3: 'invoke' primaryForMethod
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal146=(IToken)Match(input,76,FOLLOW_76_in_invokeExpression1760); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal146_tree = (CommonTree)adaptor.Create(string_literal146);
            		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal146_tree, root_0);
            	}
            	PushFollow(FOLLOW_primaryForMethod_in_invokeExpression1763);
            	primaryForMethod147 = primaryForMethod();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryForMethod147.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 28, invokeExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "invokeExpression"

    public class multipleLookupExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multipleLookupExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:320:1: multipleLookupExpression : 'multipleLookup' identifier '[' parameters ']' '[' parameters ']' -> ^( 'multipleLookup' identifier ^( InputParameters parameters ) ^( OutputParameters parameters ) ) ;
    public CalcETreeParser.multipleLookupExpression_return multipleLookupExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.multipleLookupExpression_return retval = new CalcETreeParser.multipleLookupExpression_return();
        retval.Start = input.LT(1);
        int multipleLookupExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal148 = null;
        IToken char_literal150 = null;
        IToken char_literal152 = null;
        IToken char_literal153 = null;
        IToken char_literal155 = null;
        CalcETreeParser.identifier_return identifier149 = default(CalcETreeParser.identifier_return);

        CalcETreeParser.parameters_return parameters151 = default(CalcETreeParser.parameters_return);

        CalcETreeParser.parameters_return parameters154 = default(CalcETreeParser.parameters_return);


        CommonTree string_literal148_tree=null;
        CommonTree char_literal150_tree=null;
        CommonTree char_literal152_tree=null;
        CommonTree char_literal153_tree=null;
        CommonTree char_literal155_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_parameters = new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:321:3: ( 'multipleLookup' identifier '[' parameters ']' '[' parameters ']' -> ^( 'multipleLookup' identifier ^( InputParameters parameters ) ^( OutputParameters parameters ) ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:322:3: 'multipleLookup' identifier '[' parameters ']' '[' parameters ']'
            {
            	string_literal148=(IToken)Match(input,77,FOLLOW_77_in_multipleLookupExpression1778); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(string_literal148);

            	PushFollow(FOLLOW_identifier_in_multipleLookupExpression1780);
            	identifier149 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier149.Tree);
            	char_literal150=(IToken)Match(input,49,FOLLOW_49_in_multipleLookupExpression1782); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal150);

            	PushFollow(FOLLOW_parameters_in_multipleLookupExpression1784);
            	parameters151 = parameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameters.Add(parameters151.Tree);
            	char_literal152=(IToken)Match(input,50,FOLLOW_50_in_multipleLookupExpression1786); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal152);

            	char_literal153=(IToken)Match(input,49,FOLLOW_49_in_multipleLookupExpression1788); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal153);

            	PushFollow(FOLLOW_parameters_in_multipleLookupExpression1790);
            	parameters154 = parameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameters.Add(parameters154.Tree);
            	char_literal155=(IToken)Match(input,50,FOLLOW_50_in_multipleLookupExpression1792); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal155);



            	// AST REWRITE
            	// elements:          77, parameters, identifier, parameters
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 323:5: -> ^( 'multipleLookup' identifier ^( InputParameters parameters ) ^( OutputParameters parameters ) )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:324:7: ^( 'multipleLookup' identifier ^( InputParameters parameters ) ^( OutputParameters parameters ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_77.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:326:9: ^( InputParameters parameters )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(InputParameters, "InputParameters"), root_2);

            	    adaptor.AddChild(root_2, stream_parameters.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:327:9: ^( OutputParameters parameters )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(OutputParameters, "OutputParameters"), root_2);

            	    adaptor.AddChild(root_2, stream_parameters.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 29, multipleLookupExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multipleLookupExpression"

    public class splitLookupExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "splitLookupExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:331:1: splitLookupExpression : 'splitLookup' identifier '[' rhsEntities ']' '[' ( splitLookUpInputParamExpression )? ']' '[' parameters ']' -> ^( 'splitLookup' identifier ^( RateTypeParameter rhsEntities ) ( splitLookUpInputParamExpression )? ^( OutputParameters parameters ) ) ;
    public CalcETreeParser.splitLookupExpression_return splitLookupExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.splitLookupExpression_return retval = new CalcETreeParser.splitLookupExpression_return();
        retval.Start = input.LT(1);
        int splitLookupExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal156 = null;
        IToken char_literal158 = null;
        IToken char_literal160 = null;
        IToken char_literal161 = null;
        IToken char_literal163 = null;
        IToken char_literal164 = null;
        IToken char_literal166 = null;
        CalcETreeParser.identifier_return identifier157 = default(CalcETreeParser.identifier_return);

        CalcETreeParser.rhsEntities_return rhsEntities159 = default(CalcETreeParser.rhsEntities_return);

        CalcETreeParser.splitLookUpInputParamExpression_return splitLookUpInputParamExpression162 = default(CalcETreeParser.splitLookUpInputParamExpression_return);

        CalcETreeParser.parameters_return parameters165 = default(CalcETreeParser.parameters_return);


        CommonTree string_literal156_tree=null;
        CommonTree char_literal158_tree=null;
        CommonTree char_literal160_tree=null;
        CommonTree char_literal161_tree=null;
        CommonTree char_literal163_tree=null;
        CommonTree char_literal164_tree=null;
        CommonTree char_literal166_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_splitLookUpInputParamExpression = new RewriteRuleSubtreeStream(adaptor,"rule splitLookUpInputParamExpression");
        RewriteRuleSubtreeStream stream_parameters = new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        RewriteRuleSubtreeStream stream_rhsEntities = new RewriteRuleSubtreeStream(adaptor,"rule rhsEntities");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:332:3: ( 'splitLookup' identifier '[' rhsEntities ']' '[' ( splitLookUpInputParamExpression )? ']' '[' parameters ']' -> ^( 'splitLookup' identifier ^( RateTypeParameter rhsEntities ) ( splitLookUpInputParamExpression )? ^( OutputParameters parameters ) ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:333:3: 'splitLookup' identifier '[' rhsEntities ']' '[' ( splitLookUpInputParamExpression )? ']' '[' parameters ']'
            {
            	string_literal156=(IToken)Match(input,78,FOLLOW_78_in_splitLookupExpression1872); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_78.Add(string_literal156);

            	PushFollow(FOLLOW_identifier_in_splitLookupExpression1874);
            	identifier157 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier157.Tree);
            	char_literal158=(IToken)Match(input,49,FOLLOW_49_in_splitLookupExpression1876); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal158);

            	PushFollow(FOLLOW_rhsEntities_in_splitLookupExpression1878);
            	rhsEntities159 = rhsEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_rhsEntities.Add(rhsEntities159.Tree);
            	char_literal160=(IToken)Match(input,50,FOLLOW_50_in_splitLookupExpression1880); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal160);

            	char_literal161=(IToken)Match(input,49,FOLLOW_49_in_splitLookupExpression1882); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal161);

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:333:52: ( splitLookUpInputParamExpression )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == Literal || LA23_0 == 48 || (LA23_0 >= 64 && LA23_0 <= 67) || (LA23_0 >= 95 && LA23_0 <= 97) || LA23_0 == 99 || LA23_0 == 102 || (LA23_0 >= 104 && LA23_0 <= 107)) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: splitLookUpInputParamExpression
            	        {
            	        	PushFollow(FOLLOW_splitLookUpInputParamExpression_in_splitLookupExpression1884);
            	        	splitLookUpInputParamExpression162 = splitLookUpInputParamExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_splitLookUpInputParamExpression.Add(splitLookUpInputParamExpression162.Tree);

            	        }
            	        break;

            	}

            	char_literal163=(IToken)Match(input,50,FOLLOW_50_in_splitLookupExpression1887); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal163);

            	char_literal164=(IToken)Match(input,49,FOLLOW_49_in_splitLookupExpression1889); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal164);

            	PushFollow(FOLLOW_parameters_in_splitLookupExpression1891);
            	parameters165 = parameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameters.Add(parameters165.Tree);
            	char_literal166=(IToken)Match(input,50,FOLLOW_50_in_splitLookupExpression1893); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal166);



            	// AST REWRITE
            	// elements:          rhsEntities, identifier, parameters, splitLookUpInputParamExpression, 78
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 334:5: -> ^( 'splitLookup' identifier ^( RateTypeParameter rhsEntities ) ( splitLookUpInputParamExpression )? ^( OutputParameters parameters ) )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:335:7: ^( 'splitLookup' identifier ^( RateTypeParameter rhsEntities ) ( splitLookUpInputParamExpression )? ^( OutputParameters parameters ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_78.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:337:9: ^( RateTypeParameter rhsEntities )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RateTypeParameter, "RateTypeParameter"), root_2);

            	    adaptor.AddChild(root_2, stream_rhsEntities.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:338:9: ( splitLookUpInputParamExpression )?
            	    if ( stream_splitLookUpInputParamExpression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_splitLookUpInputParamExpression.NextTree());

            	    }
            	    stream_splitLookUpInputParamExpression.Reset();
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:339:9: ^( OutputParameters parameters )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(OutputParameters, "OutputParameters"), root_2);

            	    adaptor.AddChild(root_2, stream_parameters.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 30, splitLookupExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "splitLookupExpression"

    public class splitLookUpInputParamExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "splitLookUpInputParamExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:344:1: splitLookUpInputParamExpression : parameters -> ^( InputParameters parameters ) ;
    public CalcETreeParser.splitLookUpInputParamExpression_return splitLookUpInputParamExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.splitLookUpInputParamExpression_return retval = new CalcETreeParser.splitLookUpInputParamExpression_return();
        retval.Start = input.LT(1);
        int splitLookUpInputParamExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.parameters_return parameters167 = default(CalcETreeParser.parameters_return);


        RewriteRuleSubtreeStream stream_parameters = new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:345:3: ( parameters -> ^( InputParameters parameters ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:346:3: parameters
            {
            	PushFollow(FOLLOW_parameters_in_splitLookUpInputParamExpression1983);
            	parameters167 = parameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameters.Add(parameters167.Tree);


            	// AST REWRITE
            	// elements:          parameters
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 347:5: -> ^( InputParameters parameters )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:348:7: ^( InputParameters parameters )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(InputParameters, "InputParameters"), root_1);

            	    adaptor.AddChild(root_1, stream_parameters.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 31, splitLookUpInputParamExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "splitLookUpInputParamExpression"

    public class multipleLookupReturnArguments_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multipleLookupReturnArguments"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:351:1: multipleLookupReturnArguments : multipleReturnArgumentType ( ',' multipleReturnArgumentType )* ;
    public CalcETreeParser.multipleLookupReturnArguments_return multipleLookupReturnArguments() // throws RecognitionException [1]
    {   
        CalcETreeParser.multipleLookupReturnArguments_return retval = new CalcETreeParser.multipleLookupReturnArguments_return();
        retval.Start = input.LT(1);
        int multipleLookupReturnArguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal169 = null;
        CalcETreeParser.multipleReturnArgumentType_return multipleReturnArgumentType168 = default(CalcETreeParser.multipleReturnArgumentType_return);

        CalcETreeParser.multipleReturnArgumentType_return multipleReturnArgumentType170 = default(CalcETreeParser.multipleReturnArgumentType_return);


        CommonTree char_literal169_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:352:3: ( multipleReturnArgumentType ( ',' multipleReturnArgumentType )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:353:3: multipleReturnArgumentType ( ',' multipleReturnArgumentType )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multipleReturnArgumentType_in_multipleLookupReturnArguments2016);
            	multipleReturnArgumentType168 = multipleReturnArgumentType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multipleReturnArgumentType168.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:353:30: ( ',' multipleReturnArgumentType )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == 46) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:353:31: ',' multipleReturnArgumentType
            			    {
            			    	char_literal169=(IToken)Match(input,46,FOLLOW_46_in_multipleLookupReturnArguments2019); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_multipleReturnArgumentType_in_multipleLookupReturnArguments2022);
            			    	multipleReturnArgumentType170 = multipleReturnArgumentType();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multipleReturnArgumentType170.Tree);

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 32, multipleLookupReturnArguments_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multipleLookupReturnArguments"

    public class multipleReturnArgumentType_return : ParserRuleReturnScope
    {
        public MetadataInfo multipleReturnArgumentTypeInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multipleReturnArgumentType"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:356:1: multipleReturnArgumentType returns [MetadataInfo multipleReturnArgumentTypeInfo] : rhsEntities ;
    public CalcETreeParser.multipleReturnArgumentType_return multipleReturnArgumentType() // throws RecognitionException [1]
    {   
        CalcETreeParser.multipleReturnArgumentType_return retval = new CalcETreeParser.multipleReturnArgumentType_return();
        retval.Start = input.LT(1);
        int multipleReturnArgumentType_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.rhsEntities_return rhsEntities171 = default(CalcETreeParser.rhsEntities_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:357:3: ( rhsEntities )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:358:3: rhsEntities
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_rhsEntities_in_multipleReturnArgumentType2042);
            	rhsEntities171 = rhsEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rhsEntities171.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  retval.multipleReturnArgumentTypeInfo =  ((rhsEntities171 != null) ? rhsEntities171.rhsEntitiesInfo : default(MetadataInfo)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 33, multipleReturnArgumentType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multipleReturnArgumentType"

    public class assignmentOperator_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignmentOperator"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:361:1: assignmentOperator : '=' ;
    public CalcETreeParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        CalcETreeParser.assignmentOperator_return retval = new CalcETreeParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal172 = null;

        CommonTree char_literal172_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:362:3: ( '=' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:363:3: '='
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal172=(IToken)Match(input,79,FOLLOW_79_in_assignmentOperator2059); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal172_tree = (CommonTree)adaptor.Create(char_literal172);
            		adaptor.AddChild(root_0, char_literal172_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 34, assignmentOperator_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "assignmentOperator"

    public class conditionalOrExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "conditionalOrExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:366:1: conditionalOrExpression : ( '(' )? conditionalAndExpression ( ')' )? ( ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )? )* ;
    public CalcETreeParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.conditionalOrExpression_return retval = new CalcETreeParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal173 = null;
        IToken char_literal175 = null;
        IToken set176 = null;
        IToken char_literal177 = null;
        IToken char_literal179 = null;
        CalcETreeParser.conditionalAndExpression_return conditionalAndExpression174 = default(CalcETreeParser.conditionalAndExpression_return);

        CalcETreeParser.conditionalAndExpression_return conditionalAndExpression178 = default(CalcETreeParser.conditionalAndExpression_return);


        CommonTree char_literal173_tree=null;
        CommonTree char_literal175_tree=null;
        CommonTree set176_tree=null;
        CommonTree char_literal177_tree=null;
        CommonTree char_literal179_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:367:3: ( ( '(' )? conditionalAndExpression ( ')' )? ( ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )? )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:368:3: ( '(' )? conditionalAndExpression ( ')' )? ( ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )? )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:368:3: ( '(' )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == 45) )
            	{
            	    int LA25_1 = input.LA(2);

            	    if ( (synpred47_CalcETree()) )
            	    {
            	        alt25 = 1;
            	    }
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: '('
            	        {
            	        	char_literal173=(IToken)Match(input,45,FOLLOW_45_in_conditionalOrExpression2074); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal173_tree = (CommonTree)adaptor.Create(char_literal173);
            	        		adaptor.AddChild(root_0, char_literal173_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression2077);
            	conditionalAndExpression174 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression174.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:368:33: ( ')' )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == 47) )
            	{
            	    int LA26_1 = input.LA(2);

            	    if ( (synpred48_CalcETree()) )
            	    {
            	        alt26 = 1;
            	    }
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ')'
            	        {
            	        	char_literal175=(IToken)Match(input,47,FOLLOW_47_in_conditionalOrExpression2079); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal175_tree = (CommonTree)adaptor.Create(char_literal175);
            	        		adaptor.AddChild(root_0, char_literal175_tree);
            	        	}

            	        }
            	        break;

            	}

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:369:3: ( ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )? )*
            	do 
            	{
            	    int alt30 = 2;
            	    alt30 = dfa30.Predict(input);
            	    switch (alt30) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:370:5: ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )?
            			    {
            			    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:370:5: ( 'OR' | 'AND' )?
            			    	int alt27 = 2;
            			    	int LA27_0 = input.LA(1);

            			    	if ( ((LA27_0 >= 80 && LA27_0 <= 81)) )
            			    	{
            			    	    alt27 = 1;
            			    	}
            			    	switch (alt27) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:
            			    	        {
            			    	        	set176 = (IToken)input.LT(1);
            			    	        	if ( (input.LA(1) >= 80 && input.LA(1) <= 81) ) 
            			    	        	{
            			    	        	    input.Consume();
            			    	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set176));
            			    	        	    state.errorRecovery = false;state.failed = false;
            			    	        	}
            			    	        	else 
            			    	        	{
            			    	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	        	    throw mse;
            			    	        	}


            			    	        }
            			    	        break;

            			    	}

            			    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:5: ( '(' )?
            			    	int alt28 = 2;
            			    	int LA28_0 = input.LA(1);

            			    	if ( (LA28_0 == 45) )
            			    	{
            			    	    int LA28_1 = input.LA(2);

            			    	    if ( (synpred51_CalcETree()) )
            			    	    {
            			    	        alt28 = 1;
            			    	    }
            			    	}
            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: '('
            			    	        {
            			    	        	char_literal177=(IToken)Match(input,45,FOLLOW_45_in_conditionalOrExpression2121); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal177_tree = (CommonTree)adaptor.Create(char_literal177);
            			    	        		adaptor.AddChild(root_0, char_literal177_tree);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression2124);
            			    	conditionalAndExpression178 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression178.Tree);
            			    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:35: ( ')' )?
            			    	int alt29 = 2;
            			    	int LA29_0 = input.LA(1);

            			    	if ( (LA29_0 == 47) )
            			    	{
            			    	    int LA29_1 = input.LA(2);

            			    	    if ( (synpred52_CalcETree()) )
            			    	    {
            			    	        alt29 = 1;
            			    	    }
            			    	}
            			    	switch (alt29) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ')'
            			    	        {
            			    	        	char_literal179=(IToken)Match(input,47,FOLLOW_47_in_conditionalOrExpression2126); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal179_tree = (CommonTree)adaptor.Create(char_literal179);
            			    	        		adaptor.AddChild(root_0, char_literal179_tree);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 35, conditionalOrExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "conditionalOrExpression"

    public class conditionalAndExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "conditionalAndExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:378:1: conditionalAndExpression : ( ( '(' )? equalityExpression | unaryExpressionNot ( ')' )? );
    public CalcETreeParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.conditionalAndExpression_return retval = new CalcETreeParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal180 = null;
        IToken char_literal183 = null;
        CalcETreeParser.equalityExpression_return equalityExpression181 = default(CalcETreeParser.equalityExpression_return);

        CalcETreeParser.unaryExpressionNot_return unaryExpressionNot182 = default(CalcETreeParser.unaryExpressionNot_return);


        CommonTree char_literal180_tree=null;
        CommonTree char_literal183_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:379:3: ( ( '(' )? equalityExpression | unaryExpressionNot ( ')' )? )
            int alt33 = 2;
            int LA33_0 = input.LA(1);

            if ( (LA33_0 == Literal || LA33_0 == 45 || LA33_0 == 48 || (LA33_0 >= 64 && LA33_0 <= 67) || (LA33_0 >= 95 && LA33_0 <= 97) || LA33_0 == 99 || LA33_0 == 102 || (LA33_0 >= 104 && LA33_0 <= 107)) )
            {
                alt33 = 1;
            }
            else if ( (LA33_0 == 100) )
            {
                alt33 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d33s0 =
                    new NoViableAltException("", 33, 0, input);

                throw nvae_d33s0;
            }
            switch (alt33) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:3: ( '(' )? equalityExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:3: ( '(' )?
                    	int alt31 = 2;
                    	alt31 = dfa31.Predict(input);
                    	switch (alt31) 
                    	{
                    	    case 1 :
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: '('
                    	        {
                    	        	char_literal180=(IToken)Match(input,45,FOLLOW_45_in_conditionalAndExpression2148); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{char_literal180_tree = (CommonTree)adaptor.Create(char_literal180);
                    	        		adaptor.AddChild(root_0, char_literal180_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression2151);
                    	equalityExpression181 = equalityExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression181.Tree);

                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:29: unaryExpressionNot ( ')' )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNot_in_conditionalAndExpression2155);
                    	unaryExpressionNot182 = unaryExpressionNot();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpressionNot182.Tree);
                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:48: ( ')' )?
                    	int alt32 = 2;
                    	int LA32_0 = input.LA(1);

                    	if ( (LA32_0 == 47) )
                    	{
                    	    int LA32_1 = input.LA(2);

                    	    if ( (synpred56_CalcETree()) )
                    	    {
                    	        alt32 = 1;
                    	    }
                    	}
                    	switch (alt32) 
                    	{
                    	    case 1 :
                    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ')'
                    	        {
                    	        	char_literal183=(IToken)Match(input,47,FOLLOW_47_in_conditionalAndExpression2157); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{char_literal183_tree = (CommonTree)adaptor.Create(char_literal183);
                    	        		adaptor.AddChild(root_0, char_literal183_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 36, conditionalAndExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "conditionalAndExpression"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        public MetadataInfo equalityExpressionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:383:1: equalityExpression returns [MetadataInfo equalityExpressionInfo] : ( (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+ | (c= multiplicativeExpression d= inNotInExpression )+ );
    public CalcETreeParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.equalityExpression_return retval = new CalcETreeParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.multiplicativeExpression_return a = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.multiplicativeExpression_return b = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.multiplicativeExpression_return c = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.inNotInExpression_return d = default(CalcETreeParser.inNotInExpression_return);

        CalcETreeParser.relationalOp_return relationalOp184 = default(CalcETreeParser.relationalOp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:384:3: ( (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+ | (c= multiplicativeExpression d= inNotInExpression )+ )
            int alt36 = 2;
            alt36 = dfa36.Predict(input);
            switch (alt36) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:3: (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:3: (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+
                    	int cnt34 = 0;
                    	do 
                    	{
                    	    int alt34 = 2;
                    	    alt34 = dfa34.Predict(input);
                    	    switch (alt34) 
                    		{
                    			case 1 :
                    			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:5: a= multiplicativeExpression relationalOp b= multiplicativeExpression
                    			    {
                    			    	PushFollow(FOLLOW_multiplicativeExpression_in_equalityExpression2184);
                    			    	a = multiplicativeExpression();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
                    			    	PushFollow(FOLLOW_relationalOp_in_equalityExpression2190);
                    			    	relationalOp184 = relationalOp();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalOp184.Tree);
                    			    	PushFollow(FOLLOW_multiplicativeExpression_in_equalityExpression2197);
                    			    	b = multiplicativeExpression();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
                    			    	if ( (state.backtracking==0) )
                    			    	{

                    			    	       if(isValidate)
                    			    	       {
                    			    	       
                    			    	       if((((a != null) ? a.multiplicativeExpressionInfo : default(MetadataInfo)).datatype != ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype) &&
                    			    	        !((((a != null) ? a.multiplicativeExpressionInfo : default(MetadataInfo)).datatype=="double" &&  ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype=="integer")
                    			    	       ||(((a != null) ? a.multiplicativeExpressionInfo : default(MetadataInfo)).datatype=="integer" &&  ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype=="double"))
                    			    	       && ((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo)).datatype !="null" )
                    			    	       throw new DataMisMatchedException(){ ErrorCause=((relationalOp184 != null) ? input.ToString((IToken)(relationalOp184.Start),(IToken)(relationalOp184.Stop)) : null)+" cannot be applied between different datatypes "+((a != null) ? input.ToString((IToken)(a.Start),(IToken)(a.Stop)) : null)+", "+((b != null) ? input.ToString((IToken)(b.Start),(IToken)(b.Stop)) : null) };     
                    			    	       else
                    			    	       retval.equalityExpressionInfo = ((a != null) ? a.multiplicativeExpressionInfo : default(MetadataInfo));
                    			    	       }
                    			    	      
                    			    	}

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt34 >= 1 ) goto loop34;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee34 =
                    		                new EarlyExitException(34, input);
                    		            throw eee34;
                    	    }
                    	    cnt34++;
                    	} while (true);

                    	loop34:
                    		;	// Stops C# compiler whining that label 'loop34' has no statements


                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:401:7: (c= multiplicativeExpression d= inNotInExpression )+
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:401:7: (c= multiplicativeExpression d= inNotInExpression )+
                    	int cnt35 = 0;
                    	do 
                    	{
                    	    int alt35 = 2;
                    	    alt35 = dfa35.Predict(input);
                    	    switch (alt35) 
                    		{
                    			case 1 :
                    			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:401:9: c= multiplicativeExpression d= inNotInExpression
                    			    {
                    			    	PushFollow(FOLLOW_multiplicativeExpression_in_equalityExpression2225);
                    			    	c = multiplicativeExpression();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, c.Tree);
                    			    	PushFollow(FOLLOW_inNotInExpression_in_equalityExpression2232);
                    			    	d = inNotInExpression();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(d.Tree, root_0);
                    			    	if ( (state.backtracking==0) )
                    			    	{

                    			    	       if(isValidate)
                    			    	       {
                    			    	       if(!((((c != null) ? c.multiplicativeExpressionInfo : default(MetadataInfo)).datatype=="double" &&  ((d != null) ? d.inNotInExpressionInfo : default(MetadataInfo)).datatype=="integer"))&&
                    			    	       (((c != null) ? c.multiplicativeExpressionInfo : default(MetadataInfo)).datatype != ((d != null) ? d.inNotInExpressionInfo : default(MetadataInfo)).datatype) )
                    			    	       throw new DataMisMatchedException(){ ErrorCause=((d != null) ? input.ToString((IToken)(d.Start),(IToken)(d.Stop)) : null)+" cannot be applied between different datatypes" };
                    			    	       else
                    			    	       retval.equalityExpressionInfo = ((c != null) ? c.multiplicativeExpressionInfo : default(MetadataInfo));
                    			    	       }
                    			    	      
                    			    	}

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt35 >= 1 ) goto loop35;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee35 =
                    		                new EarlyExitException(35, input);
                    		            throw eee35;
                    	    }
                    	    cnt35++;
                    	} while (true);

                    	loop35:
                    		;	// Stops C# compiler whining that label 'loop35' has no statements


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 37, equalityExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public class inNotInExpression_return : ParserRuleReturnScope
    {
        public MetadataInfo inNotInExpressionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "inNotInExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:416:1: inNotInExpression returns [MetadataInfo inNotInExpressionInfo] : inNotInOperator '(' a= parameters ')' -> ^( inNotInOperator parameters ) ;
    public CalcETreeParser.inNotInExpression_return inNotInExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.inNotInExpression_return retval = new CalcETreeParser.inNotInExpression_return();
        retval.Start = input.LT(1);
        int inNotInExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal186 = null;
        IToken char_literal187 = null;
        CalcETreeParser.parameters_return a = default(CalcETreeParser.parameters_return);

        CalcETreeParser.inNotInOperator_return inNotInOperator185 = default(CalcETreeParser.inNotInOperator_return);


        CommonTree char_literal186_tree=null;
        CommonTree char_literal187_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_inNotInOperator = new RewriteRuleSubtreeStream(adaptor,"rule inNotInOperator");
        RewriteRuleSubtreeStream stream_parameters = new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:417:3: ( inNotInOperator '(' a= parameters ')' -> ^( inNotInOperator parameters ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:418:3: inNotInOperator '(' a= parameters ')'
            {
            	PushFollow(FOLLOW_inNotInOperator_in_inNotInExpression2269);
            	inNotInOperator185 = inNotInOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_inNotInOperator.Add(inNotInOperator185.Tree);
            	char_literal186=(IToken)Match(input,45,FOLLOW_45_in_inNotInExpression2271); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal186);

            	PushFollow(FOLLOW_parameters_in_inNotInExpression2277);
            	a = parameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parameters.Add(a.Tree);
            	char_literal187=(IToken)Match(input,47,FOLLOW_47_in_inNotInExpression2279); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal187);

            	if ( (state.backtracking==0) )
            	{
            	   
            	      //retval.inNotInExpressionInfo =  ((a != null) ? a.parametersInfo : default(List<MetadataInfo>))[0];
            	      retval.inNotInExpressionInfo =  new MetadataInfo();
            	      List<MetadataInfo> paramsInfo=((a != null) ? a.parametersInfo : default(List<MetadataInfo>));
            	      if(paramsInfo.Count(itm=>itm.datatype == "integer") == paramsInfo.Count())    
            	       retval.inNotInExpressionInfo.datatype = "integer";    
            	      else if(paramsInfo.Count(itm=>itm.datatype == "double" || itm.datatype == "integer") == paramsInfo.Count()) 
            	      retval.inNotInExpressionInfo.datatype = "double";
            	      else  if(paramsInfo.Count(itm=>itm.datatype == "string") == paramsInfo.Count())        
            	       retval.inNotInExpressionInfo.datatype = "string";    
            	      else
            	      throw new DataMisMatchedException(){ ErrorCause="Invalid datatype, All parameters should be of same datatype."};         
            	      
            	}


            	// AST REWRITE
            	// elements:          parameters, inNotInOperator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 436:5: -> ^( inNotInOperator parameters )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:437:7: ^( inNotInOperator parameters )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_inNotInOperator.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_parameters.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 38, inNotInExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "inNotInExpression"

    public class inNotInOperator_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "inNotInOperator"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:442:1: inNotInOperator : ( 'IN' | 'NOTIN' );
    public CalcETreeParser.inNotInOperator_return inNotInOperator() // throws RecognitionException [1]
    {   
        CalcETreeParser.inNotInOperator_return retval = new CalcETreeParser.inNotInOperator_return();
        retval.Start = input.LT(1);
        int inNotInOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set188 = null;

        CommonTree set188_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:443:3: ( 'IN' | 'NOTIN' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set188 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 82 && input.LA(1) <= 83) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set188));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 39, inNotInOperator_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "inNotInOperator"

    public class relationalOp_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationalOp"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:448:1: relationalOp : ( 'LE' | 'GE' | 'GT' | 'LT' | 'EQ' | 'NE' ) ;
    public CalcETreeParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        CalcETreeParser.relationalOp_return retval = new CalcETreeParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set189 = null;

        CommonTree set189_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:449:3: ( ( 'LE' | 'GE' | 'GT' | 'LT' | 'EQ' | 'NE' ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:450:3: ( 'LE' | 'GE' | 'GT' | 'LT' | 'EQ' | 'NE' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set189 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 84 && input.LA(1) <= 89) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set189));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 40, relationalOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "relationalOp"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        public MetadataInfo multiplicativeExpressionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:462:1: multiplicativeExpression returns [MetadataInfo multiplicativeExpressionInfo] : a= bodmasValuesWithBraces ( ( '+' | '-' | '*' | '/' | '%' ) b= bodmasValuesWithBraces )* ;
    public CalcETreeParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.multiplicativeExpression_return retval = new CalcETreeParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set190 = null;
        CalcETreeParser.bodmasValuesWithBraces_return a = default(CalcETreeParser.bodmasValuesWithBraces_return);

        CalcETreeParser.bodmasValuesWithBraces_return b = default(CalcETreeParser.bodmasValuesWithBraces_return);


        CommonTree set190_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:463:3: (a= bodmasValuesWithBraces ( ( '+' | '-' | '*' | '/' | '%' ) b= bodmasValuesWithBraces )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:464:2: a= bodmasValuesWithBraces ( ( '+' | '-' | '*' | '/' | '%' ) b= bodmasValuesWithBraces )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bodmasValuesWithBraces_in_multiplicativeExpression2449);
            	a = bodmasValuesWithBraces();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{

            	    retval.multiplicativeExpressionInfo =  ((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo));
            	   
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:468:3: ( ( '+' | '-' | '*' | '/' | '%' ) b= bodmasValuesWithBraces )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( ((LA37_0 >= 90 && LA37_0 <= 94)) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:470:5: ( '+' | '-' | '*' | '/' | '%' ) b= bodmasValuesWithBraces
            			    {
            			    	set190 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 90 && input.LA(1) <= 94) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set190));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_bodmasValuesWithBraces_in_multiplicativeExpression2529);
            			    	b = bodmasValuesWithBraces();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	       if(isValidate)
            			    	       {
            			    	       if(((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "double" && ((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "integer" && ((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "lookup" && ((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "price" )
            			    	         throw new DataMisMatchedException(){ ErrorCause="Invalid datatype. Expecting a double datatye variable,"+((a != null) ? input.ToString((IToken)(a.Start),(IToken)(a.Stop)) : null) };
            			    	       if( ((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "double" && ((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "integer" && ((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "lookup" && ((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype != "price")
            			    	         throw new DataMisMatchedException(){ ErrorCause="Invalid datatype. Expecting a double datatye variable,"+((b != null) ? input.ToString((IToken)(b.Start),(IToken)(b.Stop)) : null) };
            			    	       if(((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype=="double")       
            			    	         retval.multiplicativeExpressionInfo = ((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo));  
            			    	       else if(((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype!="lookup" && ((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype!="price")
            			    	         retval.multiplicativeExpressionInfo = ((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo));
            			    	       else if(((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype!="lookup" && ((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo)).datatype!="price")
            			    	         retval.multiplicativeExpressionInfo = ((b != null) ? b.bodmasValuesWithBracesInfo : default(MetadataInfo));   
            			    	       else
            			    	         retval.multiplicativeExpressionInfo = ((a != null) ? a.bodmasValuesWithBracesInfo : default(MetadataInfo));
            			    	       }
            			    	     
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 41, multiplicativeExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class bodmasValuesWithBraces_return : ParserRuleReturnScope
    {
        public MetadataInfo bodmasValuesWithBracesInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "bodmasValuesWithBraces"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:498:1: bodmasValuesWithBraces returns [MetadataInfo bodmasValuesWithBracesInfo] : ( '(' multiplicativeExpression ')' | bodmasValues );
    public CalcETreeParser.bodmasValuesWithBraces_return bodmasValuesWithBraces() // throws RecognitionException [1]
    {   
        CalcETreeParser.bodmasValuesWithBraces_return retval = new CalcETreeParser.bodmasValuesWithBraces_return();
        retval.Start = input.LT(1);
        int bodmasValuesWithBraces_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal191 = null;
        IToken char_literal193 = null;
        CalcETreeParser.multiplicativeExpression_return multiplicativeExpression192 = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.bodmasValues_return bodmasValues194 = default(CalcETreeParser.bodmasValues_return);


        CommonTree char_literal191_tree=null;
        CommonTree char_literal193_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:499:3: ( '(' multiplicativeExpression ')' | bodmasValues )
            int alt38 = 2;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == 45) )
            {
                alt38 = 1;
            }
            else if ( (LA38_0 == Literal || LA38_0 == 48 || (LA38_0 >= 64 && LA38_0 <= 67) || (LA38_0 >= 95 && LA38_0 <= 97) || LA38_0 == 99 || LA38_0 == 102 || (LA38_0 >= 104 && LA38_0 <= 107)) )
            {
                alt38 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d38s0 =
                    new NoViableAltException("", 38, 0, input);

                throw nvae_d38s0;
            }
            switch (alt38) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:500:3: '(' multiplicativeExpression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal191=(IToken)Match(input,45,FOLLOW_45_in_bodmasValuesWithBraces2557); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal191_tree = (CommonTree)adaptor.Create(char_literal191);
                    		adaptor.AddChild(root_0, char_literal191_tree);
                    	}
                    	PushFollow(FOLLOW_multiplicativeExpression_in_bodmasValuesWithBraces2559);
                    	multiplicativeExpression192 = multiplicativeExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression192.Tree);
                    	char_literal193=(IToken)Match(input,47,FOLLOW_47_in_bodmasValuesWithBraces2561); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal193_tree = (CommonTree)adaptor.Create(char_literal193);
                    		adaptor.AddChild(root_0, char_literal193_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.bodmasValuesWithBracesInfo = ((multiplicativeExpression192 != null) ? multiplicativeExpression192.multiplicativeExpressionInfo : default(MetadataInfo)); 
                    	}

                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:501:5: bodmasValues
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bodmasValues_in_bodmasValuesWithBraces2569);
                    	bodmasValues194 = bodmasValues();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bodmasValues194.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.bodmasValuesWithBracesInfo = ((bodmasValues194 != null) ? bodmasValues194.bodmasValuesInfo : default(MetadataInfo)); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 42, bodmasValuesWithBraces_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "bodmasValuesWithBraces"

    public class bodmasValues_return : ParserRuleReturnScope
    {
        public MetadataInfo bodmasValuesInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "bodmasValues"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:504:1: bodmasValues returns [MetadataInfo bodmasValuesInfo] : ( rhsEntities | methodexpression | lookupExpression | callBlock );
    public CalcETreeParser.bodmasValues_return bodmasValues() // throws RecognitionException [1]
    {   
        CalcETreeParser.bodmasValues_return retval = new CalcETreeParser.bodmasValues_return();
        retval.Start = input.LT(1);
        int bodmasValues_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.rhsEntities_return rhsEntities195 = default(CalcETreeParser.rhsEntities_return);

        CalcETreeParser.methodexpression_return methodexpression196 = default(CalcETreeParser.methodexpression_return);

        CalcETreeParser.lookupExpression_return lookupExpression197 = default(CalcETreeParser.lookupExpression_return);

        CalcETreeParser.callBlock_return callBlock198 = default(CalcETreeParser.callBlock_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:505:3: ( rhsEntities | methodexpression | lookupExpression | callBlock )
            int alt39 = 4;
            alt39 = dfa39.Predict(input);
            switch (alt39) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:506:3: rhsEntities
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_rhsEntities_in_bodmasValues2589);
                    	rhsEntities195 = rhsEntities();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rhsEntities195.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.bodmasValuesInfo = ((rhsEntities195 != null) ? rhsEntities195.rhsEntitiesInfo : default(MetadataInfo)); 
                    	}

                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:507:5: methodexpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodexpression_in_bodmasValues2597);
                    	methodexpression196 = methodexpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodexpression196.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.bodmasValuesInfo = ((methodexpression196 != null) ? methodexpression196.methodexpressionInfo : default(MetadataInfo)); 
                    	}

                    }
                    break;
                case 3 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:508:5: lookupExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lookupExpression_in_bodmasValues2605);
                    	lookupExpression197 = lookupExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lookupExpression197.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.bodmasValuesInfo = ((lookupExpression197 != null) ? lookupExpression197.lookupExpressionInfo : default(MetadataInfo)); 
                    	}

                    }
                    break;
                case 4 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:509:5: callBlock
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callBlock_in_bodmasValues2613);
                    	callBlock198 = callBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callBlock198.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	  retval.bodmasValuesInfo = ((callBlock198 != null) ? callBlock198.callBlockInfo : default(MetadataInfo)); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 43, bodmasValues_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "bodmasValues"

    public class lookupExpression_return : ParserRuleReturnScope
    {
        public MetadataInfo lookupExpressionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lookupExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:512:1: lookupExpression returns [MetadataInfo lookupExpressionInfo] : lookupTypes primaryForMethod ;
    public CalcETreeParser.lookupExpression_return lookupExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.lookupExpression_return retval = new CalcETreeParser.lookupExpression_return();
        retval.Start = input.LT(1);
        int lookupExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.lookupTypes_return lookupTypes199 = default(CalcETreeParser.lookupTypes_return);

        CalcETreeParser.primaryForMethod_return primaryForMethod200 = default(CalcETreeParser.primaryForMethod_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:513:3: ( lookupTypes primaryForMethod )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:514:3: lookupTypes primaryForMethod
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_lookupTypes_in_lookupExpression2633);
            	lookupTypes199 = lookupTypes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(lookupTypes199.Tree, root_0);
            	PushFollow(FOLLOW_primaryForMethod_in_lookupExpression2637);
            	primaryForMethod200 = primaryForMethod();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryForMethod200.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  retval.lookupExpressionInfo =  new MetadataInfo(){datatype="lookup"};
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 44, lookupExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lookupExpression"

    public class lookupTypes_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lookupTypes"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:517:1: lookupTypes : ( 'lookup' | 'singleLookup' ) ;
    public CalcETreeParser.lookupTypes_return lookupTypes() // throws RecognitionException [1]
    {   
        CalcETreeParser.lookupTypes_return retval = new CalcETreeParser.lookupTypes_return();
        retval.Start = input.LT(1);
        int lookupTypes_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set201 = null;

        CommonTree set201_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:518:3: ( ( 'lookup' | 'singleLookup' ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:519:3: ( 'lookup' | 'singleLookup' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set201 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 95 && input.LA(1) <= 96) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set201));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 45, lookupTypes_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lookupTypes"

    public class methodexpression_return : ParserRuleReturnScope
    {
        public MetadataInfo methodexpressionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "methodexpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:525:1: methodexpression returns [MetadataInfo methodexpressionInfo] : 'method' a= primaryForMethod ;
    public CalcETreeParser.methodexpression_return methodexpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.methodexpression_return retval = new CalcETreeParser.methodexpression_return();
        retval.Start = input.LT(1);
        int methodexpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal202 = null;
        CalcETreeParser.primaryForMethod_return a = default(CalcETreeParser.primaryForMethod_return);


        CommonTree string_literal202_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:526:3: ( 'method' a= primaryForMethod )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:527:3: 'method' a= primaryForMethod
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal202=(IToken)Match(input,97,FOLLOW_97_in_methodexpression2690); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal202_tree = (CommonTree)adaptor.Create(string_literal202);
            		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal202_tree, root_0);
            	}
            	PushFollow(FOLLOW_primaryForMethod_in_methodexpression2697);
            	a = primaryForMethod();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.methodexpressionInfo = ((a != null) ? a.primaryForMethodInfo : default(MetadataInfo)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 46, methodexpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "methodexpression"

    public class primaryForMethod_return : ParserRuleReturnScope
    {
        public MetadataInfo primaryForMethodInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "primaryForMethod"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:529:1: primaryForMethod returns [MetadataInfo primaryForMethodInfo] : a= identifier '(' (c= parametersForMethod )? ')' (b= identifier )? ;
    public CalcETreeParser.primaryForMethod_return primaryForMethod() // throws RecognitionException [1]
    {   
        CalcETreeParser.primaryForMethod_return retval = new CalcETreeParser.primaryForMethod_return();
        retval.Start = input.LT(1);
        int primaryForMethod_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal203 = null;
        IToken char_literal204 = null;
        CalcETreeParser.identifier_return a = default(CalcETreeParser.identifier_return);

        CalcETreeParser.parametersForMethod_return c = default(CalcETreeParser.parametersForMethod_return);

        CalcETreeParser.identifier_return b = default(CalcETreeParser.identifier_return);


        CommonTree char_literal203_tree=null;
        CommonTree char_literal204_tree=null;

        MetadataInfo metaData = new MetadataInfo(); bool hasParameters = false;string methodName = string.Empty;bool isDualMethod = false;bool isDecimalMethod = false; bool isRoundMethod = false;bool IsDualParamMtd=false;bool isArrayMethod = false;bool IsSingleParamMtd=false; 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:530:3: (a= identifier '(' (c= parametersForMethod )? ')' (b= identifier )? )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:531:3: a= identifier '(' (c= parametersForMethod )? ')' (b= identifier )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_identifier_in_primaryForMethod2723);
            	a = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{

            	     methodName =((a != null) ? input.ToString((IToken)(a.Start),(IToken)(a.Stop)) : null);
            	      metaData.value = methodName;         
            	            if(dualMethods.Contains(methodName.ToUpper()))
            	            {
            	                isDualMethod = true;
            	            }  
            	            if(decimalMethods.Contains(methodName.ToUpper()))
            	            {
            	                isDecimalMethod = true;
            	            }
            	            if(roundMethod.Contains(methodName.ToUpper())) 
            	            {
            	                isRoundMethod  = true;
            	            }          
            	            if(DualParamMethods.Contains(methodName.ToUpper()))
            	            {
            	               IsDualParamMtd=true;
            	            } 
            	            if(SingleParamMethods.Contains(methodName.ToUpper()))
            	            {
            	               IsSingleParamMtd=true;
            	            }
            	            if(integerMethods.Contains(methodName.ToUpper()))
            	               metaData.datatype="integer";
            	            else if(doubleMethods.Contains(methodName.ToUpper()))
            	               metaData.datatype="double";
            	            else if(stringMethods.Contains(methodName.ToUpper()))
            	               metaData.datatype="string";
            	            else if(boolMethods.Contains(methodName.ToUpper()))
            	               metaData.datatype="boolean";
            	            else if(dateMethods.Contains(methodName.ToUpper()))
            	               metaData.datatype="date";
            	            else if(anyMethods.Contains(methodName.ToUpper()))       
            	               metaData.datatype="any";
            	            else if(noneMethods.Contains(methodName.ToUpper()))
            	               metaData.datatype="none"; 
            	            else if(arrayMethods.Contains(methodName.ToUpper()))
            	            {
            	              metaData.datatype = "array";
            	              metaData.ismultiple = true;
            	              isArrayMethod = true;
            	            }
            	                    
            	    
            	}
            	char_literal203=(IToken)Match(input,45,FOLLOW_45_in_primaryForMethod2738); if (state.failed) return retval;
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:577:9: (c= parametersForMethod )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == Literal || LA40_0 == 45 || LA40_0 == 48 || (LA40_0 >= 64 && LA40_0 <= 67) || (LA40_0 >= 95 && LA40_0 <= 97) || LA40_0 == 99 || LA40_0 == 102 || (LA40_0 >= 104 && LA40_0 <= 107)) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:577:10: c= parametersForMethod
            	        {
            	        	PushFollow(FOLLOW_parametersForMethod_in_primaryForMethod2746);
            	        	c = parametersForMethod();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, c.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   
            	        	       if(((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)) != null &&  ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count() >0 && (metaData.datatype == "array" || metaData.datatype == "any" ))
            	        	       {
            	        	         hasParameters = true;
                                     if (methodName != "CREATENEW")
                                     {
                                         string datatyperet = metaData.datatype;
                                         metaData.datatype = ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype;
                                         foreach (MetadataInfo item in ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)))
                                         {
                                             if ((item.datatype.ToLower() == "string" || item.datatype.ToLower() == "date") && datatyperet == "any")
                                                 metaData.datatype = "lookup";
                                         }
                                         
                                         
                                     }
                                     else
                                         metaData.datatype = ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].value; 
            	        	       } 
            	        	       if(IsSingleParamMtd && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)) != null &&  ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count() >1)
            	        	       {
            	        	         throw new Exception("Only one Parameter is expected for "+methodName);
            	        	       }            
            	        	       if(IsDualParamMtd && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)) != null &&  ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count()<2 )
            	        	       {
            	        	         throw new Exception("More than one Parameter is expected for "+methodName);
            	        	       }  
            	        	       //for handling Max,Min which are both array and normal functions
            	        	       if(isDualMethod && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)) != null &&  ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count() >0)
            	        	       {
            	        	          hasParameters = true;
            	        	          if(methodName.ToUpper() == "SUM" && !((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype.Equals("double", StringComparison.InvariantCultureIgnoreCase) &&
            	        	                                               !((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype.Equals("integer", StringComparison.InvariantCultureIgnoreCase))
            	        	          {
            	        	              metaData.datatype="integer";
            	        	          }
            	        	          //for handling the parameters ListItems
            	        	         else if(((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count(itm=>itm.datatype.Equals("double", StringComparison.InvariantCultureIgnoreCase))>0)
            	        	          {
            	        	          
            	        	            metaData.datatype="double";
            	        	             
            	        	          }
            	        	          else if (((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count(itm=>itm.datatype.Equals("integer", StringComparison.InvariantCultureIgnoreCase)) == ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count())
            	        	          {
            	        	                 metaData.datatype="integer";
            	        	          }
            	        	          else
            	        	          {
            	        	            metaData.datatype = ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype; 
            	        	          }
            	        	          
            	        	       }
            	        	       if(isRoundMethod && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)) != null &&  ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count() >0)
            	        	       {
            	        	         hasParameters = true;
            	        	         if(((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count()==1)
            	        	         {
            	        	            metaData.datatype="integer"; 
            	        	         }
            	        	         else
            	        	         {
            	        	            metaData.datatype=((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype; 
            	        	         }
            	        	       }
            	        	        //for handling decimalMethods 
            	        	       if(isDecimalMethod && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)) != null &&  ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count() >0)
            	        	       {
            	        	         hasParameters = true;
            	        	         metaData.datatype=((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype; 
            	        	       }
            	        	       
            	        	       
            	        	       //for handling arrayMethods 
            	        	       if(isArrayMethod && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)) != null &&  ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count() >0)
            	        	       {
            	        	         hasParameters = true;
            	        	         if((methodName.ToUpper() == "ADD" || methodName.ToUpper() == "ADDALL" || methodName.ToUpper() == "ADDBYINDEX") &&
            	        	            ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0] != null && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[1] != null)
            	        	          {
            	        	          
            	        	               switch (((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype.ToLower())
            	        	                 {
            	        	                              case "integer":
            	        	                              if(((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[0].datatype != ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[1].datatype)
            	        	                              {
            	        	                                  throw new Exception("Data type mismatch " + methodName + "()");
            	        	                              }
            	        	                              break;
            	        	                              case "decimal":
            	        	                              case "double":
            	        	                              if(!(((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[1].datatype.ToLower() == "integer" ||
            	        	                                 ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[1].datatype.ToLower() == "decimal" ||
            	        	                                 ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[1].datatype.ToLower() == "double"))
            	        	                              {
            	        	                                throw new Exception("Data type mismatch " + methodName + "()");
            	        	                              }
            	        	                              break;
            	        	                 }
            	        	             if(methodName.ToUpper() == "ADDBYINDEX" && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>)).Count() > 2 && ((c != null) ? c.parametersForMethodInfo : default(List<MetadataInfo>))[2].datatype.ToLower() != "integer")
            	        	             {
            	        	                throw new Exception("Invalid index " + methodName + "()");
            	        	             }
            	        	          } 
            	        	                
            	        	       }
            	        	     
            	        	}

            	        }
            	        break;

            	}

            	char_literal204=(IToken)Match(input,47,FOLLOW_47_in_primaryForMethod2760); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	       if(isValidate)
            	       {
            	       	if((metaData.datatype == "array" || metaData.datatype == "any"|| isDualMethod || isDecimalMethod || isRoundMethod ) && !hasParameters)
            	       	{
            	       	 throw new Exception("Parameter expected for "+methodName);
            	       	}  
            	       }
            	     
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:687:4: (b= identifier )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( (LA41_0 == Identifier) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:687:5: b= identifier
            	        {
            	        	PushFollow(FOLLOW_identifier_in_primaryForMethod2783);
            	        	b = identifier();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   metaData.datatype=((b != null) ? b.identifierInfo : default(MetadataInfo)).value;  
            	        	}

            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{

            	     retval.primaryForMethodInfo =  metaData;
            	    
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 47, primaryForMethod_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "primaryForMethod"

    public class parameters_return : ParserRuleReturnScope
    {
        public List<MetadataInfo> parametersInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "parameters"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:694:1: parameters returns [List<MetadataInfo> parametersInfo ] : a= bodmasValues ( ( ',' )? b= bodmasValues )* ;
    public CalcETreeParser.parameters_return parameters() // throws RecognitionException [1]
    {   
        CalcETreeParser.parameters_return retval = new CalcETreeParser.parameters_return();
        retval.Start = input.LT(1);
        int parameters_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal205 = null;
        CalcETreeParser.bodmasValues_return a = default(CalcETreeParser.bodmasValues_return);

        CalcETreeParser.bodmasValues_return b = default(CalcETreeParser.bodmasValues_return);


        CommonTree char_literal205_tree=null;

        List<MetadataInfo> parametersListInfo= new List<MetadataInfo>(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:695:3: (a= bodmasValues ( ( ',' )? b= bodmasValues )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:696:2: a= bodmasValues ( ( ',' )? b= bodmasValues )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bodmasValues_in_parameters2821);
            	a = bodmasValues();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   parametersListInfo.Add(((a != null) ? a.bodmasValuesInfo : default(MetadataInfo))); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:696:68: ( ( ',' )? b= bodmasValues )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == Literal || LA43_0 == 46 || LA43_0 == 48 || (LA43_0 >= 64 && LA43_0 <= 67) || (LA43_0 >= 95 && LA43_0 <= 97) || LA43_0 == 99 || LA43_0 == 102 || (LA43_0 >= 104 && LA43_0 <= 107)) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:696:69: ( ',' )? b= bodmasValues
            			    {
            			    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:696:69: ( ',' )?
            			    	int alt42 = 2;
            			    	int LA42_0 = input.LA(1);

            			    	if ( (LA42_0 == 46) )
            			    	{
            			    	    alt42 = 1;
            			    	}
            			    	switch (alt42) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ','
            			    	        {
            			    	        	char_literal205=(IToken)Match(input,46,FOLLOW_46_in_parameters2826); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal205_tree = (CommonTree)adaptor.Create(char_literal205);
            			    	        		adaptor.AddChild(root_0, char_literal205_tree);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_bodmasValues_in_parameters2832);
            			    	b = bodmasValues();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   parametersListInfo.Add(((b != null) ? b.bodmasValuesInfo : default(MetadataInfo))); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   retval.parametersInfo = parametersListInfo;
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 48, parameters_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "parameters"

    public class parametersForMethod_return : ParserRuleReturnScope
    {
        public List<MetadataInfo> parametersForMethodInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "parametersForMethod"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:699:1: parametersForMethod returns [List<MetadataInfo> parametersForMethodInfo ] : a= multiplicativeExpression ( ( ',' )? b= multiplicativeExpression )* ;
    public CalcETreeParser.parametersForMethod_return parametersForMethod() // throws RecognitionException [1]
    {   
        CalcETreeParser.parametersForMethod_return retval = new CalcETreeParser.parametersForMethod_return();
        retval.Start = input.LT(1);
        int parametersForMethod_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal206 = null;
        CalcETreeParser.multiplicativeExpression_return a = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.multiplicativeExpression_return b = default(CalcETreeParser.multiplicativeExpression_return);


        CommonTree char_literal206_tree=null;

        List<MetadataInfo> parametersListInfo= new List<MetadataInfo>(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:700:3: (a= multiplicativeExpression ( ( ',' )? b= multiplicativeExpression )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:701:2: a= multiplicativeExpression ( ( ',' )? b= multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_parametersForMethod2865);
            	a = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   parametersListInfo.Add(((a != null) ? a.multiplicativeExpressionInfo : default(MetadataInfo))); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:701:92: ( ( ',' )? b= multiplicativeExpression )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( (LA45_0 == Literal || (LA45_0 >= 45 && LA45_0 <= 46) || LA45_0 == 48 || (LA45_0 >= 64 && LA45_0 <= 67) || (LA45_0 >= 95 && LA45_0 <= 97) || LA45_0 == 99 || LA45_0 == 102 || (LA45_0 >= 104 && LA45_0 <= 107)) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:701:93: ( ',' )? b= multiplicativeExpression
            			    {
            			    	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:701:93: ( ',' )?
            			    	int alt44 = 2;
            			    	int LA44_0 = input.LA(1);

            			    	if ( (LA44_0 == 46) )
            			    	{
            			    	    alt44 = 1;
            			    	}
            			    	switch (alt44) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ','
            			    	        {
            			    	        	char_literal206=(IToken)Match(input,46,FOLLOW_46_in_parametersForMethod2870); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal206_tree = (CommonTree)adaptor.Create(char_literal206);
            			    	        		adaptor.AddChild(root_0, char_literal206_tree);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_parametersForMethod2877);
            			    	b = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   parametersListInfo.Add(((b != null) ? b.multiplicativeExpressionInfo : default(MetadataInfo))); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	if ( (state.backtracking==0) )
            	{
            	  retval.parametersForMethodInfo =  parametersListInfo;
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 49, parametersForMethod_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "parametersForMethod"

    public class lhsEntities_return : ParserRuleReturnScope
    {
        public MetadataInfo lhsEntitiesInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lhsEntities"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:705:1: lhsEntities returns [MetadataInfo lhsEntitiesInfo] : ( variableEntity | objectModelEntity | varObjectModelEntity | xPath ) ;
    public CalcETreeParser.lhsEntities_return lhsEntities() // throws RecognitionException [1]
    {   
        CalcETreeParser.lhsEntities_return retval = new CalcETreeParser.lhsEntities_return();
        retval.Start = input.LT(1);
        int lhsEntities_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.variableEntity_return variableEntity207 = default(CalcETreeParser.variableEntity_return);

        CalcETreeParser.objectModelEntity_return objectModelEntity208 = default(CalcETreeParser.objectModelEntity_return);

        CalcETreeParser.varObjectModelEntity_return varObjectModelEntity209 = default(CalcETreeParser.varObjectModelEntity_return);

        CalcETreeParser.xPath_return xPath210 = default(CalcETreeParser.xPath_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:706:3: ( ( variableEntity | objectModelEntity | varObjectModelEntity | xPath ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:707:3: ( variableEntity | objectModelEntity | varObjectModelEntity | xPath )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:707:3: ( variableEntity | objectModelEntity | varObjectModelEntity | xPath )
            	int alt46 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case 102:
            		{
            	    alt46 = 1;
            	    }
            	    break;
            	case 105:
            		{
            	    alt46 = 2;
            	    }
            	    break;
            	case 106:
            		{
            	    alt46 = 3;
            	    }
            	    break;
            	case 107:
            		{
            	    alt46 = 4;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d46s0 =
            		        new NoViableAltException("", 46, 0, input);

            		    throw nvae_d46s0;
            	}

            	switch (alt46) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:708:6: variableEntity
            	        {
            	        	PushFollow(FOLLOW_variableEntity_in_lhsEntities2909);
            	        	variableEntity207 = variableEntity();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableEntity207.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	  retval.lhsEntitiesInfo =  ((variableEntity207 != null) ? variableEntity207.variableEntityInfo : default(MetadataInfo)) ;
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:709:7: objectModelEntity
            	        {
            	        	PushFollow(FOLLOW_objectModelEntity_in_lhsEntities2919);
            	        	objectModelEntity208 = objectModelEntity();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectModelEntity208.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	  retval.lhsEntitiesInfo =  ((objectModelEntity208 != null) ? objectModelEntity208.objectModelEntityInfo : default(MetadataInfo));
            	        	}

            	        }
            	        break;
            	    case 3 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:710:7: varObjectModelEntity
            	        {
            	        	PushFollow(FOLLOW_varObjectModelEntity_in_lhsEntities2929);
            	        	varObjectModelEntity209 = varObjectModelEntity();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varObjectModelEntity209.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	  retval.lhsEntitiesInfo =  ((varObjectModelEntity209 != null) ? varObjectModelEntity209.varObjectModelEntityInfo : default(MetadataInfo));
            	        	}

            	        }
            	        break;
            	    case 4 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:711:7: xPath
            	        {
            	        	PushFollow(FOLLOW_xPath_in_lhsEntities2939);
            	        	xPath210 = xPath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, xPath210.Tree);
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	  retval.lhsEntitiesInfo =  ((xPath210 != null) ? xPath210.xpathInfo : default(MetadataInfo));
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 50, lhsEntities_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lhsEntities"

    public class operandExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "operandExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:715:1: operandExpression : 'operandDisplayProperty' Literal -> ^( 'operandDisplayProperty' Literal ) ;
    public CalcETreeParser.operandExpression_return operandExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.operandExpression_return retval = new CalcETreeParser.operandExpression_return();
        retval.Start = input.LT(1);
        int operandExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal211 = null;
        IToken Literal212 = null;

        CommonTree string_literal211_tree=null;
        CommonTree Literal212_tree=null;
        RewriteRuleTokenStream stream_98 = new RewriteRuleTokenStream(adaptor,"token 98");
        RewriteRuleTokenStream stream_Literal = new RewriteRuleTokenStream(adaptor,"token Literal");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:716:3: ( 'operandDisplayProperty' Literal -> ^( 'operandDisplayProperty' Literal ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:717:3: 'operandDisplayProperty' Literal
            {
            	string_literal211=(IToken)Match(input,98,FOLLOW_98_in_operandExpression2960); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_98.Add(string_literal211);

            	Literal212=(IToken)Match(input,Literal,FOLLOW_Literal_in_operandExpression2962); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Literal.Add(Literal212);



            	// AST REWRITE
            	// elements:          Literal, 98
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 718:5: -> ^( 'operandDisplayProperty' Literal )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:719:7: ^( 'operandDisplayProperty' Literal )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_98.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_Literal.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 51, operandExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "operandExpression"

    public class rhsEntities_return : ParserRuleReturnScope
    {
        public MetadataInfo rhsEntitiesInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "rhsEntities"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:722:1: rhsEntities returns [MetadataInfo rhsEntitiesInfo] : ( variableEntity | constantEntity | objectModelEntity | varObjectModelEntity | methodexpression | priceExpression | Literal | xPath | callBlock | 'null' );
    public CalcETreeParser.rhsEntities_return rhsEntities() // throws RecognitionException [1]
    {   
        CalcETreeParser.rhsEntities_return retval = new CalcETreeParser.rhsEntities_return();
        retval.Start = input.LT(1);
        int rhsEntities_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Literal219 = null;
        IToken string_literal222 = null;
        CalcETreeParser.variableEntity_return variableEntity213 = default(CalcETreeParser.variableEntity_return);

        CalcETreeParser.constantEntity_return constantEntity214 = default(CalcETreeParser.constantEntity_return);

        CalcETreeParser.objectModelEntity_return objectModelEntity215 = default(CalcETreeParser.objectModelEntity_return);

        CalcETreeParser.varObjectModelEntity_return varObjectModelEntity216 = default(CalcETreeParser.varObjectModelEntity_return);

        CalcETreeParser.methodexpression_return methodexpression217 = default(CalcETreeParser.methodexpression_return);

        CalcETreeParser.priceExpression_return priceExpression218 = default(CalcETreeParser.priceExpression_return);

        CalcETreeParser.xPath_return xPath220 = default(CalcETreeParser.xPath_return);

        CalcETreeParser.callBlock_return callBlock221 = default(CalcETreeParser.callBlock_return);


        CommonTree Literal219_tree=null;
        CommonTree string_literal222_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:723:3: ( variableEntity | constantEntity | objectModelEntity | varObjectModelEntity | methodexpression | priceExpression | Literal | xPath | callBlock | 'null' )
            int alt47 = 10;
            switch ( input.LA(1) ) 
            {
            case 102:
            	{
                alt47 = 1;
                }
                break;
            case 104:
            	{
                alt47 = 2;
                }
                break;
            case 105:
            	{
                alt47 = 3;
                }
                break;
            case 106:
            	{
                alt47 = 4;
                }
                break;
            case 97:
            	{
                alt47 = 5;
                }
                break;
            case 64:
            case 65:
            case 66:
            case 67:
            	{
                alt47 = 6;
                }
                break;
            case Literal:
            	{
                alt47 = 7;
                }
                break;
            case 107:
            	{
                alt47 = 8;
                }
                break;
            case 48:
            	{
                alt47 = 9;
                }
                break;
            case 99:
            	{
                alt47 = 10;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d47s0 =
            	        new NoViableAltException("", 47, 0, input);

            	    throw nvae_d47s0;
            }

            switch (alt47) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:724:3: variableEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableEntity_in_rhsEntities2998);
                    	variableEntity213 = variableEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableEntity213.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((variableEntity213 != null) ? variableEntity213.variableEntityInfo : default(MetadataInfo)) ; 
                    	}

                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:725:5: constantEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantEntity_in_rhsEntities3006);
                    	constantEntity214 = constantEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantEntity214.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((constantEntity214 != null) ? constantEntity214.constantEntityInfo : default(MetadataInfo)) ; 
                    	}

                    }
                    break;
                case 3 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:726:5: objectModelEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectModelEntity_in_rhsEntities3014);
                    	objectModelEntity215 = objectModelEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectModelEntity215.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((objectModelEntity215 != null) ? objectModelEntity215.objectModelEntityInfo : default(MetadataInfo)) ; 
                    	}

                    }
                    break;
                case 4 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:727:5: varObjectModelEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varObjectModelEntity_in_rhsEntities3022);
                    	varObjectModelEntity216 = varObjectModelEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varObjectModelEntity216.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((varObjectModelEntity216 != null) ? varObjectModelEntity216.varObjectModelEntityInfo : default(MetadataInfo)) ; 
                    	}

                    }
                    break;
                case 5 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:728:5: methodexpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodexpression_in_rhsEntities3030);
                    	methodexpression217 = methodexpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodexpression217.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((methodexpression217 != null) ? methodexpression217.methodexpressionInfo : default(MetadataInfo)) ; 
                    	}

                    }
                    break;
                case 6 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:729:5: priceExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_priceExpression_in_rhsEntities3038);
                    	priceExpression218 = priceExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, priceExpression218.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((priceExpression218 != null) ? priceExpression218.priceExpressionInfo : default(MetadataInfo)) ; 
                    	}

                    }
                    break;
                case 7 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:730:5: Literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Literal219=(IToken)Match(input,Literal,FOLLOW_Literal_in_rhsEntities3046); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Literal219_tree = (CommonTree)adaptor.Create(Literal219);
                    		adaptor.AddChild(root_0, Literal219_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	    retval.rhsEntitiesInfo = new MetadataInfo(); 
                    	    retval.rhsEntitiesInfo.value= ((Literal219 != null) ? Literal219.Text : null);
                    	    retval.rhsEntitiesInfo.datatype=TypeCastImpl.GetDatatype(retval.rhsEntitiesInfo.value);
                    	    
                    	}

                    }
                    break;
                case 8 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:736:5: xPath
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_xPath_in_rhsEntities3057);
                    	xPath220 = xPath();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, xPath220.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((xPath220 != null) ? xPath220.xpathInfo : default(MetadataInfo)); 
                    	}

                    }
                    break;
                case 9 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:737:5: callBlock
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callBlock_in_rhsEntities3065);
                    	callBlock221 = callBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callBlock221.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo = ((callBlock221 != null) ? callBlock221.callBlockInfo : default(MetadataInfo)) ; 
                    	}

                    }
                    break;
                case 10 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:738:4: 'null'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal222=(IToken)Match(input,99,FOLLOW_99_in_rhsEntities3072); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal222_tree = (CommonTree)adaptor.Create(string_literal222);
                    		adaptor.AddChild(root_0, string_literal222_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.rhsEntitiesInfo =  new MetadataInfo(){datatype="null" }; 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 52, rhsEntities_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "rhsEntities"

    public class unaryExpressionNot_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryExpressionNot"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:740:1: unaryExpressionNot : unaryOp conditionalOrExpression ;
    public CalcETreeParser.unaryExpressionNot_return unaryExpressionNot() // throws RecognitionException [1]
    {   
        CalcETreeParser.unaryExpressionNot_return retval = new CalcETreeParser.unaryExpressionNot_return();
        retval.Start = input.LT(1);
        int unaryExpressionNot_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.unaryOp_return unaryOp223 = default(CalcETreeParser.unaryOp_return);

        CalcETreeParser.conditionalOrExpression_return conditionalOrExpression224 = default(CalcETreeParser.conditionalOrExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:741:2: ( unaryOp conditionalOrExpression )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:741:4: unaryOp conditionalOrExpression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryOp_in_unaryExpressionNot3085);
            	unaryOp223 = unaryOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryOp223.Tree);
            	PushFollow(FOLLOW_conditionalOrExpression_in_unaryExpressionNot3087);
            	conditionalOrExpression224 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression224.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 53, unaryExpressionNot_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpressionNot"

    public class unaryOp_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryOp"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:743:1: unaryOp : 'NOT' ;
    public CalcETreeParser.unaryOp_return unaryOp() // throws RecognitionException [1]
    {   
        CalcETreeParser.unaryOp_return retval = new CalcETreeParser.unaryOp_return();
        retval.Start = input.LT(1);
        int unaryOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal225 = null;

        CommonTree string_literal225_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:743:9: ( 'NOT' )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:743:10: 'NOT'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal225=(IToken)Match(input,100,FOLLOW_100_in_unaryOp3095); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal225_tree = (CommonTree)adaptor.Create(string_literal225);
            		adaptor.AddChild(root_0, string_literal225_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 54, unaryOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryOp"

    public class saveExpression_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "saveExpression"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:745:1: saveExpression : 'save' commentEntities ( '(' )? ( parametersForMethod )? ( ')' )? ;
    public CalcETreeParser.saveExpression_return saveExpression() // throws RecognitionException [1]
    {   
        CalcETreeParser.saveExpression_return retval = new CalcETreeParser.saveExpression_return();
        retval.Start = input.LT(1);
        int saveExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal226 = null;
        IToken char_literal228 = null;
        IToken char_literal230 = null;
        CalcETreeParser.commentEntities_return commentEntities227 = default(CalcETreeParser.commentEntities_return);

        CalcETreeParser.parametersForMethod_return parametersForMethod229 = default(CalcETreeParser.parametersForMethod_return);


        CommonTree string_literal226_tree=null;
        CommonTree char_literal228_tree=null;
        CommonTree char_literal230_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:746:3: ( 'save' commentEntities ( '(' )? ( parametersForMethod )? ( ')' )? )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:747:3: 'save' commentEntities ( '(' )? ( parametersForMethod )? ( ')' )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal226=(IToken)Match(input,101,FOLLOW_101_in_saveExpression3108); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal226_tree = (CommonTree)adaptor.Create(string_literal226);
            		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal226_tree, root_0);
            	}
            	PushFollow(FOLLOW_commentEntities_in_saveExpression3111);
            	commentEntities227 = commentEntities();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commentEntities227.Tree);
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:747:27: ( '(' )?
            	int alt48 = 2;
            	alt48 = dfa48.Predict(input);
            	switch (alt48) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: '('
            	        {
            	        	char_literal228=(IToken)Match(input,45,FOLLOW_45_in_saveExpression3113); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal228_tree = (CommonTree)adaptor.Create(char_literal228);
            	        		adaptor.AddChild(root_0, char_literal228_tree);
            	        	}

            	        }
            	        break;

            	}

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:747:32: ( parametersForMethod )?
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == Literal || LA49_0 == 45 || LA49_0 == 48 || (LA49_0 >= 64 && LA49_0 <= 67) || (LA49_0 >= 95 && LA49_0 <= 97) || LA49_0 == 99 || LA49_0 == 102 || (LA49_0 >= 104 && LA49_0 <= 107)) )
            	{
            	    alt49 = 1;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: parametersForMethod
            	        {
            	        	PushFollow(FOLLOW_parametersForMethod_in_saveExpression3116);
            	        	parametersForMethod229 = parametersForMethod();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parametersForMethod229.Tree);

            	        }
            	        break;

            	}

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:747:53: ( ')' )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == 47) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ')'
            	        {
            	        	char_literal230=(IToken)Match(input,47,FOLLOW_47_in_saveExpression3119); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal230_tree = (CommonTree)adaptor.Create(char_literal230);
            	        		adaptor.AddChild(root_0, char_literal230_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 55, saveExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "saveExpression"

    public class commentEntities_return : ParserRuleReturnScope
    {
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "commentEntities"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:750:1: commentEntities : ( variableEntity | constantEntity | objectModelEntity | varObjectModelEntity | primary | xPath );
    public CalcETreeParser.commentEntities_return commentEntities() // throws RecognitionException [1]
    {   
        CalcETreeParser.commentEntities_return retval = new CalcETreeParser.commentEntities_return();
        retval.Start = input.LT(1);
        int commentEntities_StartIndex = input.Index();
        CommonTree root_0 = null;

        CalcETreeParser.variableEntity_return variableEntity231 = default(CalcETreeParser.variableEntity_return);

        CalcETreeParser.constantEntity_return constantEntity232 = default(CalcETreeParser.constantEntity_return);

        CalcETreeParser.objectModelEntity_return objectModelEntity233 = default(CalcETreeParser.objectModelEntity_return);

        CalcETreeParser.varObjectModelEntity_return varObjectModelEntity234 = default(CalcETreeParser.varObjectModelEntity_return);

        CalcETreeParser.primary_return primary235 = default(CalcETreeParser.primary_return);

        CalcETreeParser.xPath_return xPath236 = default(CalcETreeParser.xPath_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:751:3: ( variableEntity | constantEntity | objectModelEntity | varObjectModelEntity | primary | xPath )
            int alt51 = 6;
            switch ( input.LA(1) ) 
            {
            case 102:
            	{
                alt51 = 1;
                }
                break;
            case 104:
            	{
                alt51 = 2;
                }
                break;
            case 105:
            	{
                alt51 = 3;
                }
                break;
            case 106:
            	{
                alt51 = 4;
                }
                break;
            case Identifier:
            case Literal:
            	{
                alt51 = 5;
                }
                break;
            case 107:
            	{
                alt51 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d51s0 =
            	        new NoViableAltException("", 51, 0, input);

            	    throw nvae_d51s0;
            }

            switch (alt51) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:752:4: variableEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableEntity_in_commentEntities3137);
                    	variableEntity231 = variableEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableEntity231.Tree);

                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:753:5: constantEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantEntity_in_commentEntities3143);
                    	constantEntity232 = constantEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantEntity232.Tree);

                    }
                    break;
                case 3 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:754:5: objectModelEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectModelEntity_in_commentEntities3149);
                    	objectModelEntity233 = objectModelEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectModelEntity233.Tree);

                    }
                    break;
                case 4 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:755:5: varObjectModelEntity
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varObjectModelEntity_in_commentEntities3155);
                    	varObjectModelEntity234 = varObjectModelEntity();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varObjectModelEntity234.Tree);

                    }
                    break;
                case 5 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:756:5: primary
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primary_in_commentEntities3161);
                    	primary235 = primary();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primary235.Tree);

                    }
                    break;
                case 6 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:757:5: xPath
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_xPath_in_commentEntities3167);
                    	xPath236 = xPath();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, xPath236.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 56, commentEntities_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "commentEntities"

    public class variableEntity_return : ParserRuleReturnScope
    {
        public MetadataInfo variableEntityInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variableEntity"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:760:1: variableEntity returns [MetadataInfo variableEntityInfo] : 'Variable' '#' a= superIdentifier ( operandExpression )? ;
    public CalcETreeParser.variableEntity_return variableEntity() // throws RecognitionException [1]
    {   
        CalcETreeParser.variableEntity_return retval = new CalcETreeParser.variableEntity_return();
        retval.Start = input.LT(1);
        int variableEntity_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal237 = null;
        IToken char_literal238 = null;
        CalcETreeParser.superIdentifier_return a = default(CalcETreeParser.superIdentifier_return);

        CalcETreeParser.operandExpression_return operandExpression239 = default(CalcETreeParser.operandExpression_return);


        CommonTree string_literal237_tree=null;
        CommonTree char_literal238_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:761:3: ( 'Variable' '#' a= superIdentifier ( operandExpression )? )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:762:3: 'Variable' '#' a= superIdentifier ( operandExpression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal237=(IToken)Match(input,102,FOLLOW_102_in_variableEntity3185); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal237_tree = (CommonTree)adaptor.Create(string_literal237);
            		adaptor.AddChild(root_0, string_literal237_tree);
            	}
            	char_literal238=(IToken)Match(input,103,FOLLOW_103_in_variableEntity3187); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal238_tree = (CommonTree)adaptor.Create(char_literal238);
            		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal238_tree, root_0);
            	}
            	PushFollow(FOLLOW_superIdentifier_in_variableEntity3194);
            	a = superIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.variableEntityInfo =  ((a != null) ? a.superIdentifierInfo : default(MetadataInfo)); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:762:89: ( operandExpression )?
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( (LA52_0 == 98) )
            	{
            	    alt52 = 1;
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: operandExpression
            	        {
            	        	PushFollow(FOLLOW_operandExpression_in_variableEntity3198);
            	        	operandExpression239 = operandExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operandExpression239.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 57, variableEntity_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableEntity"

    public class constantEntity_return : ParserRuleReturnScope
    {
        public MetadataInfo constantEntityInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constantEntity"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:765:1: constantEntity returns [MetadataInfo constantEntityInfo] : 'Constant' '#' a= superIdentifier ( operandExpression )? ;
    public CalcETreeParser.constantEntity_return constantEntity() // throws RecognitionException [1]
    {   
        CalcETreeParser.constantEntity_return retval = new CalcETreeParser.constantEntity_return();
        retval.Start = input.LT(1);
        int constantEntity_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal240 = null;
        IToken char_literal241 = null;
        CalcETreeParser.superIdentifier_return a = default(CalcETreeParser.superIdentifier_return);

        CalcETreeParser.operandExpression_return operandExpression242 = default(CalcETreeParser.operandExpression_return);


        CommonTree string_literal240_tree=null;
        CommonTree char_literal241_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:766:3: ( 'Constant' '#' a= superIdentifier ( operandExpression )? )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:767:3: 'Constant' '#' a= superIdentifier ( operandExpression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal240=(IToken)Match(input,104,FOLLOW_104_in_constantEntity3217); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal240_tree = (CommonTree)adaptor.Create(string_literal240);
            		adaptor.AddChild(root_0, string_literal240_tree);
            	}
            	char_literal241=(IToken)Match(input,103,FOLLOW_103_in_constantEntity3219); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal241_tree = (CommonTree)adaptor.Create(char_literal241);
            		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal241_tree, root_0);
            	}
            	PushFollow(FOLLOW_superIdentifier_in_constantEntity3226);
            	a = superIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  retval.constantEntityInfo =  ((a != null) ? a.superIdentifierInfo : default(MetadataInfo)); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:767:88: ( operandExpression )?
            	int alt53 = 2;
            	int LA53_0 = input.LA(1);

            	if ( (LA53_0 == 98) )
            	{
            	    alt53 = 1;
            	}
            	switch (alt53) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: operandExpression
            	        {
            	        	PushFollow(FOLLOW_operandExpression_in_constantEntity3230);
            	        	operandExpression242 = operandExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operandExpression242.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 58, constantEntity_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "constantEntity"

    public class objectModelEntity_return : ParserRuleReturnScope
    {
        public MetadataInfo objectModelEntityInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectModelEntity"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:770:1: objectModelEntity returns [MetadataInfo objectModelEntityInfo] : 'ObjectModel' '#' a= objectModelDescription ( operandExpression )? ;
    public CalcETreeParser.objectModelEntity_return objectModelEntity() // throws RecognitionException [1]
    {   
        CalcETreeParser.objectModelEntity_return retval = new CalcETreeParser.objectModelEntity_return();
        retval.Start = input.LT(1);
        int objectModelEntity_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal243 = null;
        IToken char_literal244 = null;
        CalcETreeParser.objectModelDescription_return a = default(CalcETreeParser.objectModelDescription_return);

        CalcETreeParser.operandExpression_return operandExpression245 = default(CalcETreeParser.operandExpression_return);


        CommonTree string_literal243_tree=null;
        CommonTree char_literal244_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:771:3: ( 'ObjectModel' '#' a= objectModelDescription ( operandExpression )? )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:772:3: 'ObjectModel' '#' a= objectModelDescription ( operandExpression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal243=(IToken)Match(input,105,FOLLOW_105_in_objectModelEntity3249); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal243_tree = (CommonTree)adaptor.Create(string_literal243);
            		adaptor.AddChild(root_0, string_literal243_tree);
            	}
            	char_literal244=(IToken)Match(input,103,FOLLOW_103_in_objectModelEntity3251); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal244_tree = (CommonTree)adaptor.Create(char_literal244);
            		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal244_tree, root_0);
            	}
            	PushFollow(FOLLOW_objectModelDescription_in_objectModelEntity3258);
            	a = objectModelDescription();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  retval.objectModelEntityInfo =  ((a != null) ? a.objectModelDescriptionInfo : default(MetadataInfo)); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:772:108: ( operandExpression )?
            	int alt54 = 2;
            	int LA54_0 = input.LA(1);

            	if ( (LA54_0 == 98) )
            	{
            	    alt54 = 1;
            	}
            	switch (alt54) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: operandExpression
            	        {
            	        	PushFollow(FOLLOW_operandExpression_in_objectModelEntity3262);
            	        	operandExpression245 = operandExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operandExpression245.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 59, objectModelEntity_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "objectModelEntity"

    public class varObjectModelEntity_return : ParserRuleReturnScope
    {
        public MetadataInfo varObjectModelEntityInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "varObjectModelEntity"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:775:1: varObjectModelEntity returns [MetadataInfo varObjectModelEntityInfo] : 'varObjectModel' '#' a= objectModelDescription ( operandExpression )? ;
    public CalcETreeParser.varObjectModelEntity_return varObjectModelEntity() // throws RecognitionException [1]
    {   
        CalcETreeParser.varObjectModelEntity_return retval = new CalcETreeParser.varObjectModelEntity_return();
        retval.Start = input.LT(1);
        int varObjectModelEntity_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal246 = null;
        IToken char_literal247 = null;
        CalcETreeParser.objectModelDescription_return a = default(CalcETreeParser.objectModelDescription_return);

        CalcETreeParser.operandExpression_return operandExpression248 = default(CalcETreeParser.operandExpression_return);


        CommonTree string_literal246_tree=null;
        CommonTree char_literal247_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:776:3: ( 'varObjectModel' '#' a= objectModelDescription ( operandExpression )? )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:777:3: 'varObjectModel' '#' a= objectModelDescription ( operandExpression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal246=(IToken)Match(input,106,FOLLOW_106_in_varObjectModelEntity3281); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal246_tree = (CommonTree)adaptor.Create(string_literal246);
            		adaptor.AddChild(root_0, string_literal246_tree);
            	}
            	char_literal247=(IToken)Match(input,103,FOLLOW_103_in_varObjectModelEntity3283); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal247_tree = (CommonTree)adaptor.Create(char_literal247);
            		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal247_tree, root_0);
            	}
            	PushFollow(FOLLOW_objectModelDescription_in_varObjectModelEntity3290);
            	a = objectModelDescription();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  retval.varObjectModelEntityInfo =  ((a != null) ? a.objectModelDescriptionInfo : default(MetadataInfo)); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:777:114: ( operandExpression )?
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == 98) )
            	{
            	    alt55 = 1;
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: operandExpression
            	        {
            	        	PushFollow(FOLLOW_operandExpression_in_varObjectModelEntity3294);
            	        	operandExpression248 = operandExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operandExpression248.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 60, varObjectModelEntity_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "varObjectModelEntity"

    public class xPath_return : ParserRuleReturnScope
    {
        public MetadataInfo xpathInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "xPath"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:780:1: xPath returns [MetadataInfo xpathInfo] : 'xPath' '#' a= superIdentifier ( operandExpression )? ;
    public CalcETreeParser.xPath_return xPath() // throws RecognitionException [1]
    {   
        CalcETreeParser.xPath_return retval = new CalcETreeParser.xPath_return();
        retval.Start = input.LT(1);
        int xPath_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal249 = null;
        IToken char_literal250 = null;
        CalcETreeParser.superIdentifier_return a = default(CalcETreeParser.superIdentifier_return);

        CalcETreeParser.operandExpression_return operandExpression251 = default(CalcETreeParser.operandExpression_return);


        CommonTree string_literal249_tree=null;
        CommonTree char_literal250_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:781:3: ( 'xPath' '#' a= superIdentifier ( operandExpression )? )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:782:3: 'xPath' '#' a= superIdentifier ( operandExpression )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal249=(IToken)Match(input,107,FOLLOW_107_in_xPath3313); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal249_tree = (CommonTree)adaptor.Create(string_literal249);
            		adaptor.AddChild(root_0, string_literal249_tree);
            	}
            	char_literal250=(IToken)Match(input,103,FOLLOW_103_in_xPath3315); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal250_tree = (CommonTree)adaptor.Create(char_literal250);
            		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal250_tree, root_0);
            	}
            	PushFollow(FOLLOW_superIdentifier_in_xPath3322);
            	a = superIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  retval.xpathInfo =  ((a != null) ? a.superIdentifierInfo : default(MetadataInfo)); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:782:76: ( operandExpression )?
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);

            	if ( (LA56_0 == 98) )
            	{
            	    alt56 = 1;
            	}
            	switch (alt56) 
            	{
            	    case 1 :
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: operandExpression
            	        {
            	        	PushFollow(FOLLOW_operandExpression_in_xPath3326);
            	        	operandExpression251 = operandExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operandExpression251.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 61, xPath_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "xPath"

    public class objectModelDescription_return : ParserRuleReturnScope
    {
        public MetadataInfo objectModelDescriptionInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectModelDescription"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:786:1: objectModelDescription returns [MetadataInfo objectModelDescriptionInfo] : a= superIdentifier ( '.' b= superIdentifier )* ;
    public CalcETreeParser.objectModelDescription_return objectModelDescription() // throws RecognitionException [1]
    {   
        CalcETreeParser.objectModelDescription_return retval = new CalcETreeParser.objectModelDescription_return();
        retval.Start = input.LT(1);
        int objectModelDescription_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal252 = null;
        CalcETreeParser.superIdentifier_return a = default(CalcETreeParser.superIdentifier_return);

        CalcETreeParser.superIdentifier_return b = default(CalcETreeParser.superIdentifier_return);


        CommonTree char_literal252_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:787:3: (a= superIdentifier ( '.' b= superIdentifier )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:788:2: a= superIdentifier ( '.' b= superIdentifier )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_superIdentifier_in_objectModelDescription3350);
            	a = superIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  retval.objectModelDescriptionInfo = ((a != null) ? a.superIdentifierInfo : default(MetadataInfo)); 
            	}
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:789:3: ( '.' b= superIdentifier )*
            	do 
            	{
            	    int alt57 = 2;
            	    int LA57_0 = input.LA(1);

            	    if ( (LA57_0 == 108) )
            	    {
            	        alt57 = 1;
            	    }


            	    switch (alt57) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:789:4: '.' b= superIdentifier
            			    {
            			    	char_literal252=(IToken)Match(input,108,FOLLOW_108_in_objectModelDescription3357); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal252_tree = (CommonTree)adaptor.Create(char_literal252);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal252_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_superIdentifier_in_objectModelDescription3364);
            			    	b = superIdentifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  retval.objectModelDescriptionInfo = ((b != null) ? b.superIdentifierInfo : default(MetadataInfo)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop57;
            	    }
            	} while (true);

            	loop57:
            		;	// Stops C# compiler whining that label 'loop57' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 62, objectModelDescription_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "objectModelDescription"

    public class superIdentifier_return : ParserRuleReturnScope
    {
        public MetadataInfo superIdentifierInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "superIdentifier"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:792:1: superIdentifier returns [MetadataInfo superIdentifierInfo] : identifier '(' a= metadata ')' -> ^( Dummy identifier metadata ) ;
    public CalcETreeParser.superIdentifier_return superIdentifier() // throws RecognitionException [1]
    {   
        CalcETreeParser.superIdentifier_return retval = new CalcETreeParser.superIdentifier_return();
        retval.Start = input.LT(1);
        int superIdentifier_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal254 = null;
        IToken char_literal255 = null;
        CalcETreeParser.metadata_return a = default(CalcETreeParser.metadata_return);

        CalcETreeParser.identifier_return identifier253 = default(CalcETreeParser.identifier_return);


        CommonTree char_literal254_tree=null;
        CommonTree char_literal255_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        RewriteRuleSubtreeStream stream_metadata = new RewriteRuleSubtreeStream(adaptor,"rule metadata");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:793:3: ( identifier '(' a= metadata ')' -> ^( Dummy identifier metadata ) )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:794:3: identifier '(' a= metadata ')'
            {
            	PushFollow(FOLLOW_identifier_in_superIdentifier3388);
            	identifier253 = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_identifier.Add(identifier253.Tree);
            	char_literal254=(IToken)Match(input,45,FOLLOW_45_in_superIdentifier3390); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal254);

            	PushFollow(FOLLOW_metadata_in_superIdentifier3394);
            	a = metadata();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_metadata.Add(a.Tree);
            	char_literal255=(IToken)Match(input,47,FOLLOW_47_in_superIdentifier3396); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal255);

            	if ( (state.backtracking==0) )
            	{
            	   retval.superIdentifierInfo = ((a != null) ? a.metaDataInfo : default(MetadataInfo)); 
            	}


            	// AST REWRITE
            	// elements:          metadata, identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 796:5: -> ^( Dummy identifier metadata )
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:797:7: ^( Dummy identifier metadata )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(Dummy, "Dummy"), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());
            	    adaptor.AddChild(root_1, stream_metadata.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 63, superIdentifier_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "superIdentifier"

    public class metadata_return : ParserRuleReturnScope
    {
        public MetadataInfo metaDataInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "metadata"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:800:1: metadata returns [MetadataInfo metaDataInfo] : (a= identifier '=' b= primary ) ( ',' c= identifier '=' d= primary )* -> ^( MetadataDummy identifier primary ) ( ^( MetadataDummy identifier primary ) )* ;
    public CalcETreeParser.metadata_return metadata() // throws RecognitionException [1]
    {   
        CalcETreeParser.metadata_return retval = new CalcETreeParser.metadata_return();
        retval.Start = input.LT(1);
        int metadata_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal256 = null;
        IToken char_literal257 = null;
        IToken char_literal258 = null;
        CalcETreeParser.identifier_return a = default(CalcETreeParser.identifier_return);

        CalcETreeParser.primary_return b = default(CalcETreeParser.primary_return);

        CalcETreeParser.identifier_return c = default(CalcETreeParser.identifier_return);

        CalcETreeParser.primary_return d = default(CalcETreeParser.primary_return);


        CommonTree char_literal256_tree=null;
        CommonTree char_literal257_tree=null;
        CommonTree char_literal258_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_primary = new RewriteRuleSubtreeStream(adaptor,"rule primary");
        RewriteRuleSubtreeStream stream_identifier = new RewriteRuleSubtreeStream(adaptor,"rule identifier");
        MetadataInfo metaData = new MetadataInfo();  
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:801:3: ( (a= identifier '=' b= primary ) ( ',' c= identifier '=' d= primary )* -> ^( MetadataDummy identifier primary ) ( ^( MetadataDummy identifier primary ) )* )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:802:3: (a= identifier '=' b= primary ) ( ',' c= identifier '=' d= primary )*
            {
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:802:3: (a= identifier '=' b= primary )
            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:802:5: a= identifier '=' b= primary
            	{
            		PushFollow(FOLLOW_identifier_in_metadata3448);
            		a = identifier();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_identifier.Add(a.Tree);
            		char_literal256=(IToken)Match(input,79,FOLLOW_79_in_metadata3450); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_79.Add(char_literal256);

            		PushFollow(FOLLOW_primary_in_metadata3455);
            		b = primary();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_primary.Add(b.Tree);
            		if ( (state.backtracking==0) )
            		{

            		             if(((a != null) ? input.ToString((IToken)(a.Start),(IToken)(a.Stop)) : null)=="datatype")
            		             {
            		             metaData.datatype=(((b != null) ? input.ToString((IToken)(b.Start),(IToken)(b.Stop)) : null).ToLower() == "datetime") ? "date":((b != null) ? input.ToString((IToken)(b.Start),(IToken)(b.Stop)) : null);           
            		             }
            		             else if(((a != null) ? input.ToString((IToken)(a.Start),(IToken)(a.Stop)) : null)=="cardinality")
            		             {
            		              metaData.ismultiple=((((b != null) ? input.ToString((IToken)(b.Start),(IToken)(b.Stop)) : null)=="0")?false:true);
            		             }
            		             else if(((a != null) ? input.ToString((IToken)(a.Start),(IToken)(a.Stop)) : null)=="value")
            		             {
            		               metaData.value=objTypeCast.GetStringWithoutQuotes(((d != null) ? input.ToString((IToken)(d.Start),(IToken)(d.Stop)) : null));
            		             }
            		    
            		}

            	}

            	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:817:3: ( ',' c= identifier '=' d= primary )*
            	do 
            	{
            	    int alt58 = 2;
            	    int LA58_0 = input.LA(1);

            	    if ( (LA58_0 == 46) )
            	    {
            	        alt58 = 1;
            	    }


            	    switch (alt58) 
            		{
            			case 1 :
            			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:817:4: ',' c= identifier '=' d= primary
            			    {
            			    	char_literal257=(IToken)Match(input,46,FOLLOW_46_in_metadata3466); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_46.Add(char_literal257);

            			    	PushFollow(FOLLOW_identifier_in_metadata3470);
            			    	c = identifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_identifier.Add(c.Tree);
            			    	char_literal258=(IToken)Match(input,79,FOLLOW_79_in_metadata3472); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_79.Add(char_literal258);

            			    	PushFollow(FOLLOW_primary_in_metadata3476);
            			    	d = primary();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_primary.Add(d.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	             if(((c != null) ? input.ToString((IToken)(c.Start),(IToken)(c.Stop)) : null)=="datatype")
            			    	             {
            			    	             metaData.datatype=(((d != null) ? input.ToString((IToken)(d.Start),(IToken)(d.Stop)) : null).ToLower() == "datetime") ? "date":((b != null) ? input.ToString((IToken)(b.Start),(IToken)(b.Stop)) : null); 
            			    	             }
            			    	             else if(((c != null) ? input.ToString((IToken)(c.Start),(IToken)(c.Stop)) : null)=="cardinality")
            			    	             {
            			    	              metaData.ismultiple=((((d != null) ? input.ToString((IToken)(d.Start),(IToken)(d.Stop)) : null)=="0")?false:true);
            			    	             }
            			    	             else if(((c != null) ? input.ToString((IToken)(c.Start),(IToken)(c.Stop)) : null)=="value")
            			    	             {
            			    	               metaData.value=objTypeCast.GetStringWithoutQuotes(((d != null) ? input.ToString((IToken)(d.Start),(IToken)(d.Stop)) : null));
            			    	             }
            			    	    
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop58;
            	    }
            	} while (true);

            	loop58:
            		;	// Stops C# compiler whining that label 'loop58' has no statements

            	if ( (state.backtracking==0) )
            	{

            	           retval.metaDataInfo =  metaData;
            	    
            	}


            	// AST REWRITE
            	// elements:          primary, primary, identifier, identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 837:5: -> ^( MetadataDummy identifier primary ) ( ^( MetadataDummy identifier primary ) )*
            	{
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:838:7: ^( MetadataDummy identifier primary )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MetadataDummy, "MetadataDummy"), root_1);

            	    adaptor.AddChild(root_1, stream_identifier.NextTree());
            	    adaptor.AddChild(root_1, stream_primary.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:839:7: ( ^( MetadataDummy identifier primary ) )*
            	    while ( stream_primary.HasNext() || stream_identifier.HasNext() )
            	    {
            	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:839:7: ^( MetadataDummy identifier primary )
            	        {
            	        CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MetadataDummy, "MetadataDummy"), root_1);

            	        adaptor.AddChild(root_1, stream_identifier.NextTree());
            	        adaptor.AddChild(root_1, stream_primary.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_primary.Reset();
            	    stream_identifier.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 64, metadata_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "metadata"

    public class primary_return : ParserRuleReturnScope
    {
        public MetadataInfo primaryInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "primary"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:842:1: primary returns [MetadataInfo primaryInfo] : (a= Literal | b= Identifier );
    public CalcETreeParser.primary_return primary() // throws RecognitionException [1]
    {   
        CalcETreeParser.primary_return retval = new CalcETreeParser.primary_return();
        retval.Start = input.LT(1);
        int primary_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken a = null;
        IToken b = null;

        CommonTree a_tree=null;
        CommonTree b_tree=null;

        MetadataInfo metaData = new MetadataInfo();  
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:843:3: (a= Literal | b= Identifier )
            int alt59 = 2;
            int LA59_0 = input.LA(1);

            if ( (LA59_0 == Literal) )
            {
                alt59 = 1;
            }
            else if ( (LA59_0 == Identifier) )
            {
                alt59 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d59s0 =
                    new NoViableAltException("", 59, 0, input);

                throw nvae_d59s0;
            }
            switch (alt59) 
            {
                case 1 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:844:2: a= Literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	a=(IToken)Match(input,Literal,FOLLOW_Literal_in_primary3552); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{a_tree = (CommonTree)adaptor.Create(a);
                    		adaptor.AddChild(root_0, a_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{

                    	     metaData.value = ((a != null) ? a.Text : null);
                    	      metaData.datatype = TypeCastImpl.GetDatatype(((a != null) ? a.Text : null));
                    	     
                    	    
                    	}

                    }
                    break;
                case 2 :
                    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:850:4: b= Identifier
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	b=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_primary3564); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{b_tree = (CommonTree)adaptor.Create(b);
                    		adaptor.AddChild(root_0, b_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{

                    	      metaData.value = ((b != null) ? b.Text : null);
                    	      metaData.datatype = TypeCastImpl.GetDatatype(((b != null) ? b.Text : null));
                    	    
                    	}
                    	if ( (state.backtracking==0) )
                    	{

                    	      retval.primaryInfo = metaData;
                    	    
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 65, primary_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "primary"

    public class identifier_return : ParserRuleReturnScope
    {
        public MetadataInfo identifierInfo;
        public CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "identifier"
    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:860:1: identifier returns [MetadataInfo identifierInfo] : i= Identifier ;
    public CalcETreeParser.identifier_return identifier() // throws RecognitionException [1]
    {   
        CalcETreeParser.identifier_return retval = new CalcETreeParser.identifier_return();
        retval.Start = input.LT(1);
        int identifier_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken i = null;

        CommonTree i_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 66) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:861:2: (i= Identifier )
            // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:861:5: i= Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	i=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_identifier3594); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{i_tree = (CommonTree)adaptor.Create(i);
            		adaptor.AddChild(root_0, i_tree);
            	}
            	if ( (state.backtracking==0) )
            	{

            	  	 retval.identifierInfo =  new MetadataInfo();
            	  	 retval.identifierInfo.value=((i != null) ? i.Text : null);
            	  	 retval.identifierInfo.datatype=TypeCastImpl.GetDatatype(((i != null) ? i.Text : null));
            	  	
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

               catch (RecognitionException e){   
                     objTypeCast.createErrorMessage(e);    	
               	     throw e;
        	}
                   finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 66, identifier_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "identifier"

    // $ANTLR start "synpred34_CalcETree"
    public void synpred34_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:133: ( ']' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:160:133: ']'
        {
        	Match(input,50,FOLLOW_50_in_synpred34_CalcETree742); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_CalcETree"

    // $ANTLR start "synpred47_CalcETree"
    public void synpred47_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:368:3: ( '(' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:368:3: '('
        {
        	Match(input,45,FOLLOW_45_in_synpred47_CalcETree2074); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_CalcETree"

    // $ANTLR start "synpred48_CalcETree"
    public void synpred48_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:368:33: ( ')' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:368:33: ')'
        {
        	Match(input,47,FOLLOW_47_in_synpred48_CalcETree2079); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred48_CalcETree"

    // $ANTLR start "synpred51_CalcETree"
    public void synpred51_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:5: ( '(' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:5: '('
        {
        	Match(input,45,FOLLOW_45_in_synpred51_CalcETree2121); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred51_CalcETree"

    // $ANTLR start "synpred52_CalcETree"
    public void synpred52_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:35: ( ')' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:35: ')'
        {
        	Match(input,47,FOLLOW_47_in_synpred52_CalcETree2126); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred52_CalcETree"

    // $ANTLR start "synpred53_CalcETree"
    public void synpred53_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:370:5: ( ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )? )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:370:5: ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )?
        {
        	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:370:5: ( 'OR' | 'AND' )?
        	int alt65 = 2;
        	int LA65_0 = input.LA(1);

        	if ( ((LA65_0 >= 80 && LA65_0 <= 81)) )
        	{
        	    alt65 = 1;
        	}
        	switch (alt65) 
        	{
        	    case 1 :
        	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:
        	        {
        	        	if ( (input.LA(1) >= 80 && input.LA(1) <= 81) ) 
        	        	{
        	        	    input.Consume();
        	        	    state.errorRecovery = false;state.failed = false;
        	        	}
        	        	else 
        	        	{
        	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	        	    throw mse;
        	        	}


        	        }
        	        break;

        	}

        	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:5: ( '(' )?
        	int alt66 = 2;
        	int LA66_0 = input.LA(1);

        	if ( (LA66_0 == 45) )
        	{
        	    int LA66_1 = input.LA(2);

        	    if ( (synpred51_CalcETree()) )
        	    {
        	        alt66 = 1;
        	    }
        	}
        	switch (alt66) 
        	{
        	    case 1 :
        	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: '('
        	        {
        	        	Match(input,45,FOLLOW_45_in_synpred53_CalcETree2121); if (state.failed) return ;

        	        }
        	        break;

        	}

        	PushFollow(FOLLOW_conditionalAndExpression_in_synpred53_CalcETree2124);
        	conditionalAndExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:374:35: ( ')' )?
        	int alt67 = 2;
        	int LA67_0 = input.LA(1);

        	if ( (LA67_0 == 47) )
        	{
        	    alt67 = 1;
        	}
        	switch (alt67) 
        	{
        	    case 1 :
        	        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:0:0: ')'
        	        {
        	        	Match(input,47,FOLLOW_47_in_synpred53_CalcETree2126); if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred53_CalcETree"

    // $ANTLR start "synpred54_CalcETree"
    public void synpred54_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:3: ( '(' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:3: '('
        {
        	Match(input,45,FOLLOW_45_in_synpred54_CalcETree2148); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred54_CalcETree"

    // $ANTLR start "synpred56_CalcETree"
    public void synpred56_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:48: ( ')' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:380:48: ')'
        {
        	Match(input,47,FOLLOW_47_in_synpred56_CalcETree2157); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred56_CalcETree"

    // $ANTLR start "synpred57_CalcETree"
    public void synpred57_CalcETree_fragment() {
        CalcETreeParser.multiplicativeExpression_return a = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.multiplicativeExpression_return b = default(CalcETreeParser.multiplicativeExpression_return);


        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:5: (a= multiplicativeExpression relationalOp b= multiplicativeExpression )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:5: a= multiplicativeExpression relationalOp b= multiplicativeExpression
        {
        	PushFollow(FOLLOW_multiplicativeExpression_in_synpred57_CalcETree2184);
        	a = multiplicativeExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_relationalOp_in_synpred57_CalcETree2190);
        	relationalOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_multiplicativeExpression_in_synpred57_CalcETree2197);
        	b = multiplicativeExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred57_CalcETree"

    // $ANTLR start "synpred58_CalcETree"
    public void synpred58_CalcETree_fragment() {
        CalcETreeParser.multiplicativeExpression_return a = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.multiplicativeExpression_return b = default(CalcETreeParser.multiplicativeExpression_return);


        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:3: ( (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+ )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:3: (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+
        {
        	// D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:3: (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+
        	int cnt69 = 0;
        	do 
        	{
        	    int alt69 = 2;
        	    int LA69_0 = input.LA(1);

        	    if ( (LA69_0 == Literal || LA69_0 == 45 || LA69_0 == 48 || (LA69_0 >= 64 && LA69_0 <= 67) || (LA69_0 >= 95 && LA69_0 <= 97) || LA69_0 == 99 || LA69_0 == 102 || (LA69_0 >= 104 && LA69_0 <= 107)) )
        	    {
        	        alt69 = 1;
        	    }


        	    switch (alt69) 
        		{
        			case 1 :
        			    // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:385:5: a= multiplicativeExpression relationalOp b= multiplicativeExpression
        			    {
        			    	PushFollow(FOLLOW_multiplicativeExpression_in_synpred58_CalcETree2184);
        			    	a = multiplicativeExpression();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;
        			    	PushFollow(FOLLOW_relationalOp_in_synpred58_CalcETree2190);
        			    	relationalOp();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;
        			    	PushFollow(FOLLOW_multiplicativeExpression_in_synpred58_CalcETree2197);
        			    	b = multiplicativeExpression();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt69 >= 1 ) goto loop69;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee69 =
        		                new EarlyExitException(69, input);
        		            throw eee69;
        	    }
        	    cnt69++;
        	} while (true);

        	loop69:
        		;	// Stops C# compiler whining that label 'loop69' has no statements


        }
    }
    // $ANTLR end "synpred58_CalcETree"

    // $ANTLR start "synpred59_CalcETree"
    public void synpred59_CalcETree_fragment() {
        CalcETreeParser.multiplicativeExpression_return c = default(CalcETreeParser.multiplicativeExpression_return);

        CalcETreeParser.inNotInExpression_return d = default(CalcETreeParser.inNotInExpression_return);


        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:401:9: (c= multiplicativeExpression d= inNotInExpression )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:401:9: c= multiplicativeExpression d= inNotInExpression
        {
        	PushFollow(FOLLOW_multiplicativeExpression_in_synpred59_CalcETree2225);
        	c = multiplicativeExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_inNotInExpression_in_synpred59_CalcETree2232);
        	d = inNotInExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred59_CalcETree"

    // $ANTLR start "synpred72_CalcETree"
    public void synpred72_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:506:3: ( rhsEntities )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:506:3: rhsEntities
        {
        	PushFollow(FOLLOW_rhsEntities_in_synpred72_CalcETree2589);
        	rhsEntities();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred72_CalcETree"

    // $ANTLR start "synpred73_CalcETree"
    public void synpred73_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:507:5: ( methodexpression )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:507:5: methodexpression
        {
        	PushFollow(FOLLOW_methodexpression_in_synpred73_CalcETree2597);
        	methodexpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred73_CalcETree"

    // $ANTLR start "synpred94_CalcETree"
    public void synpred94_CalcETree_fragment() {
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:747:27: ( '(' )
        // D:\\IFoundrySource\\iFoundry4X\\Dev\\Shared Files\\Antlr\\CalcETree.g:747:27: '('
        {
        	Match(input,45,FOLLOW_45_in_synpred94_CalcETree3113); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred94_CalcETree"

    // Delegated rules

   	public bool synpred72_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred72_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred54_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred54_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred52_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred52_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred51_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred51_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred56_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred56_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred58_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred58_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred57_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred57_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred73_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred73_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred48_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred48_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred94_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred94_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred47_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred53_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred53_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred34_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred59_CalcETree() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred59_CalcETree_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA30 dfa30;
   	protected DFA31 dfa31;
   	protected DFA36 dfa36;
   	protected DFA34 dfa34;
   	protected DFA35 dfa35;
   	protected DFA39 dfa39;
   	protected DFA48 dfa48;
	public void InitializeCyclicDFAs()
	{
    	this.dfa30 = new DFA30(this);
    	this.dfa31 = new DFA31(this);
    	this.dfa36 = new DFA36(this);
    	this.dfa34 = new DFA34(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa39 = new DFA39(this);
    	this.dfa48 = new DFA48(this);
	    this.dfa30.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA30_SpecialStateTransition);
	    this.dfa31.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA31_SpecialStateTransition);
	    this.dfa36.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA36_SpecialStateTransition);
	    this.dfa34.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA34_SpecialStateTransition);
	    this.dfa35.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA35_SpecialStateTransition);
	    this.dfa39.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA39_SpecialStateTransition);
	    this.dfa48.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA48_SpecialStateTransition);
	}

    const string DFA30_eotS =
        "\x16\uffff";
    const string DFA30_eofS =
        "\x01\x01\x15\uffff";
    const string DFA30_minS =
        "\x01\x06\x03\uffff\x11\x00\x01\uffff";
    const string DFA30_maxS =
        "\x01\x6b\x03\uffff\x11\x00\x01\uffff";
    const string DFA30_acceptS =
        "\x01\uffff\x01\x02\x13\uffff\x01\x01";
    const string DFA30_specialS =
        "\x04\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\uffff}>";
    static readonly string[] DFA30_transitionS = {
            "\x01\x0f\x26\uffff\x01\x05\x01\uffff\x01\x01\x01\x11\x08\uffff"+
            "\x01\x01\x06\uffff\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x0c\uffff"+
            "\x02\x04\x0d\uffff\x02\x13\x01\x0a\x01\uffff\x01\x12\x01\x14"+
            "\x01\uffff\x01\x06\x01\uffff\x01\x07\x01\x08\x01\x09\x01\x10",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
    static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
    static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
    static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
    static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
    static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
    static readonly short[][] DFA30_transition = DFA.UnpackEncodedStringArray(DFA30_transitionS);

    protected class DFA30 : DFA
    {
        public DFA30(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 30;
            this.eot = DFA30_eot;
            this.eof = DFA30_eof;
            this.min = DFA30_min;
            this.max = DFA30_max;
            this.accept = DFA30_accept;
            this.special = DFA30_special;
            this.transition = DFA30_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 369:3: ( ( 'OR' | 'AND' )? ( '(' )? conditionalAndExpression ( ')' )? )*"; }
        }

    }


    protected internal int DFA30_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA30_4 = input.LA(1);

                   	 
                   	int index30_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA30_5 = input.LA(1);

                   	 
                   	int index30_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA30_6 = input.LA(1);

                   	 
                   	int index30_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA30_7 = input.LA(1);

                   	 
                   	int index30_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA30_8 = input.LA(1);

                   	 
                   	int index30_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA30_9 = input.LA(1);

                   	 
                   	int index30_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA30_10 = input.LA(1);

                   	 
                   	int index30_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA30_11 = input.LA(1);

                   	 
                   	int index30_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA30_12 = input.LA(1);

                   	 
                   	int index30_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA30_13 = input.LA(1);

                   	 
                   	int index30_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA30_14 = input.LA(1);

                   	 
                   	int index30_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA30_15 = input.LA(1);

                   	 
                   	int index30_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA30_16 = input.LA(1);

                   	 
                   	int index30_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA30_17 = input.LA(1);

                   	 
                   	int index30_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA30_18 = input.LA(1);

                   	 
                   	int index30_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA30_19 = input.LA(1);

                   	 
                   	int index30_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA30_20 = input.LA(1);

                   	 
                   	int index30_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred53_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index30_20);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae30 =
            new NoViableAltException(dfa.Description, 30, _s, input);
        dfa.Error(nvae30);
        throw nvae30;
    }
    const string DFA31_eotS =
        "\x11\uffff";
    const string DFA31_eofS =
        "\x11\uffff";
    const string DFA31_minS =
        "\x01\x06\x01\x00\x0f\uffff";
    const string DFA31_maxS =
        "\x01\x6b\x01\x00\x0f\uffff";
    const string DFA31_acceptS =
        "\x02\uffff\x01\x02\x0d\uffff\x01\x01";
    const string DFA31_specialS =
        "\x01\uffff\x01\x00\x0f\uffff}>";
    static readonly string[] DFA31_transitionS = {
            "\x01\x02\x26\uffff\x01\x01\x02\uffff\x01\x02\x0f\uffff\x04"+
            "\x02\x1b\uffff\x03\x02\x01\uffff\x01\x02\x02\uffff\x01\x02\x01"+
            "\uffff\x04\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA31_eot = DFA.UnpackEncodedString(DFA31_eotS);
    static readonly short[] DFA31_eof = DFA.UnpackEncodedString(DFA31_eofS);
    static readonly char[] DFA31_min = DFA.UnpackEncodedStringToUnsignedChars(DFA31_minS);
    static readonly char[] DFA31_max = DFA.UnpackEncodedStringToUnsignedChars(DFA31_maxS);
    static readonly short[] DFA31_accept = DFA.UnpackEncodedString(DFA31_acceptS);
    static readonly short[] DFA31_special = DFA.UnpackEncodedString(DFA31_specialS);
    static readonly short[][] DFA31_transition = DFA.UnpackEncodedStringArray(DFA31_transitionS);

    protected class DFA31 : DFA
    {
        public DFA31(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 31;
            this.eot = DFA31_eot;
            this.eof = DFA31_eof;
            this.min = DFA31_min;
            this.max = DFA31_max;
            this.accept = DFA31_accept;
            this.special = DFA31_special;
            this.transition = DFA31_transition;

        }

        override public string Description
        {
            get { return "380:3: ( '(' )?"; }
        }

    }


    protected internal int DFA31_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA31_1 = input.LA(1);

                   	 
                   	int index31_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred54_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index31_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae31 =
            new NoViableAltException(dfa.Description, 31, _s, input);
        dfa.Error(nvae31);
        throw nvae31;
    }
    const string DFA36_eotS =
        "\x12\uffff";
    const string DFA36_eofS =
        "\x12\uffff";
    const string DFA36_minS =
        "\x01\x06\x0f\x00\x02\uffff";
    const string DFA36_maxS =
        "\x01\x6b\x0f\x00\x02\uffff";
    const string DFA36_acceptS =
        "\x10\uffff\x01\x01\x01\x02";
    const string DFA36_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x02\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x01\x0b\x26\uffff\x01\x01\x02\uffff\x01\x0d\x0f\uffff\x01"+
            "\x07\x01\x08\x01\x09\x01\x0a\x1b\uffff\x02\x0f\x01\x06\x01\uffff"+
            "\x01\x0e\x02\uffff\x01\x02\x01\uffff\x01\x03\x01\x04\x01\x05"+
            "\x01\x0c",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA36_eot = DFA.UnpackEncodedString(DFA36_eotS);
    static readonly short[] DFA36_eof = DFA.UnpackEncodedString(DFA36_eofS);
    static readonly char[] DFA36_min = DFA.UnpackEncodedStringToUnsignedChars(DFA36_minS);
    static readonly char[] DFA36_max = DFA.UnpackEncodedStringToUnsignedChars(DFA36_maxS);
    static readonly short[] DFA36_accept = DFA.UnpackEncodedString(DFA36_acceptS);
    static readonly short[] DFA36_special = DFA.UnpackEncodedString(DFA36_specialS);
    static readonly short[][] DFA36_transition = DFA.UnpackEncodedStringArray(DFA36_transitionS);

    protected class DFA36 : DFA
    {
        public DFA36(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 36;
            this.eot = DFA36_eot;
            this.eof = DFA36_eof;
            this.min = DFA36_min;
            this.max = DFA36_max;
            this.accept = DFA36_accept;
            this.special = DFA36_special;
            this.transition = DFA36_transition;

        }

        override public string Description
        {
            get { return "383:1: equalityExpression returns [MetadataInfo equalityExpressionInfo] : ( (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+ | (c= multiplicativeExpression d= inNotInExpression )+ );"; }
        }

    }


    protected internal int DFA36_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA36_1 = input.LA(1);

                   	 
                   	int index36_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA36_2 = input.LA(1);

                   	 
                   	int index36_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA36_3 = input.LA(1);

                   	 
                   	int index36_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA36_4 = input.LA(1);

                   	 
                   	int index36_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA36_5 = input.LA(1);

                   	 
                   	int index36_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA36_6 = input.LA(1);

                   	 
                   	int index36_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA36_7 = input.LA(1);

                   	 
                   	int index36_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA36_8 = input.LA(1);

                   	 
                   	int index36_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA36_9 = input.LA(1);

                   	 
                   	int index36_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA36_10 = input.LA(1);

                   	 
                   	int index36_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA36_11 = input.LA(1);

                   	 
                   	int index36_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA36_12 = input.LA(1);

                   	 
                   	int index36_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA36_13 = input.LA(1);

                   	 
                   	int index36_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA36_14 = input.LA(1);

                   	 
                   	int index36_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA36_15 = input.LA(1);

                   	 
                   	int index36_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_CalcETree()) ) { s = 16; }

                   	else if ( (true) ) { s = 17; }

                   	 
                   	input.Seek(index36_15);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae36 =
            new NoViableAltException(dfa.Description, 36, _s, input);
        dfa.Error(nvae36);
        throw nvae36;
    }
    const string DFA34_eotS =
        "\x16\uffff";
    const string DFA34_eofS =
        "\x01\x01\x15\uffff";
    const string DFA34_minS =
        "\x01\x06\x02\uffff\x0f\x00\x04\uffff";
    const string DFA34_maxS =
        "\x01\x6b\x02\uffff\x0f\x00\x04\uffff";
    const string DFA34_acceptS =
        "\x01\uffff\x01\x02\x13\uffff\x01\x01";
    const string DFA34_specialS =
        "\x03\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x04\uffff}>";
    static readonly string[] DFA34_transitionS = {
            "\x01\x0d\x26\uffff\x01\x03\x01\uffff\x01\x01\x01\x0f\x08\uffff"+
            "\x01\x01\x06\uffff\x01\x09\x01\x0a\x01\x0b\x01\x0c\x0c\uffff"+
            "\x02\x01\x0d\uffff\x02\x11\x01\x08\x01\uffff\x01\x10\x01\x01"+
            "\x01\uffff\x01\x04\x01\uffff\x01\x05\x01\x06\x01\x07\x01\x0e",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA34_eot = DFA.UnpackEncodedString(DFA34_eotS);
    static readonly short[] DFA34_eof = DFA.UnpackEncodedString(DFA34_eofS);
    static readonly char[] DFA34_min = DFA.UnpackEncodedStringToUnsignedChars(DFA34_minS);
    static readonly char[] DFA34_max = DFA.UnpackEncodedStringToUnsignedChars(DFA34_maxS);
    static readonly short[] DFA34_accept = DFA.UnpackEncodedString(DFA34_acceptS);
    static readonly short[] DFA34_special = DFA.UnpackEncodedString(DFA34_specialS);
    static readonly short[][] DFA34_transition = DFA.UnpackEncodedStringArray(DFA34_transitionS);

    protected class DFA34 : DFA
    {
        public DFA34(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 34;
            this.eot = DFA34_eot;
            this.eof = DFA34_eof;
            this.min = DFA34_min;
            this.max = DFA34_max;
            this.accept = DFA34_accept;
            this.special = DFA34_special;
            this.transition = DFA34_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 385:3: (a= multiplicativeExpression relationalOp b= multiplicativeExpression )+"; }
        }

    }


    protected internal int DFA34_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA34_3 = input.LA(1);

                   	 
                   	int index34_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA34_4 = input.LA(1);

                   	 
                   	int index34_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA34_5 = input.LA(1);

                   	 
                   	int index34_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA34_6 = input.LA(1);

                   	 
                   	int index34_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA34_7 = input.LA(1);

                   	 
                   	int index34_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA34_8 = input.LA(1);

                   	 
                   	int index34_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA34_9 = input.LA(1);

                   	 
                   	int index34_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA34_10 = input.LA(1);

                   	 
                   	int index34_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA34_11 = input.LA(1);

                   	 
                   	int index34_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA34_12 = input.LA(1);

                   	 
                   	int index34_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA34_13 = input.LA(1);

                   	 
                   	int index34_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA34_14 = input.LA(1);

                   	 
                   	int index34_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA34_15 = input.LA(1);

                   	 
                   	int index34_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA34_16 = input.LA(1);

                   	 
                   	int index34_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA34_17 = input.LA(1);

                   	 
                   	int index34_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred57_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index34_17);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae34 =
            new NoViableAltException(dfa.Description, 34, _s, input);
        dfa.Error(nvae34);
        throw nvae34;
    }
    const string DFA35_eotS =
        "\x16\uffff";
    const string DFA35_eofS =
        "\x01\x01\x15\uffff";
    const string DFA35_minS =
        "\x01\x06\x02\uffff\x0f\x00\x04\uffff";
    const string DFA35_maxS =
        "\x01\x6b\x02\uffff\x0f\x00\x04\uffff";
    const string DFA35_acceptS =
        "\x01\uffff\x01\x02\x13\uffff\x01\x01";
    const string DFA35_specialS =
        "\x03\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x04\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x01\x0d\x26\uffff\x01\x03\x01\uffff\x01\x01\x01\x0f\x08\uffff"+
            "\x01\x01\x06\uffff\x01\x09\x01\x0a\x01\x0b\x01\x0c\x0c\uffff"+
            "\x02\x01\x0d\uffff\x02\x11\x01\x08\x01\uffff\x01\x10\x01\x01"+
            "\x01\uffff\x01\x04\x01\uffff\x01\x05\x01\x06\x01\x07\x01\x0e",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA35_eot = DFA.UnpackEncodedString(DFA35_eotS);
    static readonly short[] DFA35_eof = DFA.UnpackEncodedString(DFA35_eofS);
    static readonly char[] DFA35_min = DFA.UnpackEncodedStringToUnsignedChars(DFA35_minS);
    static readonly char[] DFA35_max = DFA.UnpackEncodedStringToUnsignedChars(DFA35_maxS);
    static readonly short[] DFA35_accept = DFA.UnpackEncodedString(DFA35_acceptS);
    static readonly short[] DFA35_special = DFA.UnpackEncodedString(DFA35_specialS);
    static readonly short[][] DFA35_transition = DFA.UnpackEncodedStringArray(DFA35_transitionS);

    protected class DFA35 : DFA
    {
        public DFA35(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 401:7: (c= multiplicativeExpression d= inNotInExpression )+"; }
        }

    }


    protected internal int DFA35_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA35_3 = input.LA(1);

                   	 
                   	int index35_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA35_4 = input.LA(1);

                   	 
                   	int index35_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA35_5 = input.LA(1);

                   	 
                   	int index35_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA35_6 = input.LA(1);

                   	 
                   	int index35_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA35_7 = input.LA(1);

                   	 
                   	int index35_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA35_8 = input.LA(1);

                   	 
                   	int index35_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA35_9 = input.LA(1);

                   	 
                   	int index35_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA35_10 = input.LA(1);

                   	 
                   	int index35_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA35_11 = input.LA(1);

                   	 
                   	int index35_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA35_12 = input.LA(1);

                   	 
                   	int index35_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA35_13 = input.LA(1);

                   	 
                   	int index35_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA35_14 = input.LA(1);

                   	 
                   	int index35_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA35_15 = input.LA(1);

                   	 
                   	int index35_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA35_16 = input.LA(1);

                   	 
                   	int index35_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA35_17 = input.LA(1);

                   	 
                   	int index35_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_CalcETree()) ) { s = 21; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index35_17);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae35 =
            new NoViableAltException(dfa.Description, 35, _s, input);
        dfa.Error(nvae35);
        throw nvae35;
    }
    const string DFA39_eotS =
        "\x11\uffff";
    const string DFA39_eofS =
        "\x11\uffff";
    const string DFA39_minS =
        "\x01\x06\x04\uffff\x01\x00\x06\uffff\x01\x00\x04\uffff";
    const string DFA39_maxS =
        "\x01\x6b\x04\uffff\x01\x00\x06\uffff\x01\x00\x04\uffff";
    const string DFA39_acceptS =
        "\x01\uffff\x01\x01\x0c\uffff\x01\x03\x01\x02\x01\x04";
    const string DFA39_specialS =
        "\x05\uffff\x01\x00\x06\uffff\x01\x01\x04\uffff}>";
    static readonly string[] DFA39_transitionS = {
            "\x01\x01\x29\uffff\x01\x0c\x0f\uffff\x04\x01\x1b\uffff\x02"+
            "\x0e\x01\x05\x01\uffff\x01\x01\x02\uffff\x01\x01\x01\uffff\x04"+
            "\x01",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
    static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
    static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
    static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
    static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
    static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
    static readonly short[][] DFA39_transition = DFA.UnpackEncodedStringArray(DFA39_transitionS);

    protected class DFA39 : DFA
    {
        public DFA39(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 39;
            this.eot = DFA39_eot;
            this.eof = DFA39_eof;
            this.min = DFA39_min;
            this.max = DFA39_max;
            this.accept = DFA39_accept;
            this.special = DFA39_special;
            this.transition = DFA39_transition;

        }

        override public string Description
        {
            get { return "504:1: bodmasValues returns [MetadataInfo bodmasValuesInfo] : ( rhsEntities | methodexpression | lookupExpression | callBlock );"; }
        }

    }


    protected internal int DFA39_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA39_5 = input.LA(1);

                   	 
                   	int index39_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred72_CalcETree()) ) { s = 1; }

                   	else if ( (synpred73_CalcETree()) ) { s = 15; }

                   	 
                   	input.Seek(index39_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA39_12 = input.LA(1);

                   	 
                   	int index39_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred72_CalcETree()) ) { s = 1; }

                   	else if ( (true) ) { s = 16; }

                   	 
                   	input.Seek(index39_12);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae39 =
            new NoViableAltException(dfa.Description, 39, _s, input);
        dfa.Error(nvae39);
        throw nvae39;
    }
    const string DFA48_eotS =
        "\x13\uffff";
    const string DFA48_eofS =
        "\x13\uffff";
    const string DFA48_minS =
        "\x01\x06\x01\x00\x11\uffff";
    const string DFA48_maxS =
        "\x01\x6b\x01\x00\x11\uffff";
    const string DFA48_acceptS =
        "\x02\uffff\x01\x02\x0f\uffff\x01\x01";
    const string DFA48_specialS =
        "\x01\uffff\x01\x00\x11\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x01\x02\x26\uffff\x01\x01\x01\uffff\x02\x02\x08\uffff\x01"+
            "\x02\x06\uffff\x04\x02\x1b\uffff\x03\x02\x01\uffff\x01\x02\x02"+
            "\uffff\x01\x02\x01\uffff\x04\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "747:27: ( '(' )?"; }
        }

    }


    protected internal int DFA48_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA48_1 = input.LA(1);

                   	 
                   	int index48_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred94_CalcETree()) ) { s = 18; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index48_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae48 =
            new NoViableAltException(dfa.Description, 48, _s, input);
        dfa.Error(nvae48);
        throw nvae48;
    }
 

    public static readonly BitSet FOLLOW_39_in_block86 = new BitSet(new ulong[]{0x55B90F0000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_blockStatement_in_block89 = new BitSet(new ulong[]{0x55B90F0000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_40_in_block92 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_blockStatement108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_statement123 = new BitSet(new ulong[]{0x0000300000000012UL});
    public static readonly BitSet FOLLOW_identifier_in_statement126 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_primary_in_statement128 = new BitSet(new ulong[]{0x0000300000000012UL});
    public static readonly BitSet FOLLOW_inputArguments_in_statement132 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_blockReturnType_in_statement135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_statement207 = new BitSet(new ulong[]{0x0001080000000040UL,0x00000F4A0000000FUL});
    public static readonly BitSet FOLLOW_rhsEntities_in_statement209 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_statement212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statements_in_statement237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_statement243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_inputArguments259 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_inputArguments261 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000E4000000000UL});
    public static readonly BitSet FOLLOW_lhsEntities_in_inputArguments263 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_46_in_inputArguments266 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000E4000000000UL});
    public static readonly BitSet FOLLOW_lhsEntities_in_inputArguments268 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_47_in_inputArguments272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_blockReturnType306 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_blockReturnType308 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_blockReturnType310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statements_in_statementsExpression329 = new BitSet(new ulong[]{0x55B9000000000022UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_expression_in_statements349 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_statements351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignExpression_in_expression366 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_invokeExpression_in_expression384 = new BitSet(new ulong[]{0x0241200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_invokeConditionExpression_in_expression386 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifExpression_in_expression445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileExpression_in_expression451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_saveExpression_in_expression457 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forAll_in_expression475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifExistsExpression_in_expression481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multipleLookupExpression_in_expression487 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_splitLookupExpression_in_expression505 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forAllValuesExpression_in_expression523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodexpression_in_expression529 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callBlock_in_expression547 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_invokeFormula_in_expression565 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression567 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_outputConmmentsExpression_in_expression584 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exitExpression_in_expression602 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_priceExpression_in_expression620 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookupExpression_in_expression638 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_invokePricer_in_expression656 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_applyAdjustmanets_in_expression674 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_expression676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMENT_in_expression692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_callBlock715 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_callBlock717 = new BitSet(new ulong[]{0x0002000000000010UL});
    public static readonly BitSet FOLLOW_49_in_callBlock719 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_callBlock722 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_callBlock724 = new BitSet(new ulong[]{0x0001A00000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parameters_in_callBlock725 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_callBlock727 = new BitSet(new ulong[]{0x0004000000000012UL});
    public static readonly BitSet FOLLOW_identifier_in_callBlock736 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_callBlock742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_invokeFormula810 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_invokeFormula812 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_invokeFormula815 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parameters_in_invokeFormula816 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_invokeFormula817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_invokePricer859 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_invokePricer861 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_applyAdjustmanets892 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_applyAdjustmanets894 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_46_in_applyAdjustmanets897 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_applyAdjustmanets899 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_invokeConditionExpression944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifexistsEntity_in_invokeConditionExpression950 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_ifexistsEntity965 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_objectModelEntity_in_ifexistsEntity967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_exitExpression1002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_outputConmmentsExpression1015 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_Literal_in_outputConmmentsExpression1017 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_outputConmmentsExpression1020 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_metadata_in_outputConmmentsExpression1022 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_outputConmmentsExpression1024 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_displayExpression1049 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_Literal_in_displayExpression1051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_ifExistsExpression1084 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_objectModelEntity_in_ifExistsExpression1086 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_ifExistsExpression1088 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_ifExistsExpression1090 = new BitSet(new ulong[]{0x55BD000000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_statementsExpression_in_ifExistsExpression1092 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_ifExistsExpression1094 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_ifExistsExpression1096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_forAll1138 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000E4000000000UL});
    public static readonly BitSet FOLLOW_lhsEntities_in_forAll1140 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_forAll1142 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_forAll1144 = new BitSet(new ulong[]{0x55BD000000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_statementsExpression_in_forAll1146 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_forAll1148 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_61_in_forAll1150 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_forAllValuesExpression1208 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000E4000000000UL});
    public static readonly BitSet FOLLOW_lhsEntities_in_forAllValuesExpression1210 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_forAllValuesExpression1212 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_forAllValuesExpression1214 = new BitSet(new ulong[]{0x55BD000000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_statementsExpression_in_forAllValuesExpression1216 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_forAllValuesExpression1218 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_forAllValuesExpression1220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_priceExpression1272 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_primaryForMethod_in_priceExpression1274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_priceExpression1291 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_primaryForMethod_in_priceExpression1293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_priceExpression1311 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_primaryForMethod_in_priceExpression1313 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_priceExpression1331 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_primaryForMethod_in_priceExpression1333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lhsEntities_in_assignExpression1365 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignExpression1370 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000001FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_assignExpression1382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_filterExpression_in_assignExpression1398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_filterExpression1426 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000E4000000000UL});
    public static readonly BitSet FOLLOW_lhsEntities_in_filterExpression1432 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_filterExpression1439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_ifExpression1464 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_ifExpression1466 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_ifExpression1468 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_ifExpression1470 = new BitSet(new ulong[]{0x55B9000000000020UL,0x00000E63800077AFUL});
    public static readonly BitSet FOLLOW_statementsExpression_in_ifExpression1472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000380UL});
    public static readonly BitSet FOLLOW_elseIfExpression_in_ifExpression1474 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000380UL});
    public static readonly BitSet FOLLOW_elseExpression_in_ifExpression1477 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_ifExpression1480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_elseIfExpression1596 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_elseIfExpression1598 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_elseIfExpression1600 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_elseIfExpression1602 = new BitSet(new ulong[]{0x55B9000000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_statementsExpression_in_elseIfExpression1604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_elseExpression1670 = new BitSet(new ulong[]{0x55B9000000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_statementsExpression_in_elseExpression1672 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_whileExpression1705 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_whileExpression1707 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_displayExpression_in_whileExpression1709 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_whileExpression1711 = new BitSet(new ulong[]{0x55BD000000000020UL,0x00000E638000742FUL});
    public static readonly BitSet FOLLOW_statementsExpression_in_whileExpression1713 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_whileExpression1715 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_whileExpression1717 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_invokeExpression1760 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_primaryForMethod_in_invokeExpression1763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_multipleLookupExpression1778 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_multipleLookupExpression1780 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_multipleLookupExpression1782 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parameters_in_multipleLookupExpression1784 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_multipleLookupExpression1786 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_multipleLookupExpression1788 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parameters_in_multipleLookupExpression1790 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_multipleLookupExpression1792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_splitLookupExpression1872 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_splitLookupExpression1874 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_splitLookupExpression1876 = new BitSet(new ulong[]{0x0001000000000040UL,0x00000F4A0000000FUL});
    public static readonly BitSet FOLLOW_rhsEntities_in_splitLookupExpression1878 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_splitLookupExpression1880 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_splitLookupExpression1882 = new BitSet(new ulong[]{0x0005200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_splitLookUpInputParamExpression_in_splitLookupExpression1884 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_splitLookupExpression1887 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_splitLookupExpression1889 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parameters_in_splitLookupExpression1891 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_splitLookupExpression1893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parameters_in_splitLookUpInputParamExpression1983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multipleReturnArgumentType_in_multipleLookupReturnArguments2016 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_46_in_multipleLookupReturnArguments2019 = new BitSet(new ulong[]{0x0001000000000040UL,0x00000F4A0000000FUL});
    public static readonly BitSet FOLLOW_multipleReturnArgumentType_in_multipleLookupReturnArguments2022 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_rhsEntities_in_multipleReturnArgumentType2042 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_assignmentOperator2059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_conditionalOrExpression2074 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression2077 = new BitSet(new ulong[]{0x0001A00000000042UL,0x00000F5B8003000FUL});
    public static readonly BitSet FOLLOW_47_in_conditionalOrExpression2079 = new BitSet(new ulong[]{0x0001200000000042UL,0x00000F5B8003000FUL});
    public static readonly BitSet FOLLOW_set_in_conditionalOrExpression2090 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_45_in_conditionalOrExpression2121 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression2124 = new BitSet(new ulong[]{0x0001A00000000042UL,0x00000F5B8003000FUL});
    public static readonly BitSet FOLLOW_47_in_conditionalOrExpression2126 = new BitSet(new ulong[]{0x0001200000000042UL,0x00000F5B8003000FUL});
    public static readonly BitSet FOLLOW_45_in_conditionalAndExpression2148 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression2151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNot_in_conditionalAndExpression2155 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_conditionalAndExpression2157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_equalityExpression2184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000003F00000UL});
    public static readonly BitSet FOLLOW_relationalOp_in_equalityExpression2190 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_equalityExpression2197 = new BitSet(new ulong[]{0x0001200000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_equalityExpression2225 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_inNotInExpression_in_equalityExpression2232 = new BitSet(new ulong[]{0x0001200000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_inNotInOperator_in_inNotInExpression2269 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_inNotInExpression2271 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parameters_in_inNotInExpression2277 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_inNotInExpression2279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_inNotInOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp2375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bodmasValuesWithBraces_in_multiplicativeExpression2449 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000007C000000UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression2466 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_bodmasValuesWithBraces_in_multiplicativeExpression2529 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000007C000000UL});
    public static readonly BitSet FOLLOW_45_in_bodmasValuesWithBraces2557 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_bodmasValuesWithBraces2559 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_bodmasValuesWithBraces2561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bodmasValues_in_bodmasValuesWithBraces2569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rhsEntities_in_bodmasValues2589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodexpression_in_bodmasValues2597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookupExpression_in_bodmasValues2605 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callBlock_in_bodmasValues2613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookupTypes_in_lookupExpression2633 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_primaryForMethod_in_lookupExpression2637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_lookupTypes2654 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_97_in_methodexpression2690 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_primaryForMethod_in_methodexpression2697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_primaryForMethod2723 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_primaryForMethod2738 = new BitSet(new ulong[]{0x0001A00000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parametersForMethod_in_primaryForMethod2746 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_primaryForMethod2760 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_identifier_in_primaryForMethod2783 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bodmasValues_in_parameters2821 = new BitSet(new ulong[]{0x0001600000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_46_in_parameters2826 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_bodmasValues_in_parameters2832 = new BitSet(new ulong[]{0x0001600000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_parametersForMethod2865 = new BitSet(new ulong[]{0x0001600000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_46_in_parametersForMethod2870 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_parametersForMethod2877 = new BitSet(new ulong[]{0x0001600000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_variableEntity_in_lhsEntities2909 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectModelEntity_in_lhsEntities2919 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varObjectModelEntity_in_lhsEntities2929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_xPath_in_lhsEntities2939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_98_in_operandExpression2960 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_Literal_in_operandExpression2962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableEntity_in_rhsEntities2998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantEntity_in_rhsEntities3006 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectModelEntity_in_rhsEntities3014 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varObjectModelEntity_in_rhsEntities3022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodexpression_in_rhsEntities3030 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_priceExpression_in_rhsEntities3038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Literal_in_rhsEntities3046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_xPath_in_rhsEntities3057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callBlock_in_rhsEntities3065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_99_in_rhsEntities3072 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryOp_in_unaryExpressionNot3085 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_unaryExpressionNot3087 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_100_in_unaryOp3095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_101_in_saveExpression3108 = new BitSet(new ulong[]{0x0000000000000050UL,0x00000F4000000000UL});
    public static readonly BitSet FOLLOW_commentEntities_in_saveExpression3111 = new BitSet(new ulong[]{0x0001A00000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_45_in_saveExpression3113 = new BitSet(new ulong[]{0x0001A00000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_parametersForMethod_in_saveExpression3116 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_saveExpression3119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableEntity_in_commentEntities3137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantEntity_in_commentEntities3143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectModelEntity_in_commentEntities3149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varObjectModelEntity_in_commentEntities3155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primary_in_commentEntities3161 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_xPath_in_commentEntities3167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_102_in_variableEntity3185 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_variableEntity3187 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_superIdentifier_in_variableEntity3194 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_operandExpression_in_variableEntity3198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_104_in_constantEntity3217 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_constantEntity3219 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_superIdentifier_in_constantEntity3226 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_operandExpression_in_constantEntity3230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_105_in_objectModelEntity3249 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_objectModelEntity3251 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_objectModelDescription_in_objectModelEntity3258 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_operandExpression_in_objectModelEntity3262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_106_in_varObjectModelEntity3281 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_varObjectModelEntity3283 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_objectModelDescription_in_varObjectModelEntity3290 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_operandExpression_in_varObjectModelEntity3294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_107_in_xPath3313 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_xPath3315 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_superIdentifier_in_xPath3322 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_operandExpression_in_xPath3326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_superIdentifier_in_objectModelDescription3350 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_108_in_objectModelDescription3357 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_superIdentifier_in_objectModelDescription3364 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_identifier_in_superIdentifier3388 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_superIdentifier3390 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_metadata_in_superIdentifier3394 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_superIdentifier3396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_metadata3448 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_metadata3450 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_primary_in_metadata3455 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_46_in_metadata3466 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_identifier_in_metadata3470 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_metadata3472 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_primary_in_metadata3476 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_Literal_in_primary3552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_primary3564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_identifier3594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_synpred34_CalcETree742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_synpred47_CalcETree2074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_synpred48_CalcETree2079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_synpred51_CalcETree2121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_synpred52_CalcETree2126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred53_CalcETree2090 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_45_in_synpred53_CalcETree2121 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F5B8000000FUL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_synpred53_CalcETree2124 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_synpred53_CalcETree2126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_synpred54_CalcETree2148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_synpred56_CalcETree2157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_synpred57_CalcETree2184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000003F00000UL});
    public static readonly BitSet FOLLOW_relationalOp_in_synpred57_CalcETree2190 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_synpred57_CalcETree2197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_synpred58_CalcETree2184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000003F00000UL});
    public static readonly BitSet FOLLOW_relationalOp_in_synpred58_CalcETree2190 = new BitSet(new ulong[]{0x0001200000000040UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_synpred58_CalcETree2197 = new BitSet(new ulong[]{0x0001200000000042UL,0x00000F4B8000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_synpred59_CalcETree2225 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_inNotInExpression_in_synpred59_CalcETree2232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rhsEntities_in_synpred72_CalcETree2589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodexpression_in_synpred73_CalcETree2597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_synpred94_CalcETree3113 = new BitSet(new ulong[]{0x0000000000000002UL});

}
