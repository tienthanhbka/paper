using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using HSCTSV_1.Model;

namespace HSCTSV_1.ConnectDB
{    
    class UserDB
    {
        IFlurlClient fc;
        public async Task<HSUser> userLogin(Dictionary<string, string> objReq)
        {
            fc = new FlurlClient().EnableCookies();
            HSUser objRes = new HSUser();
            try
            {
                objRes = await ("http://202.191.56.101/CTSV/User/UserLogin").WithHeaders(new { user_Agent="Thangwip"}).WithTimeout(60)
                               .PostUrlEncodedAsync(objReq).ReceiveJson<HSUser>();
                return objRes;
            }
            catch(Exception ex)
            {
                objRes = new HSUser
                {
                    RespCode = -2,
                    RespText = ex.Message
                };
                return objRes;
            }
        }
    }
}
