using System;
using System.Collections.Generic;

namespace GoogleTrendViewer.Models;

public class TrendItem
{
    public string Link { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Traffic { get; set; }
    public string Picture { get; set; }
    public string PictureSource { get; set; }
    public DateTime PubDate { get; set; }
    public List<NewsItem> NewsItems { get; set; }
    public TrendItem()
    {
        NewsItems = new List<NewsItem>();
    }
}

