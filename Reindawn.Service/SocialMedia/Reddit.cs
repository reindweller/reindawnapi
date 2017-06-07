using Reindawn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Service.SocialMedia
{
    public static class Reddit
    {
        public static List<Post> ReadPage()
        {
            var models = new List<Post>();
            //get the page
            var web = new HtmlWeb();
            var document = web.Load("https://www.reddit.com/");
            var page = document.DocumentNode;

            //loop through all div tags with item css class
            foreach (var item in page.QuerySelectorAll(".thing"))
            {
                var title = item.QuerySelector("a.title").InnerText;
                var thumbnail = item.QuerySelector(".thumbnail").ChildNodes["img"];
                var srcAttr = string.Empty;
                var src = string.Empty;


                if (thumbnail != null)
                {
                    var thumbnailAttribute = thumbnail.Attributes["src"];
                    src = srcAttr == null ? string.Empty : thumbnailAttribute.Value;
                }


                models.Add(new SsModel
                {
                    Title = title,
                    ThumbnailSrc = src,
                });

            }


            return models;
        }
    }
}
