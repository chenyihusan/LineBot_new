using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class linebot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var userid = "U17527feb1e4eb31d7abf36a21855e7b4";
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("vnQb06YtUGSoyUsbYnXEVNdFepI0vuN6XPPubay86p0Ejy2VNQi5J3UDoq+ZJnY6aMUZHOhRzzotGSDgbNHpXQnQUBAZ2qcbgmDIMUoZcvSQ5rjF6cUZH+Cf/mJxy9bPQiqMyIZI/84cNblVzPpjAwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage(userid, "test11111111");
            bot.PushMessage(userid, 1,3);
            bot.PushMessage(userid,new Uri("https://cdn.dribbble.com/users/59947/screenshots/4649726/muti2_1x.jpg"));


        }
    }
}