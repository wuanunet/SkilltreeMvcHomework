using SkilltreeMvcHomework.CustomActionResults;
using SkilltreeMvcHomework.Extensions;
using SkilltreeMvcHomework.Services;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Web.Mvc;

namespace SkilltreeMvcHomework.Controllers
{
    public class FeedController : Controller
    {
        private readonly IAccountingService _accountingService;

        public FeedController(IAccountingService accountingService)
        {
            this._accountingService = accountingService;
        }

        public ActionResult Rss()
        {
            var feed = this.GetFeedData();
            return new RssActionResult(feed);
        }

        private SyndicationFeed GetFeedData()
        {
            string hostUrl = string.Format("{0}://{1}", Request.Url.Scheme, Request.Headers["host"]);

            SyndicationFeed feed = new SyndicationFeed(
                "RSS Sample",
                "Skilltree ASP.NET MVC 5 Homework",
                new Uri(string.Concat(hostUrl, "/Rss/")));

            List<SyndicationItem> items = new List<SyndicationItem>();

            var accountingList = this._accountingService.GetData();

            foreach (var data in accountingList)
            {
                SyndicationItem item = new SyndicationItem(
                    data.Type.GetDisplayName(),
                    data.Remark.Substring(0, 50),
                    new Uri(string.Concat(hostUrl, "/Accounting/Details?id=", "")),
                    "ID",
                    data.CreateTime);

                items.Add(item);
            }

            feed.Items = items;
            return feed;
        }
    }
}