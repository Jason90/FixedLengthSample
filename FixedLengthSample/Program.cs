using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FixedLengthSample
{
    class Program
    {
        //todo:公司服务年数 decimal(12,2); 增加特殊处理
        static void Main(string[] args)
        {
            //TestSocket();
            //Test4093();
            //Test3002();
		//11111111111111
            Test3072();
        }

        private static void Test3072()
        {
            M3072Request request = new M3072Request();
            request.TRXTYPE = "3072";
            request.RETCODE = "";
            request.BNKNBR = "6442";
            request.SOURCE = "CA";
            request.BRN_NO = "";
            request.OPE_NO = "";
            request.SEQNO = "";
            request.IDTYPE = "01";
            //request.IDNO = "110101198808080036";
            //request.IDTYPE = "49";
            request.IDNO = "123566446565955325";
            request.RTN_IND = "";
            request.APP_SEQ = "";
            request.INPUT_DT = "";
            request.REVS = "";

            B3072 cup = new B3072();
            M3072Response response = cup.Query(request);


        }

        private static void Test4093()
        {
            B4093 cup = new B4093();

            cup.TRXTYPE = "4093";
            cup.RETCODE = "";
            cup.BNKNBR = "6442";
            cup.SOURCE = "CA";
            cup.BRNNO = "";
            cup.OPENO = "";
            cup.SEQNO = "";
            cup.ACTION = "N";
            cup.APPLNREF = "";
            cup.MICROFILM = "2019020110000010";
            cup.APPSTS = "1";
            cup.ACTIVENOW = "3";
            cup.CUSTRNBR = "220283198008136818";
            cup.SURNAME = "朱洪章";
            cup.PRODUCT = "0091";
            cup.ADDLCARD = "2";
            cup.ACCTYPE = "22";
            cup.CDFRM = "CMLB";
            cup.CREDLIMIT = "100000";
            cup.EMBNAMED = "ZHU/HONGZHANG/";
            cup.CDESPMTD = "POST";
            cup.CDESPLOC = "";
            cup.STMCODE = "EM";
            cup.MAILTO = "B";
            cup.ADDR1L1 = "北京市北京市";
            cup.ADDR1L2 = "丰台区";
            cup.ADDR1L3 = "汉威国际广场";
            cup.ADDR1L4 = "3区6号楼10层";
            cup.POSTCODE = "100000";
            cup.ADDR1TYPE = "B";
            cup.CYCLENBR = "1";
            cup.EXPYDATE = "";
            cup.BRANCH = "";
            cup.VCNCHNL = "00";
            cup.APPSOURCE = "";
            cup.PINCHK = "1";
            cup.SMSYN = "1";
            cup.SMSFREEYN = "0";
            cup.CDISSFLAG = "1";
            cup.MPLLM = "0";
            cup.NOREISYN = "0";
            cup.MPLIMIT = "";
            cup.MPLMTFLAG = "0";
            cup.CACCNBR = "";
            cup.CPAYMOD = "";
            cup.DECREAS = "817";
            cup.DECEMP = "999999";
            cup.ABACCES = "3";
            cup.ABBRNCH = "9901";
            cup.GIFTNO = "";
            cup.ABTEAM = "000";
            cup.ABAREA = "0";
            cup.ISSMOD = "03";
            cup.CARDSEL = "";
            cup.RUSHFLG = "1";
            cup.RUSHFEE = "0";
            cup.COURIERF = "0";
            cup.EMBOSSCPY = "";
            cup.CREDLMT = "";
            cup.PRMAGCD = "WS0001";
            cup.CARDTO = "B";
            cup.SIGNFLAG = "0";
            cup.NOCHGEXP = "";
            cup.RETAIN = "";


            string request = cup.ToFixedLengthString();
        }

        private static string TestSocket()
        {
            //SocketHelper socket = SocketHelper.CreateInstance();
            //socket.Connect("127.0.0.1", 9999);
            //string result = socket.Query(request);
            //socket.Disconnect();

            //"130.1.9.231", 30002
            //string response = SocketHelper.SendMessage("127.0.0.1", 9999, request, Encoding.GetEncoding("gb18030"));


            string request = "05333002      6442ZA0099010075905671326228090910000169   1                    0        1 S4  25628668         57915866               13811088178 qq@123.com                                               000 北京进化科技有限公司                                                        000000000004000000000000000F                                                 000000000000                                                                                                      00000000                                                        ";

            string response = SocketHelper.SendMessage("130.1.9.231", 30002, request, Encoding.GetEncoding("gb18030"));
            return request;
        }

        private static void Test3002()
        {

            string request = "05333002      6442ZA0099010075905671326228090910000169   1                    0        1 S4  25628668         57915866               13811088178 qq@123.com                                               000 北京进化科技有限公司                                                        000000000004000000000000000F                                                 000000000000                                                                                                      00000000                                                        ";
            M3002Request cup = M3002Request.FromFixedLengthString<M3002Request>(request, 4);
            string requestString = cup.ToFixedLengthString(4);

            string response = SocketHelper.SendMessage("130.1.9.231", 30002, requestString, Encoding.GetEncoding("gb18030"));

        }
    }
}
