using FontManager.Callback;
using FontManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FontManager.FontService
{

    public class SearchEngine
    {

        public event SearchFinishedHandler ListenerSearchFinished;
        public event SearchFailedHandler ListenerSearchFailed;

        private List<FontInfo> SearchResult = new List<FontInfo>();

        public class SearchData
        {
            public List<FontInfo> Source { get; set; }
            public string Keyword { get; set; }
            public int Start { get; set; }
            public int End { get; set; }
            public SearchType SearchType { get; set; }
        }

        public void FindFont(List<FontInfo> dataSource, string keyword, int lenghtConstraint, SearchType searchType = SearchType.All)
        {
            int NumberThread = 3;
            if (String.IsNullOrEmpty(keyword) && keyword.Length <= lenghtConstraint)
            {
                if (ListenerSearchFailed != null)
                {
                    ListenerSearchFailed.Invoke(this, new SearchFailedEventArgs("Not Contrains"));
                    return;
                }
            }


            if (this.SearchResult != null && this.SearchResult.Count > 0)
                this.SearchResult.Clear();

            Thread searchThread1 = new Thread(x => SearchInBackground(x));
            searchThread1.Start(new SearchData
            {
                Source = SharedData.SharedData.FontInfos,
                Start = 0,
                End = SharedData.SharedData.FontInfos.Count,
                SearchType = searchType,
                Keyword = keyword
            });
        }


        private void SearchInBackground(object dataSearch)
        {
            SearchData data = dataSearch as SearchData;

            for (int i = data.Start; i < data.End; i++)
            {
                switch (data.SearchType)
                {
                    case SearchType.All:
                        break;
                    case SearchType.Copyright:
                        string copyRight = data.Source[i].StringLanguageSupported;
                        if(copyRight != data.Source[i].Copyright && copyRight.Contains(data.Keyword))
                        {
                            this.SearchResult.Add(data.Source[i]);
                        }
                        break;
                    case SearchType.Designer:
                        string designer = data.Source[i].Designer;
                        if(designer != null && designer.Contains(data.Keyword))
                        {
                            this.SearchResult.Add(data.Source[i]);
                        }
                        break;

                    case SearchType.Family:
                        string family = data.Source[i].FontFamily;
                        if(family != null && family.Contains(data.Keyword))
                        {
                            this.SearchResult.Add(data.Source[i]);
                        }
                        break;
                    case SearchType.FileName:
                        string fileName = data.Source[i].NameInRegistry;
                        if(fileName != null && fileName.Contains(fileName))
                        {
                            this.SearchResult.Add(data.Source[i]);
                        }
                        break;
                    case SearchType.Language:
                        string lang = data.Source[i].StringLanguageSupported;
                        if (lang != null && lang.Contains(data.Keyword))
                            this.SearchResult.Add(data.Source[i]);
                        break;
                    case SearchType.Manufactuer:
                        string manufactuer = data.Source[i].Manufacturer;
                        if(manufactuer != null && manufactuer.Contains(data.Keyword))
                        {
                            this.SearchResult.Add(data.Source[i]);
                        }
                        break;
                    case SearchType.PostScript:
                        string postscript = data.Source[i].PostscriptName;
                        if(postscript != null && postscript.Contains(data.Keyword))
                        {
                            this.SearchResult.Add(data.Source[i]);
                        }
                        break;
                    case SearchType.Style:
                        string style = data.Source[i].FontSubFamily;
                        if(style != null && style.Contains(data.Keyword))
                        {
                            this.SearchResult.Add(data.Source[i]);
                        }
                        break;
                    
                    default:
                        break;
                }
            }

            if (ListenerSearchFinished != null)
            {
                ListenerSearchFinished(this, new SearchFinishedEventArgs(this.SearchResult));
            }
        }

    }
}
