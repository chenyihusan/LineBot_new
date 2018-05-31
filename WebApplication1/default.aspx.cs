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

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon() { label = "標題-文字回覆", text = "回覆文字" });
            actions.Add(new isRock.LineBot.UriActon() { label = "標題-開啟URL", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackActon() { label = "標題-發生postack", data = "abc=aaa&def=111" });
            var ButtonTempalteMsg = new isRock.LineBot.ButtonsTemplate()
            {
                title = "選項",
                text = "請選擇其中之一",
                altText = "請在手機上檢視",
                thumbnailImageUrl=new Uri("https://cdn.dribbble.com/users/42583/screenshots/4651306/frontlogo-01_1x.png"),
                actions= actions
            };
            bot.PushMessage(AdminUserId, ButtonTempalteMsg) ;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon() { label = "Yes", text = "Yes" });
            actions.Add(new isRock.LineBot.MessageActon() { label = "No", text = "No" });

            var ConfirmTemplate = new isRock.LineBot.ButtonsTemplate()
            {
                title = "選項",
     
                altText = "請在手機上檢視",
    text= "123",
                actions = actions
            };
            bot.PushMessage(AdminUserId,ConfirmTemplate);
        }
    }
}