﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sentiment.Infrastructure
{
    public class SentimentService
    {
        private readonly TwitterSentimentAnalyser _twitterSentiment;

        public SentimentService(TwitterSentimentAnalyser twitterSentiment)
        {
            _twitterSentiment = twitterSentiment;

            //Task.Run(() => 
            //    StartSentimentListeners()
            //);
        }

        public void StartSentimentListeners()
        {
            //TODO: For each listener too
            foreach (var asset in _twitterSentiment.GetSupportedAssets())
            {
                _twitterSentiment.StartRealTimeSentimentListener(new List<string> { asset.symbol, asset.name });
            }
        }
    }
}
