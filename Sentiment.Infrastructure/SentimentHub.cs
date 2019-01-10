﻿using Microsoft.AspNetCore.SignalR;
using Sentiment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sentiment.Infrastructure
{
    public class SentimentHub : Hub<ISentimentHub>
    {
        public async Task SendSentiments(SentimentAnalysisResult[] sentimentResults)
        {
            await Clients.All.ReceiveSentiments(sentimentResults);
        }
    }
}
