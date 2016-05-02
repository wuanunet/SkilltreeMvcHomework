using System.ServiceModel.Syndication;
using System.Web.Mvc;
using System.Xml;

namespace SkilltreeMvcHomework.CustomActionResults
{
    public class RssActionResult : ActionResult
    {
        private SyndicationFeed feed;

        public RssActionResult(SyndicationFeed feed)
        {
            this.feed = feed;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.ContentType = "application/rss+xml";
            Rss20FeedFormatter formatter = new Rss20FeedFormatter(this.feed);
            using (XmlWriter writer = XmlWriter.Create(context.HttpContext.Response.Output))
            {
                formatter.WriteTo(writer);
            }
        }
    }
}