using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedLengthSample
{
    /// <summary>
    /// 3002-信用卡客户资料查询及更新
    /// ="[FixedLength("&E11&", FixedLengthType."&D11&")] public string "&SUBSTITUTE(SUBSTITUTE(SUBSTITUTE(C11,"-","_",1),"-","_",1)," ","_",1)&"{get;set;}"&" //"&B11
    /// ="request."&SUBSTITUTE(SUBSTITUTE(SUBSTITUTE(C11,"-","_",1),"-","_",1)," ","_",1)&"="""&H11&""";"
    /// </summary>
    public class M3002Request : BaseModel
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
        public string BRNNO { get; set; } //网点代号
        [FixedLength(6, FixedLengthType.N)]
        public string OPENO { get; set; } //操作员号
        [FixedLength(6, FixedLengthType.N)]
        public string SEQNO { get; set; } //流水号
        [FixedLength(19, FixedLengthType.A)]
        public string CARDNBR { get; set; } //卡号
        [FixedLength(1, FixedLengthType.A)]
        public string INQOPT { get; set; } //查询方式
        [FixedLength(2, FixedLengthType.A)]
        public string KEYTYPE { get; set; } //证件类型
        [FixedLength(18, FixedLengthType.A)]
        public string CUSTID { get; set; } //证件号码
        [FixedLength(1, FixedLengthType.A)]
        public string PINFLAG { get; set; } //是否检查密码标志
        [FixedLength(8, FixedLengthType.A)]
        public string PWD { get; set; } //密码
        [FixedLength(1, FixedLengthType.A)]
        public string OPTION { get; set; } //选项
        [FixedLength(1, FixedLengthType.A)]
        public string NATION { get; set; } //国籍
        [FixedLength(1, FixedLengthType.A)]
        public string MARRIED { get; set; } //婚姻状况
        [FixedLength(1, FixedLengthType.A)]
        public string EDUCATION { get; set; } //教育程度
        [FixedLength(2, FixedLengthType.A)]
        public string JOBPOSIT { get; set; } //职务分类
        [FixedLength(17, FixedLengthType.A)]
        public string HOMEPHONE { get; set; } //家庭电话
        [FixedLength(17, FixedLengthType.A)]
        public string BUSIPHONE { get; set; } //公司电话
        [FixedLength(6, FixedLengthType.A)]
        public string BUSIEXT { get; set; } //公司电话分机
        [FixedLength(12, FixedLengthType.A)]
        public string MOBILEPHONE { get; set; } //手机号码
        [FixedLength(40, FixedLengthType.A)]
        public string EMAIL { get; set; } //E-mail地址
        [FixedLength(17, FixedLengthType.A)]
        public string FAXNO { get; set; } //传真机号码
        [FixedLength(3, FixedLengthType.N)]
        public string RESIDEYES { get; set; } //居住年数
        [FixedLength(1, FixedLengthType.A)]
        public string RESIDESTS { get; set; } //住房情况
        [FixedLength(30, FixedLengthType.A)]
        public string BUSINAME { get; set; } //单位名称
        [FixedLength(20, FixedLengthType.A)]
        public string DEPT { get; set; } //部门
        [FixedLength(20, FixedLengthType.A)]
        public string TECTITLE { get; set; } //职务
        [FixedLength(4, FixedLengthType.A)]
        public string TRADE { get; set; } //行业类别代码
        [FixedLength(2, FixedLengthType.A)]
        public string BUSITYPE { get; set; } //行业性质
        [FixedLength(3, FixedLengthType.N)]
        public string JOBYES { get; set; } //公司服务年数
        [FixedLength(12, FixedLengthType.N)]
        public string EARNING { get; set; } //年收入
        [FixedLength(12, FixedLengthType.N)]
        public string SPOUSERN { get; set; } //配偶年收入
        [FixedLength(1, FixedLengthType.A)]
        public string GENDER { get; set; } //性别
        [FixedLength(5, FixedLengthType.A)]
        public string LAYCODE1 { get; set; } //客户层分层代码1
        [FixedLength(5, FixedLengthType.A)]
        public string LAYCODE2 { get; set; } //客户层分层代码2
        [FixedLength(30, FixedLengthType.A)]
        public string FORECOMP { get; set; } //原工作单位
        [FixedLength(8, FixedLengthType.A)]
        public string FJOBTIME { get; set; } //首次参加工作时间
        [FixedLength(1, FixedLengthType.A)]
        public string SMSYN { get; set; } //客户接收短信通知
        [FixedLength(8, FixedLengthType.N)]
        public string IDDTE { get; set; } //证件有效期
        [FixedLength(4, FixedLengthType.N)]
        public string HTELAREA { get; set; } //家庭电话区号
        [FixedLength(2, FixedLengthType.A)]
        public string MAILCODE { get; set; } //可接受广告类别
        [FixedLength(100, FixedLengthType.A)]
        public string BUSINAME2 { get; set; } //单位名称2
        [FixedLength(8, FixedLengthType.N)]
        public string IDISSDT { get; set; } //证件起始日期
        [FixedLength(6, FixedLengthType.A)]
        public string ISSDEPT { get; set; } //发证机关代码
        [FixedLength(20, FixedLengthType.A)]
        public string QQNBR { get; set; } //QQ号码
        [FixedLength(30, FixedLengthType.A)]
        public string WXNBR { get; set; } //微信号码
        [FixedLength(40, FixedLengthType.A)]
        public string EMAILIN { get; set; } //校内个人邮箱
        [FixedLength(1, FixedLengthType.A)]
        public string SIGNFLAG { get; set; } //亲见亲签标志
        [FixedLength(40, FixedLengthType.A)]
        public string ISSDEPTIF { get; set; } //发证机关信息
        [FixedLength(4, FixedLengthType.A)]
        public string POICODE { get; set; } //证件签发地
        [FixedLength(60, FixedLengthType.A)]
        public string SCHLNMCH { get; set; } //学校名称及院系（中文）
        [FixedLength(60, FixedLengthType.A)]
        public string SCHLNMEN { get; set; } //学校名称及院系（英文）
        [FixedLength(6, FixedLengthType.N)]
        public string ENROLLDATE { get; set; } //入学时间
        [FixedLength(6, FixedLengthType.N)]
        public string GRADUDATE { get; set; } //毕业时间
        [FixedLength(5, FixedLengthType.A)]
        public string LAYCODE3 { get; set; } //客户分层代码3
        [FixedLength(5, FixedLengthType.A)]
        public string LAYCODE4 { get; set; } //客户分层代码4
        [FixedLength(2, FixedLengthType.A)]
        public string RLVAL { get; set; } //客户交易风险等级
        [FixedLength(10, FixedLengthType.A)]
        public string CARID { get; set; } //车牌号
        [FixedLength(120, FixedLengthType.A)]
        public string BITMAP { get; set; } //位图
        [FixedLength(19, FixedLengthType.A)]
        public string CUSTID19 { get; set; } //证件号码（19位）
        [FixedLength(3, FixedLengthType.A)]
        public string NATIONCD { get; set; } //国籍细分代码
        [FixedLength(2, FixedLengthType.A)]
        public string SPECUST { get; set; } //特定自然人
        [FixedLength(30, FixedLengthType.A)]
        public string SURNAME { get; set; } //持卡人姓名
        [FixedLength(1, FixedLengthType.A)]
        public string SMS_YN { get; set; } //短信通知本次修改
        [FixedLength(19, FixedLengthType.A)]
        public string GATNBR { get; set; } //港澳台通行证


    }
}
