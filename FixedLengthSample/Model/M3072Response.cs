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
    public class M3072Response : BaseModel
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
        [FixedLength(30, FixedLengthType.A)]
        public string NAME { get; set; } //客户姓名
        [FixedLength(2, FixedLengthType.N)]
        public string COUNT { get; set; } //本次返回交易条数
        [FixedLength(1, FixedLengthType.A)]
        public string RTN_IND { get; set; } //翻页标志



        //[FixedLength(10, FixedLengthType.N)]
        //public string APP_SEQ_1 { get; set; } //申请书编号
        //[FixedLength(12, FixedLengthType.A)]
        //public string APP_REF_1 { get; set; } //申请书条形码（前12位）
        //[FixedLength(1, FixedLengthType.N)]
        //public string CARDHOLDER_1 { get; set; } //主附卡标志
        //[FixedLength(2, FixedLengthType.N)]
        //public string APP_STATUS_1 { get; set; } //申请状态
        //[FixedLength(8, FixedLengthType.A)]
        //public string INPUT_DT_1 { get; set; } //录入日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string DEC_DATE_1 { get; set; } //审核日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string ISSUEDATE_1 { get; set; } //制卡日期
        //[FixedLength(4, FixedLengthType.N)]
        //public string PRODUCT_1 { get; set; } //产品编号
        //[FixedLength(20, FixedLengthType.A)]
        //public string PROD_DESC_1 { get; set; } //产品描述
        //[FixedLength(1, FixedLengthType.A)]
        //public string PROD_TY_1 { get; set; } //公司卡标志
        //[FixedLength(19, FixedLengthType.A)]
        //public string CARD_NBR_1 { get; set; } //卡号
        //[FixedLength(10, FixedLengthType.N)]
        //public string CRDLIMT_1 { get; set; } //核准信用额度
        //[FixedLength(2, FixedLengthType.A)]
        //public string CANCL_CODE_1 { get; set; } //卡片状态
        //[FixedLength(30, FixedLengthType.A)]
        //public string M_APP_NAME_1 { get; set; } //主卡申请人姓名
        //[FixedLength(19, FixedLengthType.A)]
        //public string M_CARD_NBR_1 { get; set; } //主卡卡号
        //[FixedLength(2, FixedLengthType.N)]
        //public string M_CARD_IDX_1 { get; set; } //主卡发卡顺序
        //[FixedLength(4, FixedLengthType.N)]
        //public string AB_BRANCH_1 { get; set; } //省市代码
        //[FixedLength(12, FixedLengthType.A)]
        //public string AB_USERS_1 { get; set; } //推广人编号
        //[FixedLength(3, FixedLengthType.N)]
        //public string DECCAN_REA_1 { get; set; } //审批原因代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTNO_1 { get; set; } //申请礼品编号1
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTN2_1 { get; set; } //申请礼品编号2
        //[FixedLength(3, FixedLengthType.N)]
        //public string AB_TEAM_1 { get; set; } //团队代码
        //[FixedLength(1, FixedLengthType.N)]
        //public string AB_AREA_1 { get; set; } //区域代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string APP_REF2_1 { get; set; } //申请书条形码（后4位）
        //[FixedLength(1, FixedLengthType.A)]
        //public string ACTIVE_FLG_1 { get; set; } //卡片曾激活标志



        //[FixedLength(10, FixedLengthType.N)]
        //public string APP_SEQ_2 { get; set; } //申请书编号
        //[FixedLength(12, FixedLengthType.A)]
        //public string APP_REF_2 { get; set; } //申请书条形码（前12位）
        //[FixedLength(1, FixedLengthType.N)]
        //public string CARDHOLDER_2 { get; set; } //主附卡标志
        //[FixedLength(2, FixedLengthType.N)]
        //public string APP_STATUS_2 { get; set; } //申请状态
        //[FixedLength(8, FixedLengthType.A)]
        //public string INPUT_DT_2 { get; set; } //录入日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string DEC_DATE_2 { get; set; } //审核日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string ISSUEDATE_2 { get; set; } //制卡日期
        //[FixedLength(4, FixedLengthType.N)]
        //public string PRODUCT_2 { get; set; } //产品编号
        //[FixedLength(20, FixedLengthType.A)]
        //public string PROD_DESC_2 { get; set; } //产品描述
        //[FixedLength(1, FixedLengthType.A)]
        //public string PROD_TY_2 { get; set; } //公司卡标志
        //[FixedLength(19, FixedLengthType.A)]
        //public string CARD_NBR_2 { get; set; } //卡号
        //[FixedLength(10, FixedLengthType.N)]
        //public string CRDLIMT_2 { get; set; } //核准信用额度
        //[FixedLength(2, FixedLengthType.A)]
        //public string CANCL_CODE_2 { get; set; } //卡片状态
        //[FixedLength(30, FixedLengthType.A)]
        //public string M_APP_NAME_2 { get; set; } //主卡申请人姓名
        //[FixedLength(19, FixedLengthType.A)]
        //public string M_CARD_NBR_2 { get; set; } //主卡卡号
        //[FixedLength(2, FixedLengthType.N)]
        //public string M_CARD_IDX_2 { get; set; } //主卡发卡顺序
        //[FixedLength(4, FixedLengthType.N)]
        //public string AB_BRANCH_2 { get; set; } //省市代码
        //[FixedLength(12, FixedLengthType.A)]
        //public string AB_USERS_2 { get; set; } //推广人编号
        //[FixedLength(3, FixedLengthType.N)]
        //public string DECCAN_REA_2 { get; set; } //审批原因代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTNO_2 { get; set; } //申请礼品编号1
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTN2_2 { get; set; } //申请礼品编号2
        //[FixedLength(3, FixedLengthType.N)]
        //public string AB_TEAM_2 { get; set; } //团队代码
        //[FixedLength(1, FixedLengthType.N)]
        //public string AB_AREA_2 { get; set; } //区域代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string APP_REF2_2 { get; set; } //申请书条形码（后4位）
        //[FixedLength(1, FixedLengthType.A)]
        //public string ACTIVE_FLG_2 { get; set; } //卡片曾激活标志



        //[FixedLength(10, FixedLengthType.N)]
        //public string APP_SEQ_3 { get; set; } //申请书编号
        //[FixedLength(12, FixedLengthType.A)]
        //public string APP_REF_3 { get; set; } //申请书条形码（前12位）
        //[FixedLength(1, FixedLengthType.N)]
        //public string CARDHOLDER_3 { get; set; } //主附卡标志
        //[FixedLength(2, FixedLengthType.N)]
        //public string APP_STATUS_3 { get; set; } //申请状态
        //[FixedLength(8, FixedLengthType.A)]
        //public string INPUT_DT_3 { get; set; } //录入日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string DEC_DATE_3 { get; set; } //审核日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string ISSUEDATE_3 { get; set; } //制卡日期
        //[FixedLength(4, FixedLengthType.N)]
        //public string PRODUCT_3 { get; set; } //产品编号
        //[FixedLength(20, FixedLengthType.A)]
        //public string PROD_DESC_3 { get; set; } //产品描述
        //[FixedLength(1, FixedLengthType.A)]
        //public string PROD_TY_3 { get; set; } //公司卡标志
        //[FixedLength(19, FixedLengthType.A)]
        //public string CARD_NBR_3 { get; set; } //卡号
        //[FixedLength(10, FixedLengthType.N)]
        //public string CRDLIMT_3 { get; set; } //核准信用额度
        //[FixedLength(2, FixedLengthType.A)]
        //public string CANCL_CODE_3 { get; set; } //卡片状态
        //[FixedLength(30, FixedLengthType.A)]
        //public string M_APP_NAME_3 { get; set; } //主卡申请人姓名
        //[FixedLength(19, FixedLengthType.A)]
        //public string M_CARD_NBR_3 { get; set; } //主卡卡号
        //[FixedLength(2, FixedLengthType.N)]
        //public string M_CARD_IDX_3 { get; set; } //主卡发卡顺序
        //[FixedLength(4, FixedLengthType.N)]
        //public string AB_BRANCH_3 { get; set; } //省市代码
        //[FixedLength(12, FixedLengthType.A)]
        //public string AB_USERS_3 { get; set; } //推广人编号
        //[FixedLength(3, FixedLengthType.N)]
        //public string DECCAN_REA_3 { get; set; } //审批原因代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTNO_3 { get; set; } //申请礼品编号1
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTN2_3 { get; set; } //申请礼品编号2
        //[FixedLength(3, FixedLengthType.N)]
        //public string AB_TEAM_3 { get; set; } //团队代码
        //[FixedLength(1, FixedLengthType.N)]
        //public string AB_AREA_3 { get; set; } //区域代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string APP_REF2_3 { get; set; } //申请书条形码（后4位）
        //[FixedLength(1, FixedLengthType.A)]
        //public string ACTIVE_FLG_3 { get; set; } //卡片曾激活标志


        //[FixedLength(10, FixedLengthType.N)]
        //public string APP_SEQ_4 { get; set; } //申请书编号
        //[FixedLength(12, FixedLengthType.A)]
        //public string APP_REF_4 { get; set; } //申请书条形码（前12位）
        //[FixedLength(1, FixedLengthType.N)]
        //public string CARDHOLDER_4 { get; set; } //主附卡标志
        //[FixedLength(2, FixedLengthType.N)]
        //public string APP_STATUS_4 { get; set; } //申请状态
        //[FixedLength(8, FixedLengthType.A)]
        //public string INPUT_DT_4 { get; set; } //录入日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string DEC_DATE_4 { get; set; } //审核日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string ISSUEDATE_4 { get; set; } //制卡日期
        //[FixedLength(4, FixedLengthType.N)]
        //public string PRODUCT_4 { get; set; } //产品编号
        //[FixedLength(20, FixedLengthType.A)]
        //public string PROD_DESC_4 { get; set; } //产品描述
        //[FixedLength(1, FixedLengthType.A)]
        //public string PROD_TY_4 { get; set; } //公司卡标志
        //[FixedLength(19, FixedLengthType.A)]
        //public string CARD_NBR_4 { get; set; } //卡号
        //[FixedLength(10, FixedLengthType.N)]
        //public string CRDLIMT_4 { get; set; } //核准信用额度
        //[FixedLength(2, FixedLengthType.A)]
        //public string CANCL_CODE_4 { get; set; } //卡片状态
        //[FixedLength(30, FixedLengthType.A)]
        //public string M_APP_NAME_4 { get; set; } //主卡申请人姓名
        //[FixedLength(19, FixedLengthType.A)]
        //public string M_CARD_NBR_4 { get; set; } //主卡卡号
        //[FixedLength(2, FixedLengthType.N)]
        //public string M_CARD_IDX_4 { get; set; } //主卡发卡顺序
        //[FixedLength(4, FixedLengthType.N)]
        //public string AB_BRANCH_4 { get; set; } //省市代码
        //[FixedLength(12, FixedLengthType.A)]
        //public string AB_USERS_4 { get; set; } //推广人编号
        //[FixedLength(3, FixedLengthType.N)]
        //public string DECCAN_REA_4 { get; set; } //审批原因代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTNO_4 { get; set; } //申请礼品编号1
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTN2_4 { get; set; } //申请礼品编号2
        //[FixedLength(3, FixedLengthType.N)]
        //public string AB_TEAM_4 { get; set; } //团队代码
        //[FixedLength(1, FixedLengthType.N)]
        //public string AB_AREA_4 { get; set; } //区域代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string APP_REF2_4 { get; set; } //申请书条形码（后4位）
        //[FixedLength(1, FixedLengthType.A)]
        //public string ACTIVE_FLG_4 { get; set; } //卡片曾激活标志



        //[FixedLength(10, FixedLengthType.N)]
        //public string APP_SEQ_5 { get; set; } //申请书编号
        //[FixedLength(12, FixedLengthType.A)]
        //public string APP_REF_5 { get; set; } //申请书条形码（前12位）
        //[FixedLength(1, FixedLengthType.N)]
        //public string CARDHOLDER_5 { get; set; } //主附卡标志
        //[FixedLength(2, FixedLengthType.N)]
        //public string APP_STATUS_5 { get; set; } //申请状态
        //[FixedLength(8, FixedLengthType.A)]
        //public string INPUT_DT_5 { get; set; } //录入日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string DEC_DATE_5 { get; set; } //审核日期
        //[FixedLength(8, FixedLengthType.A)]
        //public string ISSUEDATE_5 { get; set; } //制卡日期
        //[FixedLength(4, FixedLengthType.N)]
        //public string PRODUCT_5 { get; set; } //产品编号
        //[FixedLength(20, FixedLengthType.A)]
        //public string PROD_DESC_5 { get; set; } //产品描述
        //[FixedLength(1, FixedLengthType.A)]
        //public string PROD_TY_5 { get; set; } //公司卡标志
        //[FixedLength(19, FixedLengthType.A)]
        //public string CARD_NBR_5 { get; set; } //卡号
        //[FixedLength(10, FixedLengthType.N)]
        //public string CRDLIMT_5 { get; set; } //核准信用额度
        //[FixedLength(2, FixedLengthType.A)]
        //public string CANCL_CODE_5 { get; set; } //卡片状态
        //[FixedLength(30, FixedLengthType.A)]
        //public string M_APP_NAME_5 { get; set; } //主卡申请人姓名
        //[FixedLength(19, FixedLengthType.A)]
        //public string M_CARD_NBR_5 { get; set; } //主卡卡号
        //[FixedLength(2, FixedLengthType.N)]
        //public string M_CARD_IDX_5 { get; set; } //主卡发卡顺序
        //[FixedLength(4, FixedLengthType.N)]
        //public string AB_BRANCH_5 { get; set; } //省市代码
        //[FixedLength(12, FixedLengthType.A)]
        //public string AB_USERS_5 { get; set; } //推广人编号
        //[FixedLength(3, FixedLengthType.N)]
        //public string DECCAN_REA_5 { get; set; } //审批原因代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTNO_5 { get; set; } //申请礼品编号1
        //[FixedLength(4, FixedLengthType.A)]
        //public string GIFTN2_5 { get; set; } //申请礼品编号2
        //[FixedLength(3, FixedLengthType.N)]
        //public string AB_TEAM_5 { get; set; } //团队代码
        //[FixedLength(1, FixedLengthType.N)]
        //public string AB_AREA_5 { get; set; } //区域代码
        //[FixedLength(4, FixedLengthType.A)]
        //public string APP_REF2_5 { get; set; } //申请书条形码（后4位）
        //[FixedLength(1, FixedLengthType.A)]
        //public string ACTIVE_FLG_5 { get; set; } //卡片曾激活标志


        public M3072Response()
        {
            Details = new List<M3072ResponseDetail>();
        }

        public List<M3072ResponseDetail> Details
        {
            get;
            set;
        }
    }

    public class M3072ResponseDetail : BaseModel
    {
        [FixedLength(10, FixedLengthType.N)]
        public string APP_SEQ { get; set; } //申请书编号
        [FixedLength(12, FixedLengthType.A)]
        public string APP_REF { get; set; } //申请书条形码（前12位）
        [FixedLength(1, FixedLengthType.N)]
        public string CARDHOLDER { get; set; } //主附卡标志
        [FixedLength(2, FixedLengthType.N)]
        public string APP_STATUS { get; set; } //申请状态
        [FixedLength(8, FixedLengthType.A)]
        public string INPUT_DT { get; set; } //录入日期
        [FixedLength(8, FixedLengthType.A)]
        public string DEC_DATE { get; set; } //审核日期
        [FixedLength(8, FixedLengthType.A)]
        public string ISSUEDATE { get; set; } //制卡日期
        [FixedLength(4, FixedLengthType.N)]
        public string PRODUCT { get; set; } //产品编号
        [FixedLength(20, FixedLengthType.A)]
        public string PROD_DESC { get; set; } //产品描述
        [FixedLength(1, FixedLengthType.A)]
        public string PROD_TY { get; set; } //公司卡标志
        [FixedLength(19, FixedLengthType.A)]
        public string CARD_NBR { get; set; } //卡号
        [FixedLength(10, FixedLengthType.N)]
        public string CRDLIMT { get; set; } //核准信用额度
        [FixedLength(2, FixedLengthType.A)]
        public string CANCL_CODE { get; set; } //卡片状态
        [FixedLength(30, FixedLengthType.A)]
        public string M_APP_NAME { get; set; } //主卡申请人姓名
        [FixedLength(19, FixedLengthType.A)]
        public string M_CARD_NBR { get; set; } //主卡卡号
        [FixedLength(2, FixedLengthType.N)]
        public string M_CARD_IDX { get; set; } //主卡发卡顺序
        [FixedLength(4, FixedLengthType.N)]
        public string AB_BRANCH { get; set; } //省市代码
        [FixedLength(12, FixedLengthType.A)]
        public string AB_USERS { get; set; } //推广人编号
        [FixedLength(3, FixedLengthType.N)]
        public string DECCAN_REA { get; set; } //审批原因代码
        [FixedLength(4, FixedLengthType.A)]
        public string GIFTNO { get; set; } //申请礼品编号1
        [FixedLength(4, FixedLengthType.A)]
        public string GIFTN2 { get; set; } //申请礼品编号2
        [FixedLength(3, FixedLengthType.N)]
        public string AB_TEAM { get; set; } //团队代码
        [FixedLength(1, FixedLengthType.N)]
        public string AB_AREA { get; set; } //区域代码
        [FixedLength(4, FixedLengthType.A)]
        public string APP_REF2 { get; set; } //申请书条形码（后4位）
        [FixedLength(1, FixedLengthType.A)]
        public string ACTIVE_FLG { get; set; } //卡片曾激活标志

    }
}
