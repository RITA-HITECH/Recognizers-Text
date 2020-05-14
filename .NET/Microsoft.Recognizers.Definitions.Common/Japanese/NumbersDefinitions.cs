//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Japanese\Japanese-Numbers.yaml
//     - Language: Japanese
//     - ClassName: NumbersDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Japanese
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDefinitions
    {
      public const string LangMarker = @"Jpn";
      public const bool CompoundNumberLanguage = true;
      public const bool MultiDecimalSeparatorCulture = false;
      public const char DecimalSeparatorChar = '.';
      public const string FractionMarkerToken = @"";
      public const char NonDecimalSeparatorChar = ' ';
      public const string HalfADozenText = @"";
      public const string WordSeparatorToken = @"";
      public const char ZeroChar = '零';
      public const char PairChar = '対';
      public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
        {
            { @"k", 1000 },
            { @"m", 1000000 },
            { @"g", 1000000000 },
            { @"t", 1000000000000 },
            { @"b", 1000000000 }
        };
      public static readonly Dictionary<char, long> RoundNumberMapChar = new Dictionary<char, long>
        {
            { '十', 10 },
            { '百', 100 },
            { '千', 1000 },
            { '万', 10000 },
            { '億', 100000000 },
            { '兆', 1000000000000 }
        };
      public static readonly Dictionary<char, double> ZeroToNineMap = new Dictionary<char, double>
        {
            { '零', 0 },
            { '〇', 0 },
            { '一', 1 },
            { '二', 2 },
            { '三', 3 },
            { '四', 4 },
            { '五', 5 },
            { '六', 6 },
            { '七', 7 },
            { '八', 8 },
            { '九', 9 },
            { '0', 0 },
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { '半', 0.5 }
        };
      public static readonly Dictionary<char, char> FullToHalfMap = new Dictionary<char, char>
        {
            { '０', '0' },
            { '１', '1' },
            { '２', '2' },
            { '３', '3' },
            { '４', '4' },
            { '５', '5' },
            { '６', '6' },
            { '７', '7' },
            { '８', '8' },
            { '９', '9' },
            { '／', '/' },
            { '－', '-' },
            { '，', '\'' },
            { '、', '\'' },
            { 'Ｇ', 'G' },
            { 'Ｍ', 'M' },
            { 'Ｔ', 'T' },
            { 'Ｋ', 'K' },
            { 'ｋ', 'k' },
            { '．', '.' }
        };
      public static readonly Dictionary<string, string> UnitMap = new Dictionary<string, string>
        {
            { @"万万", @"億" },
            { @"億万", @"兆" },
            { @"万億", @"兆" },
            { @" ", @"" }
        };
      public static readonly IList<char> RoundDirectList = new List<char>
        {
            '万',
            '億',
            '兆'
        };
      public static readonly IList<char> TenChars = new List<char>
        {
            '十'
        };
      public static readonly string DigitalNumberRegex = $@"((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
      public const string ZeroToNineFullHalfRegex = @"[\d１２３４５６７８９０]";
      public static readonly string DigitNumRegex = $@"{ZeroToNineFullHalfRegex}+";
      public const string DozenRegex = @".*ダース$";
      public const string PercentageRegex = @".+(?=パ\s*ー\s*セ\s*ン\s*ト)|.*(?=[％%])";
      public static readonly string DoubleAndRoundRegex = $@"{ZeroToNineFullHalfRegex}+(\.{ZeroToNineFullHalfRegex}+)?\s*[万億]{{1,2}}(\s*(以上))?";
      public const string FracSplitRegex = @"[はと]|分\s*の";
      public const string ZeroToNineIntegerRegex = @"[〇一二三四五六七八九]";
      public const string NegativeNumberTermsRegex = @"(マ\s*イ\s*ナ\s*ス)";
      public const string NegativeNumberTermsRegexNum = @"(?<!(\d+\s*)|[-−－])[-−－]";
      public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}.*|^{NegativeNumberTermsRegexNum}.*";
      public static readonly string SpeGetNumberRegex = $@"{ZeroToNineFullHalfRegex}|{ZeroToNineIntegerRegex}|[半対]|[分厘]";
      public const string PairRegex = @".*[対膳足]$";
      public const string RoundNumberIntegerRegex = @"[十百千万億兆]";
      public const string AllowListRegex = @"(。|，|、|（|）|”｜国|週間|時間|時|匹|キロ|トン|年|個|足|本|で|は|\s|$|つ|月|の|と)";
      public static readonly string NotSingleRegex = $@"(?<!(第|だい))(({RoundNumberIntegerRegex}+(({ZeroToNineIntegerRegex}+|[十百千])+|{ZeroToNineFullHalfRegex}+|十)\s*))|(({ZeroToNineIntegerRegex}+|{ZeroToNineFullHalfRegex}+|十)\s*({RoundNumberIntegerRegex}\s*){{1,2}})\s*(([零]?({ZeroToNineIntegerRegex}+|{ZeroToNineFullHalfRegex}+|十)\s*{RoundNumberIntegerRegex}{{0,1}})\s*)*\s*(\s*(以上)?)";
      public static readonly string SingleRegex = $@"(({ZeroToNineIntegerRegex}+|{ZeroToNineFullHalfRegex}+|十)(?={AllowListRegex}))";
      public static readonly string AllIntRegex = $@"(?<!(ダース))(((({ZeroToNineIntegerRegex}|[十百千])\s*{RoundNumberIntegerRegex}*)|(({ZeroToNineFullHalfRegex}\s*{RoundNumberIntegerRegex})|{RoundNumberIntegerRegex})){{1,2}}(\s*[以上])?)";
      public const string PlaceHolderPureNumber = @"\b";
      public const string PlaceHolderDefault = @"\D|\b";
      public static readonly string NumbersSpecialsChars = $@"(({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})\s*)?{ZeroToNineFullHalfRegex}+";
      public static readonly string NumbersSpecialsCharsWithSuffix = $@"{NegativeNumberTermsRegexNum}?{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}";
      public static readonly string DottedNumbersSpecialsChar = $@"{NegativeNumberTermsRegexNum}?{ZeroToNineFullHalfRegex}{{1,3}}([,，、]{ZeroToNineFullHalfRegex}{{3}})+";
      public static readonly string NumbersWithHalfDozen = $@"半({RoundNumberIntegerRegex}|(ダース))";
      public static readonly string NumbersWithDozen = $@"({AllIntRegex}|{ZeroToNineFullHalfRegex}+)(ダース)";
      public const string PointRegexStr = @"[\.．・]";
      public static readonly string AllFloatRegex = $@"{NegativeNumberTermsRegex}?{AllIntRegex}\s*{PointRegexStr}\s*[一二三四五六七八九](\s*{ZeroToNineIntegerRegex})*";
      public static readonly string NumbersWithAllowListRegex = $@"{NegativeNumberTermsRegex}?({NotSingleRegex}|{SingleRegex})(?!({AllIntRegex}*([、.]{ZeroToNineIntegerRegex}+)*|{AllFloatRegex})*\s*{PercentageRegex}+)";
      public static readonly string NumbersAggressiveRegex = $@"(({AllIntRegex})(?!({AllIntRegex}*([、.]{ZeroToNineIntegerRegex}+)*|{AllFloatRegex})*\s*{PercentageRegex}*))";
      public static readonly string PointRegex = $@"{PointRegexStr}";
      public static readonly string DoubleSpecialsChars = $@"(?<!({ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}*))({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[\.．,]{ZeroToNineFullHalfRegex}+(?!{ZeroToNineFullHalfRegex}*[\.．,]{ZeroToNineFullHalfRegex}+)";
      public static readonly string DoubleRoundNumberSpecialsChars = $@"(?<!(({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+[\.．・,]({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})*))(({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})\s*)?({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+[\.．・,]({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+(?!({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})*[\.．・,]({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+)";
      public static readonly string DoubleSpecialsCharsWithNegatives = $@"(?<!({ZeroToNineFullHalfRegex}+|\.\.|．．))({NegativeNumberTermsRegexNum}\s*)?[\.．]{ZeroToNineFullHalfRegex}+(?!{ZeroToNineFullHalfRegex}*([\.．]{ZeroToNineFullHalfRegex}+))";
      public static readonly string SimpleDoubleSpecialsChars = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+[\.．]{ZeroToNineFullHalfRegex}+";
      public static readonly string DoubleWithMultiplierRegex = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}";
      public static readonly string DoubleWithThousandsRegex = $@"{NegativeNumberTermsRegex}{{0,1}}\s*({ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?\s*[万亿萬億]{{1,2}})";
      public static readonly string DoubleAllFloatRegex = $@"(?<!(({AllIntRegex}[.]*)|{AllFloatRegex})*){AllFloatRegex}(?!{ZeroToNineIntegerRegex}*\s*パーセント)";
      public static readonly string DoubleExponentialNotationRegex = $@"(?<!{ZeroToNineFullHalfRegex}+[\.．])({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?e(([-－+＋]*[1-9１２３４５６７８９]{ZeroToNineFullHalfRegex}*)|[0０](?!{ZeroToNineFullHalfRegex}+))";
      public static readonly string DoubleExponentialNotationKanjiRegex = $@"(?<!({ZeroToNineIntegerRegex})+[\.．・])(({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})\s*)?({ZeroToNineIntegerRegex}|[十千五百])+([\.．・]({ZeroToNineIntegerRegex})+)?(×)?(十)?(の)((((マ\s*イ\s*ナ\s*ス))*({ZeroToNineIntegerRegex}|[十])({ZeroToNineIntegerRegex}|[十])*[乗])(?!({ZeroToNineIntegerRegex}|[十])+))";
      public static readonly string DoubleScientificNotationRegex = $@"(?<!{ZeroToNineFullHalfRegex}+[\.．])({NegativeNumberTermsRegexNum}\s*)?({ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?)\^([-－+＋]*[1-9１２３４５６７８９]{ZeroToNineFullHalfRegex}*)";
      public static readonly string OrdinalNumbersRegex = $@"(((第|だい)({ZeroToNineFullHalfRegex}+)({RoundNumberIntegerRegex}+)?))|(({ZeroToNineFullHalfRegex}+|{ZeroToNineIntegerRegex}+)({RoundNumberIntegerRegex}+)?(番目|位|等))";
      public static readonly string OrdinalRegex = $@"(({OrdinalNumbersRegex})|((第|だい)({AllIntRegex})|({AllIntRegex}+(番目|位|等))))|(最初の|ファースト)";
      public const string RelativeOrdinalRegex = @"(?<relativeOrdinal>((最後)(から１つ前のこと|から１つ前(のも)?|から3番目|(から１つ前)(のもの)|から３番目|から三番目|から二番目|(から一つ前|から1つ前)(のもの|のこと)?|(から１つ)?(前))?|(次のもの)(前)?|前のもの|(現在)(のこと)?|次|二位))";
      public static readonly string AllOrdinalRegex = $@"({OrdinalRegex}|{RelativeOrdinalRegex})";
      public static readonly string AllFractionNumber = $@"((({NegativeNumberTermsRegex}{{0,1}})|{NegativeNumberTermsRegexNum})(({ZeroToNineFullHalfRegex}+|{AllIntRegex})\s*[はと]{{0,1}}\s*)?{NegativeNumberTermsRegex}{{0,1}}({ZeroToNineFullHalfRegex}+|{AllIntRegex})\s*分\s*の\s*{NegativeNumberTermsRegex}{{0,1}}({ZeroToNineFullHalfRegex}+|{AllIntRegex})+)";
      public static readonly string FractionNotationSpecialsCharsRegex = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+\s+{ZeroToNineFullHalfRegex}+[/／]{ZeroToNineFullHalfRegex}+";
      public static readonly string FractionNotationRegex = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[/／]{ZeroToNineFullHalfRegex}+";
      public static readonly string PercentagePointRegex = $@"(?<!{AllIntRegex})({AllFloatRegex}|{AllIntRegex})\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string SimplePercentageRegex = $@"({AllFloatRegex}|(({NegativeNumberTermsRegex})?({AllIntRegex}|[百])))\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string NumbersPercentagePointRegex = $@"(?<!%)(({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})?({ZeroToNineFullHalfRegex})+([\.．]({ZeroToNineFullHalfRegex})+)?\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])(?!{ZeroToNineFullHalfRegex}))";
      public static readonly string NumbersPercentageWithSeparatorRegex = $@"({ZeroToNineFullHalfRegex}{{1,3}}[,，、]{ZeroToNineFullHalfRegex}{{3}})+([\.．]{ZeroToNineFullHalfRegex}+)*\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string NumbersPercentageWithMultiplierRegex = $@"(?<!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string FractionPercentagePointRegex = $@"(?<!({ZeroToNineFullHalfRegex}+[\.．])){ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+(?!([\.．]{ZeroToNineFullHalfRegex}+))\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string FractionPercentageWithSeparatorRegex = $@"{ZeroToNineFullHalfRegex}{{1,3}}([,，、]{ZeroToNineFullHalfRegex}{{3}})+[\.．]{ZeroToNineFullHalfRegex}+\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string FractionPercentageWithMultiplierRegex = $@"{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string SimpleNumbersPercentageRegex = $@"(?<!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}+\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])(?!([\.．]{ZeroToNineFullHalfRegex}+))";
      public static readonly string SimpleNumbersPercentageWithMultiplierRegex = $@"(?<!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string SimpleNumbersPercentagePointRegex = $@"(?!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string IntegerPercentageRegex = $@"{ZeroToNineFullHalfRegex}+\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string IntegerPercentageWithMultiplierRegex = $@"{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string NumbersFractionPercentageRegex = $@"{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+\s*(パ\s*ー\s*セ\s*ン\s*ト|[%])";
      public static readonly string SimpleIntegerPercentageRegex = $@"(?<!%)(({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})?{ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?(\s*)[%](?!{ZeroToNineFullHalfRegex}))";
      public static readonly string NumbersFoldsPercentageRegex = $@"{ZeroToNineFullHalfRegex}(([\.．]?|\s*){ZeroToNineFullHalfRegex})?\s*[の]*\s*割引";
      public static readonly string FoldsPercentageRegex = $@"{ZeroToNineIntegerRegex}(\s*[.]?\s*{ZeroToNineIntegerRegex})?\s*[の]\s*割引";
      public static readonly string SimpleFoldsPercentageRegex = $@"{ZeroToNineFullHalfRegex}\s*割(\s*(半|({ZeroToNineFullHalfRegex}\s*分\s*{ZeroToNineFullHalfRegex}\s*厘)|{ZeroToNineFullHalfRegex}))?";
      public static readonly string SpecialsPercentageRegex = $@"({ZeroToNineIntegerRegex}|[十])\s*割(\s*(半|{ZeroToNineIntegerRegex}))?";
      public static readonly string NumbersSpecialsPercentageRegex = $@"({ZeroToNineFullHalfRegex}[\.．]{ZeroToNineFullHalfRegex}|[1１][0０])\s*割";
      public static readonly string SimpleSpecialsPercentageRegex = $@"{ZeroToNineIntegerRegex}\s*[.]\s*{ZeroToNineIntegerRegex}\s*割";
      public const string SpecialsFoldsPercentageRegex = @"半\s*分|(?<=ダース)";
      public const string TillRegex = @"(から|--|-|—|——|~)";
      public const string MoreRegex = @"(大なり|大きい|高い|大きく|>)";
      public const string LessRegex = @"(小なり|小さい|低い|<)";
      public const string EqualRegex = @"(等しい|イコール|=)";
      public static readonly string MoreOrEqual = $@"((大なりかイコール)|(大きいかイコール)|(大なりか等しい)|(大きいか等しい)|小さくない|以上|最低)";
      public const string MoreOrEqualSuffix = @"(より(大なりイコール|小さくない))";
      public static readonly string LessOrEqual = $@"(({LessRegex}\s*(或|或者)?\s*{EqualRegex})|(小なりかイコール)|(小なりか等しい)|(小さいかイコール)|(小さいか等しい)|(小さいか等しい)|大さくない|以下|最大)";
      public const string LessOrEqualSuffix = @"(小なりイコール|大さくない)";
      public static readonly string OneNumberRangeMoreRegex1 = $@"(?<number1>((?!(((，|、)(?!\d+))|((,|、)(?!\d+))|。)).)+)\s*((より)\s*(({MoreOrEqual}|{MoreRegex}))|超える|を超える)";
      public const string OneNumberRangeMoreRegex2 = @"(?<number1>((?!((，|、(?!\d+))|(,|、(?!\d+))|。)).)+)\s*(より)?(大なり)";
      public const string OneNumberRangeMoreRegex3 = @"(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(以上|最低)(?![万億]{1,2})";
      public static readonly string OneNumberRangeMoreRegex4 = $@"({MoreOrEqual}|{MoreRegex})\s*(?<number1>((?!(と|は|((と)?同時に)|((と)?そして)|が|，|、|,|(，(?!\d+))|(,(?!\d+))|。)).)+)";
      public const string OneNumberRangeMoreSeparateRegex = @"^[.]";
      public const string OneNumberRangeLessSeparateRegex = @"^[.]";
      public static readonly string OneNumberRangeLessRegex1 = $@"(?<number2>((?!(((，|、)(?!\d+))|((,|、)(?!\d+))|。)).)+)\s*(より)\s*({LessOrEqual}|{LessRegex})";
      public const string OneNumberRangeLessRegex2 = @"(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(より)?(小な)";
      public const string OneNumberRangeLessRegex3 = @"(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(以下|未満)(?![万億]{1,2})";
      public static readonly string OneNumberRangeLessRegex4 = $@"({LessOrEqual}|{LessRegex})\s*(?<number2>((?!(と|は|((と)?同時に)|((と)?そして)|が|，|、|,|(，(?!\d+))|(,(?!\d+))|。)).)+)";
      public static readonly string OneNumberRangeEqualRegex = $@"(((?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(に)\s*{EqualRegex})|({EqualRegex}\s*(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)))";
      public static readonly string TwoNumberRangeRegex1 = $@"(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(と|{TillRegex})\s*(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(の間)";
      public static readonly string TwoNumberRangeRegex2 = $@"({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2}|{OneNumberRangeMoreRegex3}|{OneNumberRangeMoreRegex4})\s*(と|は|((と)?同時に)|((と)?そして)|が|，|、|,)?\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2}|{OneNumberRangeLessRegex3}|{OneNumberRangeLessRegex4})";
      public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2}|{OneNumberRangeLessRegex3}|{OneNumberRangeLessRegex4})\s*(と|は|((と)?同時に)|((と)?そして)|が|，|、|,)?\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2}|{OneNumberRangeMoreRegex3}|{OneNumberRangeMoreRegex4})";
      public static readonly string TwoNumberRangeRegex4 = $@"(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*{TillRegex}\s*(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)";
      public const string AmbiguousFractionConnectorsRegex = @"^[.]";
      public static readonly Dictionary<string, string> RelativeReferenceOffsetMap = new Dictionary<string, string>
        {
            { @"現在", @"0" },
            { @"次", @"1" },
            { @"最後", @"0" },
            { @"最後から三番目", @"-2" },
            { @"最後から二番目", @"-1" },
            { @"最後から一つ前", @"-1" },
            { @"最後から一つ前のもの", @"-1" },
            { @"最後から一つ前のこと", @"-1" },
            { @"最後から1つ前のこと", @"-1" },
            { @"最後から1つ前のもの", @"-1" },
            { @"最後から1つ前", @"-1" },
            { @"現在のこと", @"0" },
            { @"前のもの", @"-1" },
            { @"次のもの", @"1" },
            { @"最後から３番目", @"-2" },
            { @"最後から１つ前", @"-1" },
            { @"最後から１つ前のもの", @"-1" },
            { @"最後から１つ前のこと", @"-1" },
            { @"最後から3番目", @"-2" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceRelativeToMap = new Dictionary<string, string>
        {
            { @"現在", @"end" },
            { @"次", @"current" },
            { @"最後", @"end" },
            { @"最後から三番目", @"end" },
            { @"最後から二番目", @"end" },
            { @"最後から一つ前", @"end" },
            { @"最後から一つ前のもの", @"end" },
            { @"最後から一つ前のこと", @"end" },
            { @"現在のこと", @"current" },
            { @"最後から1つ前のこと", @"end" },
            { @"最後から1つ前のもの", @"end" },
            { @"最後から1つ前", @"end" },
            { @"前のもの", @"current" },
            { @"次のもの", @"current" },
            { @"最後から３番目", @"end" },
            { @"最後から１つ前", @"end" },
            { @"最後から１つ前のもの", @"end" },
            { @"最後から１つ前のこと", @"end" },
            { @"最後から3番目", @"end" }
        };
    }
}