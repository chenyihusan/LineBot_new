using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "vnQb06YtUGSoyUsbYnXEVNdFepI0vuN6XPPubay86p0Ejy2VNQi5J3UDoq+ZJnY6aMUZHOhRzzotGSDgbNHpXQnQUBAZ2qcbgmDIMUoZcvSQ5rjF6cUZH+Cf/mJxy9bPQiqMyIZI/84cNblVzPpjAwdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U17527feb1e4eb31d7abf36a21855e7b4";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}