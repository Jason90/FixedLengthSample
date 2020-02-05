using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedLengthSample
{
    /// <summary>
    /// 4093-联机录入申请资料并开户
    /// ="[FixedLength("&E11&", FixedLengthType."&D11&")] public string "&SUBSTITUTE(SUBSTITUTE(SUBSTITUTE(C11,"-","_",1),"-","_",1)," ","_",1)&"{get;set;}"&" //"&B11
    /// ="request."&SUBSTITUTE(SUBSTITUTE(SUBSTITUTE(C11,"-","_",1),"-","_",1)," ","_",1)&"="""&H11&""";"
    /// </summary>
    public class M4093Request : BaseModel
    {

        [FixedLength(4, FixedLengthType.N)]
        public string TRXTYPE { get; set; }
        [FixedLength(6, FixedLengthType.A)]
        public string RETCODE { get; set; }
        [FixedLength(4, FixedLengthType.N)]
        public string BNKNBR { get; set; }
        [FixedLength(2, FixedLengthType.A)]
        public string SOURCE { get; set; }
        [FixedLength(6, FixedLengthType.N)]
        public string BRNNO { get; set; }
        [FixedLength(6, FixedLengthType.N)]
        public string OPENO { get; set; }
        [FixedLength(6, FixedLengthType.N)]
        public string SEQNO { get; set; }
        [FixedLength(1, FixedLengthType.A)]
        public string ACTION { get; set; }
        [FixedLength(10, FixedLengthType.A)]
        public string APPLNREF { get; set; }
        [FixedLength(16, FixedLengthType.A)]
        public string MICROFILM { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string APPSTS { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string ACTIVENOW { get; set; }
        [FixedLength(19, FixedLengthType.A)]
        public string CUSTRNBR { get; set; }
        [FixedLength(30, FixedLengthType.A)]
        public string SURNAME { get; set; }
        [FixedLength(4, FixedLengthType.N)]
        public string PRODUCT { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string ADDLCARD { get; set; }
        [FixedLength(2, FixedLengthType.A)]
        public string ACCTYPE { get; set; }
        [FixedLength(4, FixedLengthType.A)]
        public string CDFRM { get; set; }
        [FixedLength(10, FixedLengthType.N)]
        public string CREDLIMIT { get; set; }
        [FixedLength(28, FixedLengthType.A)]
        public string EMBNAMED { get; set; }
        [FixedLength(4, FixedLengthType.A)]
        public string CDESPMTD { get; set; }
        [FixedLength(4, FixedLengthType.N)]
        public string CDESPLOC { get; set; }
        [FixedLength(2, FixedLengthType.A)]
        public string STMCODE { get; set; }
        [FixedLength(1, FixedLengthType.A)]
        public string MAILTO { get; set; }
        [FixedLength(30, FixedLengthType.A)]
        public string ADDR1L1 { get; set; }
        [FixedLength(30, FixedLengthType.A)]
        public string ADDR1L2 { get; set; }
        [FixedLength(30, FixedLengthType.A)]
        public string ADDR1L3 { get; set; }
        [FixedLength(30, FixedLengthType.A)]
        public string ADDR1L4 { get; set; }
        [FixedLength(6, FixedLengthType.N)]
        public string POSTCODE { get; set; }
        [FixedLength(1, FixedLengthType.A)]
        public string ADDR1TYPE { get; set; }
        [FixedLength(2, FixedLengthType.N)]
        public string CYCLENBR { get; set; }
        [FixedLength(4, FixedLengthType.N)]
        public string EXPYDATE { get; set; }
        [FixedLength(4, FixedLengthType.N)]
        public string BRANCH { get; set; }
        [FixedLength(2, FixedLengthType.N)]
        public string VCNCHNL { get; set; }
        [FixedLength(10, FixedLengthType.A)]
        public string APPSOURCE { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string PINCHK { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string SMSYN { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string SMSFREEYN { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string CDISSFLAG { get; set; }
        [FixedLength(10, FixedLengthType.N)]
        public string MPLLM { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string NOREISYN { get; set; }
        [FixedLength(10, FixedLengthType.N)]
        public string MPLIMIT { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string MPLMTFLAG { get; set; }
        [FixedLength(20, FixedLengthType.A)]
        public string CACCNBR { get; set; }
        [FixedLength(1, FixedLengthType.A)]
        public string CPAYMOD { get; set; }
        [FixedLength(3, FixedLengthType.N)]
        public string DECREAS { get; set; }
        [FixedLength(6, FixedLengthType.N)]
        public string DECEMP { get; set; }
        [FixedLength(1, FixedLengthType.A)]
        public string ABACCES { get; set; }
        [FixedLength(4, FixedLengthType.N)]
        public string ABBRNCH { get; set; }
        [FixedLength(4, FixedLengthType.A)]
        public string GIFTNO { get; set; }
        [FixedLength(3, FixedLengthType.N)]
        public string ABTEAM { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string ABAREA { get; set; }
        [FixedLength(2, FixedLengthType.A)]
        public string ISSMOD { get; set; }
        [FixedLength(19, FixedLengthType.A)]
        public string CARDSEL { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string RUSHFLG { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string RUSHFEE { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string COURIERF { get; set; }
        [FixedLength(26, FixedLengthType.A)]
        public string EMBOSSCPY { get; set; }
        [FixedLength(10, FixedLengthType.N)]
        public string CREDLMT { get; set; }
        [FixedLength(6, FixedLengthType.A)]
        public string PRMAGCD { get; set; }
        [FixedLength(1, FixedLengthType.A)]
        public string CARDTO { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string SIGNFLAG { get; set; }
        [FixedLength(1, FixedLengthType.N)]
        public string NOCHGEXP { get; set; }
        [FixedLength(840, FixedLengthType.A)]
        public string RETAIN { get; set; }

    }
}
