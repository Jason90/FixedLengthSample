using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedLengthSample
{
    public class B3072 : M3072Request
    {
        public M3072Response Query(M3072Request request)
        {
            string requestString = request.ToFixedLengthString(4);

            string responseString = SocketHelper.SendMessage("130.1.9.231", 30002, requestString, Encoding.GetEncoding("gb18030"));//todo ip and encoding

            M3072Response response = Parse(responseString);

            //翻页查询
            while (response.RTN_IND == "1" && response.Details.Count > 0)
            {
                request.RTN_IND = "1";
                request.APP_SEQ = response.Details[response.Details.Count - 1].APP_SEQ;
                request.INPUT_DT = response.Details[response.Details.Count - 1].INPUT_DT;

                requestString = request.ToFixedLengthString(4);
                responseString = SocketHelper.SendMessage("130.1.9.231", 30002, requestString, Encoding.GetEncoding("gb18030"));

                M3072Response responsePage = Parse(responseString);
                responsePage.Details.InsertRange(0, response.Details);
                response = responsePage;
            }

            return response;
        }

        private M3072Response Parse(string responseString)
        {
            M3072Response response = new M3072Response();
            //解析报文头
            response = M3072Response.FromFixedLengthString<M3072Response>(SubstringWide(responseString, 0, 91), 4);
            //解析卡片明细
            int count = 0;
            if (!string.IsNullOrEmpty(response.COUNT))
                count = int.Parse(response.COUNT);
            for (int i = 0; i < count; i++)
            {
                M3072ResponseDetail detail = M3072ResponseDetail.FromFixedLengthString<M3072ResponseDetail>(SubstringWide(responseString, 91 + 192 * i, 192));
                response.Details.Add(detail);
            }

            return response;
        }
    }
}
