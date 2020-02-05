using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedLengthSample
{
    /// <summary>
    /// 3072申请进度查询
    /// ="[FixedLength("&E11&", FixedLengthType."&D11&")] public string "&SUBSTITUTE(SUBSTITUTE(SUBSTITUTE(C11,"-","_",1),"-","_",1)," ","_",1)&"{get;set;}"&" //"&B11
    /// ="request."&SUBSTITUTE(SUBSTITUTE(SUBSTITUTE(C11,"-","_",1),"-","_",1)," ","_",1)&"="""&H11&""";"
    /// </summary>
    public class M3072Request : BaseModel
    {

        [FixedLength(4, FixedLengthType.N)]
        public string TRXTYPE { get; set; } //交易代码
        [FixedLength(6, FixedLengthType.A)]
        public string RETCODE { get; set; } //响应码
        [FixedLength(4, FixedLengthType.N)]
        public string BNKNBR { get; set; } //银行代号
        [FixedLength(2, FixedLengthType.A)]
        public string SOURCE { get; set; } //交易来源
        [FixedLength(6, FixedLengthType.N)]
        public string BRN_NO { get; set; } //网点代号
        [FixedLength(6, FixedLengthType.N)]
        public string OPE_NO { get; set; } //操作员号
        [FixedLength(6, FixedLengthType.N)]
        public string SEQNO { get; set; } //流水号
        [FixedLength(2, FixedLengthType.A)]
        public string IDTYPE { get; set; } //证件类型
        [FixedLength(18, FixedLengthType.A)]
        public string IDNO { get; set; } //证件号码
        [FixedLength(1, FixedLengthType.A)]
        public string RTN_IND { get; set; } //翻页标志
        [FixedLength(10, FixedLengthType.N)]
        public string APP_SEQ { get; set; } //申请书编号
        [FixedLength(8, FixedLengthType.A)]
        public string INPUT_DT { get; set; } //录入日期
        [FixedLength(12, FixedLengthType.A)]
        public string REVS { get; set; } //保留字段


    }
}
